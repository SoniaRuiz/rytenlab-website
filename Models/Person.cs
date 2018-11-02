using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RytenLab_Web.Models
{
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public string ResearchInterest { get; set; }
        public string Biography { get; set; }
        public string NCBIPublicationsID { get; set; }
        public List<Publication> NCBIPublicationsList { get; set; }
        public List<string> CrossRefPublicationsTitles { get; set; }
        public List<Publication> CrossRefPublicationsList { get; set; }
        public string ImagePath { get; set; }
        public string GitHub { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public Person()
        {
            this.NCBIPublicationsList = new List<Publication>();
            this.CrossRefPublicationsList = new List<Publication>();
            this.CrossRefPublicationsTitles = new List<string>();
        }
    }
}