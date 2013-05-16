using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;


namespace TW_Tally.Forms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            string sUserLoginPath = @".\App_Data\userLogin.xml";
            string PassWord = textBox_Password.Text.Trim();
            string sPassWordmd5 = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(PassWord, "MD5");
            string sPassWordmd5Twice
                = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(sPassWordmd5, "MD5");
            //输入密码 两次MD5加密
            
          
             FileInfo fUserLogin = new FileInfo(sUserLoginPath);
         if (!File.Exists(sUserLoginPath))
           {
              File.CreateText(sUserLoginPath);
            }
            string sPassWordmd5Auth = "";
            //sPassWordmd5Auth = File.ReadAllText(sUserLoginPath);
            sPassWordmd5Auth=File.ReadAllText(sUserLoginPath); //读取密码的二次MD5加密值
            int iPassWordMd5Lenth = Convert.ToInt16(fUserLogin.Length);
            
            if (iPassWordMd5Lenth!=32)
            {
                FormMessageAutoClose fPassWordNoSet = new FormMessageAutoClose();
                fPassWordNoSet.setLabel("密码未设置");
                fPassWordNoSet.ShowDialog();
                Form fReg = new FormRegister();
                fReg.ShowDialog();
            }

            else
            {
                if (sPassWordmd5Auth == sPassWordmd5Twice)
                {
                    FormMessageAutoClose fLoginSuccess = new FormMessageAutoClose();
                    fLoginSuccess.setLabel("登录成功，自动跳转中");
                    fLoginSuccess.ShowDialog();
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("密码错误");
                    // textBox_UserName.Text = "";
                    textBox_Password.Text = "";
                }
            }


     
               
               


            
        }

        private void button_Register_Click(object sender, EventArgs e)
        {
            Form fReg = new FormRegister();
            fReg.ShowDialog();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Form_Login_Load(object sender, EventArgs e)
        {

        }

        private void FormLogin_Activated(object sender, EventArgs e)
        {
            textBox_Password.Focus();
        }


    }
}
