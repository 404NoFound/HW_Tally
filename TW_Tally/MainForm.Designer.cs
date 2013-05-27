namespace TW_Tally
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonExpense = new System.Windows.Forms.Button();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.buttonIncomeDetail = new System.Windows.Forms.Button();
            this.buttonExpenseDetail = new System.Windows.Forms.Button();
            this.buttonIncome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonExpense
            // 
            this.buttonExpense.Location = new System.Drawing.Point(13, 25);
            this.buttonExpense.Name = "buttonExpense";
            this.buttonExpense.Size = new System.Drawing.Size(75, 23);
            this.buttonExpense.TabIndex = 0;
            this.buttonExpense.Text = "支出";
            this.buttonExpense.UseVisualStyleBackColor = true;
            this.buttonExpense.Click += new System.EventHandler(this.buttonAddRecord_Click);
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.buttonIncomeDetail);
            this.splitContainerMain.Panel1.Controls.Add(this.buttonExpenseDetail);
            this.splitContainerMain.Panel1.Controls.Add(this.buttonIncome);
            this.splitContainerMain.Panel1.Controls.Add(this.buttonExpense);
            this.splitContainerMain.Size = new System.Drawing.Size(800, 504);
            this.splitContainerMain.SplitterDistance = 188;
            this.splitContainerMain.SplitterWidth = 10;
            this.splitContainerMain.TabIndex = 1;
            // 
            // buttonIncomeDetail
            // 
            this.buttonIncomeDetail.Location = new System.Drawing.Point(15, 202);
            this.buttonIncomeDetail.Name = "buttonIncomeDetail";
            this.buttonIncomeDetail.Size = new System.Drawing.Size(75, 23);
            this.buttonIncomeDetail.TabIndex = 3;
            this.buttonIncomeDetail.Text = "收入明细";
            this.buttonIncomeDetail.UseVisualStyleBackColor = true;
            this.buttonIncomeDetail.Click += new System.EventHandler(this.buttonIncomeDetail_Click);
            // 
            // buttonExpenseDetail
            // 
            this.buttonExpenseDetail.Location = new System.Drawing.Point(14, 160);
            this.buttonExpenseDetail.Name = "buttonExpenseDetail";
            this.buttonExpenseDetail.Size = new System.Drawing.Size(75, 23);
            this.buttonExpenseDetail.TabIndex = 2;
            this.buttonExpenseDetail.Text = "支出明细";
            this.buttonExpenseDetail.UseVisualStyleBackColor = true;
            this.buttonExpenseDetail.Click += new System.EventHandler(this.buttonExpenseDetail_Click);
            // 
            // buttonIncome
            // 
            this.buttonIncome.Location = new System.Drawing.Point(105, 24);
            this.buttonIncome.Name = "buttonIncome";
            this.buttonIncome.Size = new System.Drawing.Size(75, 23);
            this.buttonIncome.TabIndex = 1;
            this.buttonIncome.Text = "收入";
            this.buttonIncome.UseVisualStyleBackColor = true;
            this.buttonIncome.Click += new System.EventHandler(this.buttonIncome_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.splitContainerMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Money";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExpense;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.Button buttonIncome;
        private System.Windows.Forms.Button buttonExpenseDetail;
        private System.Windows.Forms.Button buttonIncomeDetail;

    }
}

