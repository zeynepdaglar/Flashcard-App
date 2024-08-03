using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flashcards
{
    public partial class SelectGroupNameForm : Form
    {
        #region Fields
        private MainForm MainForm;
        private List<FlashCard> flashcards;
        private Dictionary<string, GroupName> GroupNames;
        private List<FlashCard> SelectedGroup;
        #endregion

        public SelectGroupNameForm(List<FlashCard> flashcards, MainForm mainForm)
        {
            InitializeComponent();

            this.flashcards = flashcards;
            this.MainForm = mainForm;

            GroupNames = new Dictionary<string, GroupName>();

            GetGroupNames();
            dataGridView.AutoGenerateColumns = false;
        }

        private void SelectGroup_Load(object sender, EventArgs e)
        {

        }

        public void GetGroupNames()
        {
            foreach (var item in flashcards)
            {
                if (!GroupNames.ContainsKey(item.Group))
                {
                    GroupNames[item.Group] = new GroupName() { Group = item.Group };
                }
                else
                {
                    continue;
                }
            }
            var source = dataGridView.DataSource = GroupNames.Values.ToList();
        }

        public string GetSelectedGroupName()
        {
            var selectedGroup = dataGridView.CurrentRow?.DataBoundItem as GroupName;

            return selectedGroup?.Group;
        }

        private void buttonStartQuiz_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(GetSelectedGroupName()))
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("please select your group");
            }
        }
    }
}
