using RytenLab_Web.Adapters;
using RytenLab_Web.Models.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RytenLab_API.Repositories
{
    /// <summary>
    /// Repository to set all operations that can be done in CoExp R application
    /// </summary>
    public class CoexpRepository
    {
        /// <summary>
        /// Property to manage the http connection
        /// </summary>
        private HttpAdapter _adapter;
        /// <summary>
        /// URL to connect with CoExp R application API (published by Plumber package)
        /// </summary>
        private string _coexpURL;
        /// <summary>
        /// POST request parameters
        /// </summary>
        private string _postData { get; set; }

        /// <summary>
        /// Constructor. Here we initialize the class properties with a default value.
        /// </summary>
        public CoexpRepository()
        {
            _adapter = new HttpAdapter();
            //TODO: cambiar por la URL 'localhost'
            _coexpURL = "https://snca.atica.um.es/api/";
        }


        /****************************************************************************************/
        /********************************* GET METHODS ******************************************/
        /****************************************************************************************/

        /// <summary>
        /// Method to obtain data from 'GetNetworkCategories()' method of CoExp R application
        /// </summary>
        /// <returns>Response from CoExp R application</returns>
        public string GetNetworkCategories()
        {
            _coexpURL = _coexpURL + "getNetworkCategories";
            //Make the request
            string response = _adapter.HttpRequestJSON(_coexpURL);
            //Return the response
            return response;
        }


        /// <summary>
        /// Method to obtain data from 'GetAvailableNetworks()' method of CoExp R application
        /// </summary>
        /// <param name="category">Category</param>
        /// <returns>Response from CoExp R application</returns>
        public string GetAvailableNetworks(string category)
        {
            //Set the URL with parameters. This URL will allow us to establish a communication with
            //CoExp R application API (published using Plumber R package)
            _coexpURL = _coexpURL + "getAvailableNetworks?category=" + category;
            //Make the request
            string response = _adapter.HttpRequestJSON(_coexpURL);
            //Return the response
            return response;
        }


        /// <summary>
        /// Method to obtain data from 'GetGOFromTissue()' method of CoExp R application
        /// </summary>
        /// <param name="tissue">Tissue</param>
        /// <param name="category">Category</param>
        /// <returns></returns>
        public string GetGOFromTissue(string tissue, string category)
        {
            //Set the URL with parameters. This URL will allow us to establish a communication with
            //CoExp R application API (published using Plumber R package)
            _coexpURL = _coexpURL + "getGOFromTissue?tissue=" + tissue
                + "&which.one=" + category;
            //Make the request
            string response = _adapter.HttpRequestJSON(_coexpURL);
            //Return the response
            return response;
        }

        /// <summary>
        /// Method to obtain data from 'GetCellTypeFromTissue()' method of CoExp R application
        /// </summary>
        /// <param name="tissue">Tissue</param>
        /// <param name="category">Category</param>
        /// <returns>Response from CoExp R application</returns>
        public string GetCellTypeFromTissue(string tissue, string category)
        {
            //Set the URL with parameters. This URL will allow us to establish a communication with
            //CoExp R application API (published using Plumber R package)
            _coexpURL = _coexpURL + "getCellTypeFromTissue?tissue=" + tissue
                + "&which.one=" + category;
            //Make the request
            string response = _adapter.HttpRequestJSON(_coexpURL);
            //Return the response
            return response;
        }

        /*******************************************************************************************/
        /********************************* POST METHODS ********************************************/
        /*******************************************************************************************/

        /// <summary>
        /// Method to obtain data from 'ReportOnGenes()' method of CoExp R application
        /// </summary>
        /// <param name="data">Tissue, category and genes</param>
        /// <returns>Response from CoExp R application</returns>
        public string ReportOnGenes(ReportOnGenes data)
        {            
            //Set the URL with parameters. This URL will allow us to establish a communication with
            //CoExp R application API (published using Plumber R package)
            _coexpURL = _coexpURL + "reportOnGenes";
            _postData = "{\"tissue\":\"" + data.Network + "\",\"which.one\":\"" + data.Category 
                + "\",\"genes\":\"" + data.Genes + "\"}";

            //Make the request
            string response = _adapter.POSTHttpRequestJSON(_coexpURL, _postData);

            //Return the response
            return response;
        }

        /// <summary>
        /// Method to obtain data from 'ReportOnGenesMultipleTissue()' method of CoExp R application
        /// </summary>
        /// <param name="data">Tissues, category and genes</param>
        /// <returns>Response from CoExp R application</returns>
        public string ReportOnGenesMultipleTissue(ReportOnGenesMultipleTissue data)
        {
            //Set the URL with parameters. This URL will allow us to establish a communication with
            //CoExp R application API (published using Plumber R package)
            //_coexpURL = _coexpURL + "reportOnGenesMultipleTissue?tissues=" + tissues
            //    + "&which.one=" + category
            //    + "&genes=" + genes;
            //Make the request
            //string response = _adapter.HttpRequestJSON(_coexpURL);
            
            
            _coexpURL = _coexpURL + "reportOnGenesMultipleTissue";
            _postData = "{\"tissues\":\"" + data.Networks + "\",\"which.one\":\"" + 
                data.Category + "\",\"genes\":\"" + data.Genes + "\"}";

            //Make the request
            string response = _adapter.POSTHttpRequestJSON(_coexpURL, _postData);
            //Return the response
            return response;
        }

        /// <summary>
        /// Method to obtain data from 'GlobalReportOnGenes()' method of CoExp R application
        /// </summary>
        /// <param name="data">Tissues, categories and genes</param>
        /// <returns>Response from CoExp R application</returns>
        public string GlobalReportOnGenes(GlobalReportOnGenes data)
        {
            //Set the URL with parameters. This URL will allow us to establish a communication with
            //CoExp R application API (published using Plumber R package)
            _coexpURL = _coexpURL + "globalReportOnGenes";
            _postData = "{\"tissues\":\"" + data.Networks + "\",\"categories\":\"" 
                + data.Categories + "\",\"genes\":\"" + data.Genes + "\"}";
            
            //Make the request
            string response = _adapter.POSTHttpRequestJSON(_coexpURL, _postData);
        
            //Return the response
            return response;
        }
    }
}