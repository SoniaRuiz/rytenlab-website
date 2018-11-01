using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RytenLab_Web.Models
{
    public class Publication
    {
        public string Title { get; set; }
        public string ShortTitle { get; set; }
        public string Abstract { get; set; }
        public string Doi { get; set; }
        public string JournalName { get; set; }
        public string Volume { get; set; }
        public string Date { get; set; }
        public string Pages { get; set; }
        public string Link { get; set; }
        public List<string> Authors { get; set; }

        public Publication()
        {
            this.Authors = new List<string>();
        }
    }
}
