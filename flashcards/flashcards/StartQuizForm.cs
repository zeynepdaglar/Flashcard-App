using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace flashcards
{
    public partial class StartQuizForm : Form
    {
        #region Fields
        MainForm MainForm;

        private int score;
        private int questionCount = 0;
        private Timer timer;

        private AddNewWord type;
        private Queue<FlashCard> Questions;
        private List<FlashCard> flashcards;
        private List<FlashCard> selectedFlashcards;
        private string selectedGroupName;
        private int timeLeftToAnswer;
        #endregion

        public StartQuizForm(List<FlashCard> flashcards, AddNewWord type, string selectedGroupName)
        {
            InitializeComponent();

            Questions = new Queue<FlashCard>();

            wrong.Left = correct.Left;
            
            this.type = type;
            this.flashcards = flashcards;
            this.selectedGroupName = Convert.ToString(selectedGroupName);

            selectedFlashcards = GetSelectedFlashcards();
        }

        private List<FlashCard> GetSelectedFlashcards() 
        {
            var selectedFlashcards = new List<FlashCard>();

            foreach (var item in flashcards)
            {
                if (item.Group == selectedGroupName)
                {
                    selectedFlashcards.Add(item);
                }
            }
            return selectedFlashcards;
        } 

        private void StartQuizForm_Load(object sender, EventArgs e)
        {
            StartQuiz();
        }

        private void StartQuiz()
        {
            #region Timer
            timer = new Timer();
            timer.Interval = 1000; //her bu kadar milisaniyede bir bir kere çalışır 
            timeLeftToAnswer = 10; //toplam süre 
            timer.Tick += new EventHandler(timer_Tick);
            timer.Enabled = true;
            labelTimer.Text = $"{timeLeftToAnswer} second";
            #endregion

            Dictionary<string, bool> usedWords = new Dictionary<string, bool>();

            var Random = new Random();
            int i = 0;

            Questions.Clear();

            timer.Start();

            while (i < selectedFlashcards.Count)
            {
                var index = Random.Next(0, selectedFlashcards.Count);
                var selectedFlashcard = selectedFlashcards[index];

                if (type == AddNewWord.EngTur)
                {
                    if (!usedWords.ContainsKey(selectedFlashcard.Word))
                    {
                        Questions.Enqueue(selectedFlashcard);
                        usedWords[selectedFlashcard.Word] = true;
                        i++;
                    }
                }
                else
                {
                    if (!usedWords.ContainsKey(selectedFlashcard.Meaning))
                    {
                        Questions.Enqueue(selectedFlashcard);
                        usedWords[selectedFlashcard.Word] = true;
                        i++;
                    }
                }

                ShowNextQuestion(type);
            }

            score = 0;
            ShowScore();
        }

        private void ShowNextQuestion(AddNewWord type)
        {
            timeLeftToAnswer = 6;
            timer.Start();

            if (type == AddNewWord.EngTur)
            {
                labelKeyWord.Text = Questions.Peek().Word;
            }
            else
            {
                labelKeyWord.Text = Questions.Peek().Meaning;
            }

            textBox.Clear();
        }

        private void IsAnswerCorrect()
        {
            timer.Stop();

            if (type == AddNewWord.EngTur)
            {
                var question = Questions.Dequeue();
                var input = textBox.Text.Trim().ToLower();
                var expectedValue = question.Meaning;
                bool isCorrect = input == expectedValue;

                score += isCorrect
                    ? 1
                    : -1;
                questionCount++;

                ShowIcon(isCorrect);
            }
            else
            {
                var question = Questions.Dequeue();
                var input = textBox.Text.Trim().ToLower();
                var expectedValue = question.Word;
                bool isCorrect = input == expectedValue;

                score += isCorrect
                    ? 1
                    : -1;
                questionCount++;

                ShowIcon(isCorrect);
            }

            if (questionCount >= 10)
            {
                ShowMessage();
            }
            else
            {
                ShowScore();
                ShowNextQuestion(type);
            }
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                IsAnswerCorrect();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //her bir saniyede bu işlemi yapar
            if (timeLeftToAnswer > 0)
            {
                timeLeftToAnswer--;
                labelTimer.Text = $"{timeLeftToAnswer} score";
            }
            else
            {
                IsAnswerCorrect();
            }
        }

        private void ShowScore()
        {
            labelScore.Text = $"score: {score}";
        }
        
        private void ShowMessage()
        {
            MessageBox.Show($"Game Over Your score: {score}");
        }

        private void ShowIcon(bool isCorrect)
        {
            if (isCorrect == true)
            {
                correct.Visible = true;
                wrong.Visible = false;
            }
            else
            {
                correct.Visible = false;
                wrong.Visible = true;
            }
        }
    }
}
