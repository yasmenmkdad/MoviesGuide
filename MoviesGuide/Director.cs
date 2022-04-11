using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace MoviesGuide
{
    [Serializable, XmlRoot("table")]
    public class Director
    {
        [XmlElement]
        public string director_name { get; set; }
        //list of directors 
        [XmlElement]
        public List<DirectorAndRating> moverating = new List<DirectorAndRating>();
        [XmlIgnore]
        private string _director_name;
        [XmlIgnore]
        DirectorAndRating dm = new DirectorAndRating();
        [XmlIgnore]
        int count = 0;
        public Director()
        {
            director_name = "";
        }
        public Director(string director_name)
        {
            this.director_name = director_name;
        }
    }
}
