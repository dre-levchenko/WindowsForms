using System.Windows.Forms;

namespace WF3._2_Millionaire_Editor
{
    public partial class EditQuestion : Form
    {
        private Question _question;
        private Control[] _answerTextBoxes;
        private RadioButton[] _answerRadioButtons;

        public EditQuestion()
        {
            InitializeComponent();
            _question = new Question();

            _answerTextBoxes = new Control[] {
                editAnswerA,
                editAnswerB,
                editAnswerC,
                editAnswerD
            };
            _answerRadioButtons = new RadioButton[] {
                radioA,
                radioB,
                radioC,
                radioD
            };
        }
        public EditQuestion(Question question) : this()
        {
            _question = question;
            SetQuestion(_question);
        }

        private void OnCancelClick(object sender, System.EventArgs e)
        {
            Close();
        }

        private void OnSaveClick(object sender, System.EventArgs e)
        {
            _question = GetQuestion();
            Close();
        }

        public new Question ShowDialog()
        {
            Form form = this;
            form.ShowDialog();
            return _question;
        }

        private Question GetQuestion()
        {
            var tmpDifficult = QuestionDifficult.None;
            switch (comboDifficult.Text)
            {
                case "Легко":
                    tmpDifficult = QuestionDifficult.Easy;
                    break;
                case "Средне":
                    tmpDifficult = QuestionDifficult.Medium;
                    break;
                case "Сложно":
                    tmpDifficult = QuestionDifficult.Expert;
                    break;
            }

            string correctAnswer = "";
            var answers = new string[4];
            for (int i = 0; i < _answerTextBoxes.Length; ++i)
            {
                answers[i] = _answerTextBoxes[i].Text;
                correctAnswer = _answerRadioButtons[i].Checked == true ? _answerTextBoxes[i].Text : "";
            }

            return new Question(questionEdit.Text, new QuestionAnswer(answers, correctAnswer), tmpDifficult);
        }

        private void SetQuestion(Question question)
        {
            questionEdit.Text = _question.GetQuestionString();

            var answers = question.GetAnswers();
            for (int i = 0; i < _answerTextBoxes.Length; ++i)
            {
                _answerTextBoxes[i].Text = (string) answers[i];
                _answerRadioButtons[i].Checked = (string)answers[i] == question.GetCorrectAnswer();
            }

            switch (_question.Difficult)
            {
                case QuestionDifficult.Easy:
                    comboDifficult.SelectedItem = comboDifficult.Items[0];
                    break;
                case QuestionDifficult.Expert:
                    comboDifficult.SelectedItem = comboDifficult.Items[2];
                    break;
                case QuestionDifficult.Medium:
                    comboDifficult.SelectedItem = comboDifficult.Items[1];
                    break;
                case QuestionDifficult.None:
                    break;
            }
        }
    }
}
