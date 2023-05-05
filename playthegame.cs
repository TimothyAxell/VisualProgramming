using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace project
{
    public partial class playthegame : Form
    {
        
        public playthegame()
        {
            InitializeComponent();
        }

        int counterunviersal;
        int score, difficulty;
        int coin;
        bool tesstart = false;
        int countdown = 3;
        Bitmap lurus;
        bool kiri = false;
        bool kanan = false;
        bool lanjut = false;
        Random random = new Random();
        Bitmap bg;
        Bitmap[] musuh = new Bitmap[12] {Resource1.mobilbiru, Resource1.mobilijo,Resource1.mobilkuning,Resource1.mobilmerah,Resource1.mobiloren, Resource1.mobilbiru, Resource1.mobilijo, Resource1.mobilkuning, Resource1.mobilmerah, Resource1.mobiloren, Resource1.Bensin, Resource1.Koin};
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

        //bool replay = false;

        //list utk simpan replay

        public static List<int> xPlayer = new List<int>(); //simpan x mobil player
        public static List<int> dtkxPlayer = new List<int>(); //simpan di dtk ke brp dee masukno ke list -> pk counter mestie

        public static List<int> speedPlayer = new List<int>(); //simpan speed mobil player
        public static List<int> dtkspeedPlayer = new List<int>(); //simpan di dtk ke brp dee masukno ke list -> pk counter mestie

        //public static List<int> koinPlayer = new List<int>(); //simpan koin mobil player
        //public static List<int> dtkkoinPlayer = new List<int>(); //simpan di dtk ke brp dee masukno ke list -> pk counter mestie

        //public static List<int> bensinPlayer = new List<int>(); //simpan bensin mobil player
        //public static List<int> dtkbensinPlayer = new List<int>(); //simpan di dtk ke brp dee masukno ke list -> pk counter mestie

        public static List<int> isiSpawn = new List<int>(); //simpan x mobil musuh
        public static List<int> dtkSpawn = new List<int>(); //simpan di dtk ke brp dee masukno ke list -> pk counter mestie

        public static List<string> tagSpawn = new List<string>();//isi tagnya

        public static List<int> difficultySpawn = new List<int>();//isi tagnya

        //public static List<int> spawnBensin = new List<int>(); //simpan x bensin musuh
        //public static List<int> dtkspawnBensin = new List<int>(); //simpan di dtk ke brp dee masukno ke list -> pk counter mestie

        //public static List<int> spawnCoin = new List<int>(); //simpan x coin musuh
        //public static List<int> dtkspawnCoin = new List<int>(); //simpan di dtk ke brp dee masukno ke list -> pk counter mestie

        public static List<bool> keputusan = new List<bool>(); //simpan keputusan untuk lanjut game atau tidak
        public static List<int> dtkKeputusan = new List<int>(); //simpan di dtk ke brp dee masukno ke list -> pk counter mestie

        public static List<Bitmap> spawn = new List<Bitmap>(); //simpan bitmap mobil musuhnya spy tau wrn mobil yg akan kluar


        public static List<string> listusername = new List<string>(); 
        public static List<string> listscore = new List<string>();

        public static List<int> speedJalan = new List<int>();

        //ketika load, kedua list di atas di isi dengan cara load dari xml dan dimasukkan ke dua list tsb
        //trus di line 280 an (udah tak kasih notes juga) itu di kedua list di save ke xml

        //nanti di form highscore, kamu clear listbox nya dulu, load semua xml nya, masukin listboxnya

        //jadi ada 3...
        //Load list(di form ini, form load) --> save list(di form ini, di dalem void gerakmobil) --> load list (di form highscore)

        private void playthegame_Load(object sender, EventArgs e)
        {
            xPlayer.Clear();
            dtkxPlayer.Clear();
            speedPlayer.Clear();
            dtkspeedPlayer.Clear();
            isiSpawn.Clear();
            dtkSpawn.Clear();
            tagSpawn.Clear();
            difficultySpawn.Clear();
            keputusan.Clear();
            dtkKeputusan.Clear();
            spawn.Clear();
            speedJalan.Clear();

            btnStart.BackColor = Color.LightSkyBlue;
            btnStart.BackgroundImage = Image.FromFile(Application.StartupPath + "\\start.png");
            pnCoin.BackgroundImage = Image.FromFile(Application.StartupPath + "\\coin.png");
            pnScore.BackgroundImage = Image.FromFile(Application.StartupPath + "\\score.png");

            counterunviersal = 0;
            score = 0;
            difficulty = 5;

            lblscore.Text = progressBar1.Value.ToString();
            progressBar1.Value = 300;
            coin = 100;
            label3.Text = coin + "";
            lurus = new Bitmap(Resource1.lurus);
            
            //panel1.BackgroundImage = lurus;
            bg = new Bitmap(Resource1.jalan);
            pictureBox1.BackgroundImage = lurus; //mobil player
            progressBar1.Hide();
            //label5.Hide();
            //label6.Hide();
            //lblSpeed.Hide();
            xPlayer.Add(pictureBox1.Left);
            label7.Text = play.username;
            loadxml();

            label5.Hide();
            label6.Hide();
            lblSpeed.Hide();
            
        } //nde sini tempat load xml nya

        private void playthegame_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(bg, 0, ctr - this.Height, this.Width, this.Height);
            g.DrawImage(bg, 0, ctr, this.Width, this.Height);
        }

        //GAMBARAN SINGKAT
        //per interval kita nyimpen <aku mikire pake ctr>:
        //1. posisi x player, speed player, koin player, bensin player 
        //2. posisi x mobil,koin, bensin(spawn)
        //3. keputusan ketika continue apa ngga nya <ini tpi bukan tiap interval tpi pas yes no questionnya>

        //replaynya hrs ada penanda ini lagi game atau lagi replay bisa boolean bisa string mode


        //ini untuk gerak kanan kiri
        private void playthegame_KeyUp(object sender, KeyEventArgs e)
        {
            if (tesstart) //tesstart supaya dia gbs gerak sblm GO!!
            {
                if (e.KeyCode == Keys.A)
                {
                    kiri = false;
                }
                else if (e.KeyCode == Keys.Left)
                {
                    kiri = false;
                }
                else if (e.KeyCode == Keys.Right)
                {
                    kanan = false;
                }
                else if (e.KeyCode == Keys.D)
                {
                    kanan = false;
                }
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //capture left arrow key
            if (keyData == Keys.Left || keyData == Keys.A)
            {
                kiri = true;
                return true;
            }
            //capture right arrow key
            if (keyData == Keys.Right || keyData == Keys.D)
            {
                kanan = true;
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        // LINE INI KE BAWAH HANYA UNTUK TIMER UNIVERSAL BESERTA FUNCTION NYA. TOLONG JANGAN DI ISI FUNCTION LAIN NANTI SAYA BINGUNG HEHE -tim.
        //(bikin function lain di atasnya saja)

        private void btnStart_Click(object sender, EventArgs e)
        {
            //timer1.Start();n coba dijadiin satu semua
            timerUniversal.Start();
        }

        private void timerUniversal_Tick(object sender, EventArgs e)
        {
            xPlayer.Add(pictureBox1.Left);
            //counterunviersal == 0 || counterunviersal == 500 || counterunviersal == 1000 || counterunviersal == 1500 || counterunviersal == 2000
            if ( counterunviersal % 500 == 0)
            {
                startcountdown(); //3... 2... 1... 
            }
            if (counterunviersal>= 2000 && counterunviersal % 200 == 0)
            {
                spawnmobil();
            }
            if (counterunviersal >= 2000 && counterunviersal % 10 == 0)
            {
                gerakmobil();
            }
            if (counterunviersal >= 2000 && counterunviersal % 10 == 0)
            {
                gerakjalanraya();
            }
            counterunviersal += 10;
            label6.Text = counterunviersal + "";

        }

        void startcountdown()
        {
            // ini timer buat countdown aja
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

        void score_and_diffuclty() 
        {
            score++;
            lblscore.Text = score + "";
            label5.Text = difficulty + "";
        }

        void spawnmobil()
        {
            // ini buat spawn mobil dll
            PictureBox p = new PictureBox();
            int rnd = random.Next(0, 12);
            p.BackgroundImage = musuh[rnd];
            p.BackColor = Color.Transparent;
            p.BackgroundImageLayout = ImageLayout.Stretch;
            spawn.Add(musuh[rnd]);

            int[] coor = { 309, 487, 688, 883 };
            int x = random.Next(0, 4);
            int y = -40; //49 
            p.Location = new Point(coor[x], y);
            p.Size = new Size(60, 100); //ukuran musuh

            if (rnd != 10 && rnd != 11)//cek buat nambahi tag
            {
                p.Tag = "mobil";
                isiSpawn.Add(p.Left);
                dtkSpawn.Add(counterunviersal);
                tagSpawn.Add(p.Tag.ToString());
            }
            else if (rnd == 10)
            {
                p.Tag = "Bensin";
                isiSpawn.Add(p.Left);
                dtkSpawn.Add(counterunviersal);
                tagSpawn.Add(p.Tag.ToString());
            }
            else if (rnd == 11)
            {
                p.Tag = "Coin";
                isiSpawn.Add(p.Left);
                dtkSpawn.Add(counterunviersal);
                tagSpawn.Add(p.Tag.ToString());
            }
            this.Controls.Add(p);
        } 

        void gerakmobil()//intersect with ada di sini
        {
            if (kiri)
            {
                if (pictureBox1.Left + 96 > 400)
                {
                    pictureBox1.Left -= 10;
                }
            }
            if (kanan)
            {
                if (pictureBox1.Left + 96 < 1030)
                {
                    pictureBox1.Left += 10;
                }
            }
            foreach (var x in this.Controls.OfType<PictureBox>())//ini kecepatan mobil musuh
            {
                if (x.Tag.ToString() != "player") //mobil,bensin,coinnya
                {
                    int speed = 6;

                    speed += difficulty;//default = 5

                    x.Top += speed;

                    difficultySpawn.Add(difficulty);


                    if (x.Top >= 700) //supaya ga lag, setelah dia hilang dari layar aku dispose
                    {
                        x.Dispose();
                    }
                }
                //klo sudah lama game nya ini ditambahi value nya supaya mobil musuh lebih cpt
                //spawn rate ditambahi dari design

                if (pictureBox1.Bounds.IntersectsWith(x.Bounds))
                {
                    if (x.Tag.ToString() == "mobil")
                    {
                        x.Tag = "duar";
                        player.SoundLocation = Application.StartupPath + "\\duar.wav";
                        player.Play();
                        tesstart = false;
                        timerUniversal.Stop();
                        ctrTabrak = 0;
                        pbDuar = x;
                        tmrTabrak.Start();
                        //MessageBox.Show(dtkspeedPlayer[0].ToString());

                        //x.Image = duar[ctrTabrak];
                        //x.Dispose();
                        //konsepnya : ada mobil player di jalan biasa, trs nabrak duar kluar animasi,
                        //timer universal di stop, ganti gambar mobil dg duarnya, duarnya animasi, 
                        //duarnya ilang, kluar mbox, mbox continue, yes, timer universal dijalanin lg

                    }
                    else if (x.Tag.ToString() == "Bensin")
                    {
                        x.Dispose();

                        if (progressBar1.Value < 290)
                        {
                            progressBar1.Value += 10;
                        }


                        //buat tau krgnya seberapa apa
                        //bensinPlayer.Add(progressBar1.Maximum - progressBar1.Value);

                        //MessageBox.Show("Bensin");
                        x.Dispose();
                    }
                    else if (x.Tag.ToString() == "Coin")
                    {
                        x.Dispose();
                        coin++;
                        label3.Text = coin + "";

                        //koinPlayer.Add(coin);
                    }
                }
            }
        } //nde sini tempat save xml nya.

        int ctr = 0;
        int ctrbensin = 0;

        //ctr untuk tabrak
        int ctrTabrak = 0;
        PictureBox pbDuar;

        System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        private void tmrTabrak_Tick(object sender, EventArgs e)
        {

            ctrTabrak++;
            if (pbDuar!=null && ctrTabrak<45)
            {
                pbDuar.BackgroundImage = duar[ctrTabrak];
            }

            if (ctrTabrak >= 45)
            {
                ctrTabrak = 0;
                tmrTabrak.Stop();
                pbDuar.Dispose();
                pbDuar = null;
                if (MessageBox.Show("Nabrak mobil \nContinue?", "Play Again", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (MessageBox.Show("10 Coin?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (coin >= 10)
                        {
                            lanjut = true;
                            keputusan.Add(lanjut);
                            dtkKeputusan.Add(counterunviersal);
                            kiri = false;
                            kanan = false;
                            coin -= 10;
                            label3.Text = coin + "";
                            progressBar1.Value = 50;
                            //timer1.Start();
                            //jalan.Start();
                            //timerspawn.Start();
                            //TimerJalan.Start();
                            tesstart = true;
                            timerUniversal.Start();
                        }
                        else
                        {
                            lanjut = false;
                            keputusan.Add(lanjut);
                            dtkKeputusan.Add(counterunviersal);
                            MessageBox.Show("Uang ga cukup");
                            writexml();
                            //mestie disini jg writexml();
                            //if (MessageBox.Show("Replay?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            //{
                            //    //replay e
                                this.Hide();
                                new confirmReplay().Show();
                            //}
                        }
                    }
                    else
                    {
                        lanjut = false;
                        keputusan.Add(lanjut);
                        dtkKeputusan.Add(counterunviersal);
                        listusername.Add(label7.Text);  //save ke xml
                        listscore.Add(lblscore.Text);
                        writexml();
                        //if (MessageBox.Show("Replay?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        //{
                            //replay e
                            this.Hide();
                            new confirmReplay().Show();
                        //}
                    }

                }
                else
                {
                    lanjut = false;
                    keputusan.Add(lanjut);
                    dtkKeputusan.Add(counterunviersal);
                    listusername.Add(label7.Text); //save ke xml
                    listscore.Add(lblscore.Text);
                    writexml();
                    //if (MessageBox.Show("Replay?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    //{
                        //replay e
                        this.Hide();
                        new confirmReplay().Show();
                    //}
                }
                
            }
        }

        void gerakjalanraya()
        {
            //if (kiri)
            //{
            //    if (pictureBox1.Left + 96 > 400)
            //    {
            //        pictureBox1.Left -= 10;
            //    }
            //    xPlayer.Add(pictureBox1.Left);
            //    dtkxPlayer.Add(counterunviersal);
            //}
            //if (kanan)
            //{
            //    if (pictureBox1.Left + 96 < 1030)
            //    {
            //        pictureBox1.Left += 10;
            //    }
            //    xPlayer.Add(pictureBox1.Left);
            //    dtkxPlayer.Add(counterunviersal);
            //}
            //tim ini intervalnya aku ubah jdi 10 ya tim, soale geter di laptop lain
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
                //timer1.Stop();
                //jalan.Stop();
                //timerspawn.Stop();
                //TimerJalan.Stop();
                tesstart = false;
                timerUniversal.Stop();
                //cara merubah button yes no -> 10coin?, no
                if (MessageBox.Show("Bensin Habis \nContinue?", "Play Again", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (MessageBox.Show("10 Coin?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (coin >= 10)
                        {
                            lanjut = true;
                            keputusan.Add(lanjut);
                            dtkKeputusan.Add(counterunviersal);
                            dtkKeputusan.Add(counterunviersal);
                            coin -= 10;
                            label3.Text = coin + "";
                            progressBar1.Value = 50;
                            //timer1.Start();
                            //jalan.Start();
                            //timerspawn.Start();
                            //TimerJalan.Start();
                            
                            tesstart = true;
                            timerUniversal.Start();
                        }
                        else
                        {
                            lanjut = false;
                            keputusan.Add(lanjut);
                            dtkKeputusan.Add(counterunviersal);
                            MessageBox.Show("Uang ga cukup");
                            //mestie disini jg writexml();
                            //if (MessageBox.Show("Replay?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            //{
                            //replay e
                            writexml();
                            this.Hide();
                                new confirmReplay().Show();
                            //}
                        }
                    }
                    else
                    {
                        lanjut = false;
                        keputusan.Add(lanjut);
                        dtkKeputusan.Add(counterunviersal);
                        //replay = true;
                        listusername.Add(label7.Text);  //save ke xml
                        listscore.Add(lblscore.Text);
                        writexml();
                        //if (MessageBox.Show("Replay?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        //{
                            //replay e
                            this.Hide();
                            new confirmReplay().Show();
                        //}
                    }
                }
                else
                {
                    lanjut = false;
                    keputusan.Add(lanjut);
                    dtkKeputusan.Add(counterunviersal);
                    //replay = true;
                    listusername.Add(label7.Text);  //save ke xml
                    listscore.Add(lblscore.Text);
                    writexml();
                    //if (MessageBox.Show("Replay?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    //{
                        //replay e
                        this.Hide();
                        new confirmReplay().Show();
                    //}
                }
            }
            this.Invalidate();


            int speed = 12;
            //5, 10, 15
            if (score == difficulty)
            {
                difficulty += 5;

                if (difficulty >= 15) //limit kesusahan e hanya 30
                {
                    difficulty = 15;
                }
            }
            speed += difficulty;

            //score = 0     score = 5     score = 10     score = 15
            //12 + 5        12+5 + 5       12+5+5 + 5    
            ctr += speed; //klo sudah lama game nya ini ditambahi value nya supaya jalannnya lebih cpt
            lblSpeed.Text = speed + "";

            speedPlayer.Add(speed);
            dtkspeedPlayer.Add(counterunviersal);

            if (ctr > this.Height)
            {
                ctr = 0;
            }
        }
        void writexml()
        {
            XmlWriterSettings xSetting = new XmlWriterSettings();
            xSetting.Indent = true;

            XmlWriter xWriter = XmlWriter.Create(Application.StartupPath + "\\highscore.xml", xSetting);

            xWriter.WriteStartDocument();

            xWriter.WriteStartElement("list");
            for (int i = 0; i < listusername.Count; i++)
            {

                xWriter.WriteStartElement("data");

                xWriter.WriteElementString("Username", listusername[i]);
                xWriter.WriteElementString("Score", listscore[i]);

                xWriter.WriteEndElement();

            }
            xWriter.WriteEndElement();

            xWriter.WriteEndDocument();

            xWriter.Close();
        }

        private void btnStart_MouseEnter(object sender, EventArgs e)
        {
            btnStart.BackColor = Color.LightGreen;
        }

        private void btnStart_MouseLeave(object sender, EventArgs e)
        {
            btnStart.BackColor = Color.LightSkyBlue;
        }

        public static void loadxml()
        {
            listusername.Clear();
            listscore.Clear();
            String nodeName = "";

            XmlReader xReader = XmlReader.Create(Application.StartupPath + "\\highscore.xml");

            while (xReader.Read())
            {
                switch (xReader.NodeType)
                {
                    case XmlNodeType.Element:
                        nodeName = xReader.Name;

                        if (nodeName == "data")
                        {

                        }

                        break;
                    case XmlNodeType.Text:
                        if (nodeName == "Username")
                        {
                            listusername.Add(xReader.Value);
                        }
                        else if (nodeName == "Score")
                        {
                            listscore.Add(xReader.Value);
                        }

                        break;
                }

            }

            xReader.Close();
        }
    }
}

