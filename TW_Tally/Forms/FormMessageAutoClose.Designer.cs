namespace TW_Tally.Forms
{
    partial class FormMessageAutoClose
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
            this.label_Success = new System.Windows.Forms.Label();
            this.timer_CloseForm = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label_Success
            // 
            this.label_Success.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Success.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label_Success.Location = new System.Drawing.Point(0, 0);
            this.label_Success.Name = "label_Success";
            this.label_Success.Size = new System.Drawing.Size(234, 84);
            this.label_Success.TabIndex = 0;
            this.label_Success.Text = "默认字符";
            this.label_Success.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Success.Click += new System.EventHandler(this.label_Success_Click);
            // 
            // timer_CloseForm
            // 
            this.timer_CloseForm.Interval = 1000;
            this.timer_CloseForm.Tick += new System.EventHandler(this.timer_CloseForm_Tick);
            // 
            // FormMessageAutoClose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 84);
            this.ControlBox = false;
            this.Controls.Add(this.label_Success);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMessageAutoClose";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormMessageAutoClose_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_Success;
        private System.Windows.Forms.Timer timer_CloseForm;
    }
}