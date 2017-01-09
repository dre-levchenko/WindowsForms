namespace WF3._1_Millionaire.Forms
{
    partial class Auditory
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
            this.auditoryA = new System.Windows.Forms.ProgressBar();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.labelD = new System.Windows.Forms.Label();
            this.auditoryB = new System.Windows.Forms.ProgressBar();
            this.auditoryC = new System.Windows.Forms.ProgressBar();
            this.auditoryD = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // auditoryA
            // 
            this.auditoryA.Location = new System.Drawing.Point(40, 16);
            this.auditoryA.Name = "auditoryA";
            this.auditoryA.Size = new System.Drawing.Size(224, 16);
            this.auditoryA.TabIndex = 0;
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(16, 16);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(14, 13);
            this.labelA.TabIndex = 1;
            this.labelA.Text = "A";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(16, 48);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(14, 13);
            this.labelB.TabIndex = 2;
            this.labelB.Text = "B";
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Location = new System.Drawing.Point(16, 80);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(14, 13);
            this.labelC.TabIndex = 3;
            this.labelC.Text = "C";
            // 
            // labelD
            // 
            this.labelD.AutoSize = true;
            this.labelD.Location = new System.Drawing.Point(16, 112);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(15, 13);
            this.labelD.TabIndex = 4;
            this.labelD.Text = "D";
            // 
            // auditoryB
            // 
            this.auditoryB.Location = new System.Drawing.Point(40, 48);
            this.auditoryB.Name = "auditoryB";
            this.auditoryB.Size = new System.Drawing.Size(224, 15);
            this.auditoryB.TabIndex = 5;
            // 
            // auditoryC
            // 
            this.auditoryC.Location = new System.Drawing.Point(40, 80);
            this.auditoryC.Name = "auditoryC";
            this.auditoryC.Size = new System.Drawing.Size(224, 15);
            this.auditoryC.TabIndex = 6;
            // 
            // auditoryD
            // 
            this.auditoryD.Location = new System.Drawing.Point(40, 112);
            this.auditoryD.Name = "auditoryD";
            this.auditoryD.Size = new System.Drawing.Size(224, 15);
            this.auditoryD.TabIndex = 7;
            // 
            // Auditory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 138);
            this.Controls.Add(this.auditoryD);
            this.Controls.Add(this.auditoryC);
            this.Controls.Add(this.auditoryB);
            this.Controls.Add(this.labelD);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.auditoryA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Auditory";
            this.Text = "Помощь зала";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar auditoryA;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.ProgressBar auditoryB;
        private System.Windows.Forms.ProgressBar auditoryC;
        private System.Windows.Forms.ProgressBar auditoryD;
    }
}