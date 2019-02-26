using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace QQ
{
    public partial class frmMediaPlayer : Form
    {
        public frmMediaPlayer()
        {
            InitializeComponent();
            this.SizeChanged += new EventHandler(axWindowsMediaPlayer1_SizeChanged);
            CheckForIllegalCrossThreadCalls = false;
          
        }

        //线程是否结束标志位
        protected bool running = false;
        //歌曲列表
        protected string[] myMusicList;


        private void tsmiChooseMenu_Click(object sender, EventArgs e)
        {
            
            if (this.openFileDialogPlayerFiles.ShowDialog() == DialogResult.OK)
            {
                //默认播放第一首歌曲
                axWindowsMediaPlayer1.URL = openFileDialogPlayerFiles.FileNames[0];
                //用数组保存列表
                myMusicList = openFileDialogPlayerFiles.FileNames;
                
                string[] strTemp = new string[openFileDialogPlayerFiles.FileNames.Length];
                string tempFileName = "";
                for (int i = 0; i < openFileDialogPlayerFiles.FileNames.Length; i++)
                {
                    tempFileName = openFileDialogPlayerFiles.FileNames.GetValue(i).ToString();
                    int tempLength = tempFileName.Length;
                    int lastIndex = tempFileName.LastIndexOf("\\") + 1;
                    strTemp[i] = tempFileName.Substring(lastIndex, tempLength - lastIndex);
                }
                //绑定到播放列表
                listBoxPlayer.DataSource = strTemp;


                if (!running)
                {
                    // 启动另一线程检测 axWindowsMediaPlayer1 的播放状态，循环播放列表里的歌曲
                    running = true;
                    Thread thread = new Thread(new ThreadStart(this.CheckStatus));
                    thread.IsBackground = false;
                    thread.Start();
                }
            }
            
            }

        private void CheckStatus()
        {
            int cntIndex = 0;
            while (running)
            {
                try
                {
                    if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped && listBoxPlayer.Items.Count > 0)
                    {
                        cntIndex = listBoxPlayer.SelectedIndex + 1;
                        if (cntIndex > listBoxPlayer.Items.Count - 1)
                            cntIndex = 0;
                        listBoxPlayer.SelectedIndex = cntIndex;
                        axWindowsMediaPlayer1.URL = myMusicList[cntIndex];
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("咋回事，出错了!" + ex.ToString());
                    break;
                }
                //状态检测延时1秒,加快打开歌曲的速度
                System.Threading.Thread.Sleep(1000);
            }
            running = false;
        }

        //歌曲切换Listbox
        private void listBoxPlayer_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxPlayer.Text.Equals(""))
            {
                return;
            }
             axWindowsMediaPlayer1.URL=myMusicList[listBoxPlayer .SelectedIndex ];
           
        }

        //系统托盘按钮notifyIcon（Icon一定要设置）
        private void notifyIconPlayer_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
            this.notifyIconPlayer.Visible = false;
        }

        private void axWindowsMediaPlayer1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIconPlayer.Text = "我的播放器";
                notifyIconPlayer.Visible = true;
            }
        }

        private void frmMediaPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            running = false;
        }

        private void tsmiCloseMusic_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.baidu.com");
        }

        private void frmMediaPlayer_Load(object sender, EventArgs e)
        {

        }

        

       

       
        }
    }

