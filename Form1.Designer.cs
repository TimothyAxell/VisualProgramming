
namespace project
{
    partial class Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.pnlForm1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnHS = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.Unmute = new System.Windows.Forms.Button();
            this.Mute = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlForm1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlForm1
            // 
            this.pnlForm1.BackColor = System.Drawing.Color.Transparent;
            this.pnlForm1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlForm1.BackgroundImage")));
            this.pnlForm1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlForm1.Controls.Add(this.button1);
            this.pnlForm1.Controls.Add(this.btnHS);
            this.pnlForm1.Controls.Add(this.btnPlay);
            this.pnlForm1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnlForm1.Location = new System.Drawing.Point(638, 472);
            this.pnlForm1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlForm1.Name = "pnlForm1";
            this.pnlForm1.Size = new System.Drawing.Size(646, 751);
            this.pnlForm1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.BackgroundImage = global::project.Resource1.HowToPlay;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(132, 415);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(376, 88);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // btnHS
            // 
            this.btnHS.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnHS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHS.Location = new System.Drawing.Point(132, 318);
            this.btnHS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHS.Name = "btnHS";
            this.btnHS.Size = new System.Drawing.Size(376, 88);
            this.btnHS.TabIndex = 0;
            this.btnHS.UseVisualStyleBackColor = false;
            this.btnHS.Click += new System.EventHandler(this.button2_Click);
            this.btnHS.MouseEnter += new System.EventHandler(this.btnHS_MouseEnter);
            this.btnHS.MouseLeave += new System.EventHandler(this.btnHS_MouseLeave);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(132, 222);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(376, 88);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.button1_Click);
            this.btnPlay.MouseEnter += new System.EventHandler(this.btnPlay_MouseEnter);
            this.btnPlay.MouseLeave += new System.EventHandler(this.btnPlay_MouseLeave);
            // 
            // Unmute
            // 
            this.Unmute.BackColor = System.Drawing.Color.LightGray;
            this.Unmute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Unmute.Location = new System.Drawing.Point(1791, 18);
            this.Unmute.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Unmute.Name = "Unmute";
            this.Unmute.Size = new System.Drawing.Size(112, 115);
            this.Unmute.TabIndex = 5;
            this.Unmute.UseVisualStyleBackColor = false;
            this.Unmute.Click += new System.EventHandler(this.Unmute_Click);
            // 
            // Mute
            // 
            this.Mute.BackColor = System.Drawing.Color.LightGray;
            this.Mute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Mute.Location = new System.Drawing.Point(1791, 18);
            this.Mute.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Mute.Name = "Mute";
            this.Mute.Size = new System.Drawing.Size(112, 115);
            this.Mute.TabIndex = 6;
            this.Mute.UseVisualStyleBackColor = false;
            this.Mute.Click += new System.EventHandler(this.Mute_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1660, 759);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1922, 1050);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Mute);
            this.Controls.Add(this.Unmute);
            this.Controls.Add(this.pnlForm1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome User";
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Welcome_Paint);
            this.pnlForm1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlForm1;
        private System.Windows.Forms.Button btnHS;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button Unmute;
        private System.Windows.Forms.Button Mute;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

