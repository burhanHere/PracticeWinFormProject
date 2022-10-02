namespace PracticeWinFormProject
{
    public partial class ComboBoxControlApp : Form
    {
        public void counteItems()
        {
            int count = comboBox1.Items.Count;
            ListItemCount_label.Text = "Number of items in the list are " + count.ToString() + '.';

        }
        public ComboBoxControlApp()
        {
            InitializeComponent();
            counteItems();
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (textBox1.Text[0] >= 'A' && textBox1.Text[0] <= 'Z')
                {
                    if (!(comboBox1.Items.Contains(textBox1.Text)))
                    {
                        comboBox1.Items.Add(textBox1.Text);
                        MessageBox.Show("Item added successfully.");
                        counteItems();
                    }
                    else
                    {
                        MainFormToOpenPracticeForms.ErrorSound.Play();
                        MessageBox.Show("Item Already Exist in the list.");
                    }
                }
                else
                {
                    MainFormToOpenPracticeForms.ErrorSound.Play();
                    MessageBox.Show("Keep the first latter capital.\n");
                }
            }
            else
            {
                MainFormToOpenPracticeForms.ErrorSound.Play();
                MessageBox.Show("Please Fill the input field.");
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text != "")
                {
                    if (textBox1.Text[0] >= 'A' && textBox1.Text[0] <= 'Z')
                    {
                        if (!(comboBox1.Items.Contains(textBox1.Text)))
                        {
                            comboBox1.Items.Add(textBox1.Text);
                            MessageBox.Show("Item added successfully.");
                            counteItems();
                        }
                        else
                        {
                            MainFormToOpenPracticeForms.ErrorSound.Play();
                            MessageBox.Show("Item Already Exist in the list.");
                        }
                    }
                    else
                    {
                        MainFormToOpenPracticeForms.ErrorSound.Play();
                        MessageBox.Show("Keep the first latter capital.\n");
                    }
                }
                else
                {
                    MainFormToOpenPracticeForms.ErrorSound.Play();
                    MessageBox.Show("Please Fill the input field.");
                }
            }
        }

        private void Remove_button_Click(object sender, EventArgs e)
        {
            if (RemoveItemInput_textBox.Text != "")
            {
                if (comboBox1.Items.Contains(RemoveItemInput_textBox.Text))
                {
                    comboBox1.Items.Remove(RemoveItemInput_textBox.Text);
                    MessageBox.Show("Item removed successfully.");
                    counteItems();
                }
                else
                {
                    MainFormToOpenPracticeForms.ErrorSound.Play();
                    MessageBox.Show("Item not found in the list.");
                }
            }
            else
            {
                MainFormToOpenPracticeForms.ErrorSound.Play();
                MessageBox.Show("PLease fill the Remove Item input field.");
            }
        }

        private void ClearList_button_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count != 0)
            {
                comboBox1.Items.Clear();
                counteItems();
                MessageBox.Show("List cleared.");
            }
            else
            {
                MainFormToOpenPracticeForms.ErrorSound.Play();
                MessageBox.Show("This is already empty.");
            }
        }
        private void Sort_button_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count != 0)
            {
                if (comboBox1.Sorted != true)
                {
                    comboBox1.Sorted = true;
                    MessageBox.Show("List Sorted.");
                }
                else
                {
                    MainFormToOpenPracticeForms.ErrorSound.Play();
                    MessageBox.Show("Items are already sorted.");
                }
            }
            else
            {
                MainFormToOpenPracticeForms.ErrorSound.Play();
                MessageBox.Show("Nothing to sort.\nList is Empty.");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedItem_label.Visible = true;
            selectedItem_label.Text = comboBox1.SelectedItem.ToString() + " is selected.";
        }
    }
}
