using RytenLab_Web.Adapters;
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
        /// Constructor. Here we initialize the class properties with a default value.
        /// </summary>
        public CoexpRepository()
        {
            _adapter = new HttpAdapter();
            //TODO: cambiar por la URL 'localhost'
            _coexpURL = "https://snca.atica.um.es/api/";
        }
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


        /// <summary>
        /// Method to obtain data from 'ReportOnGenes()' method of CoExp R application
        /// </summary>
        /// <param name="tissue">Tissue</param>
        /// <param name="category">Category</param>
        /// <param name="genes">Genes</param>
        /// <returns>Response from CoExp R application</returns>
        public string ReportOnGenes(string tissue, string category, string genes)
        {
            //Set the URL with parameters. This URL will allow us to establish a communication with
            //CoExp R application API (published using Plumber R package)
            _coexpURL = _coexpURL + "reportOnGenes?tissue=" + tissue
                + "&which.one=" + category
                + "&genes=" + genes;
            //Make the request
            string response = _adapter.HttpRequestJSON(_coexpURL);
            //Return the response
            return response;
        }

        /// <summary>
        /// Method to obtain data from 'ReportOnGenesMultipleTissue()' method of CoExp R application
        /// </summary>
        /// <param name="tissues">Tissues</param>
        /// <param name="category">Category</param>
        /// <param name="genes">Genes</param>
        /// <returns>Response from CoExp R application</returns>
        public string ReportOnGenesMultipleTissue(string tissues, string category, string genes)
        {
            //Set the URL with parameters. This URL will allow us to establish a communication with
            //CoExp R application API (published using Plumber R package)
            _coexpURL = _coexpURL + "reportOnGenesMultipleTissue?tissues=" + tissues
                + "&which.one=" + category
                + "&genes=" + genes;
            //Make the request
            string response = _adapter.HttpRequestJSON(_coexpURL);
            //Return the response
            return response;
        }

        /// <summary>
        /// Method to obtain data from 'GlobalReportOnGenes()' method of CoExp R application
        /// </summary>
        /// <param name="tissues">Tissues</param>
        /// <param name="categories">Categories</param>
        /// <param name="genes">Genes</param>
        /// <returns>Response from CoExp R application</returns>
        public string GlobalReportOnGenes(string tissues, string categories, string genes)
        {
            //Set the URL with parameters. This URL will allow us to establish a communication with
            //CoExp R application API (published using Plumber R package)
            _coexpURL = _coexpURL + "globalReportOnGenes?tissues=" + tissues
                + "&categories=" + categories
                + "&genes=" + genes;
            //Make the request
            string response = _adapter.HttpRequestJSON(_coexpURL);
            //Return the response
            return response;
        }
    }
}