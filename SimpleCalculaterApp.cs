namespace WinFormsApp1
{
    public partial class SimpleCalculaterApp : Form
    {
        public SimpleCalculaterApp()
        {
            InitializeComponent();
        }
        double UserInput = 0;
        char SelectedOperator;

        private void Num0_button_Click(object sender, EventArgs e)
        {
            Input_textBox.Text += "0";
        }
        private void Num1_button_Click(object sender, EventArgs e)
        {
            Input_textBox.Text += "1";
        }

        private void Num2_button_Click(object sender, EventArgs e)
        {

            Input_textBox.Text += "2";
        }

        private void Num3_button_Click(object sender, EventArgs e)
        {
            Input_textBox.Text += "3";
        }

        private void Num4_button_Click(object sender, EventArgs e)
        {
            Input_textBox.Text += "4";
        }

        private void Num5_button_Click(object sender, EventArgs e)
        {
            Input_textBox.Text += "5";
        }

        private void Num6_button_Click(object sender, EventArgs e)
        {
            Input_textBox.Text += "6";
        }

        private void Num7_button_Click(object sender, EventArgs e)
        {
            Input_textBox.Text += "7";
        }

        private void Num8_button_Click(object sender, EventArgs e)
        {
            Input_textBox.Text += "8";
        }

        private void Num9_button_Click(object sender, EventArgs e)
        {
            Input_textBox.Text += "9";
        }

        private void decimalPoint_button_Click(object sender, EventArgs e)
        {
            Input_textBox.Text += ".";
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            SelectedOperator = '+';
            UserInput = Double.Parse(Input_textBox.Text);
            Input_textBox.Text = string.Empty;
        }

        private void Subtract_button_Click(object sender, EventArgs e)
        {
            SelectedOperator = '-';
            UserInput = Double.Parse(Input_textBox.Text);
            Input_textBox.Text = string.Empty;
        }

        private void Devide_button_Click(object sender, EventArgs e)
        {
            SelectedOperator = '/';
            UserInput = Double.Parse(Input_textBox.Text);
            Input_textBox.Text = string.Empty;
        }

        private void Multiply_button_Click(object sender, EventArgs e)
        {
            SelectedOperator = '*';
            UserInput = Double.Parse(Input_textBox.Text);
            Input_textBox.Text = string.Empty;
        }

        private void Equals_button_Click(object sender, EventArgs e)
        {
            if (SelectedOperator == '+')
            {
                UserInput += Double.Parse(Input_textBox.Text);
            }
            else if (SelectedOperator == '-')
            {
                UserInput -= Double.Parse(Input_textBox.Text);
            }
            else if (SelectedOperator == '*')
            {
                UserInput *= Double.Parse(Input_textBox.Text);
            }
            else if (SelectedOperator == '/')
            {
                UserInput /= Double.Parse(Input_textBox.Text);
            }
            Input_textBox.Text = UserInput.ToString();
        }

        private void C_button_Click(object sender, EventArgs e)
        {
            UserInput = 0;
            SelectedOperator = '\0';
            Input_textBox.Text = string.Empty;
        }

        private void Equals_button_Enter(object sender, EventArgs e)
        {

        }
    }
}
