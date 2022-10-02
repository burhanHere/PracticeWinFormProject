using PracticeWinFormProject;

namespace WinFormsApp1
{
    public partial class ListBoxControlApp : Form
    {

        int CountNamesInList()
        {
            int nameCount = Names_listBox.Items.Count;
            NameCount_lable.Text = "Number of names in the list are " + nameCount.ToString();
            return nameCount;
        }

        public ListBoxControlApp()
        {
            InitializeComponent();
        }

        private void ListBoxControlApp_Load(object sender, EventArgs e) => CountNamesInList();

        private void Add_button_Click(object sender, EventArgs e)
        {
            if (NameInput_textBox.Text != "")
            {
                Names_listBox.Items.Add(NameInput_textBox.Text);
                NameInput_textBox.Clear();
                NameInput_textBox.Focus();
            }
            else
            {
                MainFormToOpenPracticeForms.ErrorSound.Play();
                MessageBox.Show("Please enter a name.");
            }
            CountNamesInList();
        }

        private void SortAssendingbutton_Click(object sender, EventArgs e)
        {
            if (CountNamesInList() > 0)
            {
                Names_listBox.Sorted = true;
            }
            else
            {
                MainFormToOpenPracticeForms.ErrorSound.Play();
                MessageBox.Show("No names to sort.");
            }
        }

        private void DeleteLastItemInTheList_button_Click(object sender, EventArgs e)
        {
            int LastIndex = Names_listBox.Items.Count - 1;
            if (LastIndex >= 0)
            {
                Names_listBox.Items.RemoveAt(LastIndex);
                int nameCount = Names_listBox.Items.Count;
                NameCount_lable.Text = "Number of names in the list are " + nameCount.ToString();
            }
            else
            {
                MainFormToOpenPracticeForms.ErrorSound.Play();
                MessageBox.Show("All Names Removed!");
            }
            CountNamesInList();
        }

        private void Remove_button_Click(object sender, EventArgs e)
        {
            if (RemoveName_textBox.Text != "")
            {
                if (!Names_listBox.Items.Contains(RemoveName_textBox.Text))
                {
                    MainFormToOpenPracticeForms.ErrorSound.Play();
                    MessageBox.Show("Name not found in the list.");
                }
                else
                {
                    Names_listBox.Items.Remove(RemoveName_textBox.Text);
                    int nameCount = Names_listBox.Items.Count;
                    NameCount_lable.Text = "Number of names in the list are " + nameCount.ToString();
                }
            }
            else
            {
                MainFormToOpenPracticeForms.ErrorSound.Play();
                MessageBox.Show("Enter a name in the input field.");
            }
            CountNamesInList();
        }

        private void ClearList_button_Click(object sender, EventArgs e)
        {
            Names_listBox.Items.Clear();
            CountNamesInList();
        }

        private void ListBoxControlApp_Load_1(object sender, EventArgs e)
        {

        }
    }
}