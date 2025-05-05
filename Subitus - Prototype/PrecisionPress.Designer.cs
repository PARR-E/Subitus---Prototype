namespace Subitus___Prototype
{
    partial class PrecisionPress
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            label0 = new Label();
            label2 = new Label();
            lbl_roundsLeft = new Label();
            lbl_instructions = new Label();
            timer_betwRounds = new System.Windows.Forms.Timer(components);
            btn_return = new Button();
            submitName = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(212, 232, 193);
            button1.Font = new Font("Tw Cen MT Condensed", 19.8000011F);
            button1.Location = new Point(350, 195);
            button1.Name = "button1";
            button1.Size = new Size(248, 242);
            button1.TabIndex = 0;
            button1.Text = "Hold Now";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label0
            // 
            label0.AutoSize = true;
            label0.Font = new Font("Tw Cen MT Condensed", 19.8000011F);
            label0.Location = new Point(706, 195);
            label0.Name = "label0";
            label0.Size = new Size(294, 39);
            label0.TabIndex = 2;
            label0.Text = "Time to hold the button for: ";
            label0.Click += label0_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT Condensed", 19.8000011F);
            label2.Location = new Point(706, 257);
            label2.Name = "label2";
            label2.Size = new Size(352, 39);
            label2.TabIndex = 3;
            label2.Text = "Time you held it for: (not held yet)";
            label2.Click += label2_Click;
            // 
            // lbl_roundsLeft
            // 
            lbl_roundsLeft.AutoSize = true;
            lbl_roundsLeft.Font = new Font("Tw Cen MT Condensed", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_roundsLeft.Location = new Point(523, 51);
            lbl_roundsLeft.Name = "lbl_roundsLeft";
            lbl_roundsLeft.Size = new Size(204, 39);
            lbl_roundsLeft.TabIndex = 4;
            lbl_roundsLeft.Text = "Current Round: #1";
            lbl_roundsLeft.Click += lbl_roundsLeft_Click;
            // 
            // lbl_instructions
            // 
            lbl_instructions.AutoSize = true;
            lbl_instructions.Font = new Font("Tw Cen MT Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_instructions.Location = new Point(28, 531);
            lbl_instructions.Name = "lbl_instructions";
            lbl_instructions.Size = new Size(121, 32);
            lbl_instructions.TabIndex = 5;
            lbl_instructions.Text = "Instructions: ";
            lbl_instructions.Click += lbl_instructions_Click;
            // 
            // timer_betwRounds
            // 
            timer_betwRounds.Interval = 500;
            timer_betwRounds.Tick += timer_betwRounds_Tick;
            // 
            // btn_return
            // 
            btn_return.BackColor = Color.FromArgb(212, 232, 193);
            btn_return.Font = new Font("Tw Cen MT Condensed", 19.8000011F);
            btn_return.Location = new Point(377, 343);
            btn_return.Name = "btn_return";
            btn_return.Size = new Size(218, 122);
            btn_return.TabIndex = 6;
            btn_return.Text = "button2";
            btn_return.UseVisualStyleBackColor = false;
            btn_return.Click += btn_return_Click;
            // 
            // submitName
            // 
            submitName.BackColor = Color.FromArgb(212, 232, 193);
            submitName.Font = new Font("Tw Cen MT Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            submitName.Location = new Point(400, 224);
            submitName.Name = "submitName";
            submitName.Size = new Size(166, 72);
            submitName.TabIndex = 7;
            submitName.Text = "Submit Name and Score";
            submitName.UseVisualStyleBackColor = false;
            submitName.Click += submitName_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(417, 188);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // PrecisionPress
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(141, 184, 124);
            ClientSize = new Size(1262, 673);
            Controls.Add(textBox1);
            Controls.Add(submitName);
            Controls.Add(btn_return);
            Controls.Add(lbl_instructions);
            Controls.Add(lbl_roundsLeft);
            Controls.Add(label2);
            Controls.Add(label0);
            Controls.Add(button1);
            Name = "PrecisionPress";
            Text = "PrecisionPress";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Button button1;
        private Label label0;
        private Label label2;
        private Label lbl_roundsLeft;
        private Label lbl_instructions;
        private System.Windows.Forms.Timer timer_betwRounds;
        private Button btn_return;
        private Button submitName;
        private TextBox textBox1;
    }
}