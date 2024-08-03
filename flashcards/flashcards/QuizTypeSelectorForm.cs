using System;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace flashcards
{

    internal class QuizTypeSelectorForm : Form
    {
        #region Fields
        public AddNewWord Type;
        private Button ButtonENG;
        private Button ButtonTUR;
        private System.Windows.Forms.Label label1;
        #endregion

        public QuizTypeSelectorForm(MainForm mainForm)
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.ButtonENG = new System.Windows.Forms.Button();
            this.ButtonTUR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonENG
            // 
            this.ButtonENG.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonENG.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonENG.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonENG.Location = new System.Drawing.Point(132, 183);
            this.ButtonENG.Name = "ButtonENG";
            this.ButtonENG.Size = new System.Drawing.Size(227, 50);
            this.ButtonENG.TabIndex = 0;
            this.ButtonENG.Text = "English - Turkish";
            this.ButtonENG.UseVisualStyleBackColor = false;
            this.ButtonENG.Click += new System.EventHandler(this.ButtonEng_Click);
            // 
            // ButtonTUR
            // 
            this.ButtonTUR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonTUR.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonTUR.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonTUR.ForeColor = System.Drawing.Color.Black;
            this.ButtonTUR.Location = new System.Drawing.Point(132, 258);
            this.ButtonTUR.Name = "ButtonTUR";
            this.ButtonTUR.Size = new System.Drawing.Size(227, 50);
            this.ButtonTUR.TabIndex = 1;
            this.ButtonTUR.Text = "Turkish - English";
            this.ButtonTUR.UseVisualStyleBackColor = false;
            this.ButtonTUR.Click += new System.EventHandler(this.ButtonTUR_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(132, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Quiz type";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // QuizTypeSelectorForm
            // 
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonTUR);
            this.Controls.Add(this.ButtonENG);
            this.Name = "QuizTypeSelectorForm";
            this.Load += new System.EventHandler(this.QuizTypeSelector_Load);
            this.ResumeLayout(false);

        }
        private void QuizTypeSelector_Load(object sender, EventArgs e)
        {

        }
        private void ButtonEng_Click(object sender, EventArgs e)
        {
            Type = AddNewWord.EngTur;
            this.DialogResult = DialogResult.OK;
        }
        private void ButtonTUR_Click(object sender, EventArgs e)
        {
            Type = AddNewWord.TurEng;
            this.DialogResult = DialogResult.OK;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}