using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.OleDb;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace QQ
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void tsmiClient_Click(object sender, EventArgs e)
        {
            ChatsForm chatform = new ChatsForm();
            chatform.Show();
        }

        private void tsmiService_Click(object sender, EventArgs e)
        {
            frmServer frmservice = new frmServer();
            frmservice.Show();
        }

        private void tsniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiMediaplayer_Click(object sender, EventArgs e)
        {
            frmMediaPlayer mfrmMediaPlayer = new frmMediaPlayer();
            mfrmMediaPlayer.Show();
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            frmHelp mfrmhelp = new frmHelp();
            mfrmhelp.Show();
        }

    

     
    }
}
