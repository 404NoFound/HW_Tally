using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace TW_Tally.Class
{
    class DataOpen
    {
      
        private string strConnection = @" Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\App_Data";
       
        OleDbCommand DBcomm = new OleDbCommand();
        OleDbConnection DBConnection = new OleDbConnection();
        OleDbDataAdapter DBDataAdapter = new OleDbDataAdapter();
        
            void setDB()
            {
                DBConnection.ConnectionString= strConnection;
            }
        }

  /*
OleDbConnection con = new OleDbConnection(strConnection);
              OleDbCommand comm = new OleDbCommand();
              con.Open();
              string sSql = string.Format("SELECT UserName, PasswordMD5 FROM  UserList WHERE   (UserName) ='{0}'and (PasswordMD5)='{1}'", UserName, sPassWordmd5Twice);
              comm.CommandText = sSql;
              comm.Connection = con;
              int count = 0;
              comm.ExecuteScalar();
              OleDbDataReader read = comm.ExecuteReader();
              read.Read();
              if (read.HasRows)
              {
                  Form_LoginSuccess fLoginSuccess = new Form_LoginSuccess();
                  fLoginSuccess.ShowDialog();
                  this.DialogResult = DialogResult.OK;
              }
              else
              {
                  MessageBox.Show("用户名或密码错误");
                  textBox_UserName.Text = "";
                  textBox_Password.Text = "";
              }


              con.Close(); */



    }
