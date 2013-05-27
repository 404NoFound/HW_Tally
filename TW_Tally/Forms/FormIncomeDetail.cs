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
    public partial class FormIncomeDetail : Form
    {
        public FormIncomeDetail()
        {
            InitializeComponent();
        }

        private void userIncomeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userIncomeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.userDBDataSet);

        }

        private void FormIncomeDetail_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“userDBDataSet.UserIncome”中。您可以根据需要移动或删除它。
            this.userIncomeTableAdapter.Fill(this.userDBDataSet.UserIncome);

        }
    }
}
