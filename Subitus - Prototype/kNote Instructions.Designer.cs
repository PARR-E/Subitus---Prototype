namespace Subitus___Prototype
{
    partial class kNote_Instructions
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
            titleLabel = new Label();
            label0 = new Label();
            label1 = new Label();
            label2 = new Label();
            BackButton = new Button();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Tw Cen MT Condensed", 40F);
            titleLabel.Location = new Point(60, 14);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(345, 77);
            titleLabel.TabIndex = 25;
            titleLabel.Text = "Know the kNote";
            // 
            // label0
            // 
            label0.AutoSize = true;
            label0.Font = new Font("Tw Cen MT Condensed", 17F);
            label0.Location = new Point(34, 102);
            label0.Name = "label0";
            label0.Size = new Size(396, 102);
            label0.TabIndex = 26;
            label0.Text = "Click \"Begin Game\" to play a note.\r\nYour goal will be to match the note with\r\nthe ring of buttons around the start button!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT Condensed", 17F);
            label1.Location = new Point(34, 215);
            label1.Name = "label1";
            label1.Size = new Size(364, 68);
            label1.TabIndex = 27;
            label1.Text = "You can still play the notes pre-game to\r\nhear what they sound like.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT Condensed", 17F);
            label2.Location = new Point(34, 297);
            label2.Name = "label2";
            label2.Size = new Size(260, 68);
            label2.TabIndex = 28;
            label2.Text = "Get used to how they sound\r\nbefore you start!";
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.FromArgb(212, 232, 193);
            BackButton.Font = new Font("Tw Cen MT Condensed", 13.8F);
            BackButton.Location = new Point(12, 382);
            BackButton.Margin = new Padding(3, 4, 3, 4);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(86, 38);
            BackButton.TabIndex = 32;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // kNote_Instructions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(133, 180, 125);
            ClientSize = new Size(462, 433);
            Controls.Add(BackButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label0);
            Controls.Add(titleLabel);
            Name = "kNote_Instructions";
            Text = "kNote_Instructions";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Label label0;
        private Label label1;
        private Label label2;
        private Button BackButton;
    }
}