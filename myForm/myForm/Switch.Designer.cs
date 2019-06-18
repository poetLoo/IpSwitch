namespace myForm
{
    partial class Switch
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Switch));
            this.btnRun = new System.Windows.Forms.Button();
            this.rbSet = new System.Windows.Forms.RadioButton();
            this.rbAuto = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tbIp = new System.Windows.Forms.TextBox();
            this.tbSubNetMask = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbGateWay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDns = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDns2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbCurrent = new System.Windows.Forms.RadioButton();
            this.cbbIps = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRun.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRun.Location = new System.Drawing.Point(173, 12);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(80, 25);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "运行";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.button2_Click);
            // 
            // rbSet
            // 
            this.rbSet.AutoSize = true;
            this.rbSet.BackColor = System.Drawing.Color.Transparent;
            this.rbSet.ForeColor = System.Drawing.SystemColors.Info;
            this.rbSet.Location = new System.Drawing.Point(14, 16);
            this.rbSet.Name = "rbSet";
            this.rbSet.Size = new System.Drawing.Size(47, 16);
            this.rbSet.TabIndex = 3;
            this.rbSet.TabStop = true;
            this.rbSet.Text = "手动";
            this.rbSet.UseVisualStyleBackColor = false;
            this.rbSet.CheckedChanged += new System.EventHandler(this.rbSet_CheckedChanged);
            // 
            // rbAuto
            // 
            this.rbAuto.AutoSize = true;
            this.rbAuto.BackColor = System.Drawing.Color.Transparent;
            this.rbAuto.ForeColor = System.Drawing.SystemColors.Info;
            this.rbAuto.Location = new System.Drawing.Point(67, 16);
            this.rbAuto.Name = "rbAuto";
            this.rbAuto.Size = new System.Drawing.Size(47, 16);
            this.rbAuto.TabIndex = 4;
            this.rbAuto.TabStop = true;
            this.rbAuto.Text = "自动";
            this.rbAuto.UseVisualStyleBackColor = false;
            this.rbAuto.CheckedChanged += new System.EventHandler(this.rbAuto_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(22, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "IP地址：";
            // 
            // tbIp
            // 
            this.tbIp.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbIp.Location = new System.Drawing.Point(81, 102);
            this.tbIp.Name = "tbIp";
            this.tbIp.Size = new System.Drawing.Size(172, 26);
            this.tbIp.TabIndex = 6;
            // 
            // tbSubNetMask
            // 
            this.tbSubNetMask.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbSubNetMask.Location = new System.Drawing.Point(81, 147);
            this.tbSubNetMask.Name = "tbSubNetMask";
            this.tbSubNetMask.Size = new System.Drawing.Size(172, 26);
            this.tbSubNetMask.TabIndex = 8;
            this.tbSubNetMask.Text = "255.255.255.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(10, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "子网掩码：";
            // 
            // tbGateWay
            // 
            this.tbGateWay.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbGateWay.Location = new System.Drawing.Point(81, 197);
            this.tbGateWay.Name = "tbGateWay";
            this.tbGateWay.Size = new System.Drawing.Size(172, 26);
            this.tbGateWay.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(6, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "默认网关：";
            // 
            // tbDns
            // 
            this.tbDns.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbDns.Location = new System.Drawing.Point(81, 246);
            this.tbDns.Name = "tbDns";
            this.tbDns.Size = new System.Drawing.Size(172, 26);
            this.tbDns.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(12, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "首选DNS：";
            // 
            // tbDns2
            // 
            this.tbDns2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbDns2.Location = new System.Drawing.Point(81, 294);
            this.tbDns2.Name = "tbDns2";
            this.tbDns2.Size = new System.Drawing.Size(172, 26);
            this.tbDns2.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(12, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "备选DNS：";
            // 
            // rbCurrent
            // 
            this.rbCurrent.AutoSize = true;
            this.rbCurrent.BackColor = System.Drawing.Color.Transparent;
            this.rbCurrent.ForeColor = System.Drawing.SystemColors.Info;
            this.rbCurrent.Location = new System.Drawing.Point(120, 16);
            this.rbCurrent.Name = "rbCurrent";
            this.rbCurrent.Size = new System.Drawing.Size(47, 16);
            this.rbCurrent.TabIndex = 15;
            this.rbCurrent.TabStop = true;
            this.rbCurrent.Tag = "";
            this.rbCurrent.Text = "当前";
            this.rbCurrent.UseVisualStyleBackColor = false;
            this.rbCurrent.CheckedChanged += new System.EventHandler(this.rbCurrent_CheckedChanged);
            // 
            // cbbIps
            // 
            this.cbbIps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbIps.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbIps.FormattingEnabled = true;
            this.cbbIps.Location = new System.Drawing.Point(81, 59);
            this.cbbIps.Name = "cbbIps";
            this.cbbIps.Size = new System.Drawing.Size(172, 24);
            this.cbbIps.TabIndex = 16;
            this.cbbIps.SelectedValueChanged += new System.EventHandler(this.cbbIps_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(22, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 12);
            this.label6.TabIndex = 17;
            this.label6.Text = "IP列表：";
            // 
            // Switch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(285, 344);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbbIps);
            this.Controls.Add(this.rbCurrent);
            this.Controls.Add(this.tbDns2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbDns);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbGateWay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSubNetMask);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbIp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbAuto);
            this.Controls.Add(this.rbSet);
            this.Controls.Add(this.btnRun);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Switch";
            this.Text = "切换IP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.RadioButton rbSet;
        private System.Windows.Forms.RadioButton rbAuto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbIp;
        private System.Windows.Forms.TextBox tbSubNetMask;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbGateWay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDns;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDns2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbCurrent;
        private System.Windows.Forms.ComboBox cbbIps;
        private System.Windows.Forms.Label label6;
    }
}

