using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoviesGuide
{
    public partial class search : UserControl
    {
        public search()
        {
            InitializeComponent();
        }

        private void search_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void searchbtn1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            movie m = new movie();
            String filename = filenametxt1.Text;
            m.open_file(filename);
            try
            {
                int searchkey = Int32.Parse(searchkeytxt1.Text);
                List<int> indexlist = new List<int>();
                indexlist = m.search(searchkey, filename);
                if (indexlist.Count == 0)
                {
                    MessageBox.Show("NOT FOUND !!");
                }
                for (int i = 0; i < m.movielist.Count; i++)
                {

                    for (int k = 0; k < indexlist.Count; k++)
                    {
                        if (i == indexlist.ElementAt(k))
                        {
                            ArrayList rows = new ArrayList();
                            int iii = m.movielist[i].Generes.Length;
                            dataGridView1.Rows.Add(new string[] { m.movielist[i].ID, m.movielist[i].title, m.movielist[i].director, m.movielist[i].year, m.movielist[i].Rating });
                            DataGridViewComboBoxCell cell = new DataGridViewComboBoxCell();
                            dataGridView1[5, k] = cell;
                            List<string> recommend = m.recommend(m.movielist[i].Generes, m.movielist[i].title);
                            DataGridViewComboBoxCell cell2 = new DataGridViewComboBoxCell();
                            dataGridView1[6, k] = cell2;
                            for (int j = 0; j < iii; j++)
                            {
                                rows.Add(m.movielist[i].Generes.ElementAt(j));
                                cell.Items.AddRange(m.movielist[i].Generes.ElementAt(j));
                            }
                            for (int re = 0; re < recommend.Count; re++)
                            {
                                cell2.Items.AddRange(recommend.ElementAt(re));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("InCorrect Format");
            }
        }
        private void searchbtn2_Click_1(object sender, EventArgs e)
        {

            dataGridView2.Rows.Clear();
            movie m = new movie();
            String filename = filnametxt2.Text;
            m.open_file(filename);
            try
            {
                int searchkey = Int32.Parse(searchkeytxt2.Text);
                List<int> foundlist = new List<int>();

                if (above.Checked)
                    foundlist = m.search(filename, searchkey, 1);
                else if(below.Checked)
                    foundlist = m.search(filename, searchkey, 2);
                if (foundlist.Count == 0)
                {
                    MessageBox.Show("NOT FOUND !!");
                }
                for (int allindex = 0; allindex < m.movielist.Count; allindex++)
                {
                    for (int founfindex = 0; founfindex < foundlist.Count; founfindex++)
                    {
                        if (allindex == foundlist.ElementAt(founfindex))
                        {
                            ArrayList rows = new ArrayList();
                            int iii = m.movielist[allindex].Generes.Length;
                            dataGridView2.Rows.Add(new string[] { m.movielist[allindex].ID, m.movielist[allindex].title, m.movielist[allindex].director, m.movielist[allindex].year, m.movielist[allindex].Rating });
                            DataGridViewComboBoxCell cell = new DataGridViewComboBoxCell();
                            dataGridView2[5, founfindex] = cell;
                            List<string> recommend = m.recommend(m.movielist[allindex].Generes, m.movielist[allindex].title);
                            DataGridViewComboBoxCell cell2 = new DataGridViewComboBoxCell();
                            dataGridView2[6, founfindex] = cell2;

                            for (int j = 0; j < iii; j++)
                            {
                                rows.Add(m.movielist[allindex].Generes.ElementAt(j));

                                cell.Items.AddRange(m.movielist[allindex].Generes.ElementAt(j));
                            }
                            for (int re = 0; re < recommend.Count; re++)
                            {
                                cell2.Items.AddRange(recommend.ElementAt(re));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("InCorrect Format");
            }
        }
        private void searchbtn3_Click_1(object sender, EventArgs e)
        {
            dataGridView3.Rows.Clear();
            movie m = new movie();
            String filename = filenametxt3.Text;
            m.open_file(filename);
            String searchkey = searchkeytxt3.Text;
            int index = m.search(filename, searchkey);
            MessageBox.Show(index.ToString());
            if (index == -1)
            {
                MessageBox.Show("NOT FOUND !!");
            }
            else
            {

                ArrayList rows = new ArrayList();
                int iii = m.movielist[index].Generes.Length;
                dataGridView3.Rows.Add(new string[] { m.movielist[index].ID, m.movielist[index].title, m.movielist[index].director, m.movielist[index].year, m.movielist[index].Rating });
                DataGridViewComboBoxCell cell = new DataGridViewComboBoxCell();
                dataGridView3[5, 0] = cell;
                List<string> recommend = m.recommend(m.movielist[index].Generes, m.movielist[index].title);

                DataGridViewComboBoxCell cell2 = new DataGridViewComboBoxCell();
                dataGridView3[6, 0] = cell2;
                for (int i = 0; i < iii; i++)
                {
                    rows.Add(m.movielist[index].Generes.ElementAt(i));
                    cell.Items.AddRange(m.movielist[index].Generes.ElementAt(i));
                }
                for (int re = 0; re < recommend.Count; re++)
                {
                    cell2.Items.AddRange(recommend.ElementAt(re));
                }
            }
        }
        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
