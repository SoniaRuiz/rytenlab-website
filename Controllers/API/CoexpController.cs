using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RytenLab_API.Repositories;

namespace RytenLab_API.Controllers
{

    [Route("rytenlab_api/[controller]")]
    [ApiController]
    public class CoexpController : ControllerBase
    {

        /// <summary>
        /// GET method to make a request to 'GetNetworkCategories()' method from CoExp R application.
        /// </summary>
        /// <returns>Response from CoExp R application</returns>
        // GET: api/<controller>
        [HttpGet]
        [Route("GetNetworkCategories")]
        public string GetNetworkCategories()
        {
            CoexpRepository repository = new CoexpRepository();
            //First, we send the information to the repository
            string response = repository.GetNetworkCategories();
            //Finally, we return the response back
            return response;
        }

        /// <summary>
        /// GET method to obtain data from 'GetAvailableNetworks' method of CoExp R application
        /// </summary>
        /// <param name="category">Category selected</param>
        /// <returns>Response from CoExp R application</returns>
        // GET: api/<controller>
        [HttpGet]
        [Route("GetAvailableNetworks")]
        public string GetAvailableNetworks([FromQuery] string category)
        {
            CoexpRepository repository = new CoexpRepository();
            //First, we send the information to the repository
            string response = repository.GetAvailableNetworks(category);
            //Finally, we return the response received from CoExp R application back
            return response;
        }


        /// <summary>
        /// GET method to obtain data from 'GetGOFromTissue()' method of CoExp R application
        /// </summary>
        /// <param name="tissue">Tissue</param>
        /// <param name="category">Category</param>
        /// <returns>Response from CoExp R application</returns>
        [HttpGet]
        [Route("GetGOFromTissue")]
        public string GetGOFromTissue([FromQuery] string tissue, string category)
        {
            CoexpRepository repository = new CoexpRepository();
            //First, we send the information to the repository
            string response = repository.GetGOFromTissue(tissue, category);
            //Finally, we return the response received from CoExp R application back
            return response;
        }

        /// <summary>
        /// GET method to obtain data from 'GetCellTypeFromTissue()' method of CoExp R application
        /// </summary>
        /// <param name="tissue">Tissue</param>
        /// <param name="category">Category</param>
        /// <returns>Response from CoExp R application</returns>
        // GET: api/<controller>
        [HttpGet]
        [Route("GetCellTypeFromTissue")]
        public string GetCellTypeFromTissue([FromQuery] string tissue, string category)
        {
            CoexpRepository repository = new CoexpRepository();
            //First, we send the information to the repository
            string response = repository.GetCellTypeFromTissue(tissue, category);
            //Finally, we return the response received from CoExp R application back
            return response;
        }

        /// <summary>
        /// GET method to obtain data from 'ReportOnGenes()' method of CoExp R application
        /// </summary>
        /// <param name="tissue">Tissue</param>
        /// <param name="category">Category</param>
        /// <param name="genes">Genes</param>
        /// <returns>Response from CoExp R application</returns>
        // GET: api/<controller>
        [HttpGet]
        [Route("ReportOnGenes")]
        public string ReportOnGenes([FromQuery] string tissue, string category, string genes)
        {
            CoexpRepository repository = new CoexpRepository();
            //First, we send the information to the repository
            string response = repository.ReportOnGenes(tissue, category, genes);
            //Finally, we return the response received from CoExp R application back
            return response;
        }

        /// <summary>
        /// GET method to obtain data from 'ReportOnGenesMultipleTissue()' method of CoExp R application
        /// </summary>
        /// <param name="tissues">Tissues</param>
        /// <param name="category">Category</param>
        /// <param name="genes">Genes</param>
        /// <returns>Response from CoExp R application</returns>
        // GET: api/<controller>
        [HttpGet]
        [Route("ReportOnGenesMultipleTissue")]
        public string ReportOnGenesMultipleTissue([FromQuery] string tissues, string category, string genes)
        {
            CoexpRepository repository = new CoexpRepository();
            //First, we send the information to the repository
            string response = repository.ReportOnGenesMultipleTissue(tissues, category, genes);
            //Finally, we return the response received from CoExp R application back
            return response;
        }

        /// <summary>
        /// GET method to obtain data from 'GlobalReportOnGenes()' method of CoExp R application
        /// </summary>
        /// <param name="tissues">Tissues</param>
        /// <param name="categories">Categories</param>
        /// <param name="genes">Genes</param>
        /// <returns>Response from CoExp R application</returns>
        // GET: api/<controller>
        [HttpGet]
        [Route("GlobalReportOnGenes")]
        public string GlobalReportOnGenes([FromQuery] string tissues, string categories, string genes)
        {
            CoexpRepository repository = new CoexpRepository();
            //First, we send the information to the repository
            string response = repository.GlobalReportOnGenes(tissues, categories, genes);
            //Finally, we return the response received from CoExp R application back
            return response;
        }
    }
}