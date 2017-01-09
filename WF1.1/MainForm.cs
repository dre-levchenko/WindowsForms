using System;
using System.Windows.Forms;

namespace WF1._1
{
    public partial class MainForm : Form
    {
        int _answer;
        readonly Random _randNum = new Random();
        int _counter;

        public MainForm()
        {
            InitializeComponent();
        }

        private void OnTick(object sender, EventArgs e)
        {
            timer.Stop();
            Game();
        }

        private void Game()
        {
            _answer = _randNum.Next(1, 101);
            var button = MessageBox.Show("Это " + _answer + "?", @"?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch(button)
            {
                case DialogResult.Yes:
                    {
                        MessageBox.Show("Я ошибся " + _counter + " раз.", @"Все.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        var replay = MessageBox.Show("Хотите сыграть еще?", @"?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        _counter = 0;
                        switch(replay)
                        {
                            case DialogResult.Yes:
                                timer.Start();
                                break;
                            case DialogResult.No:
                                this.Close();
                                break;
                        }
                    }
                    break;
                case DialogResult.No:
                    ++_counter;
                    Game();
                    break;
            }
        }
    }
}
