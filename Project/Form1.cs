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
using System.IO;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string usernamereg, passwordreg;
        string usernamelog, passwordlog;

        public static int index;

        public static List<string> listusername = new List<string>();
        public static List<string> listpassword = new List<string>();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool check = false;
            index = -1;
            usernamelog = textBox1.Text;
            passwordlog = textBox2.Text;
            if (usernamelog == "" || passwordlog == "")
            {
                MessageBox.Show("Semua field harus diisi sebelum login");
            }
            else if (usernamelog == "admin" && passwordlog == "admin")
            {
                clearx();

                MessageBox.Show("Masuk sebagai admin");
                new FormReplay().Show();
                this.Hide();
            }
            else
            {
                foreach (string item in listusername)
                {
                    if (usernamelog == item)
                    {
                        check = true;
                    }
                }

                if (!check)
                {
                    MessageBox.Show("Username belum terdaftar");
                    clearx();
                }
                else
                {
                    for (int i = 0; i < listusername.Count; i++)
                    {
                        if (usernamelog == listusername[i])
                        {
                            index = i;
                        }
                    }
                    if (passwordlog == listpassword[index])
                    {

                        MessageBox.Show("Berhasil Login");
                        clearx();

                        new Form2().Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Password salah");
                        textBox2.Clear();
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string nodeName = "";

            listusername.Clear();
            listpassword.Clear();

            XmlReader xReader = XmlReader.Create(Application.StartupPath + "\\userlogin.xml");

            while (xReader.Read())
            {
                switch (xReader.NodeType)
                {
                    case XmlNodeType.Element:
                        nodeName = xReader.Name;
                        break;

                    case XmlNodeType.Text:
                        if (nodeName == "Nama")
                        {
                            listusername.Add(xReader.Value);

                        }
                        else if (nodeName == "Password")
                        {
                            listpassword.Add(xReader.Value);
                        }

                        break;
                }
            }
            xReader.Close();
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            bool check = false;

            usernamereg = textBox4.Text;
            passwordreg = textBox3.Text;
            if (usernamereg == "" || passwordreg == "")
            {
                MessageBox.Show("Semua field harus diisi sebelum register");
            }
            else if (usernamereg == "admin" || passwordreg == "admin")
            {
                MessageBox.Show("terdapat kata terlarang");
            }
            else
            {

                foreach (string item in listusername)
                {
                    if (item == usernamereg)
                    {
                        check = true;
                    }
                }
                if (check)
                {
                    MessageBox.Show("Username sudah terregister");
                    clearx();
                }
                else
                {
                    listusername.Add(usernamereg);
                    listpassword.Add(passwordreg);
                    MessageBox.Show("Username berhasil diregister");
                    clearx();


                    XmlWriterSettings xSetting = new XmlWriterSettings();
                    xSetting.Indent = true;

                    XmlWriter xwriter = XmlWriter.Create(Application.StartupPath + "\\userlogin.xml", xSetting);

                    xwriter.WriteStartDocument();

                    xwriter.WriteStartElement("data");
                    for (int i = 0; i < listusername.Count; i++)
                    {

                        xwriter.WriteElementString("Nama", listusername[i]);
                        xwriter.WriteElementString("Password", listpassword[i]);

                    }
                    xwriter.WriteEndElement();

                    xwriter.WriteEndDocument();

                    xwriter.Close();




                }
            }
        }

        private void clearx()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
        
    }
}
