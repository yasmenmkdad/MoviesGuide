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
    public partial class directorsandrating : UserControl
    {
        public directorsandrating()
        {
            InitializeComponent();
        }

        private void directorsandrating_Load(object sender, EventArgs e)
        {
            //    dataGridView1.Rows.Clear();
            //    dataGridView2.Rows.Clear();

            //    XmlDocument doc = new XmlDocument();
            //    doc.Load("directors.xml");
            //    XmlNodeList node = doc.GetElementsByTagName("Director");
            //    for (int i = 0; i < node.Count; i++)
            //    {
            //        XmlNodeList children = node[i].ChildNodes;
            //        string name = children[0].Name;
            //        string nvalue = children[0].InnerText;
            //        if (dataGridView1.ColumnCount == 0)
            //        {
            //            dataGridView1.Columns.Add("Director name", name);
            //        }
            //        dataGridView1.Rows.Add(nvalue);
            //    }

            //    XmlDocument doc2 = new XmlDocument();
            //    doc2.Load("directorsandrate.xml");
            //    XmlNodeList node2 = doc2.GetElementsByTagName("Director");
            //    XmlNodeList node3 = doc2.GetElementsByTagName("moverating");
            //    for (int i = 0; i < node3.Count; i++)
            //    {
            //        XmlNodeList children = node[i].ChildNodes;
            //        string rate = children[0].Name;
            //        string rvalue = children[0].InnerText;

            //        string name = children[1].Name;
            //        string nvalue = children[1].InnerText;

            //        if (dataGridView2.ColumnCount == 0)
            //        {
            //            dataGridView2.Columns.Add("Rate", rate);
            //            dataGridView2.Columns.Add("Movie name", name);
            //        }
            //        dataGridView2.Rows.Add(new string[] { rvalue});
            //    }
            //    for (int i = 0; i < node2.Count; i++)
            //    {
            //        XmlNodeList children = node[i].ChildNodes;

            //        string name = children[1].Name;
            //        string nvalue = children[1].InnerText;

            //        if (dataGridView2.ColumnCount == 0)
            //        {
            //            dataGridView2.Columns.Add("Director name", name);
            //        }
            //        dataGridView2.Rows.Add(nvalue);
            //    }
        }
    }
}