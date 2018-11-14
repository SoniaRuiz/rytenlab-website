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
            try
            {
                ////////////////////////////////////////////
                ///////////////// BIORXIV //////////////////
                //////////////////////////////////////////// 
                Publication publication = new Publication();
                publication.Title = "Moving beyond neurons: the role of cell type-specific gene regulation in Parkinson's disease heritability";
                publication.JournalName = "bioRxiv";
                publication.Authors = publication.SetAuthors("Regina H Reynolds, Juan A Botia, Mike A Nalls, International Parkinson's Disease Genomics Consortium (IPDGC), System Genomics of Parkinson's Disease (SGPD), John Hardy, Sarah A Gagliano, Mina Ryten");
                publication.Link = "https://www.biorxiv.org/content/early/2018/10/16/442152";
                publication.Date = "2018 Oct";

                /*Publication publication2 = new Publication();
                publication2.Title = "Variation at the TRIM11 locus modifies Progressive Supranuclear Palsy phenotype.";
                publication2.JournalName = "bioRxiv";
                publication2.Authors = publication2.SetAuthors("Edwin Jabbari, Woodside John, Manuela MX Tan, Shoai Maryam, Alan Pittman, Raffaele Ferrari, Kin Y Mok, David Zhang, Regina H Reynolds, Rohan de Silva, Max-Joseph Grimm, Gesine Respondek, Ulrich Muller, Safa Al-Sarraj, Steve M Gentleman, Andrew J Lees, Tom T Warner, John Hardy, Tamas Revesz, PROSPECT-UK consortium, Guenter U Hoglinger, Janice L Holton, Mina Ryten, Huw R Morris");
                publication2.Link = "https://www.biorxiv.org/content/early/2018/05/30/333195";
                publication2.Date = "2018 May";*/

                Publication publication3 = new Publication();
                publication3.Title = "G2P: Using machine learning to understand and predict genes causing rare neurological disorders";
                publication3.JournalName = "bioRxiv";
                publication3.Authors = publication3.SetAuthors("Juan A. Botia, Sebastian Guelfi, David Zhang, Karishma D'Sa, Regina Reinolds, Daniel Onah, Ellen M. McDonagh, Antonio Rueda-Martin, Arianna Tucci, Augusto Rendon, Henry Houlden, John Hardy, Mina Ryten");
                publication3.Link = "https://www.biorxiv.org/content/early/2018/03/27/288845";
                publication3.Date = "2018 March";

                



                //ViewData["Message"] = "Your application description page.";
                Team teamMembers = new Team();

                ////////////////////////////////////////////
                /////////////////// MINA ///////////////////
                ////////////////////////////////////////////
                Person mina = new Person();
                mina.ID = 0;
                mina.Name = "Mina Ryten";
                mina.Job = "Dr (MBBS, PhD)";
                mina.Description = "Description";
                mina.Email = "mina.ryten@ucl.ac.uk";
                mina.ResearchInterest = "Transcriptomics; Data Analysis of High-throughput Techniques for complex neurological diseases; Data Analysis of High-throughput Techniques to improve the diagnostic yield for rare neurogenetic disorders";
                mina.Biography = "Mina is a clinician scientist with roughly equivalent experience in clinical and research settings. In her clinical practice she cares for individuals and families with, or at risk of, a range of conditions which may have a genetic basis. As well as providing a diagnosis, the aim of her clinics is to help individuals affected by a genetic disorder live as normally as possible with their condition. Mina’s research lab focuses on the use of transcriptomics, primarily derived from human brain, to improve the molecular understanding of complex and rare neurological disorders.";
                mina.NCBIPublicationsID = "25174004,30066433";
                mina.ImagePath = "mina.jpg";
                mina.CrossRefPublicationsList.Add(publication);
                mina.CrossRefPublicationsList.Add(publication3);
                teamMembers.TeamMembers.Add(mina);

                ////////////////////////////////////////////
                /////////////////// JUAN ///////////////////
                ////////////////////////////////////////////
                Person botia = new Person();
                botia.ID = 1;
                botia.Name = "Juan A. Botía";
                botia.Job = "PhD";
                botia.Description = "Description";
                botia.Email = "j.botia@ucl.ac.uk";
                botia.GitHub = "juanbot";
                botia.NCBIPublicationsID = "30066433";
                botia.ImagePath = "botia.jpg";
                teamMembers.TeamMembers.Add(botia);

                ////////////////////////////////////////////
                ////////////////// SANCHEZ /////////////////
                ////////////////////////////////////////////
                Person sanchez = new Person();
                sanchez.ID = 2;
                sanchez.Name = "Juan A. Sanchez";
                sanchez.Job = "PhD";
                sanchez.Description = "Description";
                sanchez.Email = "jlaguna@um.es";
                sanchez.ResearchInterest = "Applying artificial intelligence, machine learning and data mining techniques to help MDs intepretate the aetiology of neurological diseases such as Alzheimer or Parkinson.";
                sanchez.Biography = "Juan A. Sánchez is an Associate Professor in the Department of Communications and Information Engineering (DIIC) at the Computer Science Faculty, of the University of Murcia, Spain. He received a B.Sc. (1997), M.Sc. (1999) and Ph.D. (2006) degree in Computer Science from the University of Murcia.";
                //sanchez.NCBIPublicationsID = "30328509";
                sanchez.ImagePath = "sanchez.jpg";
                teamMembers.TeamMembers.Add(sanchez);

                //////////////////////////////////////////////
                ////////////////// KARISHMA //////////////////
                //////////////////////////////////////////////
                Person karishma = new Person();
                karishma.ID = 3;
                karishma.Name = "Karishma D'Sa";
                karishma.Job = "PhD Student";
                karishma.Description = "Description";
                karishma.Email = "k.d'sa@ucl.ac.uk";
                karishma.NCBIPublicationsID = "30066433";
                karishma.ImagePath = "karishma.png";
                teamMembers.TeamMembers.Add(karishma);

                
                /////////////////////////////////////////
                ////////////////// SEB //////////////////
                /////////////////////////////////////////
                Person seb = new Person();
                seb.ID = 4;
                seb.Name = "Sebastian Guelfi";
                seb.Job = "PhD Student";
                seb.Description = "Description";
                seb.Email = "m.guelfi@ucl.ac.uk";
                seb.NCBIPublicationsID = "25174004,30066433";
                seb.ImagePath = "seb.jpg";
                seb.GitHub = "SebGuelfi";
                teamMembers.TeamMembers.Add(seb);


                ////////////////////////////////////////////
                ////////////////// REGINA //////////////////
                ////////////////////////////////////////////
                Person regina = new Person();
                regina.ID = 5;
                regina.Name = "Regina H. Reynolds";
                regina.Job = "PhD Student";
                regina.Description = "Description";
                regina.Email = "regina.reynolds.16@ucl.ac.uk";
                regina.ResearchInterest = "Functional genomics; Neurodegeneration; Statistical Genetics; Transcriptomics.";
                regina.Biography = "Regina is a PhD student in the Leonard Wolfson Programme at UCL. After a year of rotations, she joined the Ryten lab in 2017 where her research will involve integrating in-house RNA-sequencing, publicly available -omics data, and novel methods of analysis to understand the effect of genetic variation and cell environment on the brain transcriptome and neurodegenerative disease. Regina completed her Bachelor’s and Master’s degree in Molecular Biomedicine at the University of Copenhagen. During this time, she accumulated 2 years of wet lab experience, interrogating the interactions between miR-34a, Sirt1 and p53 in a Huntington’s disease mouse model. As a student making the transition from molecular biology to bioinformatics, Regina is a strong supporter of interdisciplinary collaboration and research; she believes access to different approaches is crucial to unravelling the complexities of the brain in health and disease.";
                regina.NCBIPublicationsID = "29289683,30066433";
                regina.ImagePath = "regina.jpg";
                regina.CrossRefPublicationsList.Add(publication);
                regina.GitHub = "RHReynolds";
                //regina.CrossRefPublicationsList.Add()
                //regina.CrossRefPublicationsTitles.Add("Moving beyond neurons: the role of cell type-specific gene regulation in Parkinson's disease heritability");
                //regina.CrossRefPublicationsTitles.Add("Regulatory sites for known and novel splicing in human basal ganglia are enriched for disease-relevant information");
                //regina.CrossRefPublicationsTitles.Add("Variation at the TRIM11 locus modifies Progressive Supranuclear Palsy phenotype");
                //regina.CrossRefPublicationsTitles.Add("G2P: Using machine learning to understand and predict genes causing rare neurological disorders");
                //regina.CrossRefPublicationsTitles.Add("Perturbations in the p53/miR-34a/SIRT1 pathway in the R6/2 Huntington’s disease model");
                teamMembers.TeamMembers.Add(regina);


                ///////////////////////////////////////////
                ////////////////// DAVID //////////////////
                ///////////////////////////////////////////
                Person david = new Person();
                david.ID = 6;
                david.Name = "David Zhang";
                david.Job = "PhD Student";
                david.Description = "Description";
                david.Email = "david.zhang.12@ucl.ac.uk";
                david.ResearchInterest = "Transcriptomics; Genetics; Bioinformatics; Novel transcription; Molecular diagnosis; Neurodegeneration; Mendelian Disease; Machine Learning; Statistical Modelling.";
                david.Biography = "David chose genetics because it allowed him to combine his practical enjoyment of computational analysis with his interest in human biology. His PhD is focussed on developing algorithms to improve the molecular diagnosis of Mendelian disease patients.";
                david.NCBIPublicationsID = "30066433";
                david.ImagePath = "david.jpg";
                david.GitHub = "dzhang32";
                //david.CrossRefPublicationsTitles.Add("Regulatory sites for known and novel splicing in human basal ganglia are enriched for disease-relevant information");
                //david.CrossRefPublicationsTitles.Add("G2P: Using machine learning to understand and predict genes causing rare neurological disorders");
                teamMembers.TeamMembers.Add(david);

                ///////////////////////////////////////////
                ////////////////// SONIA //////////////////
                ///////////////////////////////////////////
                Person sonia = new Person();
                sonia.ID = 7;
                sonia.Name = "Sonia García";
                sonia.Job = "Software Developer";
                sonia.Description = "Description";
                sonia.Email = "s.ruiz@ucl.ac.uk";
                sonia.ResearchInterest = "Web Development; Artificial Intelligence; Machine Learning, Software Development;  Transcriptomics.";
                sonia.Biography = "Sonia is a software developer at UCL. She completed her Bachelor’s in Computer Science at the University of Miguel Hernández (Spain) in 2014. After that, she accumulated 2 years of experience as a web developer, working with clients such as Microsoft and Deloitte. Nevertheless, in 2017 she decided to return to university and completed her Master’s degree in Artificial Intelligence at the University of Murcia in 2018. In the Ryten lab, Sonia uses her knowledge of web development to help build analysis and visualisation tools for easier data interpretation.";
                //sonia.NCBIPublicationsID = "30328509";
                sonia.ImagePath = "sonia.jpg";
                sonia.GitHub = "SoniaRuiz";
                teamMembers.TeamMembers.Add(sonia);


                ///////////////////////////////////////////
                ///////////////// ZHONGBO /////////////////
                ///////////////////////////////////////////
                Person zhongbo = new Person();
                zhongbo.ID = 6;
                zhongbo.Name = "Zhongbo Chen";
                zhongbo.Job = "PhD Student";
                zhongbo.Description = "Description";
                zhongbo.Email = "zhongbo.chen@ucl.ac.uk";
                zhongbo.ResearchInterest = "Genetics; Neurodegenerative diseases; Clinical Neurology; Bioinformatics.";
                zhongbo.Biography = "Zhongbo is a first-year PhD student and clinical research fellow on the Leonard Wolfson Programme at UCL. She is excited to be on her first rotation in the Ryten Lab. Zhongbo qualified as a doctor in 2010.Before embarking on the PhD, she was a specialist registrar in Neurology working at the National Hospital for Neurology and Neurosurgery.Zhongbo’s clinical and academic research interests are in studying the underlying genetics and molecular mechanisms of neurodegenerative diseases, including amyotrophic lateral sclerosis and progressive supranuclear palsy. Zhongbo’s research interests started during her undergraduate degree in Physiology and Neuroscience at the University of Cambridge, where she studied the electrophysiology of skeletal muscle using microelectrodes for her final year project She completed her clinical medicine degree at the University of Oxford.After graduating from Oxford, Zhongbo was awarded an academic foundation post at Imperial College London investigating the epidemiology of stroke, which was followed by a three - year NIHR - funded academic clinical fellowship(ACF) in Neurology at King’s College London.Alongside clinical neurology training, she developed her interests in the genetics of neurodegenerative diseases during the ACF, which culminated in the award of the Leonard Wolfson PhD fellowship.";
                zhongbo.NCBIPublicationsID = "30089514,28010125,27584932,26968196,24259043,24175058,20849322,20842366,PMC2045119";
                zhongbo.ImagePath = "zhongbo.jpg";
                zhongbo.GitHub = "";
                //david.CrossRefPublicationsTitles.Add("Regulatory sites for known and novel splicing in human basal ganglia are enriched for disease-relevant information");
                //david.CrossRefPublicationsTitles.Add("G2P: Using machine learning to understand and predict genes causing rare neurological disorders");
                teamMembers.TeamMembers.Add(zhongbo);




                return View(teamMembers);
            }
            catch (Exception e)
            {
                ErrorViewModel errorModel = new ErrorViewModel();
                errorModel.Message = e.Message;
                return View("Error", errorModel);
            }
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

        public IActionResult Publications()
        {
            try
            {
                Person genericPerson = new Person();
                PublicationRepository publications = new PublicationRepository();

                genericPerson.NCBIPublicationsID = "30066433,29289683,25174004,30089514,28010125,27584932,26968196,24259043,24175058,20849322,20842366,PMC2045119";
                genericPerson = publications.GetPublicationsDataNCBI(genericPerson);

                return View(genericPerson);
            }
            catch (Exception e)
            {
                ErrorViewModel errorModel = new ErrorViewModel();
                errorModel.Message = e.Message;
                return View("Error", errorModel);
            }
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        [HttpPost]
        public IActionResult MemberInfo(Person person)
        {
            try
            {
                PublicationRepository publications = new PublicationRepository();
                person = publications.GetPublicationsDataNCBI(person);
                person = publications.GetPublicationsDataCrossRef(person);

                return View(person);
            }
            catch(Exception e)
            {
                ErrorViewModel errorModel = new ErrorViewModel();
                errorModel.Message = e.Message;
                return View("Error", errorModel);
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { Message = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
