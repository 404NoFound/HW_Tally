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
    public partial class FormIncome : Form
    {
        public FormIncome()
        {
            InitializeComponent();
        }

        private void userIncomeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userIncomeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.userDBDataSet);

        }

        private void FormIncome_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“userDBDataSet1.IncomeClass”中。您可以根据需要移动或删除它。
            this.incomeClassTableAdapter1.Fill(this.userDBDataSet1.IncomeClass);
            // TODO: 这行代码将数据加载到表“userDBDataSet1.UserIncome”中。您可以根据需要移动或删除它。
            this.userIncomeTableAdapter.Fill(this.userDBDataSet1.UserIncome);
            // TODO: 这行代码将数据加载到表“userDBDataSet.IncomeSource”中。您可以根据需要移动或删除它。
           
            // TODO: 这行代码将数据加载到表“userDBDataSet.UserIncome”中。您可以根据需要移动或删除它。
            this.userIncomeTableAdapter.Fill(this.userDBDataSet.UserIncome);

        }

        private void moneyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            int curPos = moneyTextBox.SelectionStart;    // 當前光標位置
            int pointPos = moneyTextBox.Text.LastIndexOf('.');    // 小數點的位置
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
                    string str = moneyTextBox.Text.Trim(); ;
                    int num = str.IndexOf('.');
                    if (num != -1)
                    {
                        e.Handled = true;
                    }
                }

            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(moneyTextBox.Text)>0)
          {
            DataRow newIncomeLine = userDBDataSet.Tables["UserIncome"].NewRow();
            newIncomeLine["Money"] = moneyTextBox.Text.Trim();
            newIncomeLine["Datetime"] = datetimeDateTimePicker.Value;
            newIncomeLine["Source"] = comboBoxSource.Text;
            newIncomeLine["Comments"] = commentsTextBox.Text.Trim();
            newIncomeLine["Type"] = comboBoxType.Text.Trim();

            try
            {

                userDBDataSet.Tables["UserIncome"].Rows.Add(newIncomeLine);
                this.userIncomeTableAdapter.Update(this.userDBDataSet.UserIncome);
                FormMessageAutoClose fm = new FormMessageAutoClose();
                fm.setLabel("添加成功返回主界面。");
                fm.ShowDialog();
                //this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
          }
            else
            {
                MessageBox.Show("请输入数据");
            }
           

        }

        private void typeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.incomeClassTableAdapter1.FillBy(this.userDBDataSet.IncomeClass);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(moneyTextBox.Text) > 0)
            {
                DataRow newIncomeLine = userDBDataSet.Tables["UserIncome"].NewRow();
                newIncomeLine["Money"] = Convert.ToInt32(moneyTextBox.Text.Trim());
                newIncomeLine["Datetime"] = datetimeDateTimePicker.Value;
                newIncomeLine["Source"] = comboBoxSource.Text;
                newIncomeLine["Comments"] = commentsTextBox.Text.Trim();
                newIncomeLine["Type"] = comboBoxType.Text.Trim();

                try
                {

                    userDBDataSet.Tables["UserIncome"].Rows.Add(newIncomeLine);
                    this.userIncomeTableAdapter.Update(this.userDBDataSet.UserIncome);
                    FormMessageAutoClose fm = new FormMessageAutoClose();


                    //this.DialogResult = DialogResult.OK;


                    moneyTextBox.Text = "0.00";
                    datetimeDateTimePicker.Value = DateTime.Now;
                    commentsTextBox.Text = "";
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            } 
            else
            {
                MessageBox.Show("请输入数据");
            }
           
        }

        private void FormIncome_Activated(object sender, EventArgs e)
        {
            moneyTextBox.Focus();
        }
    }
}
