using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TW_Tally.Forms
{
    public partial class FormCost : Form
    {
        public FormCost()
        {
            InitializeComponent();
        }

        private void userExpenseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userExpenseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.userDBDataSet);

        }

        private void FormCost_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“userDBDataSet.UserExpense”中。您可以根据需要移动或删除它。
          

        }

        
        private void textBoxCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '.' || e.KeyChar == ''))
            {
                e.Handled = true;
            }
            else
            {
                if (e.KeyChar == '.')
                {
                    string str = textBoxCost.Text.Trim(); ;
                    int num = str.IndexOf('.');
                    if (num != -1)
                    {
                        e.Handled = true;
                    }
                }
               
            }
        }
    }
}
