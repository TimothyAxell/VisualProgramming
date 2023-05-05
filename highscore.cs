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
    public partial class highscore : Form
    {
        public highscore()
        {
            InitializeComponent();
        }
        List<string> listtop3 = new List<string>();
        List<string> listtempusername = new List<string>();
        List<string> listtempscore = new List<string>();
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Welcome().Show();
        }

        private void buttonBack_MouseEnter(object sender, EventArgs e)
        {
            buttonBack.BackColor = Color.Red;
        }

        private void buttonBack_MouseLeave(object sender, EventArgs e)
        {
            buttonBack.BackColor = Color.LightSkyBlue;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void highscore_Load(object sender, EventArgs e)
        {
            listtempscore.Clear();
            listtempusername.Clear();
            listtop3.Clear();

            buttonBack.BackgroundImage = Image.FromFile(Application.StartupPath + "\\back.png");
            pbChamp.BackgroundImage = Image.FromFile(Application.StartupPath + "\\champs.png");
            pbTop3.BackgroundImage = Image.FromFile(Application.StartupPath + "\\top3.png");
            //pbUname.BackgroundImage = Image.FromFile(Application.StartupPath + "\\username.png");
            //pbPersonalBest.BackgroundImage = Image.FromFile(Application.StartupPath + "\\personalbest.png");

            if (playthegame.listusername.Count!= 0)
            {
                //for (int i = 0; i < playthegame.listusername.Count; i++)
                //{
                //    listBox1.Items.Add(playthegame.listusername[i] + " - " + playthegame.listscore[i].ToString());
                //}
                
                listtempusername = playthegame.listusername;
                listtempscore = playthegame.listscore;
                listtempusername.Reverse();
                listtempscore.Reverse();
                for (int i = 0; i < listtempusername.Count; i++)
                {
                    listBox1.Items.Add(listtempusername[i] + " - " + listtempscore[i].ToString());
                    if (listBox1.Items.Count == 10)
                    {
                        break;
                    }
                }


                //listBox2.Hide();
                //pbTop3.Hide();

                //hihgscore
                int temp = playthegame.listusername.Count;
                if (temp >= 3)
                {
                    temp = 3;
                }
                for (int z = 0; z < temp; z++)
                {
                    int tertinggi = 0;
                    int index = -1;
                    for (int i = 0; i < playthegame.listscore.Count; i++)
                    {
                        if (Convert.ToInt32(playthegame.listscore[i]) > tertinggi)
                        {
                            tertinggi = Convert.ToInt32(playthegame.listscore[i]);
                            index = i;

                        }
                    }
                    listBox2.Items.Add(playthegame.listusername[index] + " - " + tertinggi);
                    listtop3.Add(playthegame.listusername[index]);
                    playthegame.listscore.RemoveAt(index);
                    playthegame.listusername.RemoveAt(index);
                }

                label1.Text = listtop3[0];
            }
            

        }
    }
}
