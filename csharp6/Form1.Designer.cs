
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
            lblDirect = new Label();
            lblSp = new Label();
            tbTeleportRadius = new TrackBar();
            lblTeleportRadius = new Label();
            ((System.ComponentModel.ISupportInitialize)picDisplay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbDirection).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbSpread).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbTeleportRadius).BeginInit();
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
            picDisplay.Size = new Size(800, 383);
            picDisplay.TabIndex = 0;
            picDisplay.TabStop = false;
            picDisplay.MouseMove += picDisplay_MouseMove;
            // 
            // tbDirection
            // 
            tbDirection.Location = new Point(-1, 409);
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
            tbSpread.Location = new Point(217, 409);
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
            // lblDirect
            // 
            lblDirect.AutoSize = true;
            lblDirect.Location = new Point(6, 385);
            lblDirect.Name = "lblDirect";
            lblDirect.Size = new Size(104, 20);
            lblDirect.TabIndex = 5;
            lblDirect.Text = "Направление";
            // 
            // lblSp
            // 
            lblSp.AutoSize = true;
            lblSp.Location = new Point(217, 385);
            lblSp.Name = "lblSp";
            lblSp.Size = new Size(117, 20);
            lblSp.TabIndex = 6;
            lblSp.Text = "Разброс частиц";
            // 
            // tbTeleportRadius
            // 
            tbTeleportRadius.Location = new Point(420, 409);
            tbTeleportRadius.Maximum = 100;
            tbTeleportRadius.Name = "tbTeleportRadius";
            tbTeleportRadius.Size = new Size(130, 56);
            tbTeleportRadius.TabIndex = 7;
            tbTeleportRadius.Scroll += tbTeleportRadius_Scroll;
            // 
            // lblTeleportRadius
            // 
            lblTeleportRadius.AutoSize = true;
            lblTeleportRadius.Location = new Point(420, 386);
            lblTeleportRadius.Name = "lblTeleportRadius";
            lblTeleportRadius.Size = new Size(135, 20);
            lblTeleportRadius.TabIndex = 8;
            lblTeleportRadius.Text = "Радиус телепорта ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTeleportRadius);
            Controls.Add(tbTeleportRadius);
            Controls.Add(lblSp);
            Controls.Add(lblDirect);
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
            ((System.ComponentModel.ISupportInitialize)tbTeleportRadius).EndInit();
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
        private Label lblDirect;
        private Label lblSp;
        private TrackBar tbTeleportRadius;
        private Label lblTeleportRadius;
    }
}
