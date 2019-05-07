using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RytenLab_API.Repositories;
using RytenLab_Web.Models.API;

namespace RytenLab_API.Controllers
{

    [Route("rytenlab_api/[controller]")]
    [ApiController]
    public class CoexpController : ControllerBase
    {
        /**************************************************************************************/
        /********************************* GET METHODS ****************************************/
        /**************************************************************************************/

        /// <summary>
        /// GET method to make a request to 'GetNetworkCategories()' method from CoExp R application.
        /// </summary>
        /// <returns>Response from CoExp R application</returns>
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

        /***************************************************************************************/
        /********************************* POST METHODS ****************************************/
        /***************************************************************************************/

        /// <summary>
        /// POST method to obtain data from 'ReportOnGenes()' method of CoExp R application
        /// </summary>
        /// <param name="data">Tissue, category and genes</param>
        /// <returns>Response from CoExp R application</returns>
        [HttpPost]
        [Route("ReportOnGenes")]
        public string ReportOnGenes([FromBody] ReportOnGenes data)
        {
            CoexpRepository repository = new CoexpRepository();
            //First, we send the information to the repository
            string response = repository.ReportOnGenes(data);
            //Finally, we return the response received from CoExp R application back
            return response;
        }

        /// <summary>
        /// POST method to obtain data from 'ReportOnGenesMultipleTissue()' method of CoExp R application
        /// </summary>
        /// <param name="data">Tissues, category and genes</param>
        /// <returns>Response from CoExp R application</returns>
        [HttpPost]
        [Route("ReportOnGenesMultipleTissue")]
        public string ReportOnGenesMultipleTissue([FromBody] ReportOnGenesMultipleTissue data)
        {
            CoexpRepository repository = new CoexpRepository();
            //First, we send the information to the repository
            string response = repository.ReportOnGenesMultipleTissue(data);
            //Finally, we return the response received from CoExp R application back
            return response;
        }

        /// <summary>
        /// POST method to obtain data from 'GlobalReportOnGenes()' method of CoExp R application
        /// </summary>
        /// <param name="data">Tissues, categories and genes</param>
        /// <returns>Response from CoExp R application</returns>
        [HttpPost]
        [Route("GlobalReportOnGenes")]
        public string GlobalReportOnGenes([FromBody] GlobalReportOnGenes data)
        {
            CoexpRepository repository = new CoexpRepository();
            //First, we send the information to the repository
            string response = repository.GlobalReportOnGenes(data);
            //Finally, we return the response received from CoExp R application back
            return response;
        }
    }
}