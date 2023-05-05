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
    public partial class createnewuser : Form
    {
        public createnewuser()
        {
            InitializeComponent();
        }

        int idx = -1;

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtUserBaru.Text != "")
            {
                for (int i = 0; i < play.user.Count; i++)
                {
                    if (txtUserBaru.Text == play.user[i])
                    {
                        idx = i;
                    }
                    else
                    {
                        idx = -1;
                        
                    }
                    break;
                }
                if (idx!=-1)
                {
                    MessageBox.Show("User sudah terdaftar");
                }
                else
                {
                    play.user.Add(txtUserBaru.Text);
                    MessageBox.Show("User created !");
                    writeUser();
                    this.Hide();
                    new play().Show();
                }
            }
            
        }

        private void createnewuser_Load(object sender, EventArgs e)
        {
            loadUser();
        }

        private void loadUser()
        {
            play.user.Clear();
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
                            play.user.Add(xReader.Value);
                        }

                        break;
                }

            }

            xReader.Close();
        }

        private void writeUser()
        {
            XmlWriterSettings xSetting = new XmlWriterSettings();
            xSetting.Indent = true;

            XmlWriter xWriter = XmlWriter.Create(Application.StartupPath + "\\user.xml", xSetting);

            xWriter.WriteStartDocument();

            xWriter.WriteStartElement("list");
            for (int i = 0; i < play.user.Count; i++)
            {

                xWriter.WriteStartElement("data");

                xWriter.WriteElementString("user", play.user[i]);

                xWriter.WriteEndElement();

            }
            xWriter.WriteEndElement();

            xWriter.WriteEndDocument();

            xWriter.Close();
        }
    }
}
