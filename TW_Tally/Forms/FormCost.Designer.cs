namespace TW_Tally.Forms
{
    partial class FormCost
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.userDBDataSet = new TW_Tally.userDBDataSet();
            this.userExpenseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userExpenseTableAdapter = new TW_Tally.userDBDataSetTableAdapters.UserExpenseTableAdapter();
            this.tableAdapterManager = new TW_Tally.userDBDataSetTableAdapters.TableAdapterManager();
            this.labelCost = new System.Windows.Forms.Label();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.labelType = new System.Windows.Forms.Label();
            this.comboBoxBig = new System.Windows.Forms.ComboBox();
            this.comboBoxSmall = new System.Windows.Forms.ComboBox();
            this.labelShop = new System.Windows.Forms.Label();
            this.comboBoxShop = new System.Windows.Forms.ComboBox();
            this.labelDataTime = new System.Windows.Forms.Label();
            this.dateTimePickerCost = new System.Windows.Forms.DateTimePicker();
            this.labelComment = new System.Windows.Forms.Label();
            this.textBoxComments = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userExpenseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // userDBDataSet
            // 
            this.userDBDataSet.DataSetName = "userDBDataSet";
            this.userDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userExpenseBindingSource
            // 
            this.userExpenseBindingSource.DataMember = "UserExpense";
            this.userExpenseBindingSource.DataSource = this.userDBDataSet;
            // 
            // userExpenseTableAdapter
            // 
            this.userExpenseTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = TW_Tally.userDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserExpenseTableAdapter = this.userExpenseTableAdapter;
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(72, 45);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(35, 12);
            this.labelCost.TabIndex = 0;
            this.labelCost.Text = "金额:";
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(126, 36);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(100, 21);
            this.textBoxCost.TabIndex = 1;
            this.textBoxCost.TextChanged += new System.EventHandler(this.textBoxCost_TextChanged);
            this.textBoxCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCost_KeyPress);
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(74, 74);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(29, 12);
            this.labelType.TabIndex = 2;
            this.labelType.Text = "种类";
            // 
            // comboBoxBig
            // 
            this.comboBoxBig.DisplayMember = "Class";
            this.comboBoxBig.FormattingEnabled = true;
            this.comboBoxBig.Location = new System.Drawing.Point(126, 74);
            this.comboBoxBig.Name = "comboBoxBig";
            this.comboBoxBig.Size = new System.Drawing.Size(121, 20);
            this.comboBoxBig.TabIndex = 3;
            this.comboBoxBig.ValueMember = "Class";
            // 
            // comboBoxSmall
            // 
            this.comboBoxSmall.FormattingEnabled = true;
            this.comboBoxSmall.Location = new System.Drawing.Point(126, 108);
            this.comboBoxSmall.Name = "comboBoxSmall";
            this.comboBoxSmall.Size = new System.Drawing.Size(121, 20);
            this.comboBoxSmall.TabIndex = 4;
            // 
            // labelShop
            // 
            this.labelShop.AutoSize = true;
            this.labelShop.Location = new System.Drawing.Point(67, 148);
            this.labelShop.Name = "labelShop";
            this.labelShop.Size = new System.Drawing.Size(41, 12);
            this.labelShop.TabIndex = 5;
            this.labelShop.Text = "商家：";
            // 
            // comboBoxShop
            // 
            this.comboBoxShop.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxShop.DataSource = this.userExpenseBindingSource;
            this.comboBoxShop.FormattingEnabled = true;
            this.comboBoxShop.Location = new System.Drawing.Point(126, 139);
            this.comboBoxShop.Name = "comboBoxShop";
            this.comboBoxShop.Size = new System.Drawing.Size(121, 20);
            this.comboBoxShop.TabIndex = 6;
            this.comboBoxShop.Text = "System.Data.DataViewManagerListItemTypeDescriptor";
            this.comboBoxShop.ValueMember = "Counts";
            // 
            // labelDataTime
            // 
            this.labelDataTime.AutoSize = true;
            this.labelDataTime.Location = new System.Drawing.Point(51, 176);
            this.labelDataTime.Name = "labelDataTime";
            this.labelDataTime.Size = new System.Drawing.Size(41, 12);
            this.labelDataTime.TabIndex = 7;
            this.labelDataTime.Text = "时间：";
            // 
            // dateTimePickerCost
            // 
            this.dateTimePickerCost.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.dateTimePickerCost.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerCost.Location = new System.Drawing.Point(126, 166);
            this.dateTimePickerCost.Name = "dateTimePickerCost";
            this.dateTimePickerCost.Size = new System.Drawing.Size(184, 21);
            this.dateTimePickerCost.TabIndex = 8;
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new System.Drawing.Point(53, 214);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(41, 12);
            this.labelComment.TabIndex = 9;
            this.labelComment.Text = "备注：";
            // 
            // textBoxComments
            // 
            this.textBoxComments.Location = new System.Drawing.Point(126, 204);
            this.textBoxComments.Multiline = true;
            this.textBoxComments.Name = "textBoxComments";
            this.textBoxComments.Size = new System.Drawing.Size(168, 50);
            this.textBoxComments.TabIndex = 10;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(126, 272);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 11;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // FormCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxComments);
            this.Controls.Add(this.labelComment);
            this.Controls.Add(this.dateTimePickerCost);
            this.Controls.Add(this.labelDataTime);
            this.Controls.Add(this.comboBoxShop);
            this.Controls.Add(this.labelShop);
            this.Controls.Add(this.comboBoxSmall);
            this.Controls.Add(this.comboBoxBig);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.labelCost);
            this.Name = "FormCost";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "支出";
            this.Activated += new System.EventHandler(this.FormCost_Activated);
            this.Load += new System.EventHandler(this.FormCost_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userExpenseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private userDBDataSet userDBDataSet;
        private System.Windows.Forms.BindingSource userExpenseBindingSource;
        private userDBDataSetTableAdapters.UserExpenseTableAdapter userExpenseTableAdapter;
        private userDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox comboBoxBig;
        private System.Windows.Forms.ComboBox comboBoxSmall;
        private System.Windows.Forms.Label labelShop;
        private System.Windows.Forms.ComboBox comboBoxShop;
        private System.Windows.Forms.Label labelDataTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerCost;
        private System.Windows.Forms.Label labelComment;
        private System.Windows.Forms.TextBox textBoxComments;
        private System.Windows.Forms.Button buttonOK;
       
       
    }
}