using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class replay : Form
    {
        public replay()
        {
            InitializeComponent();
        }

        Bitmap lurus;
        Bitmap bg;
        int ctr = 0;
        int counterunviersal = 0;
        int countdown = 3;
        int score = 0;
        int difficulty;
        int coin;
        Random random = new Random();
        int index = 0;
        int indexJalan = 0;
        int indexSpawn = 0;
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        PictureBox pbDuar;
        int ctrkeputusan = 0;
        int jln = 0;
        bool tesstart = false;
        int ctrbensin = 0;
        int ctrTabrak = 0;
        int ctrdtk = 0;
        int y = 0;
        Bitmap[] duar = new Bitmap[45]
        {
        Resource1._1, Resource1._2, Resource1._3, Resource1._4, Resource1._5,
        Resource1._6, Resource1._7, Resource1._8, Resource1._9, Resource1._10,
        Resource1._11,Resource1._12,Resource1._13,Resource1._14,Resource1._15,
        Resource1._16,Resource1._17,Resource1._18,Resource1._19,Resource1._20,
        Resource1._21,Resource1._22,Resource1._23,Resource1._24,Resource1._25,
        Resource1._26,Resource1._27,Resource1._28,Resource1._29,Resource1._30,
        Resource1._31,Resource1._32,Resource1._33,Resource1._34,Resource1._35,
        Resource1._36,Resource1._37,Resource1._38,Resource1._39,Resource1._40,
        Resource1._41,Resource1._42,Resource1._43,Resource1._44,Resource1._45
        };

        void score_and_diffuclty()
        {
            score++;
            label5.Text = score + "";
        }

        private void replay_Load(object sender, EventArgs e)
        {
            index = 0;
            lurus = new Bitmap(Resource1.lurus);
            pictureBox1.BackgroundImage = lurus;
            bg = new Bitmap(Resource1.jalan);
            timerReplay.Start();
            progressBar1.Visible = false;
            progressBar1.Value = 300;
            coin = 100;
            label3.Text = coin.ToString();
            label5.Text = score.ToString();
            pnCoin.BackgroundImage = Image.FromFile(Application.StartupPath + "\\coin.png");
            pnScore.BackgroundImage = Image.FromFile(Application.StartupPath + "\\score.png");
        }

        private void replay_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(bg, 0, ctr - this.Height, this.Width, this.Height);
            g.DrawImage(bg, 0, ctr, this.Width, this.Height);
        }

        private void timerReplay_Tick(object sender, EventArgs e)
        {
            if (counterunviersal / 10 < playthegame.xPlayer.Count)
            {
                pictureBox1.Left = playthegame.xPlayer[counterunviersal / 10];
            }
            if (counterunviersal % 500 == 0)
            {
                startcountdown(); //3... 2... 1... 
            }
            if (counterunviersal >= 2000 && index < playthegame.dtkspeedPlayer.Count && counterunviersal % 10 == 0)
            {
                gerakjalanraya();
                index += 1;
            }
            if (counterunviersal >= 2000 && indexSpawn < playthegame.dtkSpawn.Count && counterunviersal % 200 == 0)
            {
                spawnmobil();
                indexSpawn += 1;
            }
            if (counterunviersal >= 2000 && counterunviersal % 10 == 0)
            {
                gerakmobil();
                //indexJalan++;
            }

            counterunviersal += 10;
        }

        void spawnmobil()
        {
            PictureBox p = new PictureBox();
            p.BackgroundImage = playthegame.spawn[indexSpawn];
            p.BackColor = Color.Transparent;
            p.BackgroundImageLayout = ImageLayout.Stretch;
            int y = -40; //49 
            p.Location = new Point(playthegame.isiSpawn[indexSpawn], y);
            p.Size = new Size(60, 100); 
            p.Tag = playthegame.tagSpawn[indexSpawn];
            this.Controls.Add(p);
        }

        void gerakmobil()
        {
            foreach (var x in this.Controls.OfType<PictureBox>())//ini kecepatan mobil musuh
            {
                if (x.Tag.ToString() != "player")
                {
                    int speed = 6;

                    if (indexJalan < playthegame.difficultySpawn.Count)
                    {
                        speed += playthegame.difficultySpawn[indexJalan];//default = 5
                    }

                    x.Top += speed;

                    
                    indexJalan++;

                    if (x.Top >= 700) 
                    {
                        x.Dispose();
                    }
                }

                if (pictureBox1.Bounds.IntersectsWith(x.Bounds))
                {
                    if (x.Tag.ToString() == "mobil")
                    {
                        x.Tag = "duar";
                        player.SoundLocation = Application.StartupPath + "\\duar.wav";
                        player.Play();
                        //tesstart = false;
                        timerReplay.Stop();
                        ctrTabrak = 0;
                        pbDuar = x;
                        timerAnimation.Start();
                        
                    }
                    else if (x.Tag.ToString() == "Bensin")
                    {
                        x.Dispose();

                        if (progressBar1.Value < 290)
                        {
                            progressBar1.Value += 10;
                        }

                        x.Dispose();
                    }
                    else if (x.Tag.ToString() == "Coin")
                    {
                        x.Dispose();
                        coin++;
                        label3.Text = coin + "";
                    }
                }
            }
        }

        void startcountdown()
        {
            if (countdown > 0)
            {
                score = 0;
                difficulty = 5;

                //label1.Text = "  " + countdown.ToString();
                if (countdown == 3)
                {
                    pnCdown.BackgroundImage = Image.FromFile(Application.StartupPath + "\\3.png");
                }
                else if (countdown == 2)
                {
                    pnCdown.BackgroundImage = Image.FromFile(Application.StartupPath + "\\2.png");
                }
                else if (countdown == 1)
                {
                    pnCdown.BackgroundImage = Image.FromFile(Application.StartupPath + "\\1.png");
                }
                countdown -= 1;
            }
            else if (countdown == 0)
            {
                //label1.Text = "GO!";
                pnCdown.BackgroundImage = Image.FromFile(Application.StartupPath + "\\go.png");
                countdown -= 1;

            }
            else if (countdown < 0)
            {
                //label1.Text = "";
                pnCdown.Hide();
                //timer1.Stop(); skalian tak buat score sama difficulty increase aja 

                //timerspawn.Start();


                //TimerJalan.Start();
                //jalan.Start();
                tesstart = true;
                score_and_diffuclty();
                progressBar1.Show();
                //btnStart.Dispose(); //nanti nek sudah jadi di enable lagi 
            }
    }

        void gerakjalanraya()
        {
            ctrbensin += 1;
            if (progressBar1.Value > 0)
            {
                if (ctrbensin % 10 == 0)
                {
                    progressBar1.Value -= 1;

                }
            }

            if (progressBar1.Value == 0)
            {
                tesstart = false;
                timerReplay.Stop();
                if (playthegame.keputusan[ctrkeputusan] == true)
                {
                    ctrkeputusan++;
                    coin -= 10;
                    label3.Text = coin + "";
                    progressBar1.Value = 50;

                    tesstart = true;
                    timerReplay.Start();
                }
                else
                {
                    MessageBox.Show("Game over !");
                }
            }

                ctr += playthegame.speedPlayer[index];

                if (ctr > this.Height)
                {
                    ctr = 0;
                }

                jln++;
                this.Invalidate();
            
        }

        private void timerAnimation_Tick(object sender, EventArgs e)
        {
            ctrTabrak++;
            if (pbDuar != null && ctrTabrak < 45)
            {
                pbDuar.BackgroundImage = duar[ctrTabrak];

            }

            if (ctrTabrak >= 45)
            {
                ctrTabrak = 0;
                timerAnimation.Stop();
                if (pbDuar!=null)
                {
                    pbDuar.Dispose();
                }
                
                pbDuar = null;

                if (playthegame.keputusan[ctrkeputusan] == true)
                {
                    ctrkeputusan++;
                    coin -= 10;
                    label3.Text = coin + "";
                    progressBar1.Value = 50;

                    tesstart = true;
                    timerReplay.Start();
                }
                else
                {
                    MessageBox.Show("Game over !");
                    timerAnimation.Stop();
                    this.Hide();
                    new highscore().Show();
                }
            }
        }

        private void replay_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            new highscore().Show();
        }
    }
}
