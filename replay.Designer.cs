
namespace project
{
    partial class replay
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(replay));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.timerReplay = new System.Windows.Forms.Timer(this.components);
            this.timerAnimation = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnScore = new System.Windows.Forms.Panel();
            this.pnCoin = new System.Windows.Forms.Panel();
            this.pnCdown = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(315, 46);
            this.progressBar1.Maximum = 300;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1246, 55);
            this.progressBar1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Anda berada di mode replay.....";
            // 
            // timerReplay
            // 
            this.timerReplay.Interval = 10;
            this.timerReplay.Tick += new System.EventHandler(this.timerReplay_Tick);
            // 
            // timerAnimation
            // 
            this.timerAnimation.Interval = 40;
            this.timerAnimation.Tick += new System.EventHandler(this.timerAnimation_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1628, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Coin : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1749, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1749, 105);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 37);
            this.label5.TabIndex = 9;
            this.label5.Text = "-";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1058, 840);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 195);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "player";
            // 
            // pnScore
            // 
            this.pnScore.BackColor = System.Drawing.Color.Transparent;
            this.pnScore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnScore.Location = new System.Drawing.Point(1582, 111);
            this.pnScore.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnScore.Name = "pnScore";
            this.pnScore.Size = new System.Drawing.Size(144, 51);
            this.pnScore.TabIndex = 16;
            // 
            // pnCoin
            // 
            this.pnCoin.BackColor = System.Drawing.Color.Transparent;
            this.pnCoin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnCoin.Location = new System.Drawing.Point(1617, 51);
            this.pnCoin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnCoin.Name = "pnCoin";
            this.pnCoin.Size = new System.Drawing.Size(110, 51);
            this.pnCoin.TabIndex = 15;
            // 
            // pnCdown
            // 
            this.pnCdown.BackColor = System.Drawing.Color.Transparent;
            this.pnCdown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnCdown.Location = new System.Drawing.Point(900, 154);
            this.pnCdown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnCdown.Name = "pnCdown";
            this.pnCdown.Size = new System.Drawing.Size(176, 91);
            this.pnCdown.TabIndex = 13;
            // 
            // replay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1852, 1050);
            this.Controls.Add(this.pnCdown);
            this.Controls.Add(this.pnScore);
            this.Controls.Add(this.pnCoin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "replay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "replay";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.replay_FormClosing);
            this.Load += new System.EventHandler(this.replay_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.replay_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerReplay;
        private System.Windows.Forms.Timer timerAnimation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnScore;
        private System.Windows.Forms.Panel pnCoin;
        private System.Windows.Forms.Panel pnCdown;
    }
}