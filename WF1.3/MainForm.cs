using System;
using System.Windows.Forms;

namespace WF1._3
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            if (timer.Enabled == false)
            {
                timer.Start();
                e.Cancel = true;
            }
        }

        private void OnTick(object sender, EventArgs e)
        {
            if (mainForm.ActiveForm.Opacity != 0)
            {
                mainForm.ActiveForm.Opacity -= 0.01;
            }
            else
            {
                mainForm.ActiveForm.Close();
            }
        }
    }
}
