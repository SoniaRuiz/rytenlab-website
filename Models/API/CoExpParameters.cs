using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RytenLab_Web.Models
{
    public class CoExpParameters
    {
        /// <summary>
        /// The name of the category.
        /// </summary>
        /// <example>"CoExpROSMAP"</example>
        public string Category { get; set; }

        /// <summary>
        /// The name of the network from which to obtain all the modules. This network must belong to the category specified above.
        /// </summary>
        /// <example>"ad"</example>
        public string Network { get; set; }

        /// <summary>
        /// List of categories separated by commas. 
        /// </summary>
        /// <example>"CoExpROSMAP,gtexv6"</example>
        public string Categories { get; set; }

        /// <summary>
        /// List of networks separated by commas. Each network must belong to the category specified.
        /// </summary>
        /// <example>"ad,notad"</example>
        public string Networks { get; set; }
        /// <summary>
        /// The name of the module from which to obtain all the co-expression data. This module must belong to the network specified above.
        /// </summary>
        /// <example>"yellow"</example>
        public string Module { get; set; }
        /// <summary>
        /// List of genes. Each gene must be separated by a comma. The genes can be specified by both their name or EnsambleID.
        /// </summary>
        /// <example>PMVK,KRTCAP2,GBAP1</example>
        public string Genes { get; set; }

        /// <summary>
        /// The top 50,30,10, etc. genes more important.
        /// </summary>
        /// <example>"10"</example>
        public string TopGenes { get; set; }
    }
}
