
namespace csharp6
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            picDisplay = new PictureBox();
            tbDirection = new TrackBar();
            lblDirection = new Label();
            tbSpread = new TrackBar();
            lblSpread = new Label();
            tbGraviton = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)picDisplay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbDirection).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbSpread).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbGraviton).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 40;
            timer1.Tick += timer1_Tick;
            // 
            // picDisplay
            // 
            picDisplay.Location = new Point(-1, 0);
            picDisplay.Name = "picDisplay";
            picDisplay.Size = new Size(800, 393);
            picDisplay.TabIndex = 0;
            picDisplay.TabStop = false;
            picDisplay.MouseMove += picDisplay_MouseMove;
            // 
            // tbDirection
            // 
            tbDirection.Location = new Point(-1, 399);
            tbDirection.Maximum = 359;
            tbDirection.Name = "tbDirection";
            tbDirection.Size = new Size(164, 56);
            tbDirection.TabIndex = 1;
            tbDirection.Scroll += tbDirection_Scroll;
            // 
            // lblDirection
            // 
            lblDirection.AutoSize = true;
            lblDirection.Location = new Point(169, 409);
            lblDirection.Name = "lblDirection";
            lblDirection.Size = new Size(0, 20);
            lblDirection.TabIndex = 2;
            // 
            // tbSpread
            // 
            tbSpread.Location = new Point(211, 399);
            tbSpread.Maximum = 50;
            tbSpread.Name = "tbSpread";
            tbSpread.Size = new Size(130, 56);
            tbSpread.TabIndex = 3;
            tbSpread.Scroll += tbSpread_Scroll;
            // 
            // lblSpread
            // 
            lblSpread.AutoSize = true;
            lblSpread.Location = new Point(353, 412);
            lblSpread.Name = "lblSpread";
            lblSpread.Size = new Size(0, 20);
            lblSpread.TabIndex = 4;
            // 
            // tbGraviton
            // 
            tbGraviton.Location = new Point(389, 399);
            tbGraviton.Maximum = 100;
            tbGraviton.Name = "tbGraviton";
            tbGraviton.Size = new Size(130, 56);
            tbGraviton.TabIndex = 5;
            tbGraviton.Scroll += tbGraviton_Scroll;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbGraviton);
            Controls.Add(lblSpread);
            Controls.Add(tbSpread);
            Controls.Add(lblDirection);
            Controls.Add(tbDirection);
            Controls.Add(picDisplay);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picDisplay).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbDirection).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbSpread).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbGraviton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void picDisplay_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

#endregion
        private System.Windows.Forms.Timer timer1;
        private PictureBox picDisplay;
        private TrackBar tbDirection;
        private Label lblDirection;
        private TrackBar tbSpread;
        private Label lblSpread;
        private TrackBar tbGraviton;
    }
}
