using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Subitus___Prototype
{
    public partial class ObserveTheObjects : Form
    {
        //Variable initializations here:
        Random randomizer = new Random();
        string instructionsText = "Instructions: \nObjects will flash on screen for 0.5 to 2 seconds.\nAfterwards, you will enter the number of objects you saw.\nYour score will be based on your accuracy.";
        int numRounds = 5;                          //The number of rounds elapsed.
        int currentRound = 1;                       //The current round.

        int shapesShown = 0;                        //The number of shapes shown per round.
        double timeShapesShown = 0;                 //The amount of time the current round has lasted.
        double timeToShowShapes = 0;                //The amount of time the current roung should last.
        int timeBetwRounds = 5;                     //The amount of seconds between each round.
        double[] timeShow = { 0.0, 0.0, 0.0, 0.0 };             //The time each shape is to be shown before it gets hidden.
        bool[] shapeShown = { false, false, false, false };      //Whether or not each shape has been shown yet in the current round.
        int[][] locations = new int[4][];                       //Keeps track of the (x, y) coordinates for each shape.
        bool[] shapeInShape = { false, false, false, false };   //Whether or no each shape is overlapping another shape.
        int score = 0;
        public ObserveTheObjects()
        {
            InitializeComponent();

            for (int i = 0; i < 4; i++)
            {
                locations[i] = new int[2];
                for (int e = 0; e < 2; e++)
                {
                    locations[i][e] = 0;

                }
            }


            lbl_instructions.Text = instructionsText;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            //If current round less than 5, start the game. Else, do name & score stuff.
            if ((currentRound < numRounds))
            {
                timer_showShapes.Start();
                shapesShown = 0;
                timeToShowShapes = randomizer.Next(1, 3);
                btn_start.Visible = false;
            }
            else
            {
                //Abby, please put SCORE & NAME CODE HERE.


                string name = lbl_name.Text;

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

                MainMenu menuForm = new MainMenu();
                menuForm.Show();
                this.Hide();
            }
        }

        private void timer_showShapes_Tick(object sender, EventArgs e)
        {
            displayInput(false);
            timeShapesShown += 0.01;

            //Generate random number of which shape to show:
            int shapeToShow = randomizer.Next(0, 75);
            //0 is Star
            //1 is Square
            //2 is Sphere
            //3 is Triangle

            //If the random number equals 0 - 3, show the corresponding shape:
            //Locations:
            for (int i = 0; i < 4; i++)
            {
                if (shapeToShow == i && !shapeShown[i])
                {
                    locations[i][0] = randomizer.Next(100, 1000);
                    locations[i][1] = randomizer.Next(100, 300);
                }
            }

            //Make it so shapes can't appear within each other:
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i != j)
                    {
                        //int[] A = {locations[i][0] , locations[i][1], locations[i][0] + 200, locations[i][1] + 200};
                        //int[] B = { locations[j][0], locations[j][1], locations[j][0] + 200, locations[j][1] + 200 };

                        if ((locations[i][0] <= locations[j][0] + 200 || locations[i][0] + 200 <= locations[j][0])
                            && (locations[i][1] <= locations[j][1] + 200 || locations[i][1] + 200 <= locations[j][1]))
                        {
                            shapeInShape[i] = false;
                        }
                        else
                        {
                            shapeInShape[i] = true;
                        }
                    }
                }
            }
            //Other things:
            for (int i = 0; i < 4; i++)
            {
                if (shapeToShow == i && timeShow[i] <= 0 && !shapeShown[i] && !shapeInShape[i])
                {
                    timeShow[i] = (double)randomizer.Next(1, 5) / 15;
                    shapeShown[i] = true;
                    if (timeShapesShown <= timeToShowShapes)
                    {
                        shapesShown++;
                    }

                    //Adjusting the location:
                    if (i == 0)         //Star
                    {
                        img_Star.Location = new Point(locations[0][0], locations[0][1]);
                    }
                    else if (i == 1)    //Square
                    {
                        img_Square.Location = new Point(locations[1][0], locations[1][1]);
                    }
                    else if (i == 2)    //Sphere
                    {
                        img_Sphere.Location = new Point(locations[2][0], locations[2][1]);
                    }
                    else if (i == 3)    //Triangle
                    {
                        img_Triangle.Location = new Point(locations[3][0], locations[3][1]);
                    }
                }
            }

            //Debug.WriteLine("shapesShown = " + shapesShown);


            //Show shape & count down time to show that shape:
            if (timeShow[0] > 0)
            {   //Star
                img_Star.Visible = true;
                timeShow[0] -= 0.01;
            }
            if (timeShow[1] > 0)
            {    //Square
                img_Square.Visible = true;
                timeShow[1] -= 0.01;
            }
            if (timeShow[2] > 0)
            {    //Sphere
                img_Sphere.Visible = true;
                timeShow[2] -= 0.01;
            }
            if (timeShow[3] > 0)
            {    //Triangle
                img_Triangle.Visible = true;
                timeShow[3] -= 0.01;
            }

            //Make shape not visible after time is up:
            if (timeShow[0] <= 0)
            { //Star
                img_Star.Visible = false;
            }
            if (timeShow[1] <= 0)
            {    //Square
                img_Square.Visible = false;
            }
            if (timeShow[2] <= 0)
            {    //Sphere
                img_Sphere.Visible = false;
            }
            if (timeShow[3] <= 0)
            {    //Triangle
                img_Triangle.Visible = false;
            }

            //When time for the round is up:
            if (timeShapesShown > timeToShowShapes)
            {
                img_Star.Visible = false;
                img_Square.Visible = false;
                img_Sphere.Visible = false;
                img_Triangle.Visible = false;

                timeShow[0] = 0.0;
                timeShow[1] = 0.0;
                timeShow[2] = 0.0;
                timeShow[3] = 0.0;
                shapeShown[0] = false;
                shapeShown[1] = false;
                shapeShown[2] = false;
                shapeShown[3] = false;

                timeShapesShown = 0;
                timeToShowShapes = 0;
                displayInput(true);
                timer_showShapes.Stop();
            }


        }
        private void displayInput(bool _displayShapes)
        {
            lbl_textPrompt.Visible = _displayShapes;
            textBox1.Visible = _displayShapes;
            btn_submit.Visible = _displayShapes;
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            lbl_roundsLeft.Text = "Time until next round: " + timeBetwRounds.ToString();

            string ans = textBox1.Text;

            //Determening feedback to print for the user:
            lbl_feedback.Visible = true;
            if (ans == shapesShown.ToString())
            {
                lbl_feedback.Text = "Feedback:\nPerfect! You were spot-on!";
                score += 30;
            }
            else if (ans == (shapesShown - 1).ToString() || ans == (shapesShown + 1).ToString())
            {
                lbl_feedback.Text = "Feedback:\nClose. The correct answer was " + shapesShown.ToString() + ".";
                score += 10;
            }
            else if (ans.Length != 1) {
                lbl_feedback.Text = "Feedback:\nInvalid input. The correct answer was " + shapesShown.ToString() + ".";
            }
            else
            {
                lbl_feedback.Text = "Feedback:\nIncorrect. The correct answer was " + shapesShown.ToString() + ".";
            }
            shapesShown = 0;
            timer_betwRounds.Start();



        }

        private void timer_betwRounds_Tick(object sender, EventArgs e)
        {
            //Increment the amount of time between each round:
            timer_betwRounds.Interval = 1000;
            lbl_roundsLeft.Text = "Time until next round: " + (timeBetwRounds - 1).ToString();
            timeBetwRounds -= 1;

            //Starting the next round:
            if (timeBetwRounds < 1)
            {
                textBox1.Text = "";
                timer_betwRounds.Stop();
                timeBetwRounds = 5;
                currentRound += 1;

                lbl_feedback.Visible = false;

                if (currentRound > numRounds)
                {
                    lbl_roundsLeft.Text = "Game Over";
                    lbl_name.Visible = true;
                    displayInput(false);
                    btn_start.Visible = true;
                    btn_start.Text = "Submit\nName and Score";
                }
                else
                {
                    lbl_roundsLeft.Text = "Current Round: #" + currentRound.ToString();
                    timeToShowShapes = randomizer.Next(1, 3);
                    timer_showShapes.Start();
                }

                
            }
            
        }
    }
}
