using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RytenLab_Web.Models
{
    /// <summary>
    /// Model to store information about a single publication.
    /// </summary>
    public class Publications
    {
        public List<Publication> Manuscripts { get; set; }
        public Publications()
        {
            Manuscripts = new List<Publication>();
        }
    }
}
