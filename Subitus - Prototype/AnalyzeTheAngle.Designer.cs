namespace Subitus___Prototype
{
    partial class AnalyzeTheAngle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnalyzeTheAngle));
            AngleImage = new PictureBox();
            AnswerBox = new TextBox();
            HowManyDegrees = new Label();
            ExitButton = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)AngleImage).BeginInit();
            SuspendLayout();
            // 
            // AngleImage
            // 
            AngleImage.BackgroundImageLayout = ImageLayout.Stretch;
            AngleImage.Location = new Point(14, 16);
            AngleImage.Margin = new Padding(3, 4, 3, 4);
            AngleImage.Name = "AngleImage";
            AngleImage.Size = new Size(487, 568);
            AngleImage.TabIndex = 0;
            AngleImage.TabStop = false;
            // 
            // AnswerBox
            // 
            AnswerBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AnswerBox.BackColor = Color.FromArgb(212, 232, 193);
            AnswerBox.Font = new Font("Tw Cen MT Condensed", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AnswerBox.Location = new Point(709, 304);
            AnswerBox.Margin = new Padding(3, 4, 3, 4);
            AnswerBox.Name = "AnswerBox";
            AnswerBox.Size = new Size(114, 72);
            AnswerBox.TabIndex = 1;
            AnswerBox.KeyPress += AnswerBox_KeyPress;
            // 
            // HowManyDegrees
            // 
            HowManyDegrees.AutoSize = true;
            HowManyDegrees.Font = new Font("Tw Cen MT Condensed", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HowManyDegrees.Location = new Point(724, 73);
            HowManyDegrees.Name = "HowManyDegrees";
            HowManyDegrees.Size = new Size(285, 184);
            HowManyDegrees.TabIndex = 2;
            HowManyDegrees.Text = "How Many\r\n Degrees?";
            // 
            // ExitButton
            // 
            ExitButton.Font = new Font("Tw Cen MT Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExitButton.Location = new Point(697, 366);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(146, 142);
            ExitButton.TabIndex = 4;
            ExitButton.Text = "Submit Name and Score";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Visible = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(212, 232, 193);
            textBox1.Location = new Point(704, 319);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 5;
            textBox1.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 639);
            label1.Name = "label1";
            label1.Size = new Size(812, 105);
            label1.TabIndex = 6;
            label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT Condensed", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(910, 304);
            label2.Name = "label2";
            label2.Size = new Size(89, 88);
            label2.TabIndex = 7;
            label2.Text = "Round\r\n0";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // AnalyzeTheAngle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(141, 184, 124);
            ClientSize = new Size(1085, 775);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(ExitButton);
            Controls.Add(HowManyDegrees);
            Controls.Add(AnswerBox);
            Controls.Add(AngleImage);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AnalyzeTheAngle";
            Text = "AnalyzeTheAngle";
            ((System.ComponentModel.ISupportInitialize)AngleImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox AngleImage;
        private TextBox AnswerBox;
        private Label HowManyDegrees;
        private Button ExitButton;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
    }
}