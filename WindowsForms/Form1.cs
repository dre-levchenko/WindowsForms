using System;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            clock.Start();
        }

        private void Hooker(object sender, MouseEventArgs e)
        {
            mainLabel.Text = @"X:" + e.Location.X + @" Y:" + e.Location.Y;
        }

        private void OnTick(object sender, EventArgs e)
        {
            //clock.Stop();
            //MessageBox.Show(DateTime.Now.ToString());
            this.Text = DateTime.Now.Hour + @":" + DateTime.Now.Minute + @":" + DateTime.Now.Second;
        }
    }
}
