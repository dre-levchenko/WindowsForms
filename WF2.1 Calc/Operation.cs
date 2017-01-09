using System;
using System.Windows.Forms;

namespace WF2._1_Calc
{
    enum Operators
    {
        None,
        Addition,
        Division,
        Multiplication,
        Substraction,
        Root,
        Percent,
        Sign
    }
    static class Operation
    {
        private static bool _isOperationChanged;
        public static event Action OperationChanged;

        public static bool IsOperationChanged
        {
            get { return _isOperationChanged; }
        }
        public static Operators LastOperatorUsed { get; set; }

        static Operation()
        {
            OperationChanged += () => _isOperationChanged = !_isOperationChanged;
        }

        public static void OnOperationChanged(object sender, EventArgs e)
        {
            Action handler = OperationChanged;
            if (handler != null)
            {
                handler();
            }
        }

        public static double CalculateResult(double calculated, double number)
        {
            var result = calculated;
            switch (LastOperatorUsed)
            {
                case Operators.Addition:
                    if (!double.IsPositiveInfinity(result + number))
                    {
                        result += number;
                    }
                    else
                    {
                        MessageBox.Show(@"Переполнение");
                    }
                    break;
                case Operators.Division:
                    if (!double.IsNegativeInfinity(result / number))
                    {
                        result /= number;
                    }
                    else
                    {
                        MessageBox.Show(@"Переполнение");
                    }
                    break;
                case Operators.Multiplication:
                    if (!double.IsPositiveInfinity(result*number))
                    {
                        result *= number;
                    }
                    else
                    {
                        MessageBox.Show(@"Переполнение");
                    }
                    break;
                case Operators.Substraction:
                    if (!double.IsNegativeInfinity(result - number))
                    {
                        result -= number;
                    }
                    else
                    {
                        MessageBox.Show(@"Переполнение");
                    }
                    break;
                case Operators.Sign:
                case Operators.None:
                    result = number;
                    break;
            }
            return result;
        }
    }
}
