using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Subitus___Prototype
{
    public partial class PrecisionPress : Form
    {
        //Declarations:
        Random randomizer = new Random();
        int timeToHold;                             //This is the # of seconds the player aims to match.
        int numRounds = 5;                          //The number of rounds elapsed.
        int currentRound = 1;                       //The current round.
        double timeBetwClicks = 0.0;                      //Keeps track of the time the player counts.
        double timeBetwRounds = 5;                  //The # of seconds between rounds.
        bool timerIsTicking = false;                //Equals true between button clicks.                      
        string instructionsText = "Instructions: \nThe goal is to see how accurate you are at counting the number of seconds specified above.\nClick the button, then click it again after the specified number of seconds has passed.\nThe closer you are to the actual time, the more points you will earn.";
        int score = 0;
        Color sage = Color.FromArgb(212, 232, 193);

        public PrecisionPress()
        {
            InitializeComponent();

            //Set Random value for the time to hold:
            timeToHold = randomizer.Next(1, 11);

            //Update the amount of time the game tells the user to hold for:
            label0.Text = "Time to hold the button for: " + timeToHold.ToString();
            lbl_instructions.Text = instructionsText;

            //Text that displays when the number of rounds is up:
            btn_return.Text = "Game Over\nReturn to menu.";
            btn_return.Visible = false;
            submitName.Visible = false;
            textBox1.Visible = false;
        }

        //Executes every timer tick:
        private void timer1_Tick(object sender, EventArgs e)
        {
            timerIsTicking = true;
            //Set the # of MS for the tick speed:
            timer1.Interval = 500;
            timeBetwClicks += 0.5;
            //Debug.WriteLine("Time held " + timeBetwClicks);

            //If button not pressed within 30 seconds, the player took to long.
            if (timeBetwClicks > 30)
            {
                //This needs to be BEFORE the timer stops ticking.
                timerIsTicking = false;
                timer1.Stop();
                lbl_instructions.Text = "Feedback:\nYou took too long.";
                timer_betwRounds.Start();
            }
        }


        //Starts a timer when the button is clicked, stops timer when clicked again:
        private void button1_Click(object sender, EventArgs e)
        {
            //When the button is clicked while the timer isn't ticking yet:
            if (!timerIsTicking)
            {
                //timeToHold = randomizer.Next(1, 11);
                //timeBetwClicks = 0;
                timer1.Start();
                timerIsTicking = true;
                button1.Text = "Is Held";
                button1.BackColor = Color.Green;
            }
            else  //When the button is clicked while timer is ticking. Ends round:
            {
                timer1.Stop();
                timerIsTicking = false;
                label2.Text = "Time you held it for: " + timeBetwClicks.ToString();
                lbl_roundsLeft.Text = "Time until next round: " + timeBetwRounds.ToString();
                button1.Text = " ";
                button1.BackColor = sage;

                //Determening feedback to print for the user:
                if (timeBetwClicks == (double)timeToHold)
                {
                    lbl_instructions.Text = "Feedback:\nPerfect! You were spot-on!";
                    score = score + 30;
                }
                else if (timeBetwClicks == (double)timeToHold - 0.5 || timeBetwClicks == (double)timeToHold + 0.5)
                {
                    lbl_instructions.Text = "Feedback:\nSo close! You were just 0.5 seconds off.";
                    score = score + 20;
                }
                else if (timeBetwClicks == (double)timeToHold - 1.0 || timeBetwClicks == (double)timeToHold + 1.0)
                {
                    lbl_instructions.Text = "Feedback:\nAww, you were 1 second off.";
                    score = score + 10;
                }
                else
                {
                    lbl_instructions.Text = "Feedback:\nToo bad. You were more than 1 second off.";
                }
                timer_betwRounds.Start();
            }
        }

        private void label0_Click(object sender, EventArgs e)
        {

        }

        //Stuff to display during the time between rounds:
        private void timer_betwRounds_Tick(object sender, EventArgs e)
        {
            timer_betwRounds.Interval = 1000;
            timeBetwRounds -= 1.0;
            lbl_roundsLeft.Text = "Time until next round: " + timeBetwRounds.ToString();

            //SRS says 0.5 seconds, but a longer time is better.
            //When time between roudnds is up, reset everything for a new round:
            if (timeBetwRounds < 1)
            {
                //Increment the current roun we're on:
                currentRound++;
                lbl_roundsLeft.Text = "Current Round: #" + currentRound.ToString();
                timeBetwRounds = 5;

                timeToHold = randomizer.Next(1, 11);
                timeBetwClicks = 0;

                label0.Text = "Time to hold the button for: " + timeToHold.ToString();
                label2.Text = "Time you held it for: (not held yet)";
                button1.Text = "Hold Now";
                lbl_instructions.Text = instructionsText;

                //If 5 rounds have passed, replace the button with a different button that returns the user to the menu:
                if (currentRound > numRounds)
                {
                    button1.Visible = false;
                    btn_return.Visible = true;
                    submitName.Visible = true;
                    textBox1.Visible = true;
                }

                timer_betwRounds.Stop();
            }

        }

        //When this button is clicked, the user returns to the main menu:
        private void btn_return_Click(object sender, EventArgs e)
        {
            MainMenu menuForm = new MainMenu();
            menuForm.Show();
            this.Hide();
        }

        private void submitName_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;

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
            }

            // Add new entry to the end
            scores.Add(new PlayerScore { Name = name, Score = score });

            string newJson = JsonSerializer.Serialize(scores, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, newJson);

            MessageBox.Show("Score added!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_roundsLeft_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_instructions_Click(object sender, EventArgs e)
        {

        }

        //Once current round > num rounds, replace the button with a back button that takes you to main menu.
    }
}
