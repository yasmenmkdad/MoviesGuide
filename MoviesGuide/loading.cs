using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoviesGuide
{
    public partial class loading : UserControl
    {
        int value = 0;
        public loading()
        {
            InitializeComponent();
            this.timer1.Start();
            bunifuFlatButton1.Hide();
        }

        private void loading_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            value += 5;
            bunifuProgressBar1.Value = value;
            if (bunifuProgressBar1.Value == 100)
            {
                timer1.Stop();
                bunifuFlatButton1.Show();
                
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            search s = new search();
            s.Visible = true;
            this.Controls.Add(s);
            s.BringToFront();
        }
    }
}
