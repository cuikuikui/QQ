namespace QQ
{
    partial class frmMediaPlayer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMediaPlayer));
            this.menuStripPlayer = new System.Windows.Forms.MenuStrip();
            this.tsmiChooseMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCloseMusic = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxPlayer = new System.Windows.Forms.ListBox();
            this.openFileDialogPlayerFiles = new System.Windows.Forms.OpenFileDialog();
            this.notifyIconPlayer = new System.Windows.Forms.NotifyIcon(this.components);
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStripPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripPlayer
            // 
            this.menuStripPlayer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiChooseMenu,
            this.tsmiCloseMusic});
            this.menuStripPlayer.Location = new System.Drawing.Point(0, 0);
            this.menuStripPlayer.Name = "menuStripPlayer";
            this.menuStripPlayer.Size = new System.Drawing.Size(580, 28);
            this.menuStripPlayer.TabIndex = 0;
            this.menuStripPlayer.Text = "menuStrip1";
            // 
            // tsmiChooseMenu
            // 
            this.tsmiChooseMenu.Name = "tsmiChooseMenu";
            this.tsmiChooseMenu.Size = new System.Drawing.Size(81, 24);
            this.tsmiChooseMenu.Text = "选择文件";
            this.tsmiChooseMenu.Click += new System.EventHandler(this.tsmiChooseMenu_Click);
            // 
            // tsmiCloseMusic
            // 
            this.tsmiCloseMusic.Name = "tsmiCloseMusic";
            this.tsmiCloseMusic.Size = new System.Drawing.Size(96, 24);
            this.tsmiCloseMusic.Text = "关闭播放器";
            this.tsmiCloseMusic.Click += new System.EventHandler(this.tsmiCloseMusic_Click);
            // 
            // listBoxPlayer
            // 
            this.listBoxPlayer.FormattingEnabled = true;
            this.listBoxPlayer.ItemHeight = 15;
            this.listBoxPlayer.Location = new System.Drawing.Point(0, 423);
            this.listBoxPlayer.Name = "listBoxPlayer";
            this.listBoxPlayer.Size = new System.Drawing.Size(570, 139);
            this.listBoxPlayer.TabIndex = 2;
            this.listBoxPlayer.DoubleClick += new System.EventHandler(this.listBoxPlayer_DoubleClick);
            // 
            // openFileDialogPlayerFiles
            // 
            this.openFileDialogPlayerFiles.FileName = "openFileDialog1";
            this.openFileDialogPlayerFiles.Multiselect = true;
            // 
            // notifyIconPlayer
            // 
            this.notifyIconPlayer.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconPlayer.Icon")));
            this.notifyIconPlayer.Text = "notifyIcon1";
            this.notifyIconPlayer.Visible = true;
            this.notifyIconPlayer.Click += new System.EventHandler(this.notifyIconPlayer_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 27);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(570, 304);
            this.axWindowsMediaPlayer1.TabIndex = 1;
            this.axWindowsMediaPlayer1.SizeChanged += new System.EventHandler(this.axWindowsMediaPlayer1_SizeChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.linkLabel1.ForeColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Location = new System.Drawing.Point(488, 49);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(37, 15);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "帮助";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(221, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // frmMediaPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::QQ.Properties.Resources.PersonalFormBG1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(601, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.listBoxPlayer);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.menuStripPlayer);
            this.Name = "frmMediaPlayer";
            this.Text = "多媒体播放";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMediaPlayer_FormClosing);
            this.Load += new System.EventHandler(this.frmMediaPlayer_Load);
            this.menuStripPlayer.ResumeLayout(false);
            this.menuStripPlayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripPlayer;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ListBox listBoxPlayer;
        private System.Windows.Forms.ToolStripMenuItem tsmiChooseMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiCloseMusic;
        private System.Windows.Forms.OpenFileDialog openFileDialogPlayerFiles;
        private System.Windows.Forms.NotifyIcon notifyIconPlayer;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;



    }
}