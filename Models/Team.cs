using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RytenLab_Web.Models
{
    public class Team
    {
        public List<Person> TeamMembers { get; set; }
        public Team()
        {
            TeamMembers = new List<Person>();
        }  
    }
}
