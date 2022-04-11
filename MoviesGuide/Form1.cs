using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;
using System.Xml;

namespace MoviesGuide
{


    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
        }


        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (SlideB.Left == 631)
            {
                SlideA.Visible = false;
                SlideA.Left = 631;

                SlideB.Visible = false;
                SlideB.Left = 53;
                SlideB.Visible = true;
                bunifuSeparator1.Left = bunifuThinButton22.Left;
                bunifuSeparator1.Width = bunifuThinButton22.Width;
            }


        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (SlideA.Left == 631)
            {
                SlideB.Visible = false;
                SlideB.Left = 631;

                SlideA.Visible = false;
                SlideA.Left = 53;
                SlideA.Visible = true;
                bunifuSeparator1.Left = bunifuThinButton21.Left;
                bunifuSeparator1.Width = bunifuThinButton21.Width;

            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            string user = usernametxt.Text;
            string pass = passwordtxt.Text;
            bool exist = false;
            XmlDocument doc = new XmlDocument();
            doc.Load("users.xml");
            string username;
            foreach (XmlNode node in doc.SelectNodes("//user"))
            {
                username = node.SelectSingleNode("user_name").InnerText.ToString();
                if (user.Equals(username))
                {
                    exist = true;
                    break;
                }
            }
            if (exist)
            {
                existlbl.Text = "Username already exists";
            }
            else
            {
                if (!File.Exists("users.xml"))
                {
                    XmlWriter xw = XmlWriter.Create("users.xml");
                    xw.WriteStartDocument();
                    xw.WriteStartElement("Table");
                    xw.WriteAttributeString("Name", "users");
                    xw.WriteStartElement("user");
                    xw.WriteStartElement("user_name");
                    xw.WriteString(user);
                    xw.WriteEndElement();
                    xw.WriteStartElement("password");
                    xw.WriteString(pass);
                    xw.WriteEndElement();
                    xw.WriteEndElement();
                    xw.WriteEndElement();
                    xw.WriteEndDocument();
                    xw.Close();
                }
                else
                {
                    XmlElement u = doc.CreateElement("user");
                    XmlNode node = doc.CreateElement("user_name");
                    node.InnerText = user;
                    u.AppendChild(node);
                    node = doc.CreateElement("password");
                    node.InnerText = pass;
                    u.AppendChild(node);
                    doc.Load("users.xml");
                    XmlElement root = doc.DocumentElement;
                    root.AppendChild(u);
                    doc.Save("users.xml");
                }

                checkmark check = new checkmark();
                check.Visible = true;
                this.Controls.Add(check);
                check.BringToFront();
                check.Location = new Point(70, 103);
                usernametxt.Text = "";
                passwordtxt.Text = "";
            }
        }

        private void signinuserbtn_Click(object sender, EventArgs e)
        {
            bool check = false;
            string user = usernametxt1.Text;
            string pass = passwordtxt1.Text;
            XmlDocument doc = new XmlDocument();
            doc.Load("users.xml");
            string password, username;
            foreach(XmlNode node in doc.SelectNodes("//user"))
            {
                username = node.SelectSingleNode("user_name").InnerText.ToString();
                password = node.SelectSingleNode("password").InnerText.ToString();
                if(user.Equals(username)&&pass.Equals(password))
                {
                    check = true;
                    break;
                }
            }
            if(check)
            {
                MessageBox.Show(usernametxt1.Text,"Login Successeded",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                usernametxt.Text = "";
                passwordtxt1.Text = "";
                invalidadminlbl.Text = "";
                loading load = new loading();
                load.Visible = true;
                this.Controls.Add(load);
                load.BringToFront();
            }
            else
            {
                invalidlbl.Text= "Invalid Username or Password";

            }

            
        }

        private void signinadminbtn_Click(object sender, EventArgs e)
        {
            string adminpass = "admin";
            if (adminpasstxt.Text == adminpass)
            {
                adminpasstxt.Text = "";
                MessageBox.Show("You're now the admin");
                adminUC admin = new adminUC();
                admin.Visible = true;
                this.Controls.Add(admin);
                admin.BringToFront();
            }
            else
            {
                invalidadminlbl.Text = "Invalid Admin Password";
            }
        }
    }
}
