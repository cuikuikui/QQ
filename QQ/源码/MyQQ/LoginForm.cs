using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace QQ
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        //登录
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                //打开一个新的数据库链接
                DBHelper.connection.Open();
                //构造SQL脚本
                String strSQL = string.Format("SELECT COUNT(*) FROM Users WHERE id={0} and loginpwd='{1}'", Convert.ToInt32(txtLoginId.Text), txtLoginPwd.Text);
                //运行SQL脚本
                OleDbCommand command = new OleDbCommand(strSQL, DBHelper.connection);
                int iNum = Convert.ToInt32(command.ExecuteScalar());   //段系统登录验证密码的代码，当程序运行到调用Command对象的ExecuteScalar()
              
                
                if (iNum == 1)                                                           //？？？
                {
                    MainForm mMainform = new MainForm();
                    mMainform.ShowDialog();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                DBHelper.connection.Close();
            }
        }

        private void llbRegist_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registform = new RegisterForm();
            registform.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
        
