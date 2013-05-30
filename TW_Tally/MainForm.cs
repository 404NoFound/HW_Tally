using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
       
      
      
        

       

        private void buttonExpense_Click(object sender, EventArgs e)
        {

            panelRight.Controls.Clear();

            FormCost fc = new FormCost();
            fc.MdiParent = this;
           fc.Parent = panelRight;
            //fc.Height = splitContainerMain.Panel2.Height;
            //fc.Width = splitContainerMain.Panel2.Width;
            // fc.BackColor = System.Drawing.Color.Transparent;
            fc.Show();
        }

        private void buttonIncome_Click(object sender, EventArgs e)
        {
           panelRight.Controls.Clear();
            FormIncome fi = new FormIncome();
            fi.MdiParent = this;
            fi.Parent = panelRight;
            fi.Show();
        }

        private void buttonExpenseDetail_Click(object sender, EventArgs e)
        {
           panelRight.Controls.Clear();
            FormExpenseDetail fed = new FormExpenseDetail();
            fed.MdiParent = this;
            fed.Parent = panelRight;
            fed.Show();
        }

        private void buttonIncomeDeta_Click(object sender, EventArgs e)
        {
            panelRight.Controls.Clear();
            FormIncomeDetail fid = new FormIncomeDetail();
            fid.MdiParent = this;
            fid.Parent = panelRight;
            fid.Show();
        }

        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            panelRight.Controls.Clear();
        }

        
    } 
}
