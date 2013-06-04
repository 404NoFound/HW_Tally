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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonIncomeDeta = new System.Windows.Forms.Button();
            this.buttonExpenseDetail = new System.Windows.Forms.Button();
            this.buttonIncome = new System.Windows.Forms.Button();
            this.buttonExpense = new System.Windows.Forms.Button();
            this.panelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.Transparent;
            this.panelRight.BackgroundImage = global::TW_Tally.Properties.Resources.Right;
            this.panelRight.Location = new System.Drawing.Point(260, 1);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(575, 600);
            this.panelRight.TabIndex = 4;
            // 
            // panelLeft
            // 
            this.panelLeft.BackgroundImage = global::TW_Tally.Properties.Resources.Left;
            this.panelLeft.Controls.Add(this.buttonBack);
            this.panelLeft.Controls.Add(this.buttonIncomeDeta);
            this.panelLeft.Controls.Add(this.buttonExpenseDetail);
            this.panelLeft.Controls.Add(this.buttonIncome);
            this.panelLeft.Controls.Add(this.buttonExpense);
            this.panelLeft.Location = new System.Drawing.Point(2, 2);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(260, 600);
            this.panelLeft.TabIndex = 3;
            this.panelLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLeft_Paint);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Transparent;
            this.buttonBack.BackgroundImage = global::TW_Tally.Properties.Resources.back1;
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBack.ForeColor = System.Drawing.Color.Transparent;
            this.buttonBack.Location = new System.Drawing.Point(3, 552);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(62, 45);
            this.buttonBack.TabIndex = 4;
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonIncomeDeta
            // 
            this.buttonIncomeDeta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonIncomeDeta.Font = new System.Drawing.Font("汉鼎简中楷", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonIncomeDeta.Image = global::TW_Tally.Properties.Resources.QQ截图20130530082853;
            this.buttonIncomeDeta.Location = new System.Drawing.Point(100, 400);
            this.buttonIncomeDeta.Name = "buttonIncomeDeta";
            this.buttonIncomeDeta.Size = new System.Drawing.Size(150, 33);
            this.buttonIncomeDeta.TabIndex = 3;
            this.buttonIncomeDeta.Text = "收入详情";
            this.buttonIncomeDeta.UseVisualStyleBackColor = true;
            this.buttonIncomeDeta.Click += new System.EventHandler(this.buttonIncomeDeta_Click);
            // 
            // buttonExpenseDetail
            // 
            this.buttonExpenseDetail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExpenseDetail.Font = new System.Drawing.Font("汉鼎简中楷", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonExpenseDetail.Image = global::TW_Tally.Properties.Resources.QQ截图20130530082853;
            this.buttonExpenseDetail.Location = new System.Drawing.Point(0, 300);
            this.buttonExpenseDetail.Name = "buttonExpenseDetail";
            this.buttonExpenseDetail.Size = new System.Drawing.Size(150, 33);
            this.buttonExpenseDetail.TabIndex = 2;
            this.buttonExpenseDetail.Text = "支出详情";
            this.buttonExpenseDetail.UseVisualStyleBackColor = true;
            this.buttonExpenseDetail.Click += new System.EventHandler(this.buttonExpenseDetail_Click);
            // 
            // buttonIncome
            // 
            this.buttonIncome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonIncome.Font = new System.Drawing.Font("汉鼎简中楷", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonIncome.Image = global::TW_Tally.Properties.Resources.QQ截图20130530082853;
            this.buttonIncome.Location = new System.Drawing.Point(100, 200);
            this.buttonIncome.Name = "buttonIncome";
            this.buttonIncome.Size = new System.Drawing.Size(150, 33);
            this.buttonIncome.TabIndex = 1;
            this.buttonIncome.Text = "收入记录";
            this.buttonIncome.UseVisualStyleBackColor = true;
            this.buttonIncome.Click += new System.EventHandler(this.buttonIncome_Click);
            // 
            // buttonExpense
            // 
            this.buttonExpense.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExpense.Font = new System.Drawing.Font("汉鼎简中楷", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonExpense.Image = global::TW_Tally.Properties.Resources.QQ截图20130530082853;
            this.buttonExpense.Location = new System.Drawing.Point(0, 100);
            this.buttonExpense.Name = "buttonExpense";
            this.buttonExpense.Size = new System.Drawing.Size(150, 33);
            this.buttonExpense.TabIndex = 0;
            this.buttonExpense.Text = "支出记录";
            this.buttonExpense.UseVisualStyleBackColor = true;
            this.buttonExpense.Click += new System.EventHandler(this.buttonExpense_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::TW_Tally.Properties.Resources.界面1;
            this.ClientSize = new System.Drawing.Size(834, 601);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "大学生记账软件";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Button buttonExpense;
        private System.Windows.Forms.Button buttonIncome;
        private System.Windows.Forms.Button buttonExpenseDetail;
        private System.Windows.Forms.Button buttonIncomeDeta;
        private System.Windows.Forms.Button buttonBack;



    }
}

