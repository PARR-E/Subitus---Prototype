using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using static System.Formats.Asn1.AsnWriter;
using System.Text.Json;
using System.Drawing.Drawing2D;

namespace Subitus___Prototype
{
    public partial class KnowTheKNote : Form
    {
        private void RoundButton(Button btn, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, btn.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            btn.Region = new Region(path);
        }

        int score = 0;

        public KnowTheKNote()
        {
            InitializeComponent();

            RoundButton(startKNote, 30);
            RoundButton(backToMenu, 30);

            startKNote.FlatStyle = FlatStyle.Flat;
            startKNote.FlatAppearance.BorderSize = 0;
            startKNote.BackColor = Color.FromArgb(206, 229, 192);
            startKNote.ForeColor = Color.Black;

            backToMenu.FlatStyle = FlatStyle.Flat;
            backToMenu.FlatAppearance.BorderSize = 0;
            backToMenu.BackColor = Color.FromArgb(206, 229, 192);
            backToMenu.ForeColor = Color.Black;

            leaderboardName.Visible = false;
            leaderboardSubmit.Visible = false;
        }

        private Dictionary<string, string> noteFiles = new Dictionary<string, string>()
        {
            { "C4", "Audio/C4.wav" },
            { "D4", "Audio/D4.wav" },
            { "A4", "Audio/A4.wav" },
            { "G4", "Audio/G4.wav" },
            { "F4", "Audio/F4.wav" },
            { "B4", "Audio/B4.wav" },
            { "F3", "Audio/F3.wav" },
            { "D6", "Audio/D6.wav" },
            { "E4", "Audio/E4.wav" },
            { "E5", "Audio/E5.wav" },
            { "C5", "Audio/C5.wav" },
            { "G3", "Audio/G3.wav" },
            { "A3", "Audio/A3.wav" },
            { "B3", "Audio/B3.wav" },
            { "D3", "Audio/D3.wav" },
            { "E3", "Audio/E3.wav" },
        };


        // Variables for use in the game
        private string currentNote;

        private bool gameStarted = false;
        private bool notePicked = false;

        private int rounds = 0;
        private const int TotalRounds = 5;

        private void PlayRandomNote()
        {
            Random random = new Random();
            var keys = noteFiles.Keys.ToList();
            currentNote = keys[random.Next(keys.Count)];
            var soundPlayer = new SoundPlayer(noteFiles[currentNote]);
            soundPlayer.Play();
        }

        private void pianoKey_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button == null) return;

            string selectedNote = button.Text;

            switch (selectedNote)
            {
                case "C4":
                case "D4":
                case "A4":
                case "G4":
                case "F4":
                case "B4":
                case "F3":
                case "D6":
                case "E4":
                case "E5":
                case "C5":
                case "G3":
                case "A3":
                case "B3":
                case "D3":
                case "E3":
                    if (noteFiles.ContainsKey(selectedNote))
                    {
                        var player = new SoundPlayer(noteFiles[selectedNote]);
                        player.Play();
                    }
                    break;
            }

            if (gameStarted == true)
            {

                CheckNoteAccuracy(selectedNote);
            }

            else
            {

            }
        }

        private void CheckNoteAccuracy(string selectedNote)
        {
            if (selectedNote == currentNote)
            {
                MessageBox.Show("Correct!");
                score = score + 20;
                UpdateRound();
            }

            else
            {
                MessageBox.Show("Incorrect!");

                UpdateRound();

                PlayRandomNote();
            }

            if (rounds > TotalRounds)
            {
                MessageBox.Show("Game complete!");
                gameStarted = false;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("You're about to exit. Are you sure?",
                                         "Exit Game?",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void startKNote_Click(object sender, EventArgs e)
        {
            PlayRandomNote();

            rounds = 1;
            roundNumberLabel.Text = "1";
            gameStarted = true;
            startKNote.Enabled = false;
        }

        private void backToMenu_Click(object sender, EventArgs e)
        {
            MainMenu menuForm = new MainMenu();
            menuForm.Show();
            this.Hide();
        }

        private void UpdateRound()
        {
            rounds++;
            roundNumberLabel.Text = rounds.ToString();

            if (rounds > TotalRounds)
            {
                backToMenu.Visible = true;
                leaderboardName.Visible = true;
                leaderboardSubmit.Visible = true;
                roundNumberLabel.Text = "-";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = leaderboardName.Text;

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter a name.");
                return;
            }

            string filePath = "jsonFile/scores.json";

            List<PlayerScore> scores = new();

            if (File.Exists(filePath))
            {
                string existingJson = File.ReadAllText(filePath);
                scores = JsonSerializer.Deserialize<List<PlayerScore>>(existingJson);
                roundNumberLabel.Text = "-";
            }

            // Add new entry to the end
            scores.Add(new PlayerScore { Name = name, Score = score });

            string newJson = JsonSerializer.Serialize(scores, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, newJson);

            MessageBox.Show("Score added!");
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            kNote_Instructions helpForm = new kNote_Instructions(); // Initializes kNote_Instructions into variable.
            helpForm.ShowDialog(); // Opens object helpForm.
        }

        private void roundLabel_Click(object sender, EventArgs e)
        {

        }
    }
}