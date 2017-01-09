using System;
using System.Windows.Forms;

namespace WF3._1_Millionaire
{
    public partial class Game : Form
    {
        private Manager _manager;

        public Game()
        {
            InitializeComponent();
            _manager = new Manager(this);
        }

        private void OnGameLoad(object sender, EventArgs e)
        {
            _manager.NextQuestion();
        }
        private void OnAnswerButtonClick(object sender, EventArgs e)
        {
            if (_manager.CheckAnswer((Control) sender))
            {
                MessageBox.Show("Верно!", "Ведущий", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _manager.NextQuestion();
            }
            else
            {
                MessageBox.Show("Вы ответили не верно!", "Ведущий", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _manager.GameOver();
            }
        }

        private void OnMakeItEasyClick(object sender, EventArgs e)
        {
            _manager.MakeItEasy();
        }

        private void OnCallFriendClick(object sender, EventArgs e)
        {
            _manager.CallFriend();
        }

        private void OnAuditoryHelpClick(object sender, EventArgs e)
        {
            _manager.AuditoryHelp();
        }
    }
}
