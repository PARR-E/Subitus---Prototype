namespace Subitus___Prototype
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            startButton = new Button();
            settingsButton = new Button();
            lbButton = new Button();
            fileSystemWatcher1 = new FileSystemWatcher();
            gameSelection = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.BackColor = Color.FromArgb(212, 232, 193);
            startButton.Font = new Font("Tw Cen MT Condensed", 13.8F);
            startButton.Location = new Point(567, 411);
            startButton.Name = "startButton";
            startButton.Size = new Size(120, 34);
            startButton.TabIndex = 0;
            startButton.Text = "Start Button";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += startButton_Click;
            // 
            // settingsButton
            // 
            settingsButton.BackColor = Color.FromArgb(212, 232, 193);
            settingsButton.Font = new Font("Tw Cen MT Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            settingsButton.Location = new Point(1132, 25);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(113, 88);
            settingsButton.TabIndex = 2;
            settingsButton.Text = "Settings";
            settingsButton.UseVisualStyleBackColor = false;
            settingsButton.Click += settingsButton_Click;
            // 
            // lbButton
            // 
            lbButton.BackColor = Color.FromArgb(212, 232, 193);
            lbButton.Font = new Font("Tw Cen MT Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbButton.Location = new Point(21, 25);
            lbButton.Name = "lbButton";
            lbButton.Size = new Size(160, 88);
            lbButton.TabIndex = 3;
            lbButton.Text = "Leaderboard";
            lbButton.UseVisualStyleBackColor = false;
            lbButton.Click += lbButton_Click;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // gameSelection
            // 
            gameSelection.BackColor = Color.FromArgb(212, 232, 193);
            gameSelection.Font = new Font("Tw Cen MT Condensed", 13.8F);
            gameSelection.FormattingEnabled = true;
            gameSelection.Items.AddRange(new object[] { "Know The KNote", "Precision Press", "Analyze The Angles", "Observe The Objects" });
            gameSelection.Location = new Point(463, 371);
            gameSelection.Name = "gameSelection";
            gameSelection.Size = new Size(322, 34);
            gameSelection.TabIndex = 4;
            gameSelection.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT Condensed", 100.200005F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(410, 197);
            label1.Name = "label1";
            label1.Size = new Size(442, 195);
            label1.TabIndex = 5;
            label1.Text = "Subitus";
            label1.Click += label1_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(141, 184, 124);
            ClientSize = new Size(1262, 673);
            Controls.Add(gameSelection);
            Controls.Add(lbButton);
            Controls.Add(settingsButton);
            Controls.Add(startButton);
            Controls.Add(label1);
            Name = "MainMenu";
            Text = "  ";
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startButton;
        private Button settingsButton;
        private Button lbButton;
        private FileSystemWatcher fileSystemWatcher1;
        private ComboBox gameSelection;
        private Label label1;
    }
}