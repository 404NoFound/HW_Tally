using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Web.Security;
using TW_Tally.Class;
using System.IO;



namespace TW_Tally.Forms
{
    public partial class FormRegister : Form
    {   
        
      public  string strConnection = @" Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\App_Data\userDB.mdb";
        public FormRegister()
        {
            InitializeComponent();
          
           
        }

        private void label_Password_Click(object sender, EventArgs e)
        {

        }

        private void label_PasswordCheck_Click(object sender, EventArgs e)
        {

        }

        private void label_UserName_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_Register_Load(object sender, EventArgs e)
        {
            
            // TODO: 这行代码将数据加载到表“userDBDataSet.UserList”中。您可以根据需要移动或删除它。
          //  this.userListTableAdapter.Fill(this.userDBDataSet.UserList);
          
        }

        

        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {    
        
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {  
           
        }

        private void button_Reg_Click(object sender, EventArgs e)
        {
           /* if (TextBox_UserName.Text.Length < 5 || TextBox_UserName.Text.Length > 20)
            {
                MessageBox.Show("用户名请在5至20个字符内。");
                this.TextBox_UserName.Focus();
            }*/
            //////////////////////////////////////////////////////////////////////////
            string pattern = @"^[A-Za-z0-9]{6,20}$";
            Match mPassWord = Regex.Match(this.TextBoxNewPassword.Text, pattern);
            //////////////////////////////////////////////////////////////////////////
            //旧密码MD5    
            string sOldPassword = textBoxOldPassword.Text.Trim();
            string sOldPasswordmd5 = FormsAuthentication.HashPasswordForStoringInConfigFile(sOldPassword, "MD5");
            string sOldPasswordmd5Twice = FormsAuthentication.HashPasswordForStoringInConfigFile(sOldPasswordmd5, "MD5");
         
              //////////////////////////////////////////////////////////////////////////
            //新密码MD5
             string sNewPassWord=TextBoxNewPassword.Text;
             string sNewPassWordmd5 = FormsAuthentication.HashPasswordForStoringInConfigFile(sNewPassWord, "MD5");
             string sNewPassWordmd5Twice = FormsAuthentication.HashPasswordForStoringInConfigFile(sNewPassWordmd5, "MD5");
             string sUserLoginPath = @".\App_Data\userLogin.xml";
             string sPassWordmd5Auth = File.ReadAllText(sUserLoginPath);

             FormMessageAutoClose auth = new FormMessageAutoClose();
           if (sPassWordmd5Auth!=sOldPasswordmd5Twice)
            {
                auth.setLabel("原始密码错误请重新输入");
                auth.ShowDialog();
                textBoxOldPassword.Text = "";
                textBoxOldPassword.Focus();
           } 
            else
            {
                if (!mPassWord.Success)
                {
                    MessageBox.Show("请重新输入密码 注意只能包含英文大小写和数字");
                    this.TextBoxNewPassword.Text = "";
                    this.textBox_PasswordCheck.Text = "";
                    this.TextBoxNewPassword.Focus();
                }
                else
                {
                    if (!textBox_PasswordCheck.Text.Equals(TextBoxNewPassword.Text))
                    {
                        MessageBox.Show("密码不一致 请重新输入, GV好赞");
                        this.textBox_PasswordCheck.Text = "";
                        this.TextBoxNewPassword.Text = "";
                        this.TextBoxNewPassword.Focus();
                    }
                    else
                    {
                        File.WriteAllText(@".\App_Data\userLogin.xml", sNewPassWordmd5Twice);
                        MessageBox.Show("密码修改。返回登录界面");
                        this.DialogResult = DialogResult.OK;

                    }

                }

            }
            

            
            
            



                try
            {
               
               
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
               // MessageBox.Show("用户名重复 请更换");
               // TextBox_UserName.Text = "";
                TextBoxNewPassword.Focus();
            }

            finally
            {
                
            } 
            
             
        }

        private void panel_Reg_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TextBox_Password_Leave(object sender, EventArgs e)
        {   //失去焦点时 验证密码是否符合规则
           
        }

        private void TextBox_UserName_Leave(object sender, EventArgs e)
        {
          
            
        }

        private void textBox_PasswordCheck_Leave(object sender, EventArgs e)
        {
            
        }

        private void textBox_PasswordCheck_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormRegister_Activated(object sender, EventArgs e)
        {
            textBoxOldPassword.Focus();
        }

        private void textBoxOldPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
