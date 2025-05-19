using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RytenLab_Web.Models
{
    /// <summary>
    /// Model to store information about a single publication.
    /// </summary>
    public class Publication
    {
        /// <summary>
        /// Properties to store information about a single publication
        /// </summary>
        public string Title { get; set; }
        public string ShortTitle { get; set; }
        public string Abstract { get; set; }
        public string DOI { get; set; }
        public string JournalInfo { get; set; }
        public string Authors { get; set; }

        public string Year { get; set; }

        /// <summary>
        /// Constructor to initialize/set default values
        /// </summary>
        public Publication() { }
    }
}
