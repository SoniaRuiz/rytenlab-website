using RytenLab_Web.Adapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RytenLab_Web.Repositories
{
    /// <summary>
    /// Repository to set all operations that can be done in CoExp R application
    /// </summary>
    public class CoexpRepository
    {
        /// <summary>
        /// Property to manage the http connection
        /// </summary>
        readonly private HttpAdapter _adapter;
        /// <summary>
        /// URL to connect with CoExp R application API (published by Plumber package)
        /// </summary>
        private string _coexpURL;
        private string PostData;

        /// <summary>
        /// Constructor. Here we initialize the class properties with a default value.
        /// </summary>
        public CoexpRepository()
        { 
            _adapter = new HttpAdapter();
            //TODO: cambiar por la URL 'localhost'
            _coexpURL = "https://rytenlab.com/api/";
        }

        /****************************************************************************/
        /******************************* GET METHODS ********************************/
        /****************************************************************************/


        /// <summary>
        /// Method to obtain data from 'GetNetworkCategories()' method of CoExp R application
        /// </summary>
        /// <returns>Response from CoExp R application</returns>
        public string GetNetworkCategories()
        {
            _coexpURL += "getNetworkCategories";
            Uri uri = new Uri(_coexpURL);
            //Make the request
            string response = _adapter.GETHttpRequestJSON(uri);
            //Return the response
            return response;  
        }


        /****************************************************************************/
        /******************************* POST METHODS *******************************/
        /****************************************************************************/

        public string GetAvailableNetworks(string whichone)
        {
            //Set the URL with parameters. This URL will allow us to establish a communication with
            //CoExp R application API (published using Plumber R package)
            _coexpURL += "getAvailableNetworks";
            Uri uri = new Uri(_coexpURL);

            PostData = "{\"category\":\"" + whichone + "\"}";

            //Make the request
            var finalResponse = _adapter.POSTHttpRequestJSON(uri, PostData);

            //Return the response
            return finalResponse;
        }

        public string GetAvailableModules(string tissue, string whichone)
        {
            _coexpURL += "getModulesFromTissue";
            Uri uri = new Uri(_coexpURL);

            PostData = "{\"tissue\":\"" + tissue +
                "\",\"which.one\":\"" + whichone + "\"}";

            //Make the request
            var finalResponse = _adapter.POSTHttpRequestJSON(uri, PostData);


            //Return the response
            return finalResponse;
        }

        public string GetMM(string tissue, string whichone, string module)
        {
            //Set the URL with parameters. This URL will allow us to establish a communication with
            //CoExp R application API (published using Plumber R package)
            _coexpURL += "getMM";
            Uri uri = new Uri(_coexpURL);

            PostData = "{\"tissue\":\"" + tissue +
                "\",\"which.one\":\"" + whichone +
                "\",\"module\":\"" + module + "\"}";

            //Make the request
            var finalResponse = _adapter.POSTHttpRequestJSON(uri, PostData);

            //Return the response
            return finalResponse;
        }


        public string GetGOFromTissue(string tissue, string whichone)
        {
            //Set the URL with parameters. This URL will allow us to establish a communication with
            //CoExp R application API (published using Plumber R package)
            _coexpURL += "getGOFromTissue";
            Uri uri = new Uri(_coexpURL);

            PostData = "{\"tissue\":\"" + tissue +
                "\",\"which.one\":\"" + whichone + "\"}";

            //Make the request
            var finalResponse = _adapter.POSTHttpRequestJSON(uri, PostData);

            //Return the response
            return finalResponse;
        }


        public string GetCellTypeFromTissue(string tissue, string whichone)
        {
            _coexpURL += "getCellTypeFromTissue";
            Uri uri = new Uri(_coexpURL);

            PostData = "{\"tissue\":\"" + tissue +
                "\",\"which.one\":\"" + whichone + "\"}";

            //Make the request
            var finalResponse = _adapter.POSTHttpRequestJSON(uri, PostData);

            //Return the response
            return finalResponse;
        }


        /**************************************************************/
        /********************* POST METHODS ***************************/
        /**************************************************************/

        public string ReportOnGenesMultipleTissue(string tissues, string whichone, string genes)
        {

            _coexpURL += "reportOnGenesMultipleTissue";
            Uri uri = new Uri(_coexpURL);

            PostData = "{\"tissues\":\"" + tissues + "\",\"which.one\":\"" + whichone + "\",\"genes\":\"" + genes + "\"}";
            
            var response = _adapter.POSTHttpRequestJSON(uri, PostData);
            return response;
        }

        public string GlobalReportOnGenes(string categories, string networks, string genes)
        {
            _coexpURL += "globalReportOnGenes";
            Uri uri = new Uri(_coexpURL);

            PostData = "{\"categories\":\"" + categories + "\",\"tissues\":\"" + networks + "\",\"genes\":\"" + genes + "\"}";

            //Make the request
            var response = _adapter.POSTHttpRequestJSON(uri, PostData);

            return response;
        }


        public string GetModuleTOMGraph(string tissue, string whichone, string module, string topgenes)
        {

            _coexpURL += "getModuleTOMGraph";
            Uri uri = new Uri(_coexpURL);

            PostData = "{\"tissue\":\"" + tissue +
                "\",\"which.one\":\"" + whichone +
                "\",\"module\":\"" + module + "\",\"topgenes\":\"" + topgenes + "\"}";

            //Make the request
            string response = _adapter.POSTHttpRequestJSON(uri, PostData);

            return response;

        }
    }
}