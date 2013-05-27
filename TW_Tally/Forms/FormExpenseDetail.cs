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
    public partial class FormExpenseDetail : Form
    {
        public FormExpenseDetail()
        {
            InitializeComponent();
        }

        private void FormExpenseDetail_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“userDBDataSet.UserExpense”中。您可以根据需要移动或删除它。
            this.userExpenseTableAdapter.Fill(this.userDBDataSet.UserExpense);
            
        }

        private void userExpenseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {   
            try
        {
            this.Validate();
            this.userExpenseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.userDBDataSet);
            this.DialogResult = DialogResult.OK;
        }
        catch (System.Exception ex)
        {
        	FormMessageAutoClose fma=new FormMessageAutoClose();
            fma.setLabel("输入数据有误，请检查后重新输入。");
            fma.ShowDialog();
        }
            

        }

        private void userExpenseDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

      
    }
}
