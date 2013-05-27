using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TW_Tally.Forms;

using System.Text.RegularExpressions;

namespace TW_Tally
{
    public partial class MainForm : Form
    {

        //Class_db db = new Class_db();     
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“userDBDataSet.UserList”中。您可以根据需要移动或删除它。
           // this.userListTableAdapter.Fill(this.userDBDataSet.UserList);

        }
       
      
      
        

        private void buttonAddRecord_Click(object sender, EventArgs e)
        {
            splitContainerMain.Panel2.Controls.Clear();
            FormCost fc = new FormCost();
            fc.MdiParent = this;
            fc.Parent = splitContainerMain.Panel2;
            fc.Height = splitContainerMain.Panel2.Height;
            fc.Width = splitContainerMain.Panel2.Width;
           // fc.BackColor = System.Drawing.Color.Transparent;
            fc.Show();
           // fc.ShowDialog();
        }

        private void buttonIncome_Click(object sender, EventArgs e)
        {
            splitContainerMain.Panel2.Controls.Clear();
            FormIncome fi = new FormIncome();
            fi.MdiParent = this;
            fi.Parent = splitContainerMain.Panel2;
            fi.Height = splitContainerMain.Panel2.Height;
            fi.Width = splitContainerMain.Panel2.Width;
            fi.Show();
        }

        private void buttonExpenseDetail_Click(object sender, EventArgs e)
        {
            splitContainerMain.Panel2.Controls.Clear();
            FormExpenseDetail fed = new FormExpenseDetail();
            fed.MdiParent = this;
            fed.Parent = splitContainerMain.Panel2;
            fed.Height = splitContainerMain.Panel2.Height;
           fed.Width = splitContainerMain.Panel2.Width;
            fed.Show();
        }

        private void buttonIncomeDetail_Click(object sender, EventArgs e)
        {
            splitContainerMain.Panel2.Controls.Clear();
            FormIncomeDetail fid = new FormIncomeDetail();
            fid.MdiParent = this;
            fid.Parent = splitContainerMain.Panel2;
            fid.Height = splitContainerMain.Panel2.Height;
            fid.Width = splitContainerMain.Panel2.Width;
            fid.Show();
        }

        
    } 
}
