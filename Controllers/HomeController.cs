using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RytenLab_Web.Models;
using RytenLab_Web.Repositories;

namespace RytenLab_Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Team()
        {
            //ViewData["Message"] = "Your application description page.";
            Team teamMembers = new Team();

            Person mina = new Person();
            mina.ID = 0;
            mina.Name = "Mina Ryten";
            mina.Job = "PhD";
            mina.Description = "Description";
            mina.Email = "mina.ryten@ucl.ac.uk";
            mina.PublicationsID = "30328509";
            mina.ImagePath = "mina.jpg";
            teamMembers.TeamMembers.Add(mina);

            Person botia = new Person();
            botia.ID = 1;
            botia.Name = "Juan A. Botía";
            botia.Job = "PhD";
            botia.Description = "Description";
            botia.Email = "juanbotiablaya@gmail.com";
            botia.PublicationsID = "30328509";
            botia.ImagePath = "botia.jpg";
            teamMembers.TeamMembers.Add(botia);

            Person sanchez = new Person();
            sanchez.ID = 2;
            sanchez.Name = "Juan A. Laguna";
            sanchez.Job = "PhD";
            sanchez.Description = "Description";
            sanchez.Email = "jlaguna@um.es";
            sanchez.ResearchInterest = "Applying artificial intelligence, machine learning and data mining techniques to help MDs intepretate the aetiology of neurological diseases such as Alzheimer or Parkinson.";
            sanchez.Biography = "Juan A. Sánchez is an Associate Professor in the Department of Communications and Information Engineering (DIIC) at the Computer Science Faculty, of the University of Murcia, Spain. He received a B.Sc. (1997), M.Sc. (1999) and Ph.D. (2006) degree in Computer Science from the University of Murcia.";
            sanchez.PublicationsID = "30328509";
            sanchez.ImagePath = "sanchez.jpg";
            teamMembers.TeamMembers.Add(sanchez);

            Person karishma = new Person();
            karishma.ID = 3;
            karishma.Name = "Karishma D'Sa";
            karishma.Job = "PhD Student";
            karishma.Description = "Description";
            karishma.Email = "k.d'sa@ucl.ac.uk";
            karishma.PublicationsID = "30328509";
            karishma.ImagePath = "botia.jpg";
            teamMembers.TeamMembers.Add(karishma);

            Person seb = new Person();
            seb.ID = 4;
            seb.Name = "Sebastian Guelfi";
            seb.Job = "PhD Student";
            seb.Description = "Description";
            seb.Email = "manuelsebastian.guelfi@gmail.com";
            seb.PublicationsID = "30328509";
            seb.ImagePath = "seb.jpg";
            teamMembers.TeamMembers.Add(seb);

            Person regina = new Person();
            regina.ID = 5;
            regina.Name = "Regina H. Reynolds";
            regina.Job = "PhD Student";
            regina.Description = "Description";
            regina.Email = "regina.reynolds.16@ucl.ac.uk";
            regina.ResearchInterest = "Ageing; Data Analysis of High-throughput Techniques; Genetics; Huntington’s disease; Metabolism; MicroRNA Profiling; Molecular Biology; Neurodegeneration; Neurophysiology; Statistical Modelling; Transcriptomics.";
            regina.Biography = "Regina is a PhD student in the Leonard Wolfson Programme at UCL. After a year of rotations, she joined the Ryten lab in 2017 where her research will involve integrating in-house RNA-sequencing, publicly available -omics data, and novel methods of analysis to understand the effect of genetic variation and cell environment on the brain transcriptome and neurodegenerative disease. Regina completed her Bachelor’s and Master’s degree in Molecular Biomedicine at the University of Copenhagen. During this time, she accumulated 2 years of wet lab experience, interrogating the interactions between miR-34a, Sirt1 and p53 in a Huntington’s disease mouse model. As a student making the transition from molecular biology to bioinformatics, Regina is a strong supporter of interdisciplinary collaboration and research; she believes access to different approaches is crucial to unravelling the complexities of the brain in health and disease.";
            regina.PublicationsID = "29289683,30066433";
            regina.ImagePath = "regina.jpg";
            teamMembers.TeamMembers.Add(regina);

            Person david = new Person();
            david.ID = 6;
            david.Name = "David Zhang";
            david.Job = "PhD Student";
            david.Description = "Description";
            david.Email = "david.zhang.12@ucl.ac.uk";
            david.ResearchInterest = "Transcriptomics; Genetics; Bioinformatics; Novel transcription; Molecular diagnosis; Neurodegeneration; Mendelian Disease; Machine Learning; Statistical Modelling.";
            david.Biography = "David chose genetics because it allowed him to combine his practical enjoyment of computational analysis with his interest in human biology. His PhD is focussed on developing algorithms to improve the molecular diagnosis of Mendelian disease patients.";
            david.PublicationsID = "30066433";
            david.ImagePath = "david.jpg";
            teamMembers.TeamMembers.Add(david);

            Person sonia = new Person();
            sonia.ID = 7;
            sonia.Name = "Sonia García";
            sonia.Job = "Software Developer";
            sonia.Description = "Description";
            sonia.Email = "s.ruiz@ucl.ac.uk";
            sonia.PublicationsID = "30328509";
            sonia.ImagePath = "sonia.jpg";
            teamMembers.TeamMembers.Add(sonia);

            return View(teamMembers);
        }

        public IActionResult Data()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Tools()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Publications(/*Person teamMember*/)
        {
            /*PublicationRepository publications = new PublicationRepository();
            teamMember.PublicationsList = publications.GetPublicationsDataNCBI(teamMember.PublicationsID);
            ViewData["Message"] = "Your application description page.";*/

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        [HttpPost]
        public IActionResult MemberInfo(Person person)
        {
            PublicationRepository publications = new PublicationRepository();
            person = publications.GetPublicationsDataNCBI(person);

            return View(person);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
