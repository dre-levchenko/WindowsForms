using System.Collections;

namespace WF3._1_Millionaire
{
    interface IAnswerable
    {
        IEnumerable GetAnswers();
        string GetCorrectAnswer();
        string this[int index] { get; set; }
    }
}
