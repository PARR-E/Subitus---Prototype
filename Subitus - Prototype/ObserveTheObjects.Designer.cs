namespace Subitus___Prototype
{
    partial class ObserveTheObjects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ObserveTheObjects));
            lbl_instructions = new Label();
            textBox1 = new TextBox();
            lbl_textPrompt = new Label();
            btn_submit = new Button();
            btn_start = new Button();
            timer_showShapes = new System.Windows.Forms.Timer(components);
            img_Star = new PictureBox();
            img_Triangle = new PictureBox();
            img_Square = new PictureBox();
            img_Sphere = new PictureBox();
            timer_betwRounds = new System.Windows.Forms.Timer(components);
            imageList1 = new ImageList(components);
            lbl_roundsLeft = new Label();
            lbl_feedback = new Label();
            lbl_name = new TextBox();
            ((System.ComponentModel.ISupportInitialize)img_Star).BeginInit();
            ((System.ComponentModel.ISupportInitialize)img_Triangle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)img_Square).BeginInit();
            ((System.ComponentModel.ISupportInitialize)img_Sphere).BeginInit();
            SuspendLayout();
            // 
            // lbl_instructions
            // 
            lbl_instructions.AutoSize = true;
            lbl_instructions.Font = new Font("Tw Cen MT Condensed", 19.8000011F);
            lbl_instructions.Location = new Point(100, 500);
            lbl_instructions.Name = "lbl_instructions";
            lbl_instructions.Size = new Size(147, 39);
            lbl_instructions.TabIndex = 6;
            lbl_instructions.Text = "Instructions: ";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Info;
            textBox1.Location = new Point(783, 337);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 27);
            textBox1.TabIndex = 7;
            textBox1.Visible = false;
            // 
            // lbl_textPrompt
            // 
            lbl_textPrompt.AutoSize = true;
            lbl_textPrompt.Font = new Font("Tw Cen MT Condensed", 19.8000011F);
            lbl_textPrompt.Location = new Point(284, 327);
            lbl_textPrompt.Name = "lbl_textPrompt";
            lbl_textPrompt.Size = new Size(391, 39);
            lbl_textPrompt.TabIndex = 8;
            lbl_textPrompt.Text = "Enter the number of shapes you saw: ";
            lbl_textPrompt.Visible = false;
            // 
            // btn_submit
            // 
            btn_submit.BackColor = Color.FromArgb(212, 232, 193);
            btn_submit.Font = new Font("Tw Cen MT Condensed", 19.8000011F);
            btn_submit.Location = new Point(807, 384);
            btn_submit.Name = "btn_submit";
            btn_submit.Size = new Size(94, 50);
            btn_submit.TabIndex = 9;
            btn_submit.Text = "Submit";
            btn_submit.UseVisualStyleBackColor = false;
            btn_submit.Visible = false;
            btn_submit.Click += btn_submit_Click;
            // 
            // btn_start
            // 
            btn_start.BackColor = Color.FromArgb(212, 232, 193);
            btn_start.Font = new Font("Tw Cen MT Condensed", 19.8000011F);
            btn_start.Location = new Point(523, 275);
            btn_start.Name = "btn_start";
            btn_start.Size = new Size(204, 146);
            btn_start.TabIndex = 10;
            btn_start.Text = "Start";
            btn_start.UseVisualStyleBackColor = false;
            btn_start.Click += btn_start_Click;
            // 
            // timer_showShapes
            // 
            timer_showShapes.Interval = 10;
            timer_showShapes.Tick += timer_showShapes_Tick;
            // 
            // img_Star
            // 
            img_Star.BackColor = Color.Transparent;
            img_Star.Image = (Image)resources.GetObject("img_Star.Image");
            img_Star.Location = new Point(140, 100);
            img_Star.Name = "img_Star";
            img_Star.Size = new Size(200, 200);
            img_Star.SizeMode = PictureBoxSizeMode.StretchImage;
            img_Star.TabIndex = 11;
            img_Star.TabStop = false;
            img_Star.Visible = false;
            // 
            // img_Triangle
            // 
            img_Triangle.BackColor = Color.Transparent;
            img_Triangle.Image = (Image)resources.GetObject("img_Triangle.Image");
            img_Triangle.Location = new Point(664, 100);
            img_Triangle.Name = "img_Triangle";
            img_Triangle.Size = new Size(200, 200);
            img_Triangle.SizeMode = PictureBoxSizeMode.StretchImage;
            img_Triangle.TabIndex = 12;
            img_Triangle.TabStop = false;
            img_Triangle.Visible = false;
            // 
            // img_Square
            // 
            img_Square.BackColor = SystemColors.ButtonHighlight;
            img_Square.Image = (Image)resources.GetObject("img_Square.Image");
            img_Square.Location = new Point(400, 100);
            img_Square.Name = "img_Square";
            img_Square.Size = new Size(200, 200);
            img_Square.SizeMode = PictureBoxSizeMode.StretchImage;
            img_Square.TabIndex = 13;
            img_Square.TabStop = false;
            img_Square.Visible = false;
            // 
            // img_Sphere
            // 
            img_Sphere.BackColor = Color.Transparent;
            img_Sphere.Image = (Image)resources.GetObject("img_Sphere.Image");
            img_Sphere.Location = new Point(902, 100);
            img_Sphere.Name = "img_Sphere";
            img_Sphere.Size = new Size(200, 200);
            img_Sphere.SizeMode = PictureBoxSizeMode.StretchImage;
            img_Sphere.TabIndex = 14;
            img_Sphere.TabStop = false;
            img_Sphere.Visible = false;
            // 
            // timer_betwRounds
            // 
            timer_betwRounds.Interval = 1000;
            timer_betwRounds.Tick += timer_betwRounds_Tick;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // lbl_roundsLeft
            // 
            lbl_roundsLeft.AutoSize = true;
            lbl_roundsLeft.Font = new Font("Tw Cen MT Condensed", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_roundsLeft.Location = new Point(523, 30);
            lbl_roundsLeft.Name = "lbl_roundsLeft";
            lbl_roundsLeft.Size = new Size(204, 39);
            lbl_roundsLeft.TabIndex = 15;
            lbl_roundsLeft.Text = "Current Round: #1";
            lbl_roundsLeft.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbl_feedback
            // 
            lbl_feedback.AutoSize = true;
            lbl_feedback.Font = new Font("Tw Cen MT Condensed", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_feedback.Location = new Point(523, 169);
            lbl_feedback.Name = "lbl_feedback";
            lbl_feedback.Size = new Size(127, 39);
            lbl_feedback.TabIndex = 16;
            lbl_feedback.Text = " Feedback: ";
            lbl_feedback.TextAlign = ContentAlignment.TopCenter;
            lbl_feedback.Visible = false;
            // 
            // lbl_name
            // 
            lbl_name.Location = new Point(566, 211);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(125, 27);
            lbl_name.TabIndex = 17;
            lbl_name.Visible = false;
            // 
            // ObserveTheObjects
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(141, 184, 124);
            ClientSize = new Size(1262, 673);
            Controls.Add(lbl_name);
            Controls.Add(lbl_feedback);
            Controls.Add(lbl_roundsLeft);
            Controls.Add(img_Sphere);
            Controls.Add(img_Square);
            Controls.Add(img_Triangle);
            Controls.Add(img_Star);
            Controls.Add(btn_start);
            Controls.Add(btn_submit);
            Controls.Add(lbl_textPrompt);
            Controls.Add(textBox1);
            Controls.Add(lbl_instructions);
            Name = "ObserveTheObjects";
            Text = "ObserveTheObjects";
            ((System.ComponentModel.ISupportInitialize)img_Star).EndInit();
            ((System.ComponentModel.ISupportInitialize)img_Triangle).EndInit();
            ((System.ComponentModel.ISupportInitialize)img_Square).EndInit();
            ((System.ComponentModel.ISupportInitialize)img_Sphere).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_instructions;
        private TextBox textBox1;
        private Label lbl_textPrompt;
        private Button btn_submit;
        private Button btn_start;
        private System.Windows.Forms.Timer timer_showShapes;
        private PictureBox img_Star;
        private PictureBox img_Triangle;
        private PictureBox img_Square;
        private PictureBox img_Sphere;
        private System.Windows.Forms.Timer timer_betwRounds;
        private ImageList imageList1;
        private Label lbl_roundsLeft;
        private Label lbl_feedback;
        private TextBox lbl_name;
    }
}