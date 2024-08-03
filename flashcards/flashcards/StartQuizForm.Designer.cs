namespace flashcards
{
    partial class StartQuizForm
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
            this.labelTimer = new System.Windows.Forms.Label();
            this.wrong = new System.Windows.Forms.PictureBox();
            this.correct = new System.Windows.Forms.PictureBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.labelKeyWord = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.correct)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTimer
            // 
            this.labelTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTimer.AutoSize = true;
            this.labelTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTimer.Location = new System.Drawing.Point(476, 83);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(60, 24);
            this.labelTimer.TabIndex = 16;
            this.labelTimer.Text = "label1";
            this.labelTimer.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // wrong
            // 
            this.wrong.BackColor = System.Drawing.Color.Firebrick;
            this.wrong.Location = new System.Drawing.Point(376, 260);
            this.wrong.Name = "wrong";
            this.wrong.Size = new System.Drawing.Size(27, 29);
            this.wrong.TabIndex = 15;
            this.wrong.TabStop = false;
            this.wrong.Visible = false;
            // 
            // correct
            // 
            this.correct.BackColor = System.Drawing.Color.ForestGreen;
            this.correct.Location = new System.Drawing.Point(343, 260);
            this.correct.Name = "correct";
            this.correct.Size = new System.Drawing.Size(27, 29);
            this.correct.TabIndex = 14;
            this.correct.TabStop = false;
            this.correct.Visible = false;
            // 
            // textBox
            // 
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox.Location = new System.Drawing.Point(199, 260);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(138, 29);
            this.textBox.TabIndex = 13;
            this.textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // labelKeyWord
            // 
            this.labelKeyWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKeyWord.Location = new System.Drawing.Point(199, 213);
            this.labelKeyWord.Name = "labelKeyWord";
            this.labelKeyWord.Size = new System.Drawing.Size(138, 33);
            this.labelKeyWord.TabIndex = 12;
            this.labelKeyWord.Text = "label1";
            this.labelKeyWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelScore
            // 
            this.labelScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelScore.Location = new System.Drawing.Point(476, 45);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(60, 24);
            this.labelScore.TabIndex = 17;
            this.labelScore.Text = "label2";
            this.labelScore.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // StartQuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 503);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.wrong);
            this.Controls.Add(this.correct);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.labelKeyWord);
            this.Name = "StartQuizForm";
            this.Text = "StartQuizForm";
            this.Load += new System.EventHandler(this.StartQuizForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.correct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.PictureBox wrong;
        private System.Windows.Forms.PictureBox correct;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label labelKeyWord;
        private System.Windows.Forms.Label labelScore;
    }
}