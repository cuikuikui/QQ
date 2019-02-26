namespace QQ
{
    partial class frmServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServer));
            System.Windows.Forms.Button btnClose;
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbHistory = new System.Windows.Forms.RichTextBox();
            this.rtbNowSend = new System.Windows.Forms.RichTextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtPortName = new System.Windows.Forms.TextBox();
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            btnSend = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            btnSend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSend.BackgroundImage")));
            btnSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnSend.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            btnSend.ForeColor = System.Drawing.Color.Red;
            btnSend.Location = new System.Drawing.Point(404, 460);
            btnSend.Margin = new System.Windows.Forms.Padding(4);
            btnSend.Name = "btnSend";
            btnSend.Size = new System.Drawing.Size(107, 41);
            btnSend.TabIndex = 21;
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
            btnClose.Location = new System.Drawing.Point(109, 460);
            btnClose.Margin = new System.Windows.Forms.Padding(4);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(107, 41);
            btnClose.TabIndex = 20;
            btnClose.Text = "关闭";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(36, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "客户端信息:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(35, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 19);
            this.label4.TabIndex = 23;
            this.label4.Text = "发送信息内容";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(42, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "历史信息内容";
            // 
            // rtbHistory
            // 
            this.rtbHistory.Location = new System.Drawing.Point(38, 93);
            this.rtbHistory.Margin = new System.Windows.Forms.Padding(4);
            this.rtbHistory.Name = "rtbHistory";
            this.rtbHistory.Size = new System.Drawing.Size(603, 170);
            this.rtbHistory.TabIndex = 18;
            this.rtbHistory.Text = "";
            // 
            // rtbNowSend
            // 
            this.rtbNowSend.Location = new System.Drawing.Point(28, 306);
            this.rtbNowSend.Margin = new System.Windows.Forms.Padding(4);
            this.rtbNowSend.Name = "rtbNowSend";
            this.rtbNowSend.Size = new System.Drawing.Size(601, 146);
            this.rtbNowSend.TabIndex = 19;
            this.rtbNowSend.Text = "";
            this.rtbNowSend.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbNowSend_KeyPress);
            // 
            // btnStart
            // 
            this.btnStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStart.BackgroundImage")));
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStart.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStart.ForeColor = System.Drawing.Color.Red;
            this.btnStart.Location = new System.Drawing.Point(555, 12);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(107, 41);
            this.btnStart.TabIndex = 25;
            this.btnStart.Text = "启动";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtPortName
            // 
            this.txtPortName.Location = new System.Drawing.Point(346, 43);
            this.txtPortName.Multiline = true;
            this.txtPortName.Name = "txtPortName";
            this.txtPortName.Size = new System.Drawing.Size(118, 33);
            this.txtPortName.TabIndex = 27;
            this.txtPortName.Text = "65535";
            // 
            // txtServerIP
            // 
            this.txtServerIP.Location = new System.Drawing.Point(346, 1);
            this.txtServerIP.Multiline = true;
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(118, 36);
            this.txtServerIP.TabIndex = 28;
            this.txtServerIP.Text = "10.50.168.49";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(256, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 30;
            this.label5.Text = "端口";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(256, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 15);
            this.label6.TabIndex = 31;
            this.label6.Text = "IP";
            // 
            // frmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QQ.Properties.Resources.ChatFormBG2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(690, 531);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtServerIP);
            this.Controls.Add(this.txtPortName);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(btnSend);
            this.Controls.Add(btnClose);
            this.Controls.Add(this.rtbNowSend);
            this.Controls.Add(this.rtbHistory);
            this.Controls.Add(this.label1);
            this.Name = "frmServer";
            this.Text = "聊天服务器";
            this.Load += new System.EventHandler(this.frmServer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbHistory;
        private System.Windows.Forms.RichTextBox rtbNowSend;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtPortName;
        private System.Windows.Forms.TextBox txtServerIP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}