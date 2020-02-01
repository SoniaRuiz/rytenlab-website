using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace RytenLab_Web.Adapters
{
    /// <summary>
    /// Class to make http requests
    /// </summary>
    public class HttpAdapter
    {
        /// <summary>
        /// Method to make a GET http request and have a JSON as response
        /// </summary>
        /// <param name="url">URL where we want to make the request</param>
        /// <returns>Response (in JSON format) received from the URL</returns>
        public string GETHttpRequestJSON(Uri url)
        {
            try
            {
                var request = WebRequest.Create(url);

                string data = null;
                request.Timeout = 1500000;
                request.ContentType = "application/json; charset=utf-8";


                //Make the request
                var response = (HttpWebResponse)request.GetResponse();
                //Read the response
                using (var sr = new StreamReader(response.GetResponseStream()))
                {
                    data = sr.ReadToEnd();
                }
                //Return data
                return data;
            }
            catch (HttpListenerException e)
            {
                string message = "Problems with web service connection. An error has occurred during an HTTP GET request made to the API service. The details of the exception thrown are: " + e.Message;
                return message;
            }
            catch (WebException e)
            {
                string message = "Problems with web service connection. An error has occurred during an HTTP GET request made to the API service. The details of the exception thrown are: " + e.Message;
                return message;
            }
        }

        /// <summary>
        /// Method to make a POST http request and have a JSON as response
        /// </summary>
        /// <param name="url">URL where we want to make the request</param>
        /// <param name="postData">parameters to send in the request body</param>
        /// <returns>Response (in JSON format) received from the URL</returns>
        public string POSTHttpRequestJSON(Uri url, string postData = null)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

                request.Timeout = 1500000;
                request.Method = "POST";
                request.ContentType = "application/json; charset=utf-8";


                if (postData != null)
                {
                    using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                    {
                        Debug.Write(postData);
                        streamWriter.Write(postData);
                        streamWriter.Flush();
                        streamWriter.Close();
                    }
                }
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                var final_response = response.GetResponseStream();
                string responseString = new StreamReader(final_response).ReadToEnd();
                //Return data
                return responseString;
            }
            catch (HttpListenerException e)
            {
                string message = "Problems with web service connection. An error has occurred during an HTTP POST request made to the API service. The details of the exception thrown are: " + e.Message;
                return message;
            }
            catch (WebException e)
            {
                string message = "Problems with web service connection. An error has occurred during an HTTP GET request made to the API service. The details of the exception thrown are: " + e.Message;
                return message;
            }
        }
    }
}
