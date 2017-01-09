using System.Windows.Forms;

namespace WF3._1_Millionaire
{
    public partial class Millionaire : Form
    {
        public Millionaire()
        {
            InitializeComponent();
        }

        private void OnStartClick(object sender, System.EventArgs e)
        {
            this.Visible = false;
            var gameForm = new Game();
            gameForm.FormClosing += OnExitClick;
            gameForm.ShowDialog();
        }

        private void OnExitClick(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
