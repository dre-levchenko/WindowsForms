using System.Collections;
using System.ComponentModel.Design;
using System.Resources;
using System.Windows.Forms;

namespace WF3._1_Millionaire
{
    class Question : IAnswerable
    {
        private int _questionNumber;
        private string _question;
        private QuestionDifficult _difficult = QuestionDifficult.None;
        private QuestionAnswer _answers;

        public int Index
        {
            get { return _questionNumber - 1; }
        }
        public QuestionDifficult Difficult
        {
            get { return _difficult; }
        }

        public Question() : this(0) { }
        public Question(int questionNumber)
        {
            _questionNumber = questionNumber;
        }

        private void LoadQuestion()
        {
            ++_questionNumber;
            using (var questions = new ResXResourceReader(@"Resources\Questions.resx"))
            {
                questions.UseResXDataNodes = true;
                var questionsCounter = 1;
                foreach (DictionaryEntry question in questions)
                {
                    if (questionsCounter == _questionNumber)
                    {
                        var tmpNode = (ResXDataNode)question.Value;
                        _question = tmpNode.GetValue((ITypeResolutionService)null).ToString();
                        switch (tmpNode.Comment)
                        {
                            case "Easy":
                                _difficult = QuestionDifficult.Easy;
                                break;
                            case "Medium":
                                _difficult = QuestionDifficult.Medium;
                                break;
                            case "Expert":
                                _difficult = QuestionDifficult.Expert;
                                break;
                            default:
                                _difficult = QuestionDifficult.None;
                                break;
                        }
                        break;
                    }
                    ++questionsCounter;
                }
                _answers = new QuestionAnswer(_questionNumber);
            }
        }

        public void BindAnswersToButtons(Control[] labels, Control[] buttons)
        {
            _answers.BindAnswersToButtons(labels, buttons);
        }

        public bool IsCorrect(Control button)
        {
            return (QuestionResult) button.Tag == QuestionResult.Correct;
        }
        public void NextQuestion()
        {
            LoadQuestion();
        }

        public IEnumerable GetAnswers()
        {
            return ((IAnswerable) _answers).GetAnswers();
        }

        public string GetCorrectAnswer()
        {
            return ((IAnswerable) _answers).GetCorrectAnswer();
        }

        public string GetQuestionString()
        {
            return _question;
        }

        public string this[int index]
        {
            get { return _answers[index]; }
            set { _answers[index] = value; }
        }
    }
}
