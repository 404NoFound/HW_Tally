namespace TW_Tally.Forms
{
    partial class FormIncome
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
            System.Windows.Forms.Label moneyLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIncome));
            System.Windows.Forms.Label datetimeLabel;
            System.Windows.Forms.Label commentsLabel;
            System.Windows.Forms.Label typeLabel;
            this.userDBDataSet = new TW_Tally.userDBDataSet();
            this.userIncomeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userIncomeTableAdapter = new TW_Tally.userDBDataSetTableAdapters.UserIncomeTableAdapter();
            this.tableAdapterManager = new TW_Tally.userDBDataSetTableAdapters.TableAdapterManager();
            this.moneyTextBox = new System.Windows.Forms.TextBox();
            this.datetimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.commentsTextBox = new System.Windows.Forms.TextBox();
            this.labelSource = new System.Windows.Forms.Label();
            this.comboBoxSource = new System.Windows.Forms.ComboBox();
            this.incomeClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonSave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.incomeClassBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.userDBDataSet1 = new TW_Tally.userDBDataSet();
            this.userIncomeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.incomeClassTableAdapter1 = new TW_Tally.userDBDataSetTableAdapters.IncomeClassTableAdapter();
            moneyLabel = new System.Windows.Forms.Label();
            datetimeLabel = new System.Windows.Forms.Label();
            commentsLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIncomeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeClassBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeClassBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIncomeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // moneyLabel
            // 
            resources.ApplyResources(moneyLabel, "moneyLabel");
            moneyLabel.Name = "moneyLabel";
            // 
            // datetimeLabel
            // 
            resources.ApplyResources(datetimeLabel, "datetimeLabel");
            datetimeLabel.Name = "datetimeLabel";
            // 
            // commentsLabel
            // 
            resources.ApplyResources(commentsLabel, "commentsLabel");
            commentsLabel.Name = "commentsLabel";
            // 
            // typeLabel
            // 
            resources.ApplyResources(typeLabel, "typeLabel");
            typeLabel.Name = "typeLabel";
            // 
            // userDBDataSet
            // 
            this.userDBDataSet.DataSetName = "userDBDataSet";
            this.userDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userIncomeBindingSource
            // 
            this.userIncomeBindingSource.DataMember = "UserIncome";
            this.userIncomeBindingSource.DataSource = this.userDBDataSet;
            // 
            // userIncomeTableAdapter
            // 
            this.userIncomeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CostClassTableAdapter = null;
            this.tableAdapterManager.CostTypeTableAdapter = null;
            this.tableAdapterManager.IncomeClassTableAdapter = null;
            this.tableAdapterManager.MerchantListTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TW_Tally.userDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserExpenseTableAdapter = null;
            this.tableAdapterManager.UserIncomeTableAdapter = this.userIncomeTableAdapter;
            // 
            // moneyTextBox
            // 
            this.moneyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userIncomeBindingSource, "Money", true));
            resources.ApplyResources(this.moneyTextBox, "moneyTextBox");
            this.moneyTextBox.Name = "moneyTextBox";
            this.moneyTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.moneyTextBox_KeyPress);
            // 
            // datetimeDateTimePicker
            // 
            resources.ApplyResources(this.datetimeDateTimePicker, "datetimeDateTimePicker");
            this.datetimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimeDateTimePicker.Name = "datetimeDateTimePicker";
            // 
            // commentsTextBox
            // 
            this.commentsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userIncomeBindingSource, "Comments", true));
            resources.ApplyResources(this.commentsTextBox, "commentsTextBox");
            this.commentsTextBox.Name = "commentsTextBox";
            // 
            // labelSource
            // 
            resources.ApplyResources(this.labelSource, "labelSource");
            this.labelSource.Name = "labelSource";
            // 
            // comboBoxSource
            // 
            this.comboBoxSource.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxSource, "comboBoxSource");
            this.comboBoxSource.Name = "comboBoxSource";
            // 
            // incomeClassBindingSource
            // 
            this.incomeClassBindingSource.DataMember = "IncomeClass";
            this.incomeClassBindingSource.DataSource = this.userDBDataSet;
            // 
            // buttonSave
            // 
            resources.ApplyResources(this.buttonSave, "buttonSave");
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBoxType
            // 
            this.comboBoxType.DataSource = this.incomeClassBindingSource1;
            this.comboBoxType.DisplayMember = "Source";
            this.comboBoxType.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxType, "comboBoxType");
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.ValueMember = "ID";
            // 
            // incomeClassBindingSource1
            // 
            this.incomeClassBindingSource1.DataMember = "IncomeClass";
            this.incomeClassBindingSource1.DataSource = this.userDBDataSet1;
            // 
            // userDBDataSet1
            // 
            this.userDBDataSet1.DataSetName = "userDBDataSet";
            this.userDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // incomeClassTableAdapter1
            // 
            this.incomeClassTableAdapter1.ClearBeforeFill = true;
            // 
            // FormIncome
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(typeLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.comboBoxSource);
            this.Controls.Add(this.labelSource);
            this.Controls.Add(commentsLabel);
            this.Controls.Add(this.commentsTextBox);
            this.Controls.Add(datetimeLabel);
            this.Controls.Add(this.datetimeDateTimePicker);
            this.Controls.Add(moneyLabel);
            this.Controls.Add(this.moneyTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormIncome";
            this.Load += new System.EventHandler(this.FormIncome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIncomeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeClassBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeClassBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIncomeBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private userDBDataSet userDBDataSet;
        private System.Windows.Forms.BindingSource userIncomeBindingSource;
        private userDBDataSetTableAdapters.UserIncomeTableAdapter userIncomeTableAdapter;
        private userDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox moneyTextBox;
        private System.Windows.Forms.DateTimePicker datetimeDateTimePicker;
        private System.Windows.Forms.TextBox commentsTextBox;
        private userDBDataSetTableAdapters.IncomeClassTableAdapter IncomeClassTableAdapter;
        private System.Windows.Forms.Label labelSource;
        private System.Windows.Forms.ComboBox comboBoxSource;
        private System.Windows.Forms.BindingSource incomeClassBindingSource;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.BindingSource userIncomeBindingSource1;
        private userDBDataSet userDBDataSet1;
        private System.Windows.Forms.BindingSource incomeClassBindingSource1;
        private userDBDataSetTableAdapters.IncomeClassTableAdapter incomeClassTableAdapter1;
    }
}