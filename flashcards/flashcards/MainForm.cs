using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;
using System.Xml;
using Newtonsoft.Json;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using System.Data;

namespace flashcards
{
    public partial class MainForm : Form
    {
        #region Fields
        public List<FlashCard> flashcards;
        public List<FlashCard> SelectedCollection;
        public DataTable DataTable;

        public string FilePath = "C:\\Users\\zeynep\\source\\repos\\flashcards\\flashcards\\WordList.txt";
        #endregion

        public MainForm()
        {
            InitializeComponent();

            flashcards = GetWordList();
            string Type;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            SelectGroupNameForm SelectGroupNameForm = new SelectGroupNameForm(flashcards, this);
            QuizTypeSelectorForm QuizTypeSelectorForm = new QuizTypeSelectorForm(this);

            var Result = SelectGroupNameForm.ShowDialog();
            if (Result != DialogResult.OK) return;

            QuizTypeSelectorForm.ShowDialog();
            if (Result != DialogResult.OK) return;

            var SelectedGroupName = SelectGroupNameForm.GetSelectedGroupName(); // todo implement
            StartQuizForm StartQuizForm = new StartQuizForm(flashcards, QuizTypeSelectorForm.Type, SelectedGroupName);

            StartQuizForm.ShowDialog();
        }
        private void AddNewWord_Click(object sender, EventArgs e)
        {
            AddNewWordForm AddNewWordForm = new AddNewWordForm(this);

            var Result = AddNewWordForm.ShowDialog();
            if (Result == DialogResult.OK)
            {
                flashcards.Add(AddNewWordForm.FlashCard);

                string JsonString = JsonConvert.SerializeObject(flashcards, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(FilePath, JsonString);
            }
        }
        public void AddWord(string group ,string word, string meaning)
        {
            var ExistingFlashcard = flashcards.FirstOrDefault(fc => fc.Word == word);
            if (ExistingFlashcard != null)
            {
                MessageBox.Show("This word already exists");
            }
            else
            {
                flashcards.Add(new FlashCard {Group = group, Word = word, Meaning = meaning });
                MessageBox.Show("Added " + word);
            }

            SaveWordList();
        }
        private void ViewList(object sender, EventArgs e)
        {
            EditListForm EditListForm = new EditListForm(flashcards, this);
            EditListForm.ShowDialog();
        }
        private List<FlashCard> GetWordList()
        {
            var FilePath = "C:\\Users\\zeynep\\source\\repos\\flashcards\\flashcards\\WordList.txt";
            var FileText = File.ReadAllText(FilePath);

            var FlashCards = JsonConvert.DeserializeObject<List<FlashCard>>(FileText);
            return FlashCards;
        }
        private void SaveWordList()
        {
            var JsonText = JsonConvert.SerializeObject(flashcards, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(FilePath, JsonText);
        }
    }
}
