using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RytenLab_Web.Models
{
    public class Publication
    {
        public String Title { get; set; }
        public String ShortTitle { get; set; }
        public String JournalName { get; set; }
        public String Volume { get; set; }
        public DateTime Date { get; set; }
        public String Pages { get; set; }
        public String Link { get; set; }
    }
}
