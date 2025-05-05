using System.Text.Json;

namespace Subitus___Prototype
{
    public partial class AnalyzeTheAngle : Form
    {

        
        Bitmap line1 = null!;
        int angle;
        int roundcount = 0;
        String imagePath = "Resources/LineSegment.bmp";
        Bitmap line2 = null!;
        int score = 0;

        public AnalyzeTheAngle()
        {
            InitializeComponent();

            AngleImage.Image = makeNewAngle();


        }


        private Bitmap makeNewAngle()
        {
            Random rand = new Random();
            angle = rand.Next(-36, 36);
            // Generate a new angle image and set it to the AngleImage PictureBox
            // This is a placeholder for the actual implementation
            line1 = new Bitmap(imagePath);
            if (line1 == null)
            {
                MessageBox.Show("Resource 'LineSegment' not found. Ensure it is embedded correctly.");
                return new Bitmap(426, 426); // Return a blank bitmap as a fallback
            }
            line2 = new Bitmap(line1.Width, line1.Height);

            using (Graphics g = Graphics.FromImage(line2))
            {
                g.TranslateTransform(line1.Width / 2, line1.Height / 2);
                g.RotateTransform(angle * 5);
                g.DrawImage(line1, -line1.Width / 2, -line1.Height / 2);
            }
            Bitmap composedBitmap = new Bitmap(line1.Width, line1.Height);
            composedBitmap.SetResolution(line1.HorizontalResolution, line1.VerticalResolution);

            // Use Graphics to draw both images onto the new bitmap
            using (Graphics g = Graphics.FromImage(composedBitmap))
            {
                // Draw line1
                g.DrawImage(line1, 0, 0);

                // Draw line2 on top of line1
                g.DrawImage(line2, 0, 0);
            }

            return composedBitmap; // Return the composed image
        }




        private void AnswerBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                roundcount++;
                if (int.TryParse(AnswerBox.Text, out int userInput))
                {
                    if (userInput == angle * -5)
                    {
                        MessageBox.Show("good");
                        score = score + 50;
                    }
                    else
                    {
                        MessageBox.Show($"bad, {angle * -5}");
                    }
                    AngleImage.Image = makeNewAngle();
                }
                else
                {
                    MessageBox.Show("Please enter a valid integer.");
                }

                label2.Text = "Round\n" + roundcount.ToString();

                if (roundcount >= 5)
                {
                    ExitButton.Visible = true;
                    AngleImage.Visible = false;
                    AnswerBox.Visible = false;
                    textBox1.Visible = true;
                }
                else
                {
                    ExitButton.Visible = false;
                    textBox1.Visible = false;
                }
            }
        }

        

        private void ExitButton_Click(object sender, EventArgs e)
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

            MainMenu menuForm = new MainMenu();
            menuForm.Show();
            this.Hide(); 
        }
    }
}



