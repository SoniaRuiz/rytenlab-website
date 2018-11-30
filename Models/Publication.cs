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
        public string Doi { get; set; }
        public string JournalName { get; set; }
        public string Volume { get; set; }
        public string Date { get; set; }
        public string Pages { get; set; }
        public string Link { get; set; }
        public List<string> Authors { get; set; }

        /// <summary>
        /// Constructor to initialize/set default values
        /// </summary>
        public Publication()
        {
            this.Authors = new List<string>();
        }
        /// <summary>
        /// Method to split a string by ',' and store the result in a list
        /// </summary>
        /// <param name="authors"></param>
        /// <returns></returns>
        public List<string> SetAuthors(string authors)
        {
            //Split the string
            string[] authorsSplited = authors.Split(",");
            //Return a list with the splitted values
            return authorsSplited.ToList<string>();
        }
    }
}
