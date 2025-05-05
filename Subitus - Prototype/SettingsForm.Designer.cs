namespace Subitus___Prototype
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            volLabel = new Label();
            volume_control_master = new Volume_control();
            muteBtn = new Button();
            masterVolNum = new TextBox();
            saveButton = new Button();
            SuspendLayout();
            // 
            // volLabel
            // 
            volLabel.BackColor = Color.FromArgb(212, 232, 193);
            volLabel.BorderStyle = BorderStyle.FixedSingle;
            volLabel.Font = new Font("Tw Cen MT Condensed", 13.8F);
            volLabel.Location = new Point(9, 9);
            volLabel.Name = "volLabel";
            volLabel.Size = new Size(67, 38);
            volLabel.TabIndex = 0;
            volLabel.Text = "Volume";
            volLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // volume_control_master
            // 
            volume_control_master.BackColor = Color.Black;
            volume_control_master.Bar_color = Color.FromArgb(245, 215, 105);
            volume_control_master.Location = new Point(82, 9);
            volume_control_master.Max = 100;
            volume_control_master.Min = 0;
            volume_control_master.Name = "volume_control_master";
            volume_control_master.Size = new Size(438, 38);
            volume_control_master.TabIndex = 1;
            volume_control_master.Value = 40;
            volume_control_master.MouseUp += volume_control_master_MouseUp;
            // 
            // muteBtn
            // 
            muteBtn.BackColor = Color.FromArgb(212, 232, 193);
            muteBtn.Font = new Font("Tw Cen MT Condensed", 13.8F);
            muteBtn.Location = new Point(602, 7);
            muteBtn.Name = "muteBtn";
            muteBtn.Size = new Size(73, 42);
            muteBtn.TabIndex = 3;
            muteBtn.Text = "Mute";
            muteBtn.UseVisualStyleBackColor = false;
            muteBtn.Click += muteBtn_Click;
            // 
            // masterVolNum
            // 
            masterVolNum.BackColor = Color.FromArgb(212, 232, 193);
            masterVolNum.BorderStyle = BorderStyle.FixedSingle;
            masterVolNum.Font = new Font("Tw Cen MT Condensed", 13.8F);
            masterVolNum.Location = new Point(526, 13);
            masterVolNum.Name = "masterVolNum";
            masterVolNum.Size = new Size(71, 32);
            masterVolNum.TabIndex = 4;
            masterVolNum.Text = "40";
            masterVolNum.TextAlign = HorizontalAlignment.Center;
            masterVolNum.TextChanged += masterVolNum_TextChanged;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.FromArgb(212, 232, 193);
            saveButton.Font = new Font("Tw Cen MT Condensed", 13.8F);
            saveButton.Location = new Point(279, 256);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(125, 42);
            saveButton.TabIndex = 6;
            saveButton.Text = "Save Changes";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(141, 184, 124);
            ClientSize = new Size(682, 433);
            Controls.Add(saveButton);
            Controls.Add(masterVolNum);
            Controls.Add(muteBtn);
            Controls.Add(volume_control_master);
            Controls.Add(volLabel);
            Name = "Settings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SettingsForm";
            Load += Settings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label volLabel;
        private Volume_control volume_control_master;
        private Button muteBtn;
        private TextBox masterVolNum;
        private Button saveButton;
    }
}