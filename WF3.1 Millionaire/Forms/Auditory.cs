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
    public partial class Auditory : Form
    {
        public Auditory()
        {
            InitializeComponent();
        }

        public void SetVoteResult(int A, int B, int C, int D)
        {
            SetVoteResult(new int[] { A, B, C, D });
        }
        public void SetVoteResult(int[] results)
        {
            if (results[0] + results[1] + results[2] + results[3] != 100)
            {
                //throw ArgumentException;
            }
            else
            {
                auditoryA.Value = results[0];
                auditoryB.Value = results[1];
                auditoryC.Value = results[2];
                auditoryD.Value = results[3];
            }
        }
    }
}
