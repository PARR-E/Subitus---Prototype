using System.Text.Json;

namespace Subitus___Prototype
{
    public partial class LeaderboardForm : Form
    {
        public Form mainMenu;
        public LeaderboardForm()
        {
            InitializeComponent();



        }

        private void BackButton_Click(object sender, EventArgs e)
        {

            mainMenu.Show();
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LeaderboardForm_Load(object sender, EventArgs e)
        {
            LoadLeaderboard();
        }

        private List<PlayerScore> LoadScores(string filePath)
        {
            // Check if the file exists; if it doesn't, return an empty list
            if (!File.Exists(filePath))
                return new List<PlayerScore>();

            // Read the JSON file
            string json = File.ReadAllText(filePath);

            // Deserialize the JSON data into a list of PlayerScore objects
            return JsonSerializer.Deserialize<List<PlayerScore>>(json);
        }


        private void LoadLeaderboard()
        {
            string jsonPath = "jsonFile/scores.json";
            var scores = LoadScores(jsonPath); // Assuming LoadScores method is already defined

            // Sort the list in descending order by score
            var sortedScores = scores.OrderByDescending(score => score.Score).ToList();

            // Clear the ListBox before loading new data
            listBoxLeaderboard.Items.Clear();

            // Populate ListBox with sorted scores
            foreach (var score in sortedScores)
            {
                listBoxLeaderboard.Items.Add($"{score.Name} - {score.Score} pts");
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }

    public class PlayerScore
    {
        public string Name { get; set; }
        public int Score { get; set; }
    }

}
