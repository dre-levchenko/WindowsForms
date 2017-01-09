namespace WF3._1_Millionaire.Forms
{
    partial class DialogGameOver
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
            this.labelGameOver = new System.Windows.Forms.Label();
            this.labelYouWon = new System.Windows.Forms.Label();
            this.labelSum = new System.Windows.Forms.Label();
            this.buttonRestartGame = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelGameOver
            // 
            this.labelGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGameOver.Location = new System.Drawing.Point(80, 40);
            this.labelGameOver.Name = "labelGameOver";
            this.labelGameOver.Size = new System.Drawing.Size(120, 20);
            this.labelGameOver.TabIndex = 0;
            this.labelGameOver.Text = "Игра окончена";
            // 
            // labelYouWon
            // 
            this.labelYouWon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelYouWon.Location = new System.Drawing.Point(80, 80);
            this.labelYouWon.Name = "labelYouWon";
            this.labelYouWon.Size = new System.Drawing.Size(120, 13);
            this.labelYouWon.TabIndex = 1;
            this.labelYouWon.Text = "Вы выиграли:";
            this.labelYouWon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSum
            // 
            this.labelSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSum.Location = new System.Drawing.Point(80, 112);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(120, 13);
            this.labelSum.TabIndex = 2;
            this.labelSum.Text = "sum";
            this.labelSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonRestartGame
            // 
            this.buttonRestartGame.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.buttonRestartGame.Location = new System.Drawing.Point(80, 152);
            this.buttonRestartGame.Name = "buttonRestartGame";
            this.buttonRestartGame.Size = new System.Drawing.Size(120, 23);
            this.buttonRestartGame.TabIndex = 3;
            this.buttonRestartGame.Text = "Начать заново";
            this.buttonRestartGame.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.No;
            this.buttonExit.Location = new System.Drawing.Point(80, 192);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(120, 23);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // DialogGameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 251);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonRestartGame);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.labelYouWon);
            this.Controls.Add(this.labelGameOver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogGameOver";
            this.Text = "Конец";
            this.Load += new System.EventHandler(this.OnDialogGameOverLoad);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelGameOver;
        private System.Windows.Forms.Label labelYouWon;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Button buttonRestartGame;
        private System.Windows.Forms.Button buttonExit;
    }
}