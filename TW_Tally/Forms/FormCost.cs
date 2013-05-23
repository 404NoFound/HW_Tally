using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TW_Tally.Class;

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
            // TODO: 这行代码将数据加载到表“userDBDataSet1.MerchantList”中。您可以根据需要移动或删除它。
        
           
          

        }

        
        private void textBoxCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            int curPos = textBoxCost.SelectionStart;    // 當前光標位置
            int pointPos = textBoxCost.Text.LastIndexOf('.');    // 小數點的位置
            if ((pointPos > 0) && (curPos > (pointPos + 2)))  // 輸入超過兩位小數﹐
            {
                e.Handled = true;
                return;
            }

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

        private void textBoxCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            DataRow newCostLine = userDBDataSet.Tables["UserExpense"].NewRow();
            newCostLine["Cost"]=textBoxCost.Text.Trim();
            newCostLine["Class"]=comboBoxBig.Text.Trim();
            newCostLine["Event"] = comboBoxSmall.Text.Trim();
            newCostLine["Merchant"] = comboBoxShop.Text.Trim();
            newCostLine["CostData"] = dateTimePickerCost.Value;
            newCostLine["Comments"] = textBoxComments.Text.Trim();
            try
            {
                
               userDBDataSet.Tables["UserExpense"].Rows.Add(newCostLine);
               this.userExpenseTableAdapter.Update(this.userDBDataSet.UserExpense);
               FormMessageAutoClose fm = new FormMessageAutoClose();
               fm.setLabel("添加成功返回主界面。");
               fm.ShowDialog();
               this.DialogResult = DialogResult.OK;

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void FormCost_Activated(object sender, EventArgs e)
        {
            
        }

        private void comboBoxShop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        private void buttonSaveAgain_Click(object sender, EventArgs e)
        {
            DataRow newCostLine = userDBDataSet.Tables["UserExpense"].NewRow();
            newCostLine["Cost"] = textBoxCost.Text.Trim();
            newCostLine["Class"] = comboBoxBig.Text.Trim();
            newCostLine["Event"] = comboBoxSmall.Text.Trim();
            newCostLine["Merchant"] = comboBoxShop.Text.Trim();
            newCostLine["CostData"] = dateTimePickerCost.Value;
            newCostLine["Comments"] = textBoxComments.Text.Trim();
            try
            {

                userDBDataSet.Tables["UserExpense"].Rows.Add(newCostLine);
                this.userExpenseTableAdapter.Update(this.userDBDataSet.UserExpense);
                FormMessageAutoClose fm = new FormMessageAutoClose();
                fm.setLabel("添加成功。");
                fm.ShowDialog();
                textBoxCost.Text = "";
                comboBoxBig.Text = "";
                comboBoxSmall.Text = "";
                comboBoxShop.Text = "";
                dateTimePickerCost.Value = DateTime.Now;
                textBoxComments.Text = "";

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
