namespace WF2._1_Calc
{
    partial class Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.currentExpressionLabel = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.backspace = new System.Windows.Forms.Button();
            this.clearNumber = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.changeSign = new System.Windows.Forms.Button();
            this.sqrt = new System.Windows.Forms.Button();
            this.number7 = new System.Windows.Forms.Button();
            this.number8 = new System.Windows.Forms.Button();
            this.number9 = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.percent = new System.Windows.Forms.Button();
            this.number4 = new System.Windows.Forms.Button();
            this.number5 = new System.Windows.Forms.Button();
            this.number6 = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.reverse = new System.Windows.Forms.Button();
            this.number1 = new System.Windows.Forms.Button();
            this.number2 = new System.Windows.Forms.Button();
            this.number3 = new System.Windows.Forms.Button();
            this.substraction = new System.Windows.Forms.Button();
            this.number0 = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.addition = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // currentExpressionLabel
            // 
            this.currentExpressionLabel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.currentExpressionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentExpressionLabel.Location = new System.Drawing.Point(8, 8);
            this.currentExpressionLabel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.currentExpressionLabel.Name = "currentExpressionLabel";
            this.currentExpressionLabel.Size = new System.Drawing.Size(274, 26);
            this.currentExpressionLabel.TabIndex = 0;
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox.Location = new System.Drawing.Point(8, 40);
            this.textBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(274, 26);
            this.textBox.TabIndex = 1;
            this.textBox.TextChanged += new System.EventHandler(this.OnTextChanged);
            this.textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
            // 
            // backspace
            // 
            this.backspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backspace.Location = new System.Drawing.Point(8, 72);
            this.backspace.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(50, 51);
            this.backspace.TabIndex = 2;
            this.backspace.Text = "<--";
            this.backspace.UseVisualStyleBackColor = true;
            this.backspace.Click += new System.EventHandler(this.OnBackspace);
            // 
            // clearNumber
            // 
            this.clearNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearNumber.Location = new System.Drawing.Point(64, 72);
            this.clearNumber.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.clearNumber.Name = "clearNumber";
            this.clearNumber.Size = new System.Drawing.Size(50, 51);
            this.clearNumber.TabIndex = 3;
            this.clearNumber.Text = "CE";
            this.clearNumber.UseVisualStyleBackColor = true;
            this.clearNumber.Click += new System.EventHandler(this.OnClearNumber);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clear.Location = new System.Drawing.Point(120, 72);
            this.clear.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(50, 51);
            this.clear.TabIndex = 4;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.OnClear);
            // 
            // changeSign
            // 
            this.changeSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeSign.Location = new System.Drawing.Point(176, 72);
            this.changeSign.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.changeSign.Name = "changeSign";
            this.changeSign.Size = new System.Drawing.Size(50, 51);
            this.changeSign.TabIndex = 5;
            this.changeSign.Text = "+ | -";
            this.changeSign.UseVisualStyleBackColor = true;
            this.changeSign.Click += new System.EventHandler(this.OnChangeSign);
            // 
            // sqrt
            // 
            this.sqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sqrt.Location = new System.Drawing.Point(232, 72);
            this.sqrt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.sqrt.Name = "sqrt";
            this.sqrt.Size = new System.Drawing.Size(50, 51);
            this.sqrt.TabIndex = 6;
            this.sqrt.Text = "sqrt";
            this.sqrt.UseVisualStyleBackColor = true;
            this.sqrt.Click += new System.EventHandler(this.OnRoot);
            // 
            // number7
            // 
            this.number7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number7.Location = new System.Drawing.Point(8, 128);
            this.number7.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.number7.Name = "number7";
            this.number7.Size = new System.Drawing.Size(50, 51);
            this.number7.TabIndex = 7;
            this.number7.Tag = "7";
            this.number7.Text = "7";
            this.number7.UseVisualStyleBackColor = true;
            this.number7.Click += new System.EventHandler(this.OnClick);
            // 
            // number8
            // 
            this.number8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number8.Location = new System.Drawing.Point(64, 128);
            this.number8.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.number8.Name = "number8";
            this.number8.Size = new System.Drawing.Size(50, 51);
            this.number8.TabIndex = 8;
            this.number8.Tag = "8";
            this.number8.Text = "8";
            this.number8.UseVisualStyleBackColor = true;
            this.number8.Click += new System.EventHandler(this.OnClick);
            // 
            // number9
            // 
            this.number9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number9.Location = new System.Drawing.Point(120, 128);
            this.number9.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.number9.Name = "number9";
            this.number9.Size = new System.Drawing.Size(50, 51);
            this.number9.TabIndex = 9;
            this.number9.Tag = "9";
            this.number9.Text = "9";
            this.number9.UseVisualStyleBackColor = true;
            this.number9.Click += new System.EventHandler(this.OnClick);
            // 
            // division
            // 
            this.division.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.division.Location = new System.Drawing.Point(176, 128);
            this.division.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(50, 51);
            this.division.TabIndex = 10;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.OnDivide);
            // 
            // percent
            // 
            this.percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.percent.Location = new System.Drawing.Point(232, 128);
            this.percent.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(50, 51);
            this.percent.TabIndex = 11;
            this.percent.Text = "%";
            this.percent.UseVisualStyleBackColor = true;
            this.percent.Click += new System.EventHandler(this.OnPercent);
            // 
            // number4
            // 
            this.number4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number4.Location = new System.Drawing.Point(8, 184);
            this.number4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.number4.Name = "number4";
            this.number4.Size = new System.Drawing.Size(50, 51);
            this.number4.TabIndex = 12;
            this.number4.Tag = "4";
            this.number4.Text = "4";
            this.number4.UseVisualStyleBackColor = true;
            this.number4.Click += new System.EventHandler(this.OnClick);
            // 
            // number5
            // 
            this.number5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number5.Location = new System.Drawing.Point(64, 184);
            this.number5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.number5.Name = "number5";
            this.number5.Size = new System.Drawing.Size(50, 51);
            this.number5.TabIndex = 13;
            this.number5.Tag = "5";
            this.number5.Text = "5";
            this.number5.UseVisualStyleBackColor = true;
            this.number5.Click += new System.EventHandler(this.OnClick);
            // 
            // number6
            // 
            this.number6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number6.Location = new System.Drawing.Point(120, 184);
            this.number6.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.number6.Name = "number6";
            this.number6.Size = new System.Drawing.Size(50, 51);
            this.number6.TabIndex = 14;
            this.number6.Tag = "6";
            this.number6.Text = "6";
            this.number6.UseVisualStyleBackColor = true;
            this.number6.Click += new System.EventHandler(this.OnClick);
            // 
            // multiplication
            // 
            this.multiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multiplication.Location = new System.Drawing.Point(176, 184);
            this.multiplication.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(50, 51);
            this.multiplication.TabIndex = 15;
            this.multiplication.Text = "*";
            this.multiplication.UseVisualStyleBackColor = true;
            this.multiplication.Click += new System.EventHandler(this.OnMultiply);
            // 
            // reverse
            // 
            this.reverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reverse.Location = new System.Drawing.Point(232, 184);
            this.reverse.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.reverse.Name = "reverse";
            this.reverse.Size = new System.Drawing.Size(50, 51);
            this.reverse.TabIndex = 16;
            this.reverse.Text = "1 / x";
            this.reverse.UseVisualStyleBackColor = true;
            this.reverse.Click += new System.EventHandler(this.OnReverseNumber);
            // 
            // number1
            // 
            this.number1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number1.Location = new System.Drawing.Point(8, 240);
            this.number1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(50, 51);
            this.number1.TabIndex = 17;
            this.number1.Tag = "1";
            this.number1.Text = "1";
            this.number1.UseVisualStyleBackColor = true;
            this.number1.Click += new System.EventHandler(this.OnClick);
            // 
            // number2
            // 
            this.number2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number2.Location = new System.Drawing.Point(64, 240);
            this.number2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(50, 51);
            this.number2.TabIndex = 18;
            this.number2.Tag = "2";
            this.number2.Text = "2";
            this.number2.UseVisualStyleBackColor = true;
            this.number2.Click += new System.EventHandler(this.OnClick);
            // 
            // number3
            // 
            this.number3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number3.Location = new System.Drawing.Point(120, 240);
            this.number3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.number3.Name = "number3";
            this.number3.Size = new System.Drawing.Size(50, 51);
            this.number3.TabIndex = 19;
            this.number3.Tag = "3";
            this.number3.Text = "3";
            this.number3.UseVisualStyleBackColor = true;
            this.number3.Click += new System.EventHandler(this.OnClick);
            // 
            // substraction
            // 
            this.substraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.substraction.Location = new System.Drawing.Point(176, 240);
            this.substraction.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.substraction.Name = "substraction";
            this.substraction.Size = new System.Drawing.Size(50, 51);
            this.substraction.TabIndex = 20;
            this.substraction.Text = "-";
            this.substraction.UseVisualStyleBackColor = true;
            this.substraction.Click += new System.EventHandler(this.OnSubstract);
            // 
            // number0
            // 
            this.number0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number0.Location = new System.Drawing.Point(8, 296);
            this.number0.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.number0.Name = "number0";
            this.number0.Size = new System.Drawing.Size(106, 51);
            this.number0.TabIndex = 21;
            this.number0.Tag = "0";
            this.number0.Text = "0";
            this.number0.UseVisualStyleBackColor = true;
            this.number0.Click += new System.EventHandler(this.OnClick);
            // 
            // dot
            // 
            this.dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dot.Location = new System.Drawing.Point(120, 296);
            this.dot.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(50, 51);
            this.dot.TabIndex = 22;
            this.dot.Text = ",";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.OnClick);
            // 
            // addition
            // 
            this.addition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addition.Location = new System.Drawing.Point(176, 296);
            this.addition.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(50, 51);
            this.addition.TabIndex = 23;
            this.addition.Text = "+";
            this.addition.UseVisualStyleBackColor = true;
            this.addition.Click += new System.EventHandler(this.OnAdd);
            // 
            // equals
            // 
            this.equals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equals.Location = new System.Drawing.Point(232, 240);
            this.equals.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(50, 108);
            this.equals.TabIndex = 24;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = true;
            this.equals.Click += new System.EventHandler(this.OnEquals);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 353);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.addition);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.number0);
            this.Controls.Add(this.substraction);
            this.Controls.Add(this.number3);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number1);
            this.Controls.Add(this.reverse);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.number6);
            this.Controls.Add(this.number5);
            this.Controls.Add(this.number4);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.division);
            this.Controls.Add(this.number9);
            this.Controls.Add(this.number8);
            this.Controls.Add(this.number7);
            this.Controls.Add(this.sqrt);
            this.Controls.Add(this.changeSign);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.clearNumber);
            this.Controls.Add(this.backspace);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.currentExpressionLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.Text = "Калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currentExpressionLabel;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button backspace;
        private System.Windows.Forms.Button clearNumber;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button changeSign;
        private System.Windows.Forms.Button sqrt;
        private System.Windows.Forms.Button number7;
        private System.Windows.Forms.Button number8;
        private System.Windows.Forms.Button number9;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button percent;
        private System.Windows.Forms.Button number4;
        private System.Windows.Forms.Button number5;
        private System.Windows.Forms.Button number6;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button reverse;
        private System.Windows.Forms.Button number1;
        private System.Windows.Forms.Button number2;
        private System.Windows.Forms.Button number3;
        private System.Windows.Forms.Button substraction;
        private System.Windows.Forms.Button number0;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button addition;
        private System.Windows.Forms.Button equals;
    }
}

