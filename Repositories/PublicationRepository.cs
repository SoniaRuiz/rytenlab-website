using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RytenLab_Web.Adapters;
using RytenLab_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RytenLab_Web.Repositories
{
    public class PublicationRepository
    {
        private HttpAdapter adapter;

        public PublicationRepository()
        {
            adapter = new HttpAdapter();
        }

        /*public String GetPublicationsIDNCBI(String authorName)
        {
            try
            {
                if (String.IsNullOrEmpty(authorName))
                {
                    throw new Exception("Empty author name");
                }
                else
                {

                    string url = "https://eutils.ncbi.nlm.nih.gov/entrez/eutils/esearch.fcgi?db=pubmed&retmode=json&retmax=1000&term=" + authorName + "[Author]";
                    var response = adapter.HttpRequestJSON(url);

                    dynamic jsonObj = JsonConvert.DeserializeObject(response);
                    List<string> idList = new List<string>();

                    foreach (var obj in jsonObj.esearchresult.idlist)
                    {
                        idList.Add((string)obj);
                    }

                    return string.Join(",", idList);
                }
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }*/

        public Person GetPublicationsDataNCBI(Person person)
        {

            if (String.IsNullOrEmpty(person.PublicationsID))
            {
                throw new Exception("Empty id publications list");
            }
            else
            {
                int index = 0;
                

                String url = "https://eutils.ncbi.nlm.nih.gov/entrez/eutils/esummary.fcgi?db=pubmed&id=" + person.PublicationsID + "&retmode=json";
                String response = adapter.HttpRequestJSON(url);

                var jsonResponse = JObject.Parse(response);
                var data = (JObject)jsonResponse["result"];

                foreach (var item in data)
                {
                    if (index == 0)
                    {
                        index = 1;
                        continue;
                    }
                    else
                    {
                        Publication singlePublication = new Publication();
                        singlePublication.Title = (string)item.Value["title"];
                        singlePublication.JournalName = (string)item.Value["fulljournalname"];
                        singlePublication.Volume = (string)item.Value["volume"];
                        singlePublication.Date = DateTime.Parse((string)item.Value["sortpubdate"]);
                        singlePublication.Pages = (string)item.Value["pages"];
                        person.PublicationsList.Add(singlePublication);

                    }
                }

                return person;
            }
        }
    }
}
