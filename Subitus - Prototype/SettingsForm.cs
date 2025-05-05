using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;
using System.Text.Json;
using System.Drawing.Drawing2D;
using System.IO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Metadata;

namespace Subitus___Prototype
{
    public partial class Settings : Form
    {
        int masterVolume;
        bool muted = false;

        public Settings()
        {
            InitializeComponent();
            masterVolume = volume_control_master.Value;
            masterVolNum.Text = "0";
        }

        private void masterVolNum_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(masterVolNum.Text, out int newValue))
            {
                volume_control_master.Value = newValue;
            }
        }

        private void muteBtn_Click(object sender, EventArgs e)
        {
            if (muted == false)
            {
                muted = true;
                muteBtn.Text = "Unmute";
                volume_control_master.Enabled = false;
                masterVolNum.Enabled = false;
            }
            else if (muted == true)
            {
                muted = false;
                muteBtn.Text = "Mute";
                volume_control_master.Enabled = true;
                masterVolNum.Enabled = true;
            }
        }

        private void volume_control_master_MouseUp(object sender, MouseEventArgs e)
        {
            masterVolNum.Text = volume_control_master.Value.ToString();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            string volText = masterVolNum.Text;

            // Converts null to 0, but DON'T PUT IN BAD STRINGS
            // IT'LL CRASH IT <- this was Domenic
            //I put in a catch for this error - Abigail 
            if (int.TryParse(volText, out int number)) {
                int vol = Convert.ToInt32(volText);
            }
            else
            {
                MessageBox.Show($"Please enter a valid value");
            }

                string filePath = "jsonFile/userSettings.json";

            List<settingChanges> soundSettings = new();

            if (File.Exists(filePath))
            {
                string existingJson = File.ReadAllText(filePath);
                soundSettings = JsonSerializer.Deserialize<List<settingChanges>>(existingJson);
            }

            // Set volume and muted booleans to 
           // soundSettings.Add(new settingChanges { Volume = vol, Muted = muted });

            string newJson = JsonSerializer.Serialize(soundSettings, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, newJson);

            MessageBox.Show("Changes Set!");
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            LoadVolume();
        }
        private List<settingChanges> LoadSettings(string filePath)
        {
            // Check if the file exists; if it doesn't, return an empty list
            if (!File.Exists(filePath))
                return new List<settingChanges>();

            // Read the JSON file
            string json = File.ReadAllText(filePath);

            // Deserialize the JSON data into a list of PlayerScore objects
            return JsonSerializer.Deserialize<List<settingChanges>>(json);
        }

        private void LoadVolume()
        {

            string jsonPath = "jsonFile/userSettings.json";
            var userSettings = LoadSettings(jsonPath); // Assuming LoadScores method is already defined


            // Clear the Volume text box before loading new data
            masterVolNum.Clear();

            // Populate the Master Volume with the set volume.
            //masterVolNum.Text = userSettings.Volume;
        }
    }
    public class settingChanges
    {
        public int Volume { get; set; }
        public bool Muted { get; set; }
    }
}