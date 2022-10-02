namespace WinFormsApp1
{
    public partial class FirstAppWhichDisplayNamesInLabelsApp : Form
    {
        public FirstAppWhichDisplayNamesInLabelsApp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(textBox1.Text);
            //MessageBox.Show("Name you entered is " + textBox1.Text);
            label2.Text = textBox1.Text;
        }
    }
}
