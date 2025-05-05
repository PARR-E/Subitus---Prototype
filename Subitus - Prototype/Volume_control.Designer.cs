namespace Subitus___Prototype
{
    partial class Volume_control
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // Volume_control
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Name = "Volume_control";
            Load += Volume_control_Load;
            Paint += Volume_control_Paint;
            MouseDown += Volume_control_MouseDown;
            MouseMove += Volume_control_MouseMove;
            MouseUp += Volume_control_MouseUp;
            ResumeLayout(false);
        }

        #endregion
    }
}
