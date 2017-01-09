using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Resources;
using System.Text.RegularExpressions;

namespace WF3._2_Millionaire_Editor
{
    class QuestionsManager
    {
        private readonly List<Question> _questions;

        public int Count
        {
            get
            {
                return _questions.Count;
            }
        }

        public QuestionsManager()
        {
            var tmpAnswers = new List<QuestionAnswer>();
            using (var answers = new ResXResourceReader(@"Resources\Answers.resx"))
            {
                answers.UseResXDataNodes = true;
                var answersCounter = 0;
                foreach (DictionaryEntry answer in answers)
                {
                    var tmpNode = (ResXDataNode)answer.Value;

                    var tmpFullString = (string)tmpNode.GetValue((ITypeResolutionService)null);
                    var matches = Regex.Split(tmpFullString, @";");

                    tmpAnswers.Add(new QuestionAnswer(matches, tmpNode.Comment));

                    ++answersCounter;
                }
            }

            using (var questions = new ResXResourceReader(@"Resources\Questions.resx"))
            {
                _questions = new List<Question>();
                questions.UseResXDataNodes = true;
                var questionsCounter = 0;
                foreach (DictionaryEntry question in questions)
                {
                    var tmpNode = (ResXDataNode)question.Value;
                    QuestionDifficult tmpQuestionDifficult;

                    switch (tmpNode.Comment)
                    {
                        case "Easy":
                            tmpQuestionDifficult = QuestionDifficult.Easy;
                            break;
                        case "Medium":
                            tmpQuestionDifficult = QuestionDifficult.Medium;
                            break;
                        case "Expert":
                            tmpQuestionDifficult = QuestionDifficult.Expert;
                            break;
                        default:
                            tmpQuestionDifficult = QuestionDifficult.None;
                            break;
                    }
                    _questions.Add(new Question(tmpNode.GetValue((ITypeResolutionService)null).ToString(), tmpAnswers[questionsCounter], tmpQuestionDifficult));

                    ++questionsCounter;
                }
            }
        }

        public void Add(Question question)
        {
            _questions.Add(question);
        }

        public List<Question> GetQuestions()
        {
            return _questions;
        }

        public Question this[int index]
        {
            get { return _questions[index]; }
            set { _questions[index] = value; }
        }
    }
}
