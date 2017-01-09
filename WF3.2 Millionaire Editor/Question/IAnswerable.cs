using System.Collections;

namespace WF3._2_Millionaire_Editor
{
    interface IAnswerable
    {
        IList GetAnswers();
        string GetCorrectAnswer();
        string this[int index] { get; set; }
    }
}
