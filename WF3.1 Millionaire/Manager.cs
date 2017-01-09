using System;
using System.Drawing;
using System.Windows.Forms;
using WF3._1_Millionaire.Forms;


namespace WF3._1_Millionaire
{
    class Manager
    {
        private readonly Form _gameForm;
        private Question _activeQuestion;
        private readonly Control[] _questionPriceLabels;
        private readonly Control[] _buttons;
        private int _prizeSum;

        public Manager(Form gameForm)
        {
            _gameForm = gameForm;
            _activeQuestion = new Question();

            _buttons = new[]
            {
                _gameForm.Controls["buttonAnswerA"],
                _gameForm.Controls["buttonAnswerB"],
                _gameForm.Controls["buttonAnswerC"],
                _gameForm.Controls["buttonAnswerD"]
            };

            _questionPriceLabels = new[]
            {
                _gameForm.Controls["questionPrice1"],
                _gameForm.Controls["questionPrice2"],
                _gameForm.Controls["questionPrice3"],
                _gameForm.Controls["questionPrice4"],
                _gameForm.Controls["questionPrice5"],
                _gameForm.Controls["questionPrice6"],
                _gameForm.Controls["questionPrice7"],
                _gameForm.Controls["questionPrice8"],
                _gameForm.Controls["questionPrice9"],
                _gameForm.Controls["questionPrice10"],
                _gameForm.Controls["questionPrice11"],
                _gameForm.Controls["questionPrice12"],
                _gameForm.Controls["questionPrice13"],
                _gameForm.Controls["questionPrice14"],
                _gameForm.Controls["questionPrice15"]
            };
            ResetQuestionPriceBar();
        }

        private void UpdateQuestionPriceBar()
        {
            _questionPriceLabels[_activeQuestion.Index].BackColor = Color.FromArgb((int)QuestionPriceColors.Active);

            var previousPriceLabelIndex = _activeQuestion.Index - 1;
            if (previousPriceLabelIndex >= 0)
            {
                switch ((QuestionStatus)_questionPriceLabels[previousPriceLabelIndex].Tag)
                {
                    case QuestionStatus.Million:
                        _questionPriceLabels[previousPriceLabelIndex].BackColor =
                            Color.FromArgb((int)QuestionPriceColors.Million);
                        break;
                    case QuestionStatus.Primary:
                        _questionPriceLabels[previousPriceLabelIndex].BackColor =
                            Color.FromArgb((int)QuestionPriceColors.Primary);
                        break;
                    case QuestionStatus.Protected:
                        _questionPriceLabels[previousPriceLabelIndex].BackColor =
                            Color.FromArgb((int)QuestionPriceColors.Protected);
                        break;
                }
            }
        }

        private void ResetQuestionPriceBar()
        {
            for (var i = 0; i < _questionPriceLabels.Length; i++)
            {
                switch (i)
                {
                    case 9:
                    case 4:
                        _questionPriceLabels[i].Tag = QuestionStatus.Protected;
                        _questionPriceLabels[i].BackColor = Color.FromArgb((int)QuestionPriceColors.Protected);
                        break;
                    case 14:
                        _questionPriceLabels[i].Tag = QuestionStatus.Million;
                        _questionPriceLabels[i].BackColor = Color.FromArgb((int)QuestionPriceColors.Million);
                        break;
                    default:
                        _questionPriceLabels[i].Tag = QuestionStatus.Primary;
                        _questionPriceLabels[i].BackColor = Color.FromArgb((int)QuestionPriceColors.Primary);
                        break;
                }
            }
        }

        public void LoadQuestion()
        {
            _gameForm.Controls["question"].Text = _activeQuestion.GetQuestionString();
            var labels = new[]
            {
                _gameForm.Controls["answerA"],
                _gameForm.Controls["answerB"],
                _gameForm.Controls["answerC"],
                _gameForm.Controls["answerD"]
            };
            _activeQuestion.BindAnswersToButtons(labels, _buttons);
        }

        public void NextQuestion()
        {
            if (_activeQuestion.Index < 14)
            {
                _activeQuestion.NextQuestion();
                LoadQuestion();
                UpdateQuestionPriceBar();
                MakeItHard();
            }
            else
            {
                GameOver();
            }
        }

        public bool CheckAnswer(Control button)
        {
            var result = _activeQuestion.IsCorrect(button);
            var questionStatus = (QuestionStatus) _questionPriceLabels[_activeQuestion.Index].Tag;

            _prizeSum = result && questionStatus == QuestionStatus.Protected || questionStatus == QuestionStatus.Million
                ? Convert.ToInt32(_questionPriceLabels[_activeQuestion.Index].Text)
                : _prizeSum;

            return result;
        }

        public void GameOver()
        {
            var dialogGameOver = new DialogGameOver
            {
                PrizeSum = _prizeSum
            };

            switch (dialogGameOver.ShowDialog())
            {
                case DialogResult.Yes:
                    _activeQuestion = new Question(0);
                    _prizeSum = 0;
                    _gameForm.Controls["buttonCallFriend"].Enabled = true;
                    _gameForm.Controls["buttonMakeItEasy"].Enabled = true;
                    _gameForm.Controls["buttonAuditoryHelp"].Enabled = true;
                    NextQuestion();
                    ResetQuestionPriceBar();
                    UpdateQuestionPriceBar();
                    break;
                case DialogResult.No:
                    _gameForm.Close();
                    break;
            }
        }

        public void MakeItEasy()
        {
            var tmpButtons = new Control[_buttons.Length];
            _buttons.CopyTo(tmpButtons, 0);
            tmpButtons = ArrayExtension.Shuffle<Control>(tmpButtons);

            for (int i = 0, j = 0; i < tmpButtons.Length && j < 2; ++i)
            {
                if ((QuestionResult) tmpButtons[i].Tag == QuestionResult.Incorrect)
                {
                    tmpButtons[i].Enabled = false;
                    ++j;
                }
            }

            _gameForm.Controls["buttonMakeItEasy"].Enabled = false;
        }

        public void MakeItHard()
        {
            foreach(var button in _buttons)
            {
                button.Enabled = true;
            }
        }

        public void CallFriend()
        {
            var friendMessage = "Я думаю, что правильный вариант - ";
            var random = new Random(DateTime.Now.Millisecond);
            var successPercent = 100;
            switch(_activeQuestion.Difficult)
            {
                case QuestionDifficult.Easy:
                    successPercent = 50;
                    break;
                case QuestionDifficult.Medium:
                    successPercent = 25;
                    break;
                case QuestionDifficult.Expert:
                    successPercent = 15;
                    break;
            }

            if (random.Next(0, 101) <= successPercent)
            {
                foreach(var button in _buttons)
                {
                    if ((QuestionResult) button.Tag == QuestionResult.Correct)
                    {
                        friendMessage += button.Text + ".";
                    }
                }
            }
            else
            {
                friendMessage = "Я не знаю правильного ответа";
            }

            MessageBox.Show(friendMessage, "Друг", MessageBoxButtons.OK);
            _gameForm.Controls["buttonCallFriend"].Enabled = false;
        }

        public void AuditoryHelp()
        {
            var auditory = new Auditory();
            var auditoryVoteResults = new int[4];
            var correctAnswerIndex = 0;

            var random = new Random(DateTime.Now.Millisecond);
            var successPercent = 0;
            switch (_activeQuestion.Difficult)
            {
                case QuestionDifficult.Easy:
                    successPercent = 30;
                    break;
                case QuestionDifficult.Medium:
                    successPercent = 20;
                    break;
                case QuestionDifficult.Expert:
                    successPercent = 10;
                    break;
            }
            for (var i = 0; i < _buttons.Length; ++i)
            {
                if ((QuestionResult)_buttons[i].Tag == QuestionResult.Correct)
                {
                    auditoryVoteResults[i] += successPercent;
                    correctAnswerIndex = i;
                    break;
                }
            }

            for (var i = 0; i < 100 - successPercent; ++i)
            {
                var tmpIndex = random.Next(0, 4);
                ++auditoryVoteResults[tmpIndex];
            }
            
            auditory.SetVoteResult(auditoryVoteResults);
            _gameForm.Controls["buttonAuditoryHelp"].Enabled = false;
            auditory.ShowDialog();
        }
    }
}
