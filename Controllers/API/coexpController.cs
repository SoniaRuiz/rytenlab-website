﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RytenLab_Web.Models;
using RytenLab_Web.Repositories;
using System.ComponentModel.DataAnnotations;

namespace RytenLab_Web.Controllers
{

    [Route("rytenlab_api/[controller]")]
    [ApiController]
    public class CoexpController : ControllerBase
    {

        /****************************************************************************/
        /******************************* GET METHODS ********************************/
        /****************************************************************************/


        /// <summary>
        /// Returns all categories currently available.
        /// Each category can be used later to request different co-expression networks.
        /// </summary>
        /// <returns>All categories that are currently available.</returns>
        [HttpGet]
        [Route("GetNetworkCategories")]
        public string GetNetworkCategories()
        {
            CoexpRepository repository = new CoexpRepository();
            string response = repository.GetNetworkCategories();
            return response;
        }


        /****************************************************************************/
        /******************************* POST METHODS *******************************/
        /****************************************************************************/

        /// <summary>
        /// Returns all networks that belong to a specific category.
        /// </summary>
        /// <remarks>
        /// A sample for the 'Request Body':
        ///
        ///     {
        ///        "Category": "CoExpROSMAP"
        ///     }
        /// </remarks>
        /// <example>
        /// my example
        /// </example>
        /// <param name="data">
        /// The requested body must be a JSON object formed by the key "Category" (this is the name of the category from which to obtain all the networks).
        /// An example of the 'Request Body' is provided above.
        /// </param>
        /// <returns>Returns all gene co-expression networks that belong to the specified category.</returns>
        [HttpPost]
        [Route("GetAvailableNetworks")]
        public string GetAvailableNetworks([FromBody] CoExpParameters data)
        {
  
            CoexpRepository repository = new CoexpRepository();
            string response = repository.GetAvailableNetworks(data.Category);
            return response;
        }

        /// <summary>
        /// Returns all modules that belong to the specified category and co-expression network.
        /// </summary>
        /// <remarks>
        /// A sample for the 'Request Body':
        ///
        ///     {
        ///        "Category": "CoExpROSMAP",
        ///        "Network": "ad"
        ///     }
        /// </remarks>
        /// <example>
        /// </example>
        /// <param name="data">
        /// The requested body must be a JSON object formed by the keys: "Category" (this is the name of the category) and "Network" (this is the name of the network from which to obtain all the modules - this network must belong to the category specified before). 
        /// An example of the 'Request Body' is provided above.
        /// </param>
        /// <returns>Returns all modules that belong to the specified category and co-expression network.</returns>
        [HttpPost]
        [Route("GetAvailableModules")]
        public string GetAvailableModules([FromBody, Required] CoExpParameters data)
        {
            CoexpRepository repository = new CoexpRepository();
            string response = repository.GetAvailableModules(data.Network, data.Category);
            return response;
        }

        /// <summary>
        /// Returns the module membership (MM) of each gene to its module.
        /// </summary>
        /// <remarks>
        /// A sample for the 'Request Body':
        ///
        ///     {
        ///        "Category": "CoExpROSMAP",
        ///        "Network": "ad",
        ///        "Module": "yellow"
        ///     }
        /// </remarks>
        /// <param name="data">
        /// The requested body must be a JSON object formed by the keys: "Category" (this is the name of the category), "Network" (this is the name of the network from which to obtain all the modules - this network must belong to the category specified before)
        /// and "Module" (this is the name of the module from which to obtain all the genes - this module must belong to the network specified before). 
        /// An example of the 'Request Body' is provided above.
        /// </param>
        /// <returns>Returns the module membership (MM) of each gene to its module.</returns>
        [HttpPost]
        [Route("GetMM")]
        public string GetMM([FromBody] CoExpParameters data)
        {
            CoexpRepository repository = new CoexpRepository();
            string response = repository.GetMM(data.Network, data.Category, data.Module);
            return response;
        }

        /// <summary>
        /// Returns the Gene Ontology (GO) terminology associated to each gene belonging to the specified co-expression network.
        /// </summary>
        /// <remarks>
        /// A sample for the 'Request Body':
        ///
        ///     {
        ///        "Category": "CoExpROSMAP",
        ///        "Network": "ad"
        ///     }
        /// </remarks>
        /// <param name="data">
        /// The requested body must be a JSON object formed by the keys: "Category" (this is the name of the category) and "Network" (this is the name of the network from which to obtain all the modules - this network must belong to the category specified before). 
        /// An example of the 'Request Body' is provided above.
        /// </param>
        /// <returns>Returns the Gene Ontology (GO) terminology associated to each gene belonging to the specified co-expression network.</returns>        
        [HttpPost]
        [Route("GetGOFromTissue")]
        public string GetGOFromTissue([FromBody, Required] CoExpParameters data)
        {
            //category = which.one
            //network = network
            CoexpRepository repository = new CoexpRepository();
            string response = repository.GetGOFromTissue(data.Network, data.Category);

            return response;
        }

        /// <summary>
        /// Returns a matrix of p-values, corrected by the Bonferroni method, that support the linkage between each cell type and all genes found in each module.
        /// </summary>
        /// <remarks>
        /// A sample for the 'Request Body':
        ///
        ///     {
        ///        "Category": "CoExpROSMAP",
        ///        "Network": "ad"
        ///     }
        /// </remarks>
        /// <param name="data">
        /// The requested body must be a JSON object formed by the keys: "Category" (this is the name of the category) and "Network" (this is the name of the network from which to obtain all the modules - this network must belong to the category specified before). 
        /// An example of the 'Request Body' is provided above.
        /// </param>
        /// <returns>Returns a matrix of p-values, corrected by the Bonferroni method, that support the linkage between each cell type and all genes found in each module.</returns>
        [HttpPost]
        [Route("GetCellTypeFromTissue")]
        public string GetCellTypeFromTissue([FromBody, Required] CoExpParameters data)
        {
            CoexpRepository repository = new CoexpRepository();
            string response = repository.GetCellTypeFromTissue(data.Network, data.Category);
            return response;
        }



        /// <summary>
        /// Returns a report about the different genes that belong to one or more networks from the same category. The networks and the genes must be comma-separated.
        /// </summary>
        /// <remarks>
        /// A sample for the 'Request Body':
        ///
        ///     {
        ///        "Category": "CoExpROSMAP",
        ///        "Networks": "ad,notad",
        ///        "Genes": "PMVK,KRTCAP2,GBAP1"
        ///     }
        /// </remarks>
        /// <param name="data">
        /// The requested body must be a JSON object formed by the keys: "Category" (this is the name of the category), "Networks" (a list of networks from which to obtain all the genes - the networks must be comma-separated) 
        /// and "Genes" (this must be a list of comma-separated genes). 
        /// An example of the 'Request Body' is provided above.
        /// </param>
        /// <returns>Returns a report about the different genes that belong to one or more networks from the same category.</returns>
        [HttpPost]
        [Route("ReportOnGenesMultipleTissue")]
        public string ReportOnGenesMultipleTissue([FromBody] CoExpParameters data)
        {
            //category = which.one
            //network = network
            CoexpRepository repository = new CoexpRepository();
            string response = repository.ReportOnGenesMultipleTissue(data.Networks, data.Category, data.Genes);

            return response;
        }

        /// <summary>
        /// Returns an extensive report about the different genes that belong to one or more networks from one or more categories. The categories, networks and genes must be comma-separated.
        /// </summary>
        /// <remarks>
        /// A sample for the 'Request Body':
        ///
        ///     {
        ///        "Categories": "CoExpROSMAP,CoExpROSMAP,gtexv6",
        ///        "Networks": "ad,notad,AdiposeSub",
        ///        "Genes": "PMVK,KRTCAP2,GBAP1"
        ///     }
        /// </remarks>
        /// <param name="data">
        /// The requested body must be a JSON object formed by the keys: "Categories" (a list of categories, one for each network requested - the categories must be comma-separated), "Networks" (a list of networks from which to obtain all the genes - the networks must be comma-separated) 
        /// and "Genes" (this must be a list of comma-separated genes). 
        /// An example of the 'Request Body' is provided above.
        /// </param>
        /// <returns>Returns an extensive report about the different genes that belong to one or more networks from one or more categories. The categories, networks and genes must be comma-separated.</returns>
        [HttpPost]
        [Route("GlobalReportOnGenes")]
        public string GlobalReportOnGenes([FromBody, Required] CoExpParameters data)
        {

            CoexpRepository repository = new CoexpRepository();
            string response = repository.GlobalReportOnGenes(data.Categories, data.Networks, data.Genes);

            return response;
        }

        /// <summary>
        /// Returns the most important genes that belong to an specific category, network and module.
        /// </summary>
        /// <remarks>
        /// A sample for the 'Request Body':
        ///
        ///     {
        ///        "Category": "CoExpROSMAP",
        ///        "Network": "ad",
        ///        "Module": "yellow",
        ///        "TopGenes": "10"
        ///     }
        /// </remarks>
        /// <param name="data">
        /// The requested body must be a JSON object formed by the keys: "Category", "Network", "Module" and "TopGenes".
        /// An example of the 'Request Body' is shown above.
        /// </param>
        /// <returns>Returns the most important genes that belong to an specific category, network and module.</returns>
        [HttpPost]
        [Route("GetModuleTOMGraph")]
        public string GetModuleTOMGraph([FromBody, Required] CoExpParameters data)
        {

            CoexpRepository repository = new CoexpRepository();
            string response = repository.GetModuleTOMGraph(data.Network, data.Category, data.Module, data.TopGenes);

            return response;
        }

        /// <summary>
        /// Returns all genes from a module.
        /// </summary>
        /// <remarks>
        /// A sample for the 'Request Body':
        ///
        ///     {
        ///        "Category": "CoExpROSMAP",
        ///        "Network": "ad",
        ///        "Module": "yellow"
        ///     }
        /// </remarks>
        /// <param name="data">
        /// The requested body must be a JSON object formed by the keys: "Category", "Network" and "Module".
        /// An example of the 'Request Body' is shown above.
        /// </param>
        /// <returns>Returns all genes from a module.</returns>
        [HttpPost]
        [Route("GetModuleTOMGenes")]
        public string GetModuleTOMGenes([FromBody, Required] CoExpParameters data)
        {

            CoexpRepository repository = new CoexpRepository();
            string response = repository.GetModuleTOMGenes(data.Network, data.Category, data.Module);

            return response;
        }
    }
}