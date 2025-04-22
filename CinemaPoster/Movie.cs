using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaPoster
{
    public class Movie
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public string PosterUrl { get; set; }
        public string Director { get; set; }
        public List<string> Actors { get; set; }
        public List<string> Showtimes { get; set; }
    }
}

