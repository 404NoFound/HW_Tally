namespace TW_Tally.Forms
{
    partial class FormExpenseDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExpenseDetail));
            this.userDBDataSet = new TW_Tally.userDBDataSet();
            this.userExpenseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userExpenseTableAdapter = new TW_Tally.userDBDataSetTableAdapters.UserExpenseTableAdapter();
            this.tableAdapterManager = new TW_Tally.userDBDataSetTableAdapters.TableAdapterManager();
            this.userExpenseBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.userExpenseBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.userExpenseDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.userDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userExpenseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userExpenseBindingNavigator)).BeginInit();
            this.userExpenseBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userExpenseDataGridView)).BeginInit();
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
            this.tableAdapterManager.CostClassTableAdapter = null;
            this.tableAdapterManager.CostTypeTableAdapter = null;
            this.tableAdapterManager.IncomeClassTableAdapter = null;
            this.tableAdapterManager.MerchantListTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TW_Tally.userDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserExpenseTableAdapter = this.userExpenseTableAdapter;
            this.tableAdapterManager.UserIncomeTableAdapter = null;
            // 
            // userExpenseBindingNavigator
            // 
            this.userExpenseBindingNavigator.AddNewItem = null;
            this.userExpenseBindingNavigator.BindingSource = this.userExpenseBindingSource;
            this.userExpenseBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.userExpenseBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.userExpenseBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorDeleteItem,
            this.userExpenseBindingNavigatorSaveItem});
            this.userExpenseBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.userExpenseBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.userExpenseBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.userExpenseBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.userExpenseBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.userExpenseBindingNavigator.Name = "userExpenseBindingNavigator";
            this.userExpenseBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.userExpenseBindingNavigator.Size = new System.Drawing.Size(575, 25);
            this.userExpenseBindingNavigator.TabIndex = 1;
            this.userExpenseBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(31, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "删除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // userExpenseBindingNavigatorSaveItem
            // 
            this.userExpenseBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.userExpenseBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("userExpenseBindingNavigatorSaveItem.Image")));
            this.userExpenseBindingNavigatorSaveItem.Name = "userExpenseBindingNavigatorSaveItem";
            this.userExpenseBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.userExpenseBindingNavigatorSaveItem.Text = "保存数据";
            this.userExpenseBindingNavigatorSaveItem.Click += new System.EventHandler(this.userExpenseBindingNavigatorSaveItem_Click);
            // 
            // userExpenseDataGridView
            // 
            this.userExpenseDataGridView.AllowUserToAddRows = false;
            this.userExpenseDataGridView.AutoGenerateColumns = false;
            this.userExpenseDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userExpenseDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.userExpenseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userExpenseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.userExpenseDataGridView.DataSource = this.userExpenseBindingSource;
            this.userExpenseDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userExpenseDataGridView.Location = new System.Drawing.Point(0, 25);
            this.userExpenseDataGridView.Name = "userExpenseDataGridView";
            this.userExpenseDataGridView.RowTemplate.Height = 23;
            this.userExpenseDataGridView.Size = new System.Drawing.Size(575, 575);
            this.userExpenseDataGridView.TabIndex = 2;
            this.userExpenseDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userExpenseDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Cost";
            this.dataGridViewTextBoxColumn2.HeaderText = "金额";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Class";
            this.dataGridViewTextBoxColumn3.HeaderText = "种类";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Event";
            this.dataGridViewTextBoxColumn4.HeaderText = "小项";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Merchant";
            this.dataGridViewTextBoxColumn5.HeaderText = "商家";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CostData";
            this.dataGridViewTextBoxColumn6.FillWeight = 150F;
            this.dataGridViewTextBoxColumn6.HeaderText = "日期";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Comments";
            this.dataGridViewTextBoxColumn7.HeaderText = "备注";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // FormExpenseDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TW_Tally.Properties.Resources.Right;
            this.ClientSize = new System.Drawing.Size(575, 600);
            this.Controls.Add(this.userExpenseDataGridView);
            this.Controls.Add(this.userExpenseBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormExpenseDetail";
            this.Text = "FormExpenseDetail";
            this.Load += new System.EventHandler(this.FormExpenseDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userExpenseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userExpenseBindingNavigator)).EndInit();
            this.userExpenseBindingNavigator.ResumeLayout(false);
            this.userExpenseBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userExpenseDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private userDBDataSet userDBDataSet;
        private System.Windows.Forms.BindingSource userExpenseBindingSource;
        private userDBDataSetTableAdapters.UserExpenseTableAdapter userExpenseTableAdapter;
        private userDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator userExpenseBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView userExpenseDataGridView;
        private System.Windows.Forms.ToolStripButton userExpenseBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}