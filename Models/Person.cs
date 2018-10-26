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
        public string PublicationsID { get; set; }
        public List<Publication> PublicationsList { get; set; }
       
    }
}
