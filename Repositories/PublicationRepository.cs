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

        public Person GetPublicationsDataNCBI(Person person)
        {
            if (!String.IsNullOrEmpty(person.NCBIPublicationsID))
            {
                int index = 0;

                String url = "https://eutils.ncbi.nlm.nih.gov/entrez/eutils/esummary.fcgi?db=pubmed&id=" + person.NCBIPublicationsID + "&retmode=json";
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
                        foreach(var author in item.Value["authors"])
                        {
                            singlePublication.Authors.Add((string)author["name"]);
                        }
                        singlePublication.Volume = (string)item.Value["volume"];
                        singlePublication.Date = (string)item.Value["pubdate"];
                        singlePublication.Pages = (string)item.Value["pages"];
                        var title = singlePublication.Title;
                        title = title.Replace(" ", "+");
                        singlePublication.Link = "https://www.ncbi.nlm.nih.gov/pubmed/?term=" + title;
                        person.NCBIPublicationsList.Add(singlePublication);
                    }
                }

            }
            return person;
        }

        public Person GetPublicationsDataCrossRef(Person person)
        {
            if (person.CrossRefPublicationsTitles.Count > 0 && !String.IsNullOrEmpty(person.Name))
            {
                foreach(var title in person.CrossRefPublicationsTitles)
                {
                    String url = "https://api.crossref.org/works?rows=1&query.title=" + title + "&query.author=" + person.Name;
                    String response = adapter.HttpRequestJSON(url);

                    var jsonResponse = JObject.Parse(response);
                    var data = (JObject)jsonResponse["message"];

                    foreach (var item in data)
                    {
                        if (item.Key == "items")
                        {
                            foreach (var x in item.Value)
                            {
                                Publication singlePublication = new Publication();
                                singlePublication.Title = (x["title"] != null) ? (string)x["title"][0] : string.Empty;
                                //singlePublication.Abstract = (string)x["abstract"];
                                singlePublication.Doi = (string)x["DOI"];
                                singlePublication.Link = (x["link"] != null) ? (string)x["link"][0]["URL"] : string.Empty;
                                singlePublication.JournalName = (x["institution"] != null) ? (string)x["institution"]["name"] : string.Empty;
                                //singlePublication.Volume = (string)item.Value["volume"];
                                //singlePublication.Date = DateTime.Parse((string)item.Value["sortpubdate"]);
                                //singlePublication.Pages = (string)item.Value["pages"];
                                person.CrossRefPublicationsList.Add(singlePublication);
                            }
                        }
                    }
                }
            }
            return person;
        }
    }
}