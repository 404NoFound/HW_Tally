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
            FormCost fc = new FormCost();
            fc.ShowDialog();
        }

        
    } 
}
