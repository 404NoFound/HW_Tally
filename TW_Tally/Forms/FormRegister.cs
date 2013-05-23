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
        FormMessageAutoClose auth = new FormMessageAutoClose();
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
            label1.Text = Properties.Settings.Default.PassWordMd5Twice.ToString();
        }

        

        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {    
        
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {  
           
        }

        private void button_Reg_Click(object sender, EventArgs e)
        {
           
            //////////////////////////////////////////////////////////////////////////
            string pattern = @"^[A-Za-z0-9]{6,20}$";
            Match mPassWord = Regex.Match(this.TextBoxNewPassword.Text, pattern);
            //////////////////////////////////////////////////////////////////////////
            //旧密码MD5    
            string sOldPassword = textBoxOldPassword.Text.Trim();
            sOldPassword += "abc";

            string sOldPasswordmd5 = FormsAuthentication.HashPasswordForStoringInConfigFile(sOldPassword, "MD5");
            string sOldPasswordmd5Twice = FormsAuthentication.HashPasswordForStoringInConfigFile(sOldPasswordmd5, "MD5");
            //////////////////////////////////////////////////////////////////////////
            //新密码MD5
             string sNewPassWord=TextBoxNewPassword.Text;
             sNewPassWord += "abc";
             
             string sNewPassWordmd5 = FormsAuthentication.HashPasswordForStoringInConfigFile(sNewPassWord, "MD5");
             string sNewPassWordmd5Twice = FormsAuthentication.HashPasswordForStoringInConfigFile(sNewPassWordmd5, "MD5");
            // string sUserLoginPath = @".\App_Data\userLogin.dll";
             //string sPassWordmd5Auth = File.ReadAllText(sUserLoginPath);
             string sPassWordmd5Auth = Properties.Settings.Default.PassWordMd5Twice.ToString(); 
            
             
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
                       // File.WriteAllText(sUserLoginPath, sNewPassWordmd5Twice);
                        Properties.Settings.Default.PassWordMd5Twice = sNewPassWordmd5Twice;

                        Properties.Settings.Default.Save();
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
