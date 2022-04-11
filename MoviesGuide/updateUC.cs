using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace MoviesGuide
{
    public partial class updateUC : UserControl
    {
        public updateUC()
        {
            InitializeComponent();
            label1.Hide();
            bunifuCustomLabel6.Show();
            filenametxt.Show();
            showbtn.Show();
            moviesdgv.Hide();
            posteraddbtn.Hide();
            imagetxt.Hide();
            movieidtxt.Hide();
            movienametxt.Hide();
            directornametxt.Hide();
            ratingtxt.Hide();
            yeartxt.Hide();
            generestxt.Hide();
            updatemoviebtn.Hide();
            namelbl.Hide();
            bunifuCustomLabel1.Hide();
            bunifuCustomLabel2.Hide();
            bunifuCustomLabel3.Hide();
            bunifuCustomLabel4.Hide();
            bunifuCustomLabel5.Hide();
            
        }
        private void updateUC_Load(object sender, EventArgs e)
        {

        }

        private void moviesdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = moviesdgv.Rows[index];
            movieidtxt.Text = selectedRow.Cells[0].Value.ToString();
            movienametxt.Text = selectedRow.Cells[1].Value.ToString();
            directornametxt.Text = selectedRow.Cells[2].Value.ToString();
            yeartxt.Text = selectedRow.Cells[3].Value.ToString();
            generestxt.Text = selectedRow.Cells[5].Value.ToString();
            ratingtxt.Text = selectedRow.Cells[4].Value.ToString();
            imagetxt.Text = selectedRow.Cells[6].Value.ToString();

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void updatemoviebtn_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(filenametxt.Text+".xml");
            foreach (XmlNode node in doc.SelectNodes("//movie"))
            {
                MessageBox.Show(node.SelectSingleNode("title").InnerText);
                MessageBox.Show(moviesdgv.SelectedRows[0].Cells[1].Value.ToString());
                if (node.SelectSingleNode("title").InnerText.Equals(moviesdgv.SelectedRows[0].Cells[1].Value.ToString()))
                {

                    node.SelectSingleNode("ID").InnerText = movieidtxt.Text;
                    node.SelectSingleNode("title").InnerText = movienametxt.Text;
                    node.SelectSingleNode("director").InnerText = directornametxt.Text;
                    List<string> l = new List<string>();

                    for (int i = 0; i < genereschecklist.Items.Count; i++)
                    {
                        if (genereschecklist.GetItemChecked(i))
                        {
                            l.Add(((string)genereschecklist.Items[i]));
                        }
                    }
                    string[] Generes = new string[l.Count];
                    for (int i = 0; i < l.Count; i++)
                    {
                        Generes[i] = l.ElementAt(i);
                    }
                    for (int i = 0; i < Generes.Length; i++)
                    {
                        node.SelectSingleNode("Generes").InnerText = generestxt.Text;
                    }
                    node.SelectSingleNode("Rating").InnerText = ratingtxt.Text;
                    node.SelectSingleNode("year").InnerText = yeartxt.Text;
                    node.SelectSingleNode("poster").InnerText = imagetxt.Text;
                }
            }
             doc.Save(filenametxt.Text + ".xml");
             movie c = new movie();
                c.show(filenametxt.Text, moviesdgv);
              
        
           
        }

        private void showbtn_Click(object sender, EventArgs e)
        {
            if (!File.Exists(filenametxt.Text + ".xml") || filenametxt.Text == "")
            {
                label1.Show();
                label1.Text = "File doesn't exist";
            }
            else
            {
                moviesdgv.Show();
                posteraddbtn.Show();
                imagetxt.Show();
                movieidtxt.Show();
                movienametxt.Show();
                directornametxt.Show();
                ratingtxt.Show();
                yeartxt.Show();
                generestxt.Show();
                updatemoviebtn.Show();
                namelbl.Show();
                bunifuCustomLabel1.Show();
                bunifuCustomLabel2.Show();
                bunifuCustomLabel3.Show();
                bunifuCustomLabel4.Show();
                bunifuCustomLabel5.Show();
                bunifuCustomLabel6.Hide();
                filenametxt.Hide();
                showbtn.Hide();
                movie c = new movie();
                c.show(filenametxt.Text, moviesdgv);
            }
        }

        private void posteraddbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imagetxt.Text = ofd.FileName;
            }

        }
    }
}