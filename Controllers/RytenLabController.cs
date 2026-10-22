using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.AspNetCore.Mvc;
using RytenLab_Web.Models;
using RytenLab_Web.Repositories;
using System.Web;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;


namespace RytenLab_Web.Controllers
{

    /// <summary>
    /// This controller sets the main operations of RytenLab web
    /// </summary>
    public class RytenLabController : Controller
    {
        private IHostEnvironment _hostingEnvironment;
        private readonly ILogger<RytenLabController> _logger;


        public RytenLabController(IHostEnvironment environment, ILogger<RytenLabController> logger)
        {
            _hostingEnvironment = environment;
            _logger = logger;
        }

        /// <summary>
        /// Loads team.xml from App_Data (not publicly downloadable, unlike wwwroot).
        /// </summary>
        private XmlDocument LoadTeamXml()
        {
            var doc = new XmlDocument();
            doc.Load(Path.Combine(_hostingEnvironment.ContentRootPath, "App_Data", "team.xml"));
            return doc;
        }

        private static string Text(XmlNode node, string name) => node[name]?.InnerText ?? string.Empty;

        /// <summary>
        /// Reads all team members from team.xml, ordered by name.
        /// </summary>
        private List<Person> ReadPeople()
        {
            var people = new List<Person>();
            foreach (XmlNode node in LoadTeamXml().SelectNodes("/TeamMembers/Person"))
            {
                people.Add(new Person
                {
                    ID = int.TryParse(Text(node, "ID"), out var id) ? id : -1,
                    Name = Text(node, "Name"),
                    Title = Text(node, "Title"),
                    Job = Text(node, "Job"),
                    Email = Text(node, "Email"),
                    ResearchInterest = Text(node, "ResearchInterest"),
                    Biography = Text(node, "Biography"),
                    ImagePath = Text(node, "ImagePath"),
                    GitHub = Text(node, "GitHub"),
                    GoogleScholar = Text(node, "GoogleScholar"),
                    ResearchGate = Text(node, "ResearchGate"),
                    CurrentMember = Text(node, "CurrentMember")
                });
            }
            return people.OrderBy(p => p.Name).ToList();
        }

        /// <summary>
        /// Reads all furry members from team.xml, ordered by name.
        /// </summary>
        private List<Pet> ReadPets()
        {
            var pets = new List<Pet>();
            foreach (XmlNode node in LoadTeamXml().SelectNodes("/TeamMembers/Pet"))
            {
                pets.Add(new Pet
                {
                    ID = int.TryParse(Text(node, "ID"), out var id) ? id : -1,
                    Name = Text(node, "Name"),
                    Nickname = Text(node, "Nickname"),
                    HumanName = Text(node, "HumanName"),
                    ImagePath = Text(node, "ImagePath"),
                    Bio = Text(node, "Bio")
                });
            }
            return pets.OrderBy(p => p.Name).ToList();
        }

        /// <summary>
        /// Logs the exception and shows the generic error page with the request ID only
        /// (no exception text is exposed to the visitor).
        /// </summary>
        private IActionResult ErrorView(Exception e)
        {
            _logger.LogError(e, "Error in RytenLab controller");
            return View("Error", new ErrorViewModel { Message = HttpContext.TraceIdentifier });
        }


        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Controller method for the main page
        /// </summary>
        /// <returns>Returns 'About' view</returns>
        public IActionResult About()
        {
            return View();
        }

        /// <summary>
        /// Controller method for 'Team' Page
        /// It takes the data from an xml file called team.xml.
        /// </summary>
        /// <returns>
        /// If everything is ok: Returns 'Team' view.
        /// If an error occurs: returns 'Error' view
        /// </returns>
        public IActionResult Team()
        {
            try
            {
                return View(new Team { TeamMembers = ReadPeople() });
            }
            catch (Exception e)
            {
                return ErrorView(e);
            }
        }

        public IActionResult FormerMembers()
        {
            try
            {
                return View(new Team { TeamMembers = ReadPeople() });
            }
            catch (Exception e)
            {
                return ErrorView(e);
            }
        }

        public IActionResult FurryMembers()
        {
            try
            {
                return View(new Pets { FurryMembers = ReadPets() });
            }
            catch (Exception e)
            {
                return ErrorView(e);
            }
        }



        /// <summary>
        /// Controller method for 'Tools' page.
        /// </summary>
        /// <returns>Returns 'Tools' view.</returns>
        public IActionResult Tools()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Research()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        /// <summary>
        /// Controller method for 'Publications' page.
        /// </summary>
        /// <returns>Returns 'Publications' view.</returns>
        public IActionResult Publications()
        {
            Publications papers = new Publications();
            //Load the XML file in XmlDocument.

            var path = Path.Combine(_hostingEnvironment.ContentRootPath, "wwwroot/xml/publications.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load(path);

            //Loop through the selected Nodes.
            foreach (XmlNode node in doc.SelectNodes("/Publications/Publication"))
            {
                string title_text = node["Title"] != null ? node["Title"].InnerText : string.Empty;
                string abstract_text = node["Abstract"] != null ? node["Abstract"].InnerText : string.Empty;
                string DOI_text = node["DOI"] != null ? node["DOI"].InnerText : string.Empty;
                string journal_text = node["JournalInfo"] != null ? node["JournalInfo"].InnerText : string.Empty;
                string authors_text = node["Authors"] != null ? node["Authors"].InnerText : string.Empty;

                string year_text = node["Year"] != null ? node["Year"].InnerText : string.Empty;

                papers.Manuscripts.Add(new Publication
                {
                    Title = title_text,
                    Abstract = abstract_text,
                    DOI = DOI_text,
                    JournalInfo = journal_text,
                    Authors = authors_text,
                    Year = year_text
                });
            }

            papers.Manuscripts = papers.Manuscripts.OrderByDescending(o => o.Year).ToList();



            return View(papers);
        }

        /// <summary>
        /// Controller method for 'Contact' page.
        /// </summary>
        /// <returns> Returns 'Contact' view. </returns>
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }


        /// <summary>
        /// Controller method for 'MemberInfo' page.
        /// The member is looked up on the server by the numeric ID from team.xml,
        /// so nothing posted or supplied by the client is rendered.
        /// </summary>
        /// <param name="id">Team member ID (from team.xml)</param>
        /// <returns>'MemberInfo' view, or 404 if the ID does not exist</returns>
        [HttpGet]
        public IActionResult MemberInfo(int id)
        {
            try
            {
                var person = ReadPeople().FirstOrDefault(p => p.ID == id);
                return person == null ? NotFound() : View(person);
            }
            catch (Exception e)
            {
                return ErrorView(e);
            }
        }


        /// <summary>
        /// Controller method for 'FurryMember' page.
        /// The pet is looked up on the server by the numeric ID from team.xml.
        /// </summary>
        /// <param name="id">Pet ID (from team.xml)</param>
        /// <returns>'FurryMember' view, or 404 if the ID does not exist</returns>
        [HttpGet]
        public IActionResult FurryMember(int id)
        {
            try
            {
                var pet = ReadPets().FirstOrDefault(p => p.ID == id);
                return pet == null ? NotFound() : View(pet);
            }
            catch (Exception e)
            {
                return ErrorView(e);
            }
        }

        /// <summary>
        /// Controller method for 'Privacy' page
        /// </summary>
        /// <returns>Returns 'Privacy' view</returns>
        public IActionResult Privacy()
        {
            //TODO: set this 'privacy' page
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { Message = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}