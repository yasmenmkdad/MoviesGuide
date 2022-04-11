using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace MoviesGuide
{

    [Serializable]
    public class movie
    {
        
        [XmlElement]
        public String ID { get; set; }

        [XmlElement]
        public String title { get; set; }

        [XmlElement]
        public String director { get; set; }

        [XmlElement]
        public String year { get; set; }

        [XmlElement]
        public String Rating { get; set; }

        [XmlElement]
        public String poster { get; set; }

        [XmlElement]
        public String[] Generes { get; set; }

        [XmlIgnore]
        public Director dir = new Director();

        [XmlIgnore]
        public List<movie> movielist = new List<movie>();

        [XmlIgnore]
        public List<Director> directorlist = new List<Director>();

        [XmlIgnore]
        List<Director> directorAndRating = new List<Director>();

        [XmlIgnore]
        DirectorAndRating dr = new DirectorAndRating();

        private int j;

        public movie()
        { }
        public movie(String ID, String title, String director, String year, String Rating, String poster, String[] Generes)
        {
            this.ID = ID;
            this.director = director;
            this.Generes = Generes;
            this.title = title;
            this.poster = poster;
            this.Rating = Rating;
            this.year = year;
        }

        public void open_file(String filename)
        {
            if (File.Exists(filename + ".xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<movie>));
                using (FileStream stream = new FileStream(filename + ".xml", FileMode.Open))
                {
                    movielist = (List<movie>)serializer.Deserialize(stream);
                }
            }
        }
        public void save_file(String filename)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<movie>));
            using (FileStream stream = new FileStream(filename + ".xml", FileMode.Create))//to delete and write
            {
                serializer.Serialize(stream, movielist);
            }

        }

        public void OpenDirectorFiel()
        {
            XmlSerializer serializer = new XmlSerializer(directorlist.GetType());
            if (File.Exists("directors.xml"))
            {

                FileStream stream = new FileStream("directors.xml", FileMode.Open);
                directorlist = (List<Director>)serializer.Deserialize(stream);
                //MessageBox.Show(directorlist.ElementAt(0).ToString());
                stream.Close();
            }
        }
        public void SaveDirectorFiel()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Director>));
            FileStream stream = new FileStream("directors.xml", FileMode.Create);
            serializer.Serialize(stream, directorlist);
            stream.Close();
        }
        public void AddDirectors()
        {
            if (directorlist.Count() == 0)
            {
                dir.director_name = movielist.ElementAt(0).director;
                directorlist.Add(dir);
            }
            else
            {
                bool found = false;
                for (int i = 0; i < movielist.Count(); i++)
                {
                    for (int j = 0; j < directorlist.Count(); j++)
                    {
                        if (movielist.ElementAt(i).director == directorlist.ElementAt(j).director_name)
                        {
                            found = true;

                        }
                    }
                    if (!found)
                    {
                        dir.director_name = movielist.ElementAt(i).director;
                        directorlist.Add(dir);
                        //MessageBox.Show("added new director in directoe file");
                    }
                }
            }
        }
        public void OpenDirectorsAndRates()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Director>));
            if (File.Exists("directorsandrate.xml"))
            {
                FileStream stream = new FileStream("directorsandrate.xml", FileMode.Open);
                directorAndRating = (List<Director>)serializer.Deserialize(stream);
                stream.Close();
            }
        }
        public void AddDirectorsAndRates()
        {
            if (directorAndRating.Count() == 0)
            {
                dir.director_name = movielist.ElementAt(0).director;
                dr.move_name = movielist.ElementAt(0).ID;
                dr.move_rate = movielist.ElementAt(0).Rating;
                dir.moverating.Add(dr);
                directorAndRating.Add(dir);
                //MessageBox.Show("added new director and its move indirectoe and rate file");
            }
            else
            {
                for (int i = 0; i < movielist.Count(); i++)
                {
                    bool founddorector = false;
                    for (int j = 0; j < directorAndRating.Count(); j++)
                    {
                        bool foundmove = false;
                        if (movielist.ElementAt(i).director.Equals(directorAndRating.ElementAt(j).director_name))
                        {
                            for (int k = 0; k < directorAndRating.ElementAt(j).moverating.Count(); k++)
                            {
                                founddorector = true;
                                if (movielist.ElementAt(i).ID == directorAndRating.ElementAt(j).moverating.ElementAt(k).move_name)
                                {
                                    foundmove = true;

                                    break;

                                }

                            }
                            if (!foundmove)
                            {
                                dr.move_name = movielist.ElementAt(i).ID;
                                dr.move_rate = movielist.ElementAt(i).Rating;
                                directorAndRating.ElementAt(j).moverating.Add(dr);
                            }
                        }
                    }
                    if (founddorector == false)
                    {
                        dir.director_name = movielist.ElementAt(i).director;
                        dr.move_name = movielist.ElementAt(i).ID;
                        dr.move_rate = movielist.ElementAt(i).Rating;
                        dir.moverating.Add(dr);
                        directorAndRating.Add(dir);
                    }
                }
            }
        }
        public void SaveDirectorsAndRatesFiel()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Director>));
            FileStream stream = new FileStream("directorsandrate.xml", FileMode.Create);
            serializer.Serialize(stream, directorAndRating);
            stream.Close();
        }
        
        //public void add(string filename, movie m)
        //{
        //    if (!File.Exists(filename + ".xml"))
        //    {
        //        FileStream f = new FileStream(filename + ".xml", FileMode.Create);
        //        movielist.Add(m);
                
        //        XmlSerializer ser = new XmlSerializer(movielist.GetType());
        //        ser.Serialize(f, m.movielist);
        //        MessageBox.Show("Added");
        //        f.Close();
        //    }
        //    else
        //    {
        //        bool x = false;
        //        XmlDocument doc = new XmlDocument();
        //        doc.Load(filename + ".xml");

        //        XmlNodeList n = doc.GetElementsByTagName("movie");
        //        for (int i = 0; i < n.Count; i++)
        //        {
        //            XmlNodeList children = n[i].ChildNodes;
        //            if (children[1].InnerText.Equals(title))
        //            {
        //                MessageBox.Show("already exists");
        //                x = true;
        //            }
        //        }
        //        if (x == false)
        //        {
        //            XmlElement u = doc.CreateElement("movie");
        //            XmlNode node = doc.CreateElement("ID");
        //            node.InnerText = ID;
        //            u.AppendChild(node);
        //            node = doc.CreateElement("title");
        //            node.InnerText = title;
        //            u.AppendChild(node);
        //            node = doc.CreateElement("director");
        //            node.InnerText = director;
        //            u.AppendChild(node);
        //            node = doc.CreateElement("year");
        //            node.InnerText = year;
        //            u.AppendChild(node);
        //            node = doc.CreateElement("Rating");
        //            node.InnerText = Rating;
        //            u.AppendChild(node);
        //            node = doc.CreateElement("poster");
        //            node.InnerText = poster;
        //            u.AppendChild(node);
        //            for (int i = 0; i < Generes.Length; i++)
        //            {
        //                node = doc.CreateElement("Generes");
        //                node.InnerText = Generes.ElementAt(i);
        //                u.AppendChild(node);
        //            }
        //            doc.Load(filename + ".xml");
        //            XmlElement root = doc.DocumentElement;
        //            root.AppendChild(u);
        //            doc.Save(filename + ".xml");
        //            MessageBox.Show("added");
        //        }
        //    }
        //}
        public void show(string filename, DataGridView moviesdgv)
        {
            moviesdgv.Rows.Clear();
            XmlDocument doc = new XmlDocument();
            doc.Load(filename + ".xml");

            XmlNodeList node = doc.GetElementsByTagName("movie");
            for (int i = 0; i < node.Count; i++)
            {
                XmlNodeList children = node[i].ChildNodes;
                List <string> generes = new List<string>();
                
                string id = children[0].Name;
                string idvalue = children[0].InnerText;

                string name = children[1].Name;
                string nvalue = children[1].InnerText;

                string directorname = children[2].Name;
                string dvalue = children[2].InnerText;

                string year = children[3].Name;
                string yvalue = children[3].InnerText;

                string rate = children[4].Name;
                string rvalue = children[4].InnerText;

                string poster = children[5].Name;
                string pvalue = children[5].InnerText;
                
                string genr = children[6].Name;
                string gvalue="";
                for (int j = 6; j < children.Count; j++)
                {
                    if (children[j].Name == "Generes")
                    {
                        if (gvalue.Equals(""))
                        {
                            gvalue = children[j].InnerText;
                        }
                        else
                        {
                            gvalue = gvalue + " /*/ " + children[j].InnerText;
                        }
                    }
                }

               

                    if (moviesdgv.ColumnCount == 0)
                    {
                        moviesdgv.Columns.Add("ID", id);
                        moviesdgv.Columns.Add("Name", name);
                        moviesdgv.Columns.Add("Director", directorname);
                        moviesdgv.Columns.Add("Year", year);
                        moviesdgv.Columns.Add("Rate", rate);
                        moviesdgv.Columns.Add("Generes", genr);
                        moviesdgv.Columns.Add("Poster", poster);
                    }
                    moviesdgv.Rows.Add(new string[] {idvalue, nvalue, dvalue, yvalue,rvalue,gvalue,pvalue});
                    
                }
            }
        public void delete(string filename, DataGridView moviesdgv)
       {
           XmlDocument doc = new XmlDocument();
           doc.Load(filename+".xml");
           foreach (XmlNode node in doc.SelectNodes("//movie"))
               if (node.SelectSingleNode("title").InnerText.Equals(moviesdgv.SelectedRows[0].Cells[1].Value.ToString()))
                   node.ParentNode.RemoveChild(node);
           doc.Save(filename + ".xml");
           show(filename, moviesdgv);
       }
     
        //search by title
        public int search(String filename, String searchkey)
       {

           bool found = false; int index = 0;
           for (int i = 0; i < movielist.Count; i++)
           {
               if (movielist[i].title == searchkey)
               {
                   found = true;
                   index = i;
                   break;
               }
               else
               { found = false; }
           }
           if (found)
           { return index; }
           else
           { return -1; }
       }
        public List<string> recommend(string[] oldgenres, string titleoldmovie)
       {
           List<movie> recommend = new List<movie>();
           List<string> newlist = new List<string>();
           for (int i = 0; i < movielist.Count(); i++)
           {
               for (int j = 0; j < movielist[i].Generes.Count(); j++)
               {

                   if (oldgenres.Contains(movielist[i].Generes[j]))
                   {
                       if (titleoldmovie != (movielist[i].title))//to no repeat
                       {
                           recommend.Add(movielist[i]);
                           break;
                       }
                   }

               }
           }
           recommend.Sort(delegate(movie c1, movie c2)
           {
               
               int num1 = int.Parse(c1.Rating);
               int num2 = int.Parse(c2.Rating);
               return num1.CompareTo(num2);
           });
           recommend.Reverse();

           for (int i = 0; i < recommend.Count(); i++)
           {
               newlist.Add(recommend[i].title);
           }
           return newlist;
       }
        //search by year
        public List<int> search(int searchkey, String filename)
       {

           List<int> indexat = new List<int>();
           for (int i = 0; i < movielist.Count; i++)
           {
               if (Int32.Parse(movielist[i].year) == searchkey)
               {
                   indexat.Add(i);
               }
           }
           return indexat;
       }
        //search by rate
        public List<int> search(String filename, int searchkey,int check)
       {
           List<int> indexat = new List<int>();
           for (int i = 0; i < movielist.Count; i++)
           {

               if (Int32.Parse(movielist[i].Rating) >= searchkey && check ==1)
               { indexat.Add(i); }

               else if (Int32.Parse(movielist[i].Rating) <= searchkey && check == 2)
               { indexat.Add(i); }

           }
           return indexat;
       }

    }
}
