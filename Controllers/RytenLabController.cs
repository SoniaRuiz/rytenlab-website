using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.AspNetCore.Mvc;
using RytenLab_Web.Models;
using RytenLab_Web.Repositories;
using System.Web;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.Extensions.Hosting;

namespace RytenLab_Web.Controllers
{
    /// <summary>
    /// This controller sets the main operations of RytenLab web
    /// </summary>
    public class RytenLabController : Controller
    {
        private IHostEnvironment _hostingEnvironment;

        public RytenLabController(IHostEnvironment environment)
        {
            _hostingEnvironment = environment;
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
                Team teamMembers = new Team();

                var path = Path.Combine(_hostingEnvironment.ContentRootPath, "wwwroot/xml/team.xml");
                //Load the XML file in XmlDocument.
                XmlDocument doc = new XmlDocument();
                doc.Load(path);

                //Loop through the selected Nodes.
                foreach (XmlNode node in doc.SelectNodes("/TeamMembers/Person"))
                {
                    //Fetch the Node values and assign it to Model.
                    teamMembers.TeamMembers.Add(new Person
                    {
                        ID = int.Parse(node["ID"].InnerText),
                        Name = node["Name"].InnerText,
                        Title = node["Title"].InnerText,
                        Job = node["Job"].InnerText,
                        Email = node["Email"].InnerText,
                        ResearchInterest = node["ResearchInterest"].InnerText,
                        Biography = node["Biography"].InnerText,
                        ImagePath = node["ImagePath"].InnerText,
                        GitHub = node["GitHub"].InnerText,
                        ResearchGate = node["ResearchGate"].InnerText,
                        CurrentMember = node["CurrentMember"].InnerText
                    });
                }

                return View(teamMembers);
            }
            catch (Exception e)
            {
                ErrorViewModel errorModel = new ErrorViewModel
                {
                    Message = e.Message
                };
                return View("Error", errorModel);
            }
        }

        public IActionResult PastMembers()
        {
            try
            {
                Team pastMembers = new Team();

                var path = Path.Combine(_hostingEnvironment.ContentRootPath, "wwwroot/xml/team.xml");
                //Load the XML file in XmlDocument.
                XmlDocument doc = new XmlDocument();
                doc.Load(path);

                //Loop through the selected Nodes.
                foreach (XmlNode node in doc.SelectNodes("/TeamMembers/Person"))
                {
                    //Fetch the Node values and assign it to Model.
                    pastMembers.TeamMembers.Add(new Person
                    {
                        ID = int.Parse(node["ID"].InnerText),
                        Name = node["Name"].InnerText,
                        Title = node["Title"].InnerText,
                        Job = node["Job"].InnerText,
                        Email = node["Email"].InnerText,
                        ResearchInterest = node["ResearchInterest"].InnerText,
                        Biography = node["Biography"].InnerText,
                        ImagePath = node["ImagePath"].InnerText,
                        GitHub = node["GitHub"].InnerText,
                        ResearchGate = node["ResearchGate"].InnerText,
                        CurrentMember = node["CurrentMember"].InnerText
                    });
                }

                return View(pastMembers);
            }
            catch (Exception e)
            {
                ErrorViewModel errorModel = new ErrorViewModel
                {
                    Message = e.Message
                };
                return View("Error", errorModel);
            }
        }


        public IActionResult FurryMembers()
        {
            try
            {
                Pets petMembers = new Pets();

                var path = Path.Combine(_hostingEnvironment.ContentRootPath, "wwwroot/xml/team.xml");
                //Load the XML file in XmlDocument.
                XmlDocument doc = new XmlDocument();
                doc.Load(path);

                //Loop through the selected Nodes.
                foreach (XmlNode node in doc.SelectNodes("/TeamMembers/Pet"))
                {
                    //Fetch the Node values and assign it to Model.
                    petMembers.FurryMembers.Add(new Pet
                    {
                        ID = int.Parse(node["ID"].InnerText),
                        Name = node["Name"].InnerText,
                        Nickname = node["Nickname"].InnerText,
                        HumanName = node["HumanName"].InnerText,
                        ImagePath = node["ImagePath"].InnerText,
                        Bio = node["Bio"].InnerText
                    });
                }

                return View(petMembers);
            }
            catch (Exception e)
            {
                ErrorViewModel errorModel = new ErrorViewModel
                {
                    Message = e.Message
                };
                return View("Error", errorModel);
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
        /// Controller method for 'MemberInfo' page
        /// </summary>
        /// <param name="person">Team member info</param>
        /// <returns>'MemberInfo' view</returns>
        [HttpPost]
        public IActionResult MemberInfo(Person person)
        {
            try
            {
                //PublicationRepository publications = new PublicationRepository();
                //person = publications.GetPublicationsDataNCBI(person);
                //person = publications.GetPublicationsDataCrossRef(person);

                return View(person);
            }
            catch(Exception e)
            {
                ErrorViewModel errorModel = new ErrorViewModel
                {
                    Message = e.Message
                };
                return View("Error", errorModel);
            }
        }
        /// <summary>
        /// Controller method for returning 'MemberInfo' page
        /// Is requesting using GET protocol.
        /// </summary>
        /// <param name="person">Team member info</param>
        /// <returns>'MemberInfo' view</returns>
        [HttpGet]
        [ActionName("MemberInfo")]
        public ActionResult MemberInfoGet(Person person)
        {
            try
            {
                string memberName = string.Empty;

                switch (person.Id)
                {
                    case "8774A_!52101":
                        memberName = "Mina Ryten";
                        break;  // Always break each case
                    case "BP98-F74160":
                        memberName = "Juan A. Botía";
                        break;
                    case "1A_P04986":
                        memberName = "Juan A. Sanchez";
                        break;
                    case "2548LOP641":
                        memberName = "Karishma D'Sa";
                        break;
                    case "91AA_B35843":
                        memberName = "Sebastian Guelfi";
                        break;
                    case "103698KFT714":
                        memberName = "Regina H. Reynolds";
                        break;
                    case "103PO8741457":
                        memberName = "David Zhang";
                        break;
                    case "LO96_F34158":
                        memberName = "Sonia García Ruiz";
                        break;
                    case "189635LLDP42":
                        memberName = "Zhongbo Chen";
                        break;
                    case "3DD_P9652844":
                        memberName = "Siddharth Sethi";
                        break;
                    case "1_FON05125800":
                        memberName = "Aine Fairbrother-Browne";
                        break;
                    //case "85_RR4347H20":
                    //    memberName = "Fran Kiernan";
                    //    break;
                };

                var path = Path.Combine(_hostingEnvironment.ContentRootPath, "wwwroot/xml/team.xml");
                //Load the XML file in XmlDocument.
                XmlDocument doc = new XmlDocument();
                doc.Load(path);
                //Loop through the selected Nodes.
                foreach (XmlNode node in doc.SelectNodes("/TeamMembers/Person"))
                {
                    if(node["Name"].InnerText == memberName)
                    {
                        person.ID = int.Parse(node["ID"].InnerText);
                        person.Name = node["Name"].InnerText;
                        person.Title = node["Title"].InnerText;
                        person.Job = node["Job"].InnerText;
                        person.Email = node["Email"].InnerText;
                        person.ResearchInterest = node["ResearchInterest"].InnerText;
                        person.Biography = node["Biography"].InnerText;
                        person.ImagePath = node["ImagePath"].InnerText;
                        person.GitHub = node["GitHub"].InnerText;
                        person.ResearchGate = node["ResearchGate"].InnerText;
                        person.CurrentMember = node["CurrentMember"].InnerText;
                        break;
                    }
                }
                return View(person);
            }
            catch (Exception e)
            {
                ErrorViewModel errorModel = new ErrorViewModel
                {
                    Message = e.Message
                };
                return View("Error", errorModel);
            }
        }



        /// <summary>
        /// Controller method for 'FurryMember' page
        /// </summary>
        /// <param name="pet">Pet Furry Member info</param>
        /// <returns>'FurryMember' view</returns>
        [HttpPost]
        public IActionResult FurryMember(Pet pet)
        {
            try
            {
                return View(pet);
            }
            catch (Exception e)
            {
                ErrorViewModel errorModel = new ErrorViewModel
                {
                    Message = e.Message
                };
                return View("Error", errorModel);
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
