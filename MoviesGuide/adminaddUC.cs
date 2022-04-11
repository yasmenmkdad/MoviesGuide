using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace MoviesGuide
{
    public partial class adminaddUC : UserControl
    {
        
        public adminaddUC()
        {
            InitializeComponent();
           
        }

        OpenFileDialog ofd = new OpenFileDialog();

        private void adminaddUC_Load(object sender, EventArgs e)
        {

        }

        private void posteraddbtn_Click(object sender, EventArgs e)
        {
            
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                imagetxt.Text = ofd.FileName;
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void addmoviebtn_Click(object sender, EventArgs e)
        {
            string id = movieidtxt.Text;
            string name = movienametxt.Text;
            string directorname = directornametxt.Text;
            string year = yeartxt.Text;
            string rate = ratingtxt.Text;
            string filename = filenametxt.Text;
            string poster = imagetxt.Text;
            int j=0;
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
                Generes[i]=l.ElementAt(i);
            }
            movie c = new movie(id, name, directorname, year, rate, poster, Generes);
            //c.add(filename,c);
            c.movielist.Add(c);
            c.save_file(filename);
            c.OpenDirectorFiel();
            c.AddDirectors();
            c.SaveDirectorFiel();
            c.OpenDirectorsAndRates();
            c.AddDirectorsAndRates();
            c.SaveDirectorsAndRatesFiel();
        }

        private void ratingtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
