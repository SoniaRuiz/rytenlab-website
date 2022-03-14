using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RytenLab_Web.Models
{
    /// <summary>
    /// Model to save information about a team member
    /// </summary>
    public class Pet
    {
        /// <summary>
        /// Unique identifier
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Unique string identifier
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// Team member's name
        /// </summary>
        public string Name { get; set; }
        public string Nickname { get; set; }
        /// <summary>
        /// Team member's quote
        /// </summary>
        public string HumanName { get; set; }
        public string Bio { get; set; }

        public string ImagePath { get; set; }
        /// <summary>
        /// Constructor
        /// </summary>
        public Pet()
        {
        }
    }
}