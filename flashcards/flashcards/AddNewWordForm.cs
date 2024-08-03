using flashcards;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

public class AddNewWordForm : Form
{
    private MainForm MainForm;
    private Label LabelWord;
    private Button ButtonAdd;
    private Label LabelMeaning;
    private TextBox TextBoxWord;
    private Label label1;
    private TextBox textBoxGroupName;
    private TextBox TextBoxMeaning;
    public FlashCard FlashCard { get; set; }

    public AddNewWordForm(MainForm mainForm)
    {
        InitializeComponent();
        this.MainForm = mainForm;
        this.Text = "AddNewWordForm";
    }
    private void InitializeComponent()
    {
            this.TextBoxWord = new System.Windows.Forms.TextBox();
            this.LabelWord = new System.Windows.Forms.Label();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.TextBoxMeaning = new System.Windows.Forms.TextBox();
            this.LabelMeaning = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxGroupName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TextBoxWord
            // 
            this.TextBoxWord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TextBoxWord.Location = new System.Drawing.Point(212, 222);
            this.TextBoxWord.Name = "TextBoxWord";
            this.TextBoxWord.Size = new System.Drawing.Size(207, 29);
            this.TextBoxWord.TabIndex = 0;
            // 
            // LabelWord
            // 
            this.LabelWord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelWord.AutoSize = true;
            this.LabelWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelWord.Location = new System.Drawing.Point(215, 184);
            this.LabelWord.Name = "LabelWord";
            this.LabelWord.Size = new System.Drawing.Size(66, 24);
            this.LabelWord.TabIndex = 1;
            this.LabelWord.Text = "Word :";
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAdd.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonAdd.Location = new System.Drawing.Point(212, 385);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(207, 50);
            this.ButtonAdd.TabIndex = 2;
            this.ButtonAdd.Text = "Add New";
            this.ButtonAdd.UseVisualStyleBackColor = false;
            this.ButtonAdd.Click += new System.EventHandler(this.buttonAdd_Click_1);
            // 
            // TextBoxMeaning
            // 
            this.TextBoxMeaning.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxMeaning.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TextBoxMeaning.Location = new System.Drawing.Point(212, 308);
            this.TextBoxMeaning.Name = "TextBoxMeaning";
            this.TextBoxMeaning.Size = new System.Drawing.Size(207, 29);
            this.TextBoxMeaning.TabIndex = 3;
            // 
            // LabelMeaning
            // 
            this.LabelMeaning.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelMeaning.AutoSize = true;
            this.LabelMeaning.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelMeaning.Location = new System.Drawing.Point(208, 272);
            this.LabelMeaning.Name = "LabelMeaning";
            this.LabelMeaning.Size = new System.Drawing.Size(94, 24);
            this.LabelMeaning.TabIndex = 4;
            this.LabelMeaning.Text = "Meaning :";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(215, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Group :";
            // 
            // textBoxGroupName
            // 
            this.textBoxGroupName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxGroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxGroupName.Location = new System.Drawing.Point(212, 127);
            this.textBoxGroupName.Name = "textBoxGroupName";
            this.textBoxGroupName.Size = new System.Drawing.Size(207, 29);
            this.textBoxGroupName.TabIndex = 5;
            // 
            // AddNewWordForm
            // 
            this.ClientSize = new System.Drawing.Size(637, 581);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxGroupName);
            this.Controls.Add(this.LabelMeaning);
            this.Controls.Add(this.TextBoxMeaning);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.LabelWord);
            this.Controls.Add(this.TextBoxWord);
            this.Name = "AddNewWordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }
    private void Form2_Load(object sender, EventArgs e)
    {

    }
    
    private void buttonAdd_Click(object sender, EventArgs e)
    {
        string Group = textBoxGroupName.Text.Trim();
        string Word = TextBoxWord.Text.Trim();
        string Meaning = TextBoxMeaning.Text.Trim();

        if (!string.IsNullOrEmpty(Group) && !string.IsNullOrEmpty(Word) && !string.IsNullOrEmpty(Meaning))
        {
            MainForm.AddWord(Group, Word, Meaning);
            this.Close();
        }
        else
        {
            MessageBox.Show("Please enter your word");
        }
    }
    private void buttonAdd_Click_1(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(textBoxGroupName.Text) || string.IsNullOrWhiteSpace(TextBoxWord.Text) || string.IsNullOrWhiteSpace(TextBoxMeaning.Text))
        {
            MessageBox.Show("Please enter the words");
            return;
        }

        FlashCard = new FlashCard();
        FlashCard.Group = textBoxGroupName.Text;
        FlashCard.Word = TextBoxWord.Text;
        FlashCard.Meaning = TextBoxMeaning.Text;

        MainForm.AddWord(FlashCard.Group ,FlashCard.Word, FlashCard.Meaning);
        this.DialogResult = DialogResult.OK;
    }

}
