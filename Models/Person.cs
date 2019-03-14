using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RytenLab_Web.Models
{
    /// <summary>
    /// Model to save information about a team member
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Unique identifier
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Team member's name
        /// </summary>
        public string Name { get; set; }
        public string Title { get; set; }
        /// <summary>
        /// Team member's quote
        /// </summary>
        public string Job { get; set; }
        public string Email { get; set; }
        public string ResearchInterest { get; set; }
        public string Biography { get; set; }
        /// <summary>
        /// List with all publications ID from NCBI
        /// </summary>
        public string NCBIPublicationsID { get; set; }
        /// <summary>
        /// Publications list obtained from NCBI
        /// </summary>
        public List<Publication> NCBIPublicationsList { get; set; }
        /// <summary>
        /// Titles list of pre-accepted publications
        /// </summary>
        public List<string> PreAcceptedPublicationsTitles { get; set; }
        public List<Publication> PreAcceptedPublicationsList { get; set; }
        public string ImagePath { get; set; }
        /// <summary>
        /// Team member's GitHub URL
        /// </summary>
        public string GitHub { get; set; }
        public string ResearchGate { get; set; }
        /// <summary>
        /// Constructor
        /// </summary>
        public Person()
        {
            this.NCBIPublicationsList = new List<Publication>();
            this.PreAcceptedPublicationsList = new List<Publication>();
            this.PreAcceptedPublicationsTitles = new List<string>();
        }
    }
}