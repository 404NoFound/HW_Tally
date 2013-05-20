namespace TW_Tally.Forms
{
    partial class FormRegister
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
            System.Windows.Forms.Label Label_Password;
            this.label_PasswordCheck = new System.Windows.Forms.Label();
            this.textBox_PasswordCheck = new System.Windows.Forms.TextBox();
            this.button_Reg = new System.Windows.Forms.Button();
            this.panel_Reg = new System.Windows.Forms.Panel();
            this.textBoxOldPassword = new System.Windows.Forms.TextBox();
            this.labelOldPassword = new System.Windows.Forms.Label();
            this.TextBoxNewPassword = new System.Windows.Forms.TextBox();
            Label_Password = new System.Windows.Forms.Label();
            this.panel_Reg.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label_Password
            // 
            Label_Password.AutoSize = true;
            Label_Password.Location = new System.Drawing.Point(42, 65);
            Label_Password.Name = "Label_Password";
            Label_Password.Size = new System.Drawing.Size(47, 12);
            Label_Password.TabIndex = 7;
            Label_Password.Text = "新密码:";
            // 
            // label_PasswordCheck
            // 
            this.label_PasswordCheck.AutoSize = true;
            this.label_PasswordCheck.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_PasswordCheck.Location = new System.Drawing.Point(41, 113);
            this.label_PasswordCheck.Name = "label_PasswordCheck";
            this.label_PasswordCheck.Size = new System.Drawing.Size(79, 13);
            this.label_PasswordCheck.TabIndex = 3;
            this.label_PasswordCheck.Text = "再输入一次:";
            this.label_PasswordCheck.Click += new System.EventHandler(this.label_PasswordCheck_Click);
            // 
            // textBox_PasswordCheck
            // 
            this.textBox_PasswordCheck.Location = new System.Drawing.Point(124, 105);
            this.textBox_PasswordCheck.Name = "textBox_PasswordCheck";
            this.textBox_PasswordCheck.PasswordChar = '*';
            this.textBox_PasswordCheck.Size = new System.Drawing.Size(100, 21);
            this.textBox_PasswordCheck.TabIndex = 2;
            this.textBox_PasswordCheck.UseSystemPasswordChar = true;
            this.textBox_PasswordCheck.TextChanged += new System.EventHandler(this.textBox_PasswordCheck_TextChanged);
            this.textBox_PasswordCheck.Leave += new System.EventHandler(this.textBox_PasswordCheck_Leave);
            // 
            // button_Reg
            // 
            this.button_Reg.Location = new System.Drawing.Point(105, 218);
            this.button_Reg.Name = "button_Reg";
            this.button_Reg.Size = new System.Drawing.Size(75, 23);
            this.button_Reg.TabIndex = 3;
            this.button_Reg.Text = "确认";
            this.button_Reg.UseVisualStyleBackColor = true;
            this.button_Reg.Click += new System.EventHandler(this.button_Reg_Click);
            // 
            // panel_Reg
            // 
            this.panel_Reg.Controls.Add(this.textBoxOldPassword);
            this.panel_Reg.Controls.Add(this.labelOldPassword);
            this.panel_Reg.Controls.Add(Label_Password);
            this.panel_Reg.Controls.Add(this.TextBoxNewPassword);
            this.panel_Reg.Controls.Add(this.label_PasswordCheck);
            this.panel_Reg.Controls.Add(this.textBox_PasswordCheck);
            this.panel_Reg.Location = new System.Drawing.Point(17, 12);
            this.panel_Reg.Name = "panel_Reg";
            this.panel_Reg.Size = new System.Drawing.Size(292, 200);
            this.panel_Reg.TabIndex = 8;
            this.panel_Reg.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Reg_Paint);
            // 
            // textBoxOldPassword
            // 
            this.textBoxOldPassword.Location = new System.Drawing.Point(124, 24);
            this.textBoxOldPassword.Name = "textBoxOldPassword";
            this.textBoxOldPassword.PasswordChar = '*';
            this.textBoxOldPassword.Size = new System.Drawing.Size(100, 21);
            this.textBoxOldPassword.TabIndex = 0;
            this.textBoxOldPassword.UseSystemPasswordChar = true;
            this.textBoxOldPassword.TextChanged += new System.EventHandler(this.textBoxOldPassword_TextChanged);
            // 
            // labelOldPassword
            // 
            this.labelOldPassword.AutoSize = true;
            this.labelOldPassword.Location = new System.Drawing.Point(42, 34);
            this.labelOldPassword.Name = "labelOldPassword";
            this.labelOldPassword.Size = new System.Drawing.Size(47, 12);
            this.labelOldPassword.TabIndex = 8;
            this.labelOldPassword.Text = "原密码:";
            // 
            // TextBoxNewPassword
            // 
            this.TextBoxNewPassword.Location = new System.Drawing.Point(124, 62);
            this.TextBoxNewPassword.Name = "TextBoxNewPassword";
            this.TextBoxNewPassword.PasswordChar = '*';
            this.TextBoxNewPassword.Size = new System.Drawing.Size(100, 21);
            this.TextBoxNewPassword.TabIndex = 1;
            this.TextBoxNewPassword.UseSystemPasswordChar = true;
            this.TextBoxNewPassword.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            this.TextBoxNewPassword.Leave += new System.EventHandler(this.TextBox_Password_Leave);
            // 
            // FormRegister
            // 
            this.AcceptButton = this.button_Reg;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 261);
            this.Controls.Add(this.panel_Reg);
            this.Controls.Add(this.button_Reg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "密码设置";
            this.Activated += new System.EventHandler(this.FormRegister_Activated);
            this.Load += new System.EventHandler(this.Form_Register_Load);
            this.panel_Reg.ResumeLayout(false);
            this.panel_Reg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_PasswordCheck;
        private System.Windows.Forms.TextBox textBox_PasswordCheck;
        private System.Windows.Forms.Button button_Reg;
        private System.Windows.Forms.Panel panel_Reg;

       
        private System.Windows.Forms.TextBox TextBoxNewPassword;
        private System.Windows.Forms.Label labelOldPassword;
        private System.Windows.Forms.TextBox textBoxOldPassword;
    }
}