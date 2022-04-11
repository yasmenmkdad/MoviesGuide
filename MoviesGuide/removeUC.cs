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
    public partial class removeUC : UserControl
    {
        public removeUC()
        {
            InitializeComponent();
            label1.Hide();
            bunifuCustomLabel6.Show();
            filenametxt.Show();
            showbtn.Show();
            moviesdgv.Hide();
            removebtn.Hide();
            moviesdgv.Rows.Clear();
           
        }
        private void removeUC_Load(object sender, EventArgs e)
        {

        }
        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void showbtn_Click_1(object sender, EventArgs e)
        {
            if (filenametxt.Text == "")
                label1.Show();
            else if (!File.Exists(filenametxt.Text + ".xml"))
            {
                MessageBox.Show("El file is not exists");
            }
            else
            {
                moviesdgv.Show();
                removebtn.Show();
                bunifuCustomLabel6.Hide();
                filenametxt.Hide();
                showbtn.Hide();
                label1.Hide();
                movie c = new movie();
                c.show(filenametxt.Text, moviesdgv);
            }
        }

        private void moviesdgv_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = moviesdgv.Rows[index];
        }

        private void bunifuCustomLabel6_Click(object sender, EventArgs e)
        {

        }

        private void filenametxt_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void removebtn_Click_1(object sender, EventArgs e)
        {

            movie c = new movie();
            c.delete(filenametxt.Text, moviesdgv);
            
        }
    }
}
