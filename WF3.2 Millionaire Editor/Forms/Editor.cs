using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WF3._2_Millionaire_Editor
{
    public partial class Editor : Form
    {
        private readonly QuestionsManager _questionsManager;
        public Editor()
        {
            InitializeComponent();
            _questionsManager = new QuestionsManager();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            UpdateQuestionsList();
        }

        private void OnEditClick(object sender, EventArgs e)
        {
            var editQuestion = new EditQuestion(_questionsManager[questionsList.SelectedIndex]);
            _questionsManager[questionsList.SelectedIndex] = editQuestion.ShowDialog();
        }

        private void OnSelectedValueChanged(object sender, EventArgs e)
        {
            buttonEdit.Enabled = questionsList.SelectedIndex != -1;
        }

        private void OnAddClick(object sender, EventArgs e)
        {
            var editQuestion = new EditQuestion();
            //editQuestion.ShowDialog();
            _questionsManager.Add(editQuestion.ShowDialog());
            UpdateQuestionsList();
        }

        private void UpdateQuestionsList()
        {
            questionsList.Items.Clear();
            List<Question> questions = _questionsManager.GetQuestions();
            for (var i = 0; i < _questionsManager.Count; ++i)
            {
                questionsList.Items.Add(questions[i].GetQuestionString());
            }
        }
    }
}
