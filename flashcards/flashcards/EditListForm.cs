using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace flashcards
{
    public partial class EditListForm : Form
    {
        private MainForm MainForm;
        private List<FlashCard> FlashCards;

        public EditListForm(List<FlashCard> flashCards, MainForm mainForm)
        {
            InitializeComponent();
            this.FlashCards = flashCards;
            this.MainForm = mainForm;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView.AutoGenerateColumns = false;
            dataGridView.DataSource = FlashCards;
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string JsonString = JsonConvert.SerializeObject(FlashCards, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(MainForm.FilePath, JsonString);
        }
    }
}
