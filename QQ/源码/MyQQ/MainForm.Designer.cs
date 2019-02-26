namespace QQ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiChat = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClient = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiService = new System.Windows.Forms.ToolStripMenuItem();
            this.多媒体播放ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMediaplayer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSystem,
            this.tsmiChat,
            this.多媒体播放ToolStripMenuItem,
            this.tsmiHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(876, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiSystem
            // 
            this.tsmiSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsniExit});
            this.tsmiSystem.Name = "tsmiSystem";
            this.tsmiSystem.Size = new System.Drawing.Size(81, 24);
            this.tsmiSystem.Text = "系统管理";
            // 
            // tsniExit
            // 
            this.tsniExit.Name = "tsniExit";
            this.tsniExit.Size = new System.Drawing.Size(108, 24);
            this.tsniExit.Text = "退出";
            this.tsniExit.Click += new System.EventHandler(this.tsniExit_Click);
            // 
            // tsmiChat
            // 
            this.tsmiChat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiClient,
            this.tsmiService});
            this.tsmiChat.Name = "tsmiChat";
            this.tsmiChat.Size = new System.Drawing.Size(81, 24);
            this.tsmiChat.Text = "聊天功能";
            // 
            // tsmiClient
            // 
            this.tsmiClient.Name = "tsmiClient";
            this.tsmiClient.Size = new System.Drawing.Size(123, 24);
            this.tsmiClient.Text = "客户机";
            this.tsmiClient.Click += new System.EventHandler(this.tsmiClient_Click);
            // 
            // tsmiService
            // 
            this.tsmiService.Name = "tsmiService";
            this.tsmiService.Size = new System.Drawing.Size(123, 24);
            this.tsmiService.Text = "服务器";
            this.tsmiService.Click += new System.EventHandler(this.tsmiService_Click);
            // 
            // 多媒体播放ToolStripMenuItem
            // 
            this.多媒体播放ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMediaplayer});
            this.多媒体播放ToolStripMenuItem.Name = "多媒体播放ToolStripMenuItem";
            this.多媒体播放ToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.多媒体播放ToolStripMenuItem.Text = "多媒体播放";
            // 
            // tsmiMediaplayer
            // 
            this.tsmiMediaplayer.Name = "tsmiMediaplayer";
            this.tsmiMediaplayer.Size = new System.Drawing.Size(153, 24);
            this.tsmiMediaplayer.Text = "多媒体播放";
            this.tsmiMediaplayer.Click += new System.EventHandler(this.tsmiMediaplayer_Click);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(51, 24);
            this.tsmiHelp.Text = "帮助";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(152, 24);
            this.tsmiAbout.Text = "关于";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QQ.Properties.Resources.ChatFormBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(876, 634);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "主窗口";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiSystem;
        private System.Windows.Forms.ToolStripMenuItem tsniExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiChat;
        private System.Windows.Forms.ToolStripMenuItem 多媒体播放ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiClient;
        private System.Windows.Forms.ToolStripMenuItem tsmiService;
        private System.Windows.Forms.ToolStripMenuItem tsmiMediaplayer;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;

    }
}