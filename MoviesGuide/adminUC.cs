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

namespace MoviesGuide
{
    public partial class adminUC : UserControl
    {
        public adminUC()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            adminaddUC add = new adminaddUC();
            add.Visible = true;
            this.Controls.Add(add);
            add.BringToFront();
        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            removeUC remove = new removeUC();
            remove.Visible = true;
            this.Controls.Add(remove);
            remove.BringToFront();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            updateUC update = new updateUC();
            update.Visible = true;
            this.Controls.Add(update);
            update.BringToFront();
        }

        private void filesbtn_Click(object sender, EventArgs e)
        {
            if (!File.Exists("directors.xml") || !File.Exists("directorsandrate.xml"))
            {
                MessageBox.Show("There are no movies please add one first!");
            }
            else
            {
                directorsandrating d = new directorsandrating();
                d.Visible = true;
                this.Controls.Add(d);
                d.BringToFront();
            }
        }
    }
}
