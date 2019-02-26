namespace QQ
{
    partial class ChatsForm
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
            System.Windows.Forms.Button btnSend;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatsForm));
            System.Windows.Forms.Button btnClose;
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.txtPortName = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.rtbNowSend = new System.Windows.Forms.RichTextBox();
            this.rtbHistory = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            btnSend = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            btnSend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSend.BackgroundImage")));
            btnSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnSend.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            btnSend.ForeColor = System.Drawing.Color.Red;
            btnSend.Location = new System.Drawing.Point(411, 526);
            btnSend.Margin = new System.Windows.Forms.Padding(4);
            btnSend.Name = "btnSend";
            btnSend.Size = new System.Drawing.Size(107, 41);
            btnSend.TabIndex = 15;
            btnSend.Text = "发送";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnClose
            // 
            btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnClose.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            btnClose.ForeColor = System.Drawing.Color.Red;
            btnClose.Location = new System.Drawing.Point(116, 526);
            btnClose.Margin = new System.Windows.Forms.Padding(4);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(107, 41);
            btnClose.TabIndex = 14;
            btnClose.Text = "关闭";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtServerIP);
            this.groupBox2.Controls.Add(this.txtPortName);
            this.groupBox2.Controls.Add(this.btnConnect);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(34, 29);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(601, 84);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "服务器参数";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(288, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "端口:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(8, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "IP地址:";
            // 
            // txtServerIP
            // 
            this.txtServerIP.Location = new System.Drawing.Point(98, 36);
            this.txtServerIP.Margin = new System.Windows.Forms.Padding(4);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(169, 30);
            this.txtServerIP.TabIndex = 1;
            this.txtServerIP.Text = "10.50.168.49";
            // 
            // txtPortName
            // 
            this.txtPortName.Location = new System.Drawing.Point(367, 36);
            this.txtPortName.Margin = new System.Windows.Forms.Padding(4);
            this.txtPortName.Name = "txtPortName";
            this.txtPortName.Size = new System.Drawing.Size(108, 30);
            this.txtPortName.TabIndex = 2;
            this.txtPortName.Text = "65535";
            // 
            // btnConnect
            // 
            this.btnConnect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConnect.BackgroundImage")));
            this.btnConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConnect.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnConnect.ForeColor = System.Drawing.Color.Red;
            this.btnConnect.Location = new System.Drawing.Point(483, 31);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(110, 41);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "连接";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // rtbNowSend
            // 
            this.rtbNowSend.Location = new System.Drawing.Point(32, 372);
            this.rtbNowSend.Margin = new System.Windows.Forms.Padding(4);
            this.rtbNowSend.Name = "rtbNowSend";
            this.rtbNowSend.Size = new System.Drawing.Size(601, 146);
            this.rtbNowSend.TabIndex = 13;
            this.rtbNowSend.Text = "";
            this.rtbNowSend.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbNowSend_KeyPress);
            // 
            // rtbHistory
            // 
            this.rtbHistory.Location = new System.Drawing.Point(35, 149);
            this.rtbHistory.Margin = new System.Windows.Forms.Padding(4);
            this.rtbHistory.Name = "rtbHistory";
            this.rtbHistory.Size = new System.Drawing.Size(603, 170);
            this.rtbHistory.TabIndex = 12;
            this.rtbHistory.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(49, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "历史信息内容";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(42, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "发送信息内容";
            // 
            // ChatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QQ.Properties.Resources.ChatFormBG1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(665, 580);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(btnSend);
            this.Controls.Add(btnClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.rtbNowSend);
            this.Controls.Add(this.rtbHistory);
            this.Name = "ChatsForm";
            this.Text = "客户机";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChatsForm_FormClosing);
            this.Load += new System.EventHandler(this.ChatsForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtServerIP;
        private System.Windows.Forms.TextBox txtPortName;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.RichTextBox rtbHistory;
        private System.Windows.Forms.RichTextBox rtbNowSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}