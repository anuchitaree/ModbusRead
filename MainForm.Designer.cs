namespace ModbusRead
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbStatus = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmbRegType = new System.Windows.Forms.ComboBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtAddrIp = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtStartAddr = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtUpdate = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTimeOut = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(270, 59);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(38, 13);
            this.lbStatus.TabIndex = 13;
            this.lbStatus.Text = "status:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(154, 434);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "label1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(154, 408);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "label1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(154, 381);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "label1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(154, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "label1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "label1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(260, 17);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(97, 39);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "CONNECT";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 495);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(485, 20);
            this.textBox1.TabIndex = 14;
            // 
            // cmbRegType
            // 
            this.cmbRegType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRegType.FormattingEnabled = true;
            this.cmbRegType.Items.AddRange(new object[] {
            "01 (0x01) Read Coils",
            "02 (0x02) Read Discrete Inputs",
            "03 (0x03) Read Holding Registers",
            "04 (0x04) Read Input Registers"});
            this.cmbRegType.Location = new System.Drawing.Point(19, 83);
            this.cmbRegType.Name = "cmbRegType";
            this.cmbRegType.Size = new System.Drawing.Size(219, 21);
            this.cmbRegType.TabIndex = 15;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(177, 27);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(77, 20);
            this.txtPort.TabIndex = 16;
            this.txtPort.Text = "502";
            // 
            // txtAddrIp
            // 
            this.txtAddrIp.Location = new System.Drawing.Point(16, 27);
            this.txtAddrIp.Name = "txtAddrIp";
            this.txtAddrIp.Size = new System.Drawing.Size(155, 20);
            this.txtAddrIp.TabIndex = 17;
            this.txtAddrIp.Text = "192.168.100.127";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "IP Address";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(187, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Port";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Register Type";
            // 
            // txtStartAddr
            // 
            this.txtStartAddr.Location = new System.Drawing.Point(257, 110);
            this.txtStartAddr.Name = "txtStartAddr";
            this.txtStartAddr.Size = new System.Drawing.Size(100, 20);
            this.txtStartAddr.TabIndex = 19;
            this.txtStartAddr.Text = "1";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(363, 110);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(100, 20);
            this.txtQty.TabIndex = 19;
            this.txtQty.Text = "10";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(257, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Start address";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(376, 91);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Q\'TY";
            // 
            // txtUpdate
            // 
            this.txtUpdate.Location = new System.Drawing.Point(469, 110);
            this.txtUpdate.Name = "txtUpdate";
            this.txtUpdate.Size = new System.Drawing.Size(100, 20);
            this.txtUpdate.TabIndex = 19;
            this.txtUpdate.Text = "1";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(477, 91);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "Auto-update(sec)";
            // 
            // txtTimeOut
            // 
            this.txtTimeOut.Location = new System.Drawing.Point(479, 36);
            this.txtTimeOut.Name = "txtTimeOut";
            this.txtTimeOut.Size = new System.Drawing.Size(100, 20);
            this.txtTimeOut.TabIndex = 19;
            this.txtTimeOut.Text = "5000";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(481, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 13);
            this.label16.TabIndex = 13;
            this.label16.Text = "Timeout(ms)";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(215, 165);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(690, 302);
            this.dgv.TabIndex = 20;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 545);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.txtTimeOut);
            this.Controls.Add(this.txtUpdate);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtStartAddr);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtAddrIp);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.cmbRegType);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConnect);
            this.Name = "MainForm";
            this.Text = "Modbus TCP Read";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmbRegType;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtAddrIp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtStartAddr;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtUpdate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtTimeOut;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dgv;
    }
}

