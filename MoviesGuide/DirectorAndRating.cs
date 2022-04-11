using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace MoviesGuide
{
    public class DirectorAndRating
    {
        [XmlElement]
        public string move_rate;
        [XmlElement]
        public string move_name;

        public DirectorAndRating()
        {

        }
        public DirectorAndRating(string move_rate, string move_name)
        {
            this.move_name = move_name;
            this.move_rate = move_rate;
        }
    }
}
