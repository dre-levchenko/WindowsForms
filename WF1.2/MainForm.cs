using System.Windows.Forms;

namespace WF1._2
{
    public partial class mainForm : Form
    {
        int[] counters = new int[3];
        public mainForm()
        {
            InitializeComponent();
        }
        
        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case System.Windows.Forms.MouseButtons.Left:
                    ++counters[0];
                    break;
                case System.Windows.Forms.MouseButtons.Middle:
                    ++counters[1];
                    break;
                case System.Windows.Forms.MouseButtons.Right:
                    ++counters[2];
                    break;
            }

            mainForm.ActiveForm.Text = "LB: " + counters[0] + " | MB: " + counters[1] + " | RB: " + counters[2];
        }
    }
}
