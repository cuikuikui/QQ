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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
        private int GetBloodType(String strBloodTypeType)
        {
            int iBloodTypeID = 0;
            try
            {
                //打开一个新的数据库连接
                DBHelper.connection.Open();
                //构造SQL脚本
                String strSQL = String.Format("SELECT ID FROM bloodtype where bloodtype='{0}'", strBloodTypeType);
                //运行SQL脚本
                OleDbCommand command = new OleDbCommand(strSQL, DBHelper.connection);
                iBloodTypeID = Convert.ToInt32(command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            finally
            {
                DBHelper.connection.Close();
            }
            return iBloodTypeID;

        }

        private int GetStarId(String strStarType)
        {
            int iStartID = 0;
            try
            {
                //打开一个新的数据库连接
                DBHelper.connection.Open();
                //构造SQL脚本
                String strSQL = String.Format("SELECT ID FROM Star where star='{0}'",strStarType);
                //运行SQL脚本
                OleDbCommand command = new OleDbCommand(strSQL, DBHelper.connection);
                iStartID = Convert.ToInt32(command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            finally
            {
                DBHelper.connection.Close();
            }
            return iStartID;
         
        }
    
        private void RegisterForm_Load(object sender, EventArgs e)
        {
            //星座
            try
            {
                //打开一个新的数据库连接
                DBHelper.connection.Open();
                //构造SQL脚本
                String strSQL = String.Format("SELECT * FROM Star");
                //运行SQL脚本
                OleDbCommand command = new OleDbCommand(strSQL, DBHelper.connection);
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cboStar.Items.Add((string)reader[1]);
                }
                reader.Close();
               }
                catch (Exception ex)
                {
                    ex.ToString ();
                }
            finally 
            {
            DBHelper .connection .Close ();
            }

            //血型
            try
            {
                //打开一个新的数据库连接
                DBHelper.connection.Open();
                //构造SQL脚本
                String strSQL = String.Format("SELECT * FROM BloodType");
                //运行SQL脚本
                OleDbCommand command = new OleDbCommand(strSQL, DBHelper.connection);
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cboBloodType.Items.Add((string)reader[1]);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            finally
            {
                DBHelper.connection.Close();
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegist_Click(object sender, EventArgs e)
        {

            int iID = Convert.ToInt32(txtNum.Text);
            String strLoginPwd = txtLoginPwd.Text;
            String strNickName = txtNickName.Text;
            String strSex = rdoMale.Checked ? rdoMale.Text : rdoFemale.Text;
            int iAge = Convert.ToInt32(txtAge.Text);
            String strName = txtName.Text;
            int iStarID = GetStarId(cboStar.Text.ToString());
            int iBloodTypeID = GetBloodType(cboBloodType.Text.ToString());
            int iFaceID = 0; 
            try
            {
                //打开一个数据库连接
                DBHelper.connection.Open();
                //构造SQL脚本
                  String strSQL = string.Format("insert INTO Users(ID,LoginPwd,NickName,Sex,Age,Name,StarID,BloodTypeID,FaceId) values({0},'{1}','{2}','{3}',{4},'{5}',{6},{7},{8})", iID, strLoginPwd, strNickName, strSex, iAge, strName, iStarID, iBloodTypeID, iFaceID);
                //运行SQL脚本
                OleDbCommand command = new OleDbCommand(strSQL, DBHelper.connection);
                command.ExecuteNonQuery(); 
                MessageBox.Show("恭喜你，注册成功"); 
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            finally
            {
                DBHelper.connection.Close();
            }

        }


        
    }
}

