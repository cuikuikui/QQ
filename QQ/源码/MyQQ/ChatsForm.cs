using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
//添加新的名称空间引用
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace QQ
{
    public partial class ChatsForm : Form
    {
        public ChatsForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;//禁用此异常
        }

        //客户机与服务器之间的连接状态
        public bool bConnected = false;
        //侦听线程
        public Thread tAcceptMsg = null;
        //用于Socket通信的IP地址和端口
        public IPEndPoint IPP = null;
        //Socket通信
        public Socket socket = null;
        //网络访问的基础数据流
        public NetworkStream nStream = null;
        //创建读取器
        public TextReader tReader = null;
        //创建编写器
        public TextWriter wReader = null;
        //侦听多线程，用于显示信息

        public void AcceptMessage()
        {
            ////接受客户机的连接请求
            //clientSocket = socket.Accept();

            //if (clientSocket != null)
            //{
            //    bConnected = true;
            //    label1.Text = "与客户 " + clientSocket.RemoteEndPoint.ToString() + " 成功建立连接。";
            //}

            //nStream = new NetworkStream(clientSocket);
            ////读字节流
            //tReader = new StreamReader(nStream);
            ////写字节流
            //wReader = new StreamWriter(nStream);

            string sTemp; //临时存储读取的字符串
            while (bConnected)
            {
                try
                {
                    //连续从当前流中读取字符串直至结束
                    sTemp = tReader.ReadLine();
                    if (sTemp.Length != 0)
                    {
                        //richTextBox2_KeyPress()和AcceptMessage()
                        //都将向richTextBox1写字符，可能访问有冲突，
                        //所以，需要多线程互斥
                        lock (this)
                        {
                            rtbHistory.Text = "服务器：" + sTemp + "\n" + rtbHistory.Text;
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("无法与服务器通信。");
                }
            }
            ////禁止当前Socket上的发送与接收
            //clientSocket.Shutdown(SocketShutdown.Both);
            ////关闭Socket，并释放所有关联的资源
            //clientSocket.Close();
            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
        }

        private void ChatsForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (bConnected)
            {
                try
                {
                    lock (this)
                    {
                        rtbHistory.Text = "客户机：" + rtbNowSend.Text + "\n" + rtbHistory.Text;
                        //客户机聊天信息写入网络流，以便服务器接收
                        wReader.WriteLine(rtbNowSend.Text);
                        //清理当前缓冲区数据，使所有缓冲数据写入基础设备
                        wReader.Flush();
                        //发送成功后，清空输入框并聚集之
                        rtbNowSend.Text = "";
                        rtbNowSend.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("无法与服务器通信!");
                }
            }
            else
            {
                MessageBox.Show("未与服务器建立连接，不能通信。");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rtbNowSend_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)//按下的是回车键
            {
                if (bConnected)
                {
                    try
                    {
                        lock (this)
                        {
                            rtbHistory.Text = "客户机：" + rtbNowSend.Text + rtbHistory.Text;
                            wReader.WriteLine(rtbNowSend.Text);
                            wReader.Flush();
                            rtbNowSend.Text = " ";
                            rtbNowSend.Focus();
                        }

                    }
                    catch
                    {
                        MessageBox.Show("与服务器断开连接");
                    }

                }
                else
                {
                    MessageBox.Show("未与服务器建立连接，不能通信");
                }

            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                IPP = new IPEndPoint(IPAddress.Parse(txtServerIP.Text), int.Parse(txtPortName.Text));
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
          
                socket.Connect(IPP);
             
                if (socket.Connected)
                {
                    nStream = new NetworkStream(socket);
                    tReader = new StreamReader(nStream);
                    wReader = new StreamWriter(nStream);
                    tAcceptMsg = new Thread(new ThreadStart(this.AcceptMessage));
                    tAcceptMsg.Start();
                    bConnected = true;
                    btnConnect.Enabled = false;
                    MessageBox.Show("与服务器成功建立连接，可以通信。"); 
                }
            }
            catch
            { 
                MessageBox.Show("无法与服务器通信。");
            }
        }

        private void ChatsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                socket.Close();
                tAcceptMsg.Abort();
            }
            catch
            {

            }
        }


    }
}
