using System;
using System.Windows.Forms;

namespace WF2._1_Calc
{
    public partial class Calculator : Form
    {
        string _expression = "";
        string _inputNumber = "";
        double _result;
        bool _isFloating;

        public event Action NumberPress;

        protected virtual void OnNumberPress()
        {
            Action handler = NumberPress;
            if (handler != null) handler();
        }

        public Calculator()
        {
            InitializeComponent();

            Operation.OperationChanged += ClearNumber;

            number0.Click += SetFocusAtInput;
            number1.Click += SetFocusAtInput;
            number2.Click += SetFocusAtInput;
            number3.Click += SetFocusAtInput;
            number4.Click += SetFocusAtInput;
            number5.Click += SetFocusAtInput;
            number6.Click += SetFocusAtInput;
            number7.Click += SetFocusAtInput;
            number8.Click += SetFocusAtInput;
            number9.Click += SetFocusAtInput;
            backspace.Click += SetFocusAtInput;
            clearNumber.Click += SetFocusAtInput;
            clear.Click += SetFocusAtInput;
            changeSign.Click += SetFocusAtInput;
            dot.Click += SetFocusAtInput;

            addition.Click += SetFocusAtInput;
            addition.Click += Operation.OnOperationChanged;
            substraction.Click += SetFocusAtInput;
            substraction.Click += Operation.OnOperationChanged;
            multiplication.Click += SetFocusAtInput;
            multiplication.Click += Operation.OnOperationChanged;
            division.Click += SetFocusAtInput;
            division.Click += Operation.OnOperationChanged;
            percent.Click += SetFocusAtInput;
            //percent.Click += Operation.OnOperationChanged;
            reverse.Click += SetFocusAtInput;
            //reverse.Click += Operation.OnOperationChanged;
            equals.Click += SetFocusAtInput;
            //equals.Click += Operation.OnOperationChanged;
            sqrt.Click += SetFocusAtInput;
            //sqrt.Click += Operation.OnOperationChanged;

            ExportNumber();
            textBox.SelectionLength = 0;
        }
        
        private void Add()
        {
            ImportNumber();
            if (_inputNumber != "")
            {
                var number = ImportNumber();
                if (Operation.LastOperatorUsed != Operators.Root)
                {
                    _expression += _inputNumber;
                }
                _expression += " + ";
                ExportExpression();

                _result = Operation.CalculateResult(_result, number);
                Operation.LastOperatorUsed = Operators.Addition;
            }
        }

        private void Divide()
        {
            ImportNumber();
            if (_inputNumber != "")
            {
                var number = ImportNumber();
                if (Operation.LastOperatorUsed != Operators.Root)
                {
                    _expression += _inputNumber;
                }
                _expression += " / ";
                ExportExpression();

                _result = Operation.CalculateResult(_result, number);
                Operation.LastOperatorUsed = Operators.Division;
            }
        }

        private void Multiply()
        {
            ImportNumber();
            if (_inputNumber != "")
            {
                var number = ImportNumber();
                if (Operation.LastOperatorUsed != Operators.Root)
                {
                    _expression += _inputNumber;
                }
                _expression += " * ";
                ExportExpression();

                _result = Operation.CalculateResult(_result, number);
                Operation.LastOperatorUsed = Operators.Multiplication;
            }
        }

        private void Substract()
        {
            ImportNumber();
            if (_inputNumber != "")
            {
                var number = ImportNumber();
                if (Operation.LastOperatorUsed != Operators.Root)
                {
                    _expression += _inputNumber;
                }
                _expression += " - ";
                ExportExpression();

                _result = Operation.CalculateResult(_result, number);
                Operation.LastOperatorUsed = Operators.Substraction;
            }
        }

        private void Calculate()
        {
            var number = ImportNumber();
            if (_inputNumber == "")
            {
                switch (Operation.LastOperatorUsed)
                {
                    case Operators.Addition:
                        number = 0;
                        break;
                    case Operators.Division:
                        number = 1;
                        break;
                    case Operators.Multiplication:
                        number = 1;
                        break;
                    case Operators.Substraction:
                        number = 0;
                        break;
                }
            }
            _result = Operation.CalculateResult(_result, number);
            ExportNumber(_result);
            ClearExpression();
            Operation.LastOperatorUsed = Operators.None;
        }

        private void ChangeSign()
        {
            var number = ImportNumber();
            if (_inputNumber.Length > 0)
            {
                if (number > 0)
                {
                    _inputNumber = _inputNumber.Insert(0, "-");
                }
                else if (number < 0)
                {
                    _inputNumber = _inputNumber.Remove(0, 1);
                }
                ExportNumber();
            }

            Operation.LastOperatorUsed = Operators.Sign;
        }

        private void Clear()
        {
            ClearNumber();
            ClearExpression();
            _result = 0;
        }

        private void ClearNumber()
        {
            _inputNumber = "";
            _isFloating = false;
            ExportNumber();
        }

        private void Backspace()
        {
            ImportNumber();
            if (_inputNumber.Length > 0)
            {
                _inputNumber = _inputNumber.Remove(_inputNumber.Length - 1, 1);
                ExportNumber();
            }
        }

        private void ReverseNumber()
        {
            if (ImportNumber() != 0)
            {
                var number = 1/ImportNumber();
                ExportNumber(number);
            }
        }

        private void Root()
        {
            var number = ImportNumber();

            if (number >= 0)
            {
                number = Math.Sqrt(number);
                _expression += "sqrt(" + number + ") ";
                ExportNumber(number);
                ExportExpression();

                _result = Operation.CalculateResult(_result, number);
                Operation.LastOperatorUsed = Operators.Root;
            }
        }

        private void Percent()
        {
            var number = ImportNumber();

            if (number > 0)
            {
                number = _result * number / 100;
                ExportNumber(number);
            }
        }

        private void ClearExpression()
        {
            _expression = "";
            ExportExpression();
        }

        private void ImportExpression()
        {
            _expression = currentExpressionLabel.Text;
        }

        private void ExportExpression()
        {
            currentExpressionLabel.Text = _expression;
        }

        private double ImportNumber()
        {
            double result = 0;
            _inputNumber = textBox.Text;
            if (_inputNumber == "")
            {
                result = 0;
            }
            else
            {
                try
                {
                    result = Convert.ToDouble(_inputNumber);
                }
                catch (OverflowException e)
                {
                    MessageBox.Show(e.Message);
                    result = 0;
                }
            }

            return result;
        }

        private void ExportNumber()
        {
            textBox.Text = _inputNumber;
        }

        private void ExportNumber(double number)
        {
            _inputNumber = number.ToString();
            ExportNumber();
        }

        private void SetFocusAtInput(object sender, EventArgs e)
        {
            this.ActiveControl = textBox;
            textBox.SelectionStart += textBox.SelectionLength;
        }



        private void OnKeyPress(object sender, KeyPressEventArgs e)
        {
            ImportNumber();
            if (_inputNumber.Length < 13)
            {
                if (e.KeyChar == ',' && _isFloating == false && _inputNumber.Length > 0)
                {
                    _isFloating = true;
                    _inputNumber += ",";
                }
                else if (e.KeyChar < '0' || e.KeyChar > '9')
                {
                    switch (e.KeyChar)
                    {
                        case '+':
                            addition.PerformClick();
                            break;
                        case '/':
                            division.PerformClick();
                            break;
                        case '*':
                            multiplication.PerformClick();
                            break;
                        case '-':
                            substraction.PerformClick();
                            break;
                        case '%':
                            percent.PerformClick();
                            break;
                        case (char) Keys.Back:
                            backspace.PerformClick();
                            break;
                        case (char) Keys.Delete:
                            clearNumber.PerformClick();
                            break;
                        case '=':
                        case (char) Keys.Enter:
                            equals.PerformClick();
                            break;
                        case 'c':
                        case (char) Keys.Escape:
                            clear.PerformClick();
                            break;
                        default:
                            MessageBox.Show(@"В это поле можно вводить только цифры.", @"Ошибка ввода",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                    e.Handled = true;
                }
                else
                {
                    _inputNumber += e.KeyChar;
                    ExportNumber();
                }
                textBox.SelectionLength = 0;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void OnClick(object sender, EventArgs e)
        {
            ImportNumber();

            var button = (Button)sender; 
            if (button == dot && _isFloating == false && _inputNumber.Length > 0)
            {
                _inputNumber += ",";
                _isFloating = true;
            }
            else if (button != null && button != dot)
            {
                if (_inputNumber.Length < 13)
                {
                    switch (button.Tag.ToString())
                    {
                        case "0":
                            _inputNumber += "0";
                            break;
                        case "1":
                            _inputNumber += "1";
                            break;
                        case "2":
                            _inputNumber += "2";
                            break;
                        case "3":
                            _inputNumber += "3";
                            break;
                        case "4":
                            _inputNumber += "4";
                            break;
                        case "5":
                            _inputNumber += "5";
                            break;
                        case "6":
                            _inputNumber += "6";
                            break;
                        case "7":
                            _inputNumber += "7";
                            break;
                        case "8":
                            _inputNumber += "8";
                            break;
                        case "9":
                            _inputNumber += "9";
                            break;
                    }
                }
            } 

            textBox.Text = _inputNumber;
        }

        private void OnBackspace(object sender, EventArgs e)
        {
            Backspace();
        }

        private void OnClear(object sender, EventArgs e)
        {
            Clear();
        }

        private void OnChangeSign(object sender, EventArgs e)
        {
            ChangeSign();
        }

        private void OnRoot(object sender, EventArgs e)
        {
            Root();
        }

        private void OnDivide(object sender, EventArgs e)
        {
            Divide();
        }

        private void OnMultiply(object sender, EventArgs e)
        {
            Multiply();
        }

        private void OnSubstract(object sender, EventArgs e)
        {
            Substract();
        }

        private void OnAdd(object sender, EventArgs e)
        {
            Add();
        }

        private void OnReverseNumber(object sender, EventArgs e)
        {
            ReverseNumber();
        }

        private void OnEquals(object sender, EventArgs e)
        {
            Calculate();
        }

        private void OnPercent(object sender, EventArgs e)
        {
            _isFloating = false;
            Percent();
        }

        private void OnClearNumber(object sender, EventArgs e)
        {
            ClearNumber();
        }

        private void OnTextChanged(object sender, EventArgs e)
        {
        }
    }
}
