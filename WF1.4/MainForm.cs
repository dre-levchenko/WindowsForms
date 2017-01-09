using System;
using System.Drawing;
using System.Windows.Forms;

namespace WF1._4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OnKeyPress(object sender, KeyPressEventArgs e)
        {
            switch(e.KeyChar)
            {
                case (char)Keys.Enter:
                    MainForm.ActiveForm.Size = new Size(300, 300);
                    MainForm.ActiveForm.Location = new Point(0, 0);
                    timer.Start();
                    break;
                case (char)Keys.Escape:
                    timer.Stop();
                    break;
            }
        }

        private void OnTick(object sender, EventArgs e)
        {
            var stepSize = 10;

            var x = MainForm.ActiveForm.Location.X;
            var y = MainForm.ActiveForm.Location.Y;

            if (x + ActiveForm.Width <= Screen.PrimaryScreen.Bounds.Width && y == 0)
            {
                MainForm.ActiveForm.Left += stepSize;
            }
            else if (y + ActiveForm.Height <= Screen.PrimaryScreen.Bounds.Height)
            {
                MainForm.ActiveForm.Top += stepSize;
            }
            else if (x > 0 && y > 0)
            {
                MainForm.ActiveForm.Left -= stepSize;
            }
            else if (y > 0 && x == 0)
            {
                MainForm.ActiveForm.Top -= stepSize;
            }

            MainForm.ActiveForm.Text = x + " " + y;
        }
    }
}
