using static System.Windows.Forms.Design.AxImporter;

namespace Subitus___Prototype
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            //display new form
            PrecisionPress ppForm = new PrecisionPress();
            KnowTheKNote knowNoteForm = new KnowTheKNote();
            AnalyzeTheAngle ataForm = new AnalyzeTheAngle();
            ObserveTheObjects otoForm = new ObserveTheObjects();

            int selectedIndex = gameSelection.SelectedIndex;

            if (selectedIndex == -1)
            {
                MessageBox.Show("Please select a Game to play.");
            }
            //KnowTheKNote
            else if (selectedIndex == 0)
            {
                knowNoteForm.Show();
                //hide the current form:
                this.Hide();
            }
            //PrecisionPress
            else if (selectedIndex == 1)
            {
                ppForm.Show();
                //hide the current form:
                this.Hide();
            }
            //Analyze The Angles
            else if (selectedIndex == 2)
            {
                ataForm.Show();
                //hide the current form:
                this.Hide();
            }
            //Observe The Objects
            else if (selectedIndex == 3)
            {
                otoForm.Show();
                //hide the current form:
                this.Hide();
            }
            else
            {
                MessageBox.Show("Unexpected selection.");
            }



        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            Settings settingsForm = new Settings(); // Initializes SettingsForm into variable.
            settingsForm.ShowDialog(); // Opens object settingsForm.
        }

        private void lbButton_Click(object sender, EventArgs e)
        {
            LeaderboardForm leaderboardForm = new LeaderboardForm();
            MainMenu mainMenu = this;
            leaderboardForm.mainMenu = mainMenu;
            leaderboardForm.Show();
            mainMenu.Hide();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}