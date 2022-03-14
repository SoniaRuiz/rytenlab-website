using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RytenLab_Web.Models
{
    public class Pets
    {
        public List<Pet> FurryMembers { get; set; }
        public Pets()
        {
            FurryMembers = new List<Pet>();
        }  
    }
}
