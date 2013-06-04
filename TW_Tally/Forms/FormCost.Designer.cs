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
            this.labelCost = new System.Windows.Forms.Label();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.labelType = new System.Windows.Forms.Label();
            this.comboBoxBig = new System.Windows.Forms.ComboBox();
            this.userDBDataSet = new TW_Tally.userDBDataSet();
            this.comboBoxSmall = new System.Windows.Forms.ComboBox();
            this.costTypeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.labelShop = new System.Windows.Forms.Label();
            this.comboBoxShop = new System.Windows.Forms.ComboBox();
            this.merchantListBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.merchantListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelDataTime = new System.Windows.Forms.Label();
            this.dateTimePickerCost = new System.Windows.Forms.DateTimePicker();
            this.labelComment = new System.Windows.Forms.Label();
            this.textBoxComments = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonSaveAgain = new System.Windows.Forms.Button();
            this.costClassTableAdapter = new TW_Tally.userDBDataSetTableAdapters.CostClassTableAdapter();
            this.userExpenseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userExpenseTableAdapter = new TW_Tally.userDBDataSetTableAdapters.UserExpenseTableAdapter();
            this.tableAdapterManager = new TW_Tally.userDBDataSetTableAdapters.TableAdapterManager();
            this.costTypeTableAdapter = new TW_Tally.userDBDataSetTableAdapters.CostTypeTableAdapter();
            this.merchantListTableAdapter = new TW_Tally.userDBDataSetTableAdapters.MerchantListTableAdapter();
            this.pictureBoxType = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.userDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costTypeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.merchantListBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.merchantListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userExpenseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxType)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.BackColor = System.Drawing.Color.Transparent;
            this.labelCost.Font = new System.Drawing.Font("方正少儿_GBK", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCost.ForeColor = System.Drawing.Color.White;
            this.labelCost.Location = new System.Drawing.Point(95, 60);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(58, 24);
            this.labelCost.TabIndex = 0;
            this.labelCost.Text = "金额:";
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(278, 60);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(121, 21);
            this.textBoxCost.TabIndex = 0;
            this.textBoxCost.Text = "0";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.BackColor = System.Drawing.Color.Transparent;
            this.labelType.Font = new System.Drawing.Font("方正少儿_GBK", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelType.ForeColor = System.Drawing.Color.White;
            this.labelType.Location = new System.Drawing.Point(95, 140);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(76, 24);
            this.labelType.TabIndex = 2;
            this.labelType.Text = "种类：";
            // 
            // comboBoxBig
            // 
            this.comboBoxBig.DataSource = this.userDBDataSet;
            this.comboBoxBig.DisplayMember = "CostClass.CostClass";
            this.comboBoxBig.FormattingEnabled = true;
            this.comboBoxBig.Location = new System.Drawing.Point(278, 137);
            this.comboBoxBig.Name = "comboBoxBig";
            this.comboBoxBig.Size = new System.Drawing.Size(121, 20);
            this.comboBoxBig.TabIndex = 1;
            this.comboBoxBig.ValueMember = "CostClass.CostClass";
            this.comboBoxBig.TextChanged += new System.EventHandler(this.comboBoxBig_TextChanged);
            // 
            // userDBDataSet
            // 
            this.userDBDataSet.DataSetName = "userDBDataSet";
            this.userDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxSmall
            // 
            this.comboBoxSmall.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.userDBDataSet, "CostType.Class", true));
            this.comboBoxSmall.DataSource = this.costTypeBindingSource1;
            this.comboBoxSmall.DisplayMember = "Event";
            this.comboBoxSmall.FormattingEnabled = true;
            this.comboBoxSmall.Location = new System.Drawing.Point(278, 184);
            this.comboBoxSmall.Name = "comboBoxSmall";
            this.comboBoxSmall.Size = new System.Drawing.Size(121, 20);
            this.comboBoxSmall.TabIndex = 2;
            this.comboBoxSmall.ValueMember = "Event";
            this.comboBoxSmall.SelectedValueChanged += new System.EventHandler(this.comboBoxSmall_SelectedValueChanged);
            this.comboBoxSmall.TextChanged += new System.EventHandler(this.comboBoxSmall_TextChanged);
            // 
            // costTypeBindingSource1
            // 
            this.costTypeBindingSource1.DataMember = "CostType";
            this.costTypeBindingSource1.DataSource = this.userDBDataSet;
            // 
            // labelShop
            // 
            this.labelShop.AutoSize = true;
            this.labelShop.BackColor = System.Drawing.Color.Transparent;
            this.labelShop.Font = new System.Drawing.Font("方正少儿_GBK", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelShop.ForeColor = System.Drawing.Color.White;
            this.labelShop.Location = new System.Drawing.Point(95, 220);
            this.labelShop.Name = "labelShop";
            this.labelShop.Size = new System.Drawing.Size(76, 24);
            this.labelShop.TabIndex = 5;
            this.labelShop.Text = "商家：";
            // 
            // comboBoxShop
            // 
            this.comboBoxShop.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxShop.DataSource = this.merchantListBindingSource2;
            this.comboBoxShop.DisplayMember = "MerchantName";
            this.comboBoxShop.FormattingEnabled = true;
            this.comboBoxShop.Location = new System.Drawing.Point(277, 220);
            this.comboBoxShop.Name = "comboBoxShop";
            this.comboBoxShop.Size = new System.Drawing.Size(168, 20);
            this.comboBoxShop.TabIndex = 3;
            this.comboBoxShop.ValueMember = "MerchantName";
            this.comboBoxShop.SelectedIndexChanged += new System.EventHandler(this.comboBoxShop_SelectedIndexChanged);
            // 
            // merchantListBindingSource2
            // 
            this.merchantListBindingSource2.DataMember = "MerchantList";
            this.merchantListBindingSource2.DataSource = this.userDBDataSet;
            // 
            // merchantListBindingSource
            // 
            this.merchantListBindingSource.DataMember = "MerchantList";
            // 
            // labelDataTime
            // 
            this.labelDataTime.AutoSize = true;
            this.labelDataTime.BackColor = System.Drawing.Color.Transparent;
            this.labelDataTime.Font = new System.Drawing.Font("方正少儿_GBK", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelDataTime.ForeColor = System.Drawing.Color.Transparent;
            this.labelDataTime.Location = new System.Drawing.Point(95, 300);
            this.labelDataTime.Name = "labelDataTime";
            this.labelDataTime.Size = new System.Drawing.Size(76, 24);
            this.labelDataTime.TabIndex = 7;
            this.labelDataTime.Text = "时间：";
            // 
            // dateTimePickerCost
            // 
            this.dateTimePickerCost.CustomFormat = "yyyy/MM/dd HH:MM";
            this.dateTimePickerCost.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerCost.Location = new System.Drawing.Point(278, 303);
            this.dateTimePickerCost.Name = "dateTimePickerCost";
            this.dateTimePickerCost.Size = new System.Drawing.Size(168, 21);
            this.dateTimePickerCost.TabIndex = 4;
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.BackColor = System.Drawing.Color.Transparent;
            this.labelComment.Font = new System.Drawing.Font("方正少儿_GBK", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelComment.ForeColor = System.Drawing.Color.White;
            this.labelComment.Location = new System.Drawing.Point(95, 380);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(76, 24);
            this.labelComment.TabIndex = 9;
            this.labelComment.Text = "备注：";
            // 
            // textBoxComments
            // 
            this.textBoxComments.Location = new System.Drawing.Point(277, 377);
            this.textBoxComments.Multiline = true;
            this.textBoxComments.Name = "textBoxComments";
            this.textBoxComments.Size = new System.Drawing.Size(168, 76);
            this.textBoxComments.TabIndex = 5;
            // 
            // buttonOK
            // 
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOK.Image = global::TW_Tally.Properties.Resources.QQ截图20130530082853;
            this.buttonOK.Location = new System.Drawing.Point(97, 500);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "保存";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonSaveAgain
            // 
            this.buttonSaveAgain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSaveAgain.Image = global::TW_Tally.Properties.Resources.QQ截图20130530082853;
            this.buttonSaveAgain.Location = new System.Drawing.Point(370, 500);
            this.buttonSaveAgain.Name = "buttonSaveAgain";
            this.buttonSaveAgain.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveAgain.TabIndex = 7;
            this.buttonSaveAgain.Text = "保存再记";
            this.buttonSaveAgain.UseVisualStyleBackColor = true;
            this.buttonSaveAgain.Click += new System.EventHandler(this.buttonSaveAgain_Click);
            // 
            // costClassTableAdapter
            // 
            this.costClassTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.CostClassTableAdapter = this.costClassTableAdapter;
            this.tableAdapterManager.CostTypeTableAdapter = null;
            this.tableAdapterManager.IncomeClassTableAdapter = null;
            this.tableAdapterManager.MerchantListTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TW_Tally.userDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserExpenseTableAdapter = this.userExpenseTableAdapter;
            this.tableAdapterManager.UserIncomeTableAdapter = null;
            // 
            // costTypeTableAdapter
            // 
            this.costTypeTableAdapter.ClearBeforeFill = true;
            // 
            // merchantListTableAdapter
            // 
            this.merchantListTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBoxType
            // 
            this.pictureBoxType.Location = new System.Drawing.Point(403, 60);
            this.pictureBoxType.Name = "pictureBoxType";
            this.pictureBoxType.Size = new System.Drawing.Size(173, 144);
            this.pictureBoxType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxType.TabIndex = 13;
            this.pictureBoxType.TabStop = false;
            // 
            // FormCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TW_Tally.Properties.Resources.Right;
            this.ClientSize = new System.Drawing.Size(575, 600);
            this.Controls.Add(this.pictureBoxType);
            this.Controls.Add(this.buttonSaveAgain);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCost";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "支出";
            this.Activated += new System.EventHandler(this.FormCost_Activated);
            this.Load += new System.EventHandler(this.FormCost_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costTypeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.merchantListBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.merchantListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userExpenseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

     
     
      
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
        private System.Windows.Forms.Button buttonSaveAgain;
       
        private System.Windows.Forms.BindingSource merchantListBindingSource;
        private System.Windows.Forms.BindingSource costClassBindingSource;
    
        private System.Windows.Forms.BindingSource costTypeBindingSource;
      
        private System.Windows.Forms.BindingSource merchantListBindingSource1;
        private userDBDataSet userDBDataSet;
        private userDBDataSetTableAdapters.CostClassTableAdapter costClassTableAdapter;
        private System.Windows.Forms.BindingSource userExpenseBindingSource;
        private userDBDataSetTableAdapters.UserExpenseTableAdapter userExpenseTableAdapter;
        private userDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private userDBDataSetTableAdapters.CostTypeTableAdapter costTypeTableAdapter;
        private System.Windows.Forms.BindingSource merchantListBindingSource2;
        private userDBDataSetTableAdapters.MerchantListTableAdapter merchantListTableAdapter;
        private System.Windows.Forms.PictureBox pictureBoxType;
        private System.Windows.Forms.BindingSource costTypeBindingSource1;
       
       
       
    }
}