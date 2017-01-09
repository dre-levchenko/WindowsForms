using System;
using System.Collections;
using System.Resources;
using System.ComponentModel.Design;
using System.Text.RegularExpressions;
using System.Linq;
using System.Windows.Forms;

namespace WF3._1_Millionaire
{
    class QuestionAnswer : IAnswerable
    {
        private string[] _answers;
        private string _correctAnswer;
        private readonly int _questionNumber;

        public QuestionAnswer(int questionNumber)
        {
            _questionNumber = questionNumber;
            LoadAnswers();
        }

        private void LoadAnswers()
        {
            using (var answers = new ResXResourceReader(@"Resources\Answers.resx"))
            {
                var random = new Random(DateTime.Now.Millisecond);

                answers.UseResXDataNodes = true;
                var answersCounter = 1;
                foreach (DictionaryEntry answer in answers)
                {
                    if (answersCounter == _questionNumber)
                    {
                        var tmpNode = (ResXDataNode)answer.Value;
                        _correctAnswer = tmpNode.Comment;

                        var tmpFullString = (string) tmpNode.GetValue((ITypeResolutionService)null);
                        var matches = Regex.Split(tmpFullString, @";");
                        _answers = matches.OrderBy(x => random.Next()).ToArray();
                        break;
                    }
                    ++answersCounter;
                }
            }
        }

        public void BindAnswersToButtons(Control[] labels, Control[] buttons)
        {
            for (var i = 0; i < buttons.Length; i++)
            {
                labels[i].Text = _answers[i];
                buttons[i].Tag = _answers[i] == _correctAnswer ? QuestionResult.Correct : QuestionResult.Incorrect;
            }
        }

        public IEnumerable GetAnswers()
        {
            return _answers;
        }

        public string GetCorrectAnswer()
        {
            return _correctAnswer;
        }

        public string this[int index]
        {
            get { return _answers[index]; }
            set { _answers[index] = value; }
        }
    }
}
