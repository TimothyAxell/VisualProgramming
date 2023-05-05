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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        Bitmap bg;
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        private void Welcome_Load(object sender, EventArgs e)
        {
            bg = new Bitmap(Resource1.bg);

            Mute.BackgroundImage = Image.FromFile(Application.StartupPath + "\\MuteSmall.png");
            Unmute.BackgroundImage = Image.FromFile(Application.StartupPath + "\\UnmuteSmall.png");
            btnPlay.BackgroundImage = Image.FromFile(Application.StartupPath + "\\play.png");
            btnHS.BackgroundImage = Image.FromFile(Application.StartupPath + "\\highscore.png");

            player.SoundLocation = Application.StartupPath + "\\Music1.wav";
            player.Play();
            Unmute.Visible = false;
            playthegame.listusername.Clear();
            playthegame.listscore.Clear();
            playthegame.loadxml();
        }

        private void Welcome_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(bg, 20, 20, 400, 200);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new play().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new highscore().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnPlay_MouseLeave(object sender, EventArgs e)
        {
            btnPlay.BackColor = Color.LightSkyBlue;
        }

        private void btnHS_MouseLeave(object sender, EventArgs e)
        {
            btnHS.BackColor = Color.LightSkyBlue;
        }

        //private void btnSetting_MouseLeave(object sender, EventArgs e)
        //{
        //    btnSetting.BackColor = Color.PaleTurquoise;
        //}

        //private void btnLogout_MouseLeave(object sender, EventArgs e)
        //{
        //    btnLogout.BackColor = Color.PaleTurquoise;
        //}

        private void btnPlay_MouseEnter(object sender, EventArgs e)
        {
            btnPlay.BackColor = Color.Lime;
        }

        private void btnHS_MouseEnter(object sender, EventArgs e)
        {
            btnHS.BackColor = Color.Yellow;
        }

        //private void btnSetting_MouseEnter(object sender, EventArgs e)
        //{
        //    btnSetting.BackColor = Color.LightGray;
        //}

        //private void btnLogout_MouseEnter(object sender, EventArgs e)
        //{
        //    btnLogout.BackColor = Color.LightGray;
        //}

        private void Unmute_Click(object sender, EventArgs e)
        {
            player.Play();
            Unmute.Visible = false;
            Mute.Visible = true;
        }

        private void Mute_Click(object sender, EventArgs e)
        {
            player.Stop();
            Mute.Visible = false;
            Unmute.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new tutor().Show();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Lime;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightSkyBlue;
        }
    }
}
