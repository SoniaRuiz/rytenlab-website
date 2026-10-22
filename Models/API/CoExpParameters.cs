using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RytenLab_Web.Models
{
    public class CoExpParameters
    {
        /// <summary>
        /// The name of the category.
        /// </summary>
        /// <example>CoExpROSMAP</example>
        [StringLength(64)]
        [RegularExpression(@"^[A-Za-z0-9._-]*$")]
        public string Category { get; set; }

        /// <summary>
        /// The name of the network from which to obtain all the modules. This network must belong to the category specified above.
        /// </summary>
        /// <example>ad</example>
        [StringLength(64)]
        [RegularExpression(@"^[A-Za-z0-9._-]*$")]
        public string Network { get; set; }

        /// <summary>
        /// List of categories separated by commas. 
        /// </summary>
        /// <example>CoExpROSMAP,CoExpROSMAP</example>
        [StringLength(2000)]
        [RegularExpression(@"^[A-Za-z0-9._,\- ]*$")]
        public string Categories { get; set; }

        /// <summary>
        /// List of networks separated by commas. Each network must belong to the category specified.
        /// </summary>
        /// <example>ad,notad</example>
        [StringLength(2000)]
        [RegularExpression(@"^[A-Za-z0-9._,\- ]*$")]
        public string Networks { get; set; }

        /// <summary>
        /// The name of the module from which to obtain all the co-expression data. This module must belong to the network specified above.
        /// </summary>
        /// <example>yellow</example>
        [StringLength(64)]
        [RegularExpression(@"^[A-Za-z0-9._-]*$")]
        public string Module { get; set; }

        /// <summary>
        /// List of genes. Each gene must be separated by a comma. The genes can be specified by both their name or EnsambleID.
        /// </summary>
        /// <example>PMVK,KRTCAP2,GBAP1</example>
        [StringLength(5000)]
        [RegularExpression(@"^[A-Za-z0-9._,\- ]*$")]
        public string Genes { get; set; }

        /// <summary>
        /// The top - 50,30,10, etc. - genes more important.
        /// </summary>
        /// <example>10</example>
        [RegularExpression(@"^[0-9]{0,4}$")]
        public string TopGenes { get; set; }
    }
}