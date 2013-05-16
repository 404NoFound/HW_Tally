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
    public partial class FormMessageAutoClose : Form
    {
        public FormMessageAutoClose()
        {
            InitializeComponent();
            timer_CloseForm.Interval=500; //1.5s 
        }

       public void setLabel(string LabelText)
        {
            this.label_Success.Text = LabelText;
        }

        private void Form_LoginSuccess_Load(object sender, EventArgs e)
        {
            timer_CloseForm.Start();

        }

        private void timer_CloseForm_Tick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            timer_CloseForm.Stop();

        }

        private void label_Success_Click(object sender, EventArgs e)
        {

        }

        private void FormMessageAutoClose_Load(object sender, EventArgs e)
        {
            timer_CloseForm.Start();
        }
    }
}
