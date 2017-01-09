using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF3._1_Millionaire.Forms
{
    public partial class DialogGameOver : Form
    {
        public int PrizeSum { get; set; }

        public DialogGameOver()
        {
            InitializeComponent();
        }

        private void OnDialogGameOverLoad(object sender, EventArgs e)
        {
            this.labelSum.Text = PrizeSum.ToString();
        }
    }
}
