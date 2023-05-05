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
    public partial class play : Form
    {
        public play()
        {
            InitializeComponent();
        }

        int ctr = -1;
        public static string username;
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (cmbUser.Text!="")
            {
                this.Hide();
                new Form2().Show();
            }
            else
            {
                MessageBox.Show("user belum dipilih");
            }
        }

        public static List<string> user = new List<string>();

        private void btnCreate_Click(object sender, EventArgs e)
        {
            this.Hide();
            new createnewuser().Show();
        }

        private void play_Load(object sender, EventArgs e)
        {
            loadUser();
            for (int i = 0; i < user.Count; i++)
            {
                cmbUser.Items.Add(user[i]);
            }
            cmbUser.SelectedIndex = 0;
        }

        private void loadUser()
        {
            user.Clear();
            String nodeName = "";

            XmlReader xReader = XmlReader.Create(Application.StartupPath + "\\user.xml");

            while (xReader.Read())
            {
                switch (xReader.NodeType)
                {
                    case XmlNodeType.Element:
                        nodeName = xReader.Name;

                        if (nodeName == "list")
                        {

                        }

                        break;
                    case XmlNodeType.Text:
                        if (nodeName == "user")
                        {
                            user.Add(xReader.Value);
                        }

                        break;
                }

            }

            xReader.Close();
        }

        private void cmbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            ctr = cmbUser.SelectedIndex;
            lblUser.Text = user[ctr];
            username = lblUser.Text;
            btnPlay.Text = "";
            btnPlay.Text = "Play as " +  cmbUser.Text;
        }

        private void play_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            new Welcome().Show();
        }
    }
}
