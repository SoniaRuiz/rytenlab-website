using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace RytenLab_Web.Adapters
{
    public class HttpAdapter
    {
        public string HttpRequestJSON(string url)
        {
            var request = WebRequest.Create(url);
            string data = null;
            var response = (HttpWebResponse)request.GetResponse();

            request.ContentType = "application/json; charset=utf-8";

            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                data = sr.ReadToEnd();
            }

            return data;
        }
    }
}
