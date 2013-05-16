using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using System.IO;

namespace TW_Tally.Class
{
    class Class_db_control
    {
        void TestSQLite2()
        {
            try
            {
                //创建一个数据库文件

                string datasource = "./test.db";

                System.Data.SQLite.SQLiteConnection.CreateFile(datasource);

                //连接数据库

                System.Data.SQLite.SQLiteConnection conn =

                    new System.Data.SQLite.SQLiteConnection();

                System.Data.SQLite.SQLiteConnectionStringBuilder connstr =

                    new System.Data.SQLite.SQLiteConnectionStringBuilder();

                connstr.DataSource = datasource;

                //  connstr.Password = "admin";//设置密码，SQLite ADO.NET实现了数据库密码保护

                conn.ConnectionString = connstr.ToString();

                conn.Open();

                //创建表

                System.Data.SQLite.SQLiteCommand cmd = new System.Data.SQLite.SQLiteCommand();

                string sql = "CREATE TABLE test(username varchar(20),password text)";

                cmd.CommandText = sql;

                cmd.Connection = conn;

                cmd.ExecuteNonQuery();

                //插入数据
                SQLiteCommand cmd2 = new SQLiteCommand("INSERT INTO test(username, password) VALUES('dotnetthink', ?)", conn);
                cmd2.Parameters.Add("password");

                byte[] password = new byte[] { 1, 2, 3, 4, 5 };

                cmd2.Parameters["password"].Value = password;

                cmd2.ExecuteNonQuery();

                //取出数据

                sql = "SELECT * FROM test";

                cmd.CommandText = sql;

                System.Data.SQLite.SQLiteDataReader reader = cmd.ExecuteReader();

                StringBuilder sb = new StringBuilder();

                while (reader.Read())
                {

                    sb.Append("username:").Append(reader.GetString(0)).Append("\n")

                    .Append("password:").Append(reader.GetString(1));

                }

                MessageBox.Show(sb.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void TestSQLite()
        {
            using (SQLiteConnection cn = new SQLiteConnection("Data Source=Test.db;Pooling=true;FailIfMissing=false"))
            {
                //在打开数据库时，会判断数据库是否存在，如果不存在，则在当前目录下创建一个
                try
                {
                    cn.Open();

                    using (SQLiteCommand cmd = new SQLiteCommand())
                    {
                        cmd.Connection = cn;

                        //建立表，如果表已经存在，则报错
                        cmd.CommandText = "CREATE TABLE [test] (id int, name nvarchar(20))";
                        cmd.ExecuteNonQuery();

                        //插入测试数据
                        for (int i = 2; i < 5; i++)
                        {
                            cmd.CommandText = string.Format("INSERT INTO [test] VALUES ({0}, '杜思波技术讨论区域')", i);
                            cmd.ExecuteNonQuery();
                        }

                        for (int i = 5; i < 10; i++)
                        {
                            cmd.CommandText = string.Format("INSERT INTO [test] VALUES ({0}, 'English Test')", i);
                            cmd.ExecuteNonQuery();
                        }

                        //读取数据
                        cmd.CommandText = "SELECT * FROM [test]";
                        using (SQLiteDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                //Console.WriteLine("第{0} 条：{1}", dr.GetValue(0), dr.GetString(1));
                                MessageBox.Show(string.Format("第{0} 条：{1}", dr.GetValue(0), dr.GetString(1)));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


    }
}
