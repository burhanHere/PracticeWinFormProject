using System.Media;
using WinFormsApp1;

namespace PracticeWinFormProject
{
    public partial class MainFormToOpenPracticeForms : Form
    {
        public static SoundPlayer ErrorSound = new SoundPlayer(@"D:\CSharp\WinFormsByLearningNeverEnds\PracticeWinFormProject\PracticeWinFormProject\off-hook-tone-43891-Trimed.wav");
        public MainFormToOpenPracticeForms()
        {
            InitializeComponent();
        }

        private void FirstAppWhichDisplayNamesInLabels_button_Click(object sender, EventArgs e)
        {
            var FormToBeOpened = new FirstAppWhichDisplayNamesInLabelsApp();
            FormToBeOpened.Show();
        }

        private void SimpleCalculator_button_Click(object sender, EventArgs e)
        {
            var FormToBeOpened = new SimpleCalculaterApp();
            FormToBeOpened.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var FormToBeOpened = new ListBoxControlApp();
            FormToBeOpened.Show();
        }

        private void ComboBox_button_Click(object sender, EventArgs e)
        {
            var FromToBeOpened = new ComboBoxControlApp();
            FromToBeOpened.Show();
        }
    }
}
