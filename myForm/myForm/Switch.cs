using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.IO;

namespace myForm
{
    public partial class Switch : Form
    {
        /// <summary>
        /// 本地连接信息
        /// </summary>
        InetAddress current = new InetAddress();

        /// <summary>
        /// 以保存的列表
        /// </summary>
        List<InetAddress> listItem = new List<InetAddress>();

        //string listCont = null;
        /// <summary>
        /// 连接名称：比如“本地连接”
        /// </summary>
        string lkName = null;
        string temp = Path.GetTempPath() + "switch_ip.tmp";
        public Switch()
        {
            InitializeComponent();
            rbSet.Checked = true;
            getCurrent();
            initHistory();
        }

        private void initHistory()
        {
            try
            {
                if (!File.Exists(temp))
                    return;

                string  ipHistory = File.ReadAllText(temp);
                if (ipHistory != null && !"".Equals(ipHistory))
                {
                    string[] adrss = ipHistory.Split(new char[] { '#' });
                    listItem.Clear();
                    for (int i = 0; i < adrss.Count(); i++)
                    {
                        if (adrss[i] == null || "".Equals(adrss[i]))
                            continue;
                        string[] items = adrss[i].Split(new char[] { '-' });
                        InetAddress setInet = new InetAddress();
                        setInet.ip = items[0];
                        setInet.subNet = items[1];
                        setInet.gateWay = items[2];
                        setInet.dns = items[3];
                        setInet.dns2 = (items.Length > 4 && !String.IsNullOrEmpty(items[4])) ? items[4] : null;
                        listItem.Add(setInet);
                    }
                    flushItems(null);
                }
               
            }
            catch (Exception e)
            {
                MessageBox.Show("读取文件异常：" + e, "提示", MessageBoxButtons.OK);
            }
        }

        private void initFile()
        {
            FileStream fs = null;
            if (File.Exists(temp))
            {
                File.Delete(temp);
            }
            
            fs = File.Create(temp);
            if (fs != null)
                fs.Close();
        }

        private void wirte(string content)
        {
            try
            {
                if (content != null && !"".Equals(content))
                {
                    initFile();
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(@temp, true))
                    {
                        file.Write(content);
                        file.Flush();
                    }
                }

            }catch(Exception e){
                MessageBox.Show("写入文件异常：" + e, "提示", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<String> cmd = new List<String>();
            if (rbSet.Checked)
            {
                InetAddress setInet = new InetAddress();
                setInet.ip = tbIp.Text.Trim();
                setInet.subNet = tbSubNetMask.Text.Trim();
                setInet.gateWay = tbGateWay.Text.Trim();
                setInet.dns = tbDns.Text.Trim();
                setInet.dns2 = tbDns2.Text.Trim();

                if (!IsIpaddress(setInet.ip))
                {
                    MessageBox.Show("请设置正确IP！", "提示", MessageBoxButtons.OK);
                    return;
                }
                //手动设置IP信息
                cmd.Add("netsh interface ip set address " + lkName + " source=static addr=" + setInet.ip + " mask=" + setInet.subNet + " gateway=" + setInet.gateWay);
                cmd.Add("netsh interface ip set dns " + lkName + " source=static addr=" + setInet.dns + " register=primary");
                if(setInet.dns2!=null&&setInet.dns2 !=""){
                    cmd.Add("netsh interface ip add dns " + lkName + " addr="+setInet.dns2+" index=2");
                }
                setInetAddress(cmd);
                if(listItem.Find(it => { return it.ip.Equals(setInet.ip); }) == null)
                {
                    listItem.Add(setInet);
                }
                flushItems(setInet);
                reWriteData();
            }
            else if (rbCurrent.Checked)
            {
                getCurrent();
                setTextVal(current);
            }
            else
            {
                //设置自动获取IP信息
                cmd.Add("netsh interface ip set address " + lkName + " DHCP");
                cmd.Add("netsh interface ip set dns " + lkName + " DHCP");
                setInetAddress(cmd);
            }
            MessageBox.Show("操作成功！", "提示", MessageBoxButtons.OK);
        }

        private void reWriteData()
        {
            StringBuilder sbl = new StringBuilder();
            listItem.ForEach(it => { sbl.Append(it.ip).Append("-").Append(it.subNet).Append("-").Append(it.gateWay).Append("-").Append(it.dns).Append("-").Append(it.dns2).Append("-").Append("#"); });
            wirte(sbl.ToString());
        }

        private void flushItems(InetAddress setInet)
        {
            //绑定数据源，并指定要展示的列和值得绑定
            cbbIps.DataSource = null;
            cbbIps.DataSource = listItem;
            cbbIps.DisplayMember = "ip";
            cbbIps.ValueMember = "ip";
            if (setInet != null)
            {
                cbbIps.SelectedItem = setInet;
            }
        }
        private void getCurrent()
        {
            string ip4 = getIpv4();
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface nic in nics)
            {
                //只获取以太网和无线
                if (nic.NetworkInterfaceType != NetworkInterfaceType.Wireless80211 && nic.NetworkInterfaceType != NetworkInterfaceType.Ethernet)
                    continue;
                lkName = nic.Name;
                //NetworkInterfaceType.Wireless80211/NetworkInterfaceType.Ethernet
                IPInterfaceProperties ip = nic.GetIPProperties();
                PhysicalAddress phy =  nic.GetPhysicalAddress();
                if (ip.UnicastAddresses.Count > 0)
                {
                    for (int i = 0; i < ip.UnicastAddresses.Count; i++)
                    {
                        current.ip = ip.UnicastAddresses[i].Address.ToString();//IP地址
                        current.subNet = ip.UnicastAddresses[i].IPv4Mask.ToString();//子网掩码
                        if (String.Equals(ip4, current.ip))
                            break;
                    }
                    
                }
                if (ip.GatewayAddresses.Count > 0)
                {
                    current.gateWay = ip.GatewayAddresses[0].Address.ToString();//默认网关
                }
                int DnsCount = ip.DnsAddresses.Count;

                if (DnsCount > 0)
                {
                    try
                    {
                        current.dns = ip.DnsAddresses[0].ToString(); //主DNS
                        current.dns2 = ip.DnsAddresses[1].ToString(); //备用DNS地址
                    }
                    catch (Exception er)
                    {
                        Console.WriteLine("获取DNS异常：" + er);
                    }
                }
                if (String.Equals(ip4, current.ip))
                {
                    break;
                }
            }
        }

        private void setTextVal(InetAddress iad)
        {
            if (iad == null) return;
            tbIp.Text = iad.ip;
            tbSubNetMask.Text = iad.subNet;
            tbGateWay.Text = iad.gateWay;
            tbDns.Text = iad.dns;
            tbDns2.Text = iad.dns2;
        }

        /// <summary>
        /// 获取ipv4的IP地址
        /// </summary>
        /// <returns></returns>
        private string getIpv4()
        {
            System.Net.IPAddress[] addressList = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName()).AddressList;
            
            foreach (System.Net.IPAddress addr in addressList)
            {
                try { long a = addr.ScopeId; }
                catch
                {
                    return addr.ToString();
                }
            }
            return "-1";
        }


        public void setInetAddress(List<string> comd)
        {
            if (comd == null || comd.Count < 1) return;

            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            try
            {
                comd.ForEach(c =>
                {
                    try
                    {
                        process.StandardInput.WriteLine(c);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("执行命令异常："+e);
                    }
                });
                process.StandardInput.WriteLine("exit");
                process.WaitForExit(10); 
            }
            catch(Exception e)
            {
                MessageBox.Show("运行ingling异常！" + e, "提示", MessageBoxButtons.OK);
            }
            finally
            {
                if (process != null)
                    process.Close();
            }
            
        }

        
        /// <summary>
        /// 判断是否是正确的ip地址
        /// </summary>
        /// <param name="ipaddress"></param>
        /// <returns></returns>
        protected bool IsIpaddress(string ipaddress)
        {
            string[] nums = ipaddress.Split('.');
            if (nums.Length != 4) return false;
            try
            {
                foreach (string num in nums)
                {
                    if (Convert.ToInt32(num) < 0 || Convert.ToInt32(num) > 255) return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        private void cbbIps_SelectedValueChanged(object sender, EventArgs e)
        {
            setTextVal(cbbIps.SelectedItem as InetAddress);
        }

        private void rbAuto_CheckedChanged(object sender, EventArgs e)
        {
            setTextVal(new InetAddress());
            enableCompent(false);
        }
       
        private void rbCurrent_CheckedChanged(object sender, EventArgs e)
        {
            setTextVal(new InetAddress());
            enableCompent(false);
        }

        private void rbSet_CheckedChanged(object sender, EventArgs e)
        {
            enableCompent(true);
        }

        private void enableCompent(bool flag)
        {
            tbIp.Enabled = flag;
            tbSubNetMask.Enabled = flag;
            tbGateWay.Enabled = flag;
            tbDns.Enabled = flag;
            tbDns2.Enabled = flag;
            cbbIps.Enabled = flag;
        }

    }
}
