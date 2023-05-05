
namespace project
{
    partial class playthegame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(playthegame));
            this.btnStart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblscore = new System.Windows.Forms.Label();
            this.timerUniversal = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.tmrTabrak = new System.Windows.Forms.Timer(this.components);
            this.pnCdown = new System.Windows.Forms.Panel();
            this.pnCoin = new System.Windows.Forms.Panel();
            this.pnScore = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStart.Location = new System.Drawing.Point(1422, 34);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(153, 55);
            this.btnStart.TabIndex = 0;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            this.btnStart.MouseEnter += new System.EventHandler(this.btnStart_MouseEnter);
            this.btnStart.MouseLeave += new System.EventHandler(this.btnStart_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1749, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "-";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(328, 34);
            this.progressBar1.Maximum = 300;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1246, 55);
            this.progressBar1.TabIndex = 6;
            // 
            // lblscore
            // 
            this.lblscore.AutoSize = true;
            this.lblscore.BackColor = System.Drawing.Color.Transparent;
            this.lblscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscore.ForeColor = System.Drawing.Color.White;
            this.lblscore.Location = new System.Drawing.Point(1749, 117);
            this.lblscore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(27, 37);
            this.lblscore.TabIndex = 8;
            this.lblscore.Text = "-";
            // 
            // timerUniversal
            // 
            this.timerUniversal.Interval = 10;
            this.timerUniversal.Tick += new System.EventHandler(this.timerUniversal_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(1664, 209);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(1664, 166);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "label5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 38);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 37);
            this.label7.TabIndex = 10;
            this.label7.Text = "label7";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeed.Location = new System.Drawing.Point(1552, 318);
            this.lblSpeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(178, 61);
            this.lblSpeed.TabIndex = 11;
            this.lblSpeed.Text = "Speed";
            // 
            // tmrTabrak
            // 
            this.tmrTabrak.Interval = 40;
            this.tmrTabrak.Tick += new System.EventHandler(this.tmrTabrak_Tick);
            // 
            // pnCdown
            // 
            this.pnCdown.BackColor = System.Drawing.Color.Transparent;
            this.pnCdown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnCdown.Location = new System.Drawing.Point(900, 154);
            this.pnCdown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnCdown.Name = "pnCdown";
            this.pnCdown.Size = new System.Drawing.Size(176, 91);
            this.pnCdown.TabIndex = 12;
            // 
            // pnCoin
            // 
            this.pnCoin.BackColor = System.Drawing.Color.Transparent;
            this.pnCoin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnCoin.Location = new System.Drawing.Point(1630, 49);
            this.pnCoin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnCoin.Name = "pnCoin";
            this.pnCoin.Size = new System.Drawing.Size(110, 51);
            this.pnCoin.TabIndex = 13;
            // 
            // pnScore
            // 
            this.pnScore.BackColor = System.Drawing.Color.Transparent;
            this.pnScore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnScore.Location = new System.Drawing.Point(1596, 111);
            this.pnScore.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnScore.Name = "pnScore";
            this.pnScore.Size = new System.Drawing.Size(144, 51);
            this.pnScore.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1058, 840);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 195);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "player";
            // 
            // playthegame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1852, 1050);
            this.Controls.Add(this.pnScore);
            this.Controls.Add(this.pnCoin);
            this.Controls.Add(this.pnCdown);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblscore);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnStart);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "playthegame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "playthegame";
            this.Load += new System.EventHandler(this.playthegame_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.playthegame_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.playthegame_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblscore;
        private System.Windows.Forms.Timer timerUniversal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Timer tmrTabrak;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnCdown;
        private System.Windows.Forms.Panel pnCoin;
        private System.Windows.Forms.Panel pnScore;
    }
}