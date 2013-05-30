using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TW_Tally.Class;
using System.Data.OleDb;

namespace TW_Tally.Forms
{
    public partial class FormCost : Form
    {
        public FormCost()
        {
            InitializeComponent();
        }

     

        private void FormCost_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“userDBDataSet.MerchantList”中。您可以根据需要移动或删除它。
            this.merchantListTableAdapter.Fill(this.userDBDataSet.MerchantList);
            // TODO: 这行代码将数据加载到表“userDBDataSet.CostType”中。您可以根据需要移动或删除它。
            this.costTypeTableAdapter.Fill(this.userDBDataSet.CostType);
            // TODO: 这行代码将数据加载到表“userDBDataSet.UserExpense”中。您可以根据需要移动或删除它。
            this.userExpenseTableAdapter.Fill(this.userDBDataSet.UserExpense);
            // TODO: 这行代码将数据加载到表“userDBDataSet.CostClass”中。您可以根据需要移动或删除它。
            this.costClassTableAdapter.Fill(this.userDBDataSet.CostClass);
            for (int i = 1; i <= 24; i++)
            {
              //  comboBoxHours.Items.Add(i);
            }

            for (int i = 1; i <= 60; i++)
            {
            //    comboBoxMinutes.Items.Add(i);
            }
            DateTime DT = new DateTime();
            DT = DateTime.Now;
          //  comboBoxMinutes.Text = DT.Minute.ToString();
           // comboBoxHours.Text=DT.Hour.ToString();


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

       

        private void buttonOK_Click(object sender, EventArgs e)
        {   

           DataRow newCostLine = userDBDataSet.Tables["UserExpense"].NewRow();
            DateTime dt=new DateTime();
          //  dt = dateTimePickerCost.Value;
            //dt.Hour = comboBoxHours.SelectedItem;
           // dt.Minute = comboBoxMinutes.SelectedItem;
            

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
               //this.DialogResult = DialogResult.OK;
               this.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void FormCost_Activated(object sender, EventArgs e)
        {
            textBoxCost.Focus();
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

        private void comboBoxSmall_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBoxSmall_SelectedValueChanged(object sender, EventArgs e)
        {   
            try
            {
                if (comboBoxSmall.Text != "")
                {
                    string sPicSource = System.Environment.CurrentDirectory;
                    sPicSource += @"\Pics\";
                    sPicSource += comboBoxSmall.Text;
                    sPicSource += @".jpg";
                    pictureBoxType.Load(sPicSource);
                }
            }
            catch (System.Exception ex)
            {
                pictureBoxType.Load(@".\Pics\Null.jpg");
            }
            finally
            {
               
            }

       

           
        }

   
        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.costTypeTableAdapter.FillBy(this.userDBDataSet.CostType);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void comboBoxBig_TextChanged(object sender, EventArgs e)
        {/*
            string strConnection = @" Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\userDB.mdb";
            string strCommand = string.Format("SELECT Event  FROM  CostType WHERE   (Class) ='{0}'",comboBoxBig.Text );
            OleDbCommand DBcomm = new OleDbCommand();
            OleDbConnection DBConnection = new OleDbConnection();
            DBConnection.ConnectionString = strConnection;
            DBConnection.Open();
            DBcomm.CommandText = strCommand;
            OleDbDataAdapter DA = new OleDbDataAdapter(strCommand,DBConnection);
           
            DataSet ds=new DataSet();
            DA.Fill(ds);
            DataTable dt=ds.Tables[0];
            for (int i=0;i<dt.Rows.Count;i++)
            {
                comboBoxSmall.Items.Add(dt.Rows[i]["Event"]);
            }
            DBConnection.Close();

         */
           
        }
    }
}
