namespace Client
{
    partial class Player
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
            this.tbxQuestion = new System.Windows.Forms.TextBox();
            this.ucAnswerA = new Client.ucAnswer();
            this.ucAnswerB = new Client.ucAnswer();
            this.ucAnswerC = new Client.ucAnswer();
            this.ucAnswerD = new Client.ucAnswer();
            this.SuspendLayout();
            // 
            // tbxQuestion
            // 
            this.tbxQuestion.Location = new System.Drawing.Point(56, 231);
            this.tbxQuestion.Multiline = true;
            this.tbxQuestion.Name = "tbxQuestion";
            this.tbxQuestion.Size = new System.Drawing.Size(981, 158);
            this.tbxQuestion.TabIndex = 0;
            // 
            // ucAnswerA
            // 
            this.ucAnswerA.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ucAnswerA.LaCauTraLoi = false;
            this.ucAnswerA.Location = new System.Drawing.Point(56, 419);
            this.ucAnswerA.Name = "ucAnswerA";
            this.ucAnswerA.NoiDung = "";
            this.ucAnswerA.Size = new System.Drawing.Size(476, 62);
            this.ucAnswerA.TabIndex = 1;
            this.ucAnswerA.TieuDe = "A";
            // 
            // ucAnswerB
            // 
            this.ucAnswerB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ucAnswerB.LaCauTraLoi = false;
            this.ucAnswerB.Location = new System.Drawing.Point(561, 419);
            this.ucAnswerB.Name = "ucAnswerB";
            this.ucAnswerB.NoiDung = "";
            this.ucAnswerB.Size = new System.Drawing.Size(476, 62);
            this.ucAnswerB.TabIndex = 2;
            this.ucAnswerB.TieuDe = "B";
            // 
            // ucAnswerC
            // 
            this.ucAnswerC.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ucAnswerC.LaCauTraLoi = false;
            this.ucAnswerC.Location = new System.Drawing.Point(56, 523);
            this.ucAnswerC.Name = "ucAnswerC";
            this.ucAnswerC.NoiDung = "";
            this.ucAnswerC.Size = new System.Drawing.Size(476, 62);
            this.ucAnswerC.TabIndex = 3;
            this.ucAnswerC.TieuDe = "C";
            // 
            // ucAnswerD
            // 
            this.ucAnswerD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ucAnswerD.LaCauTraLoi = false;
            this.ucAnswerD.Location = new System.Drawing.Point(561, 523);
            this.ucAnswerD.Name = "ucAnswerD";
            this.ucAnswerD.NoiDung = "";
            this.ucAnswerD.Size = new System.Drawing.Size(476, 62);
            this.ucAnswerD.TabIndex = 4;
            this.ucAnswerD.TieuDe = "D";
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 643);
            this.Controls.Add(this.ucAnswerD);
            this.Controls.Add(this.ucAnswerC);
            this.Controls.Add(this.ucAnswerB);
            this.Controls.Add(this.ucAnswerA);
            this.Controls.Add(this.tbxQuestion);
            this.Name = "Player";
            this.Text = "Player";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxQuestion;
        private ucAnswer ucAnswerA;
        private ucAnswer ucAnswerB;
        private ucAnswer ucAnswerC;
        private ucAnswer ucAnswerD;
    }
}