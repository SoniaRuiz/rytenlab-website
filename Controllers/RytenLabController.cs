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
    /// <summary>
    /// This controller sets the main operations of RytenLab web
    /// </summary>
    public class RytenLabController : Controller
    {
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
        /// Because we don't have the team information stored in a data base, we need to set it here.
        /// </summary>
        /// <returns>
        /// If everything is ok: Returns 'Team' view.
        /// If an error occurs: returns 'Error' view
        /// </returns>
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

                Publication publication4 = new Publication();
                publication4.Title = "A systems-level analysis highlights microglial activation as a modifying factor in common forms of human epilepsy.";
                publication4.JournalName = "bioRxiv";
                publication4.Authors = publication3.SetAuthors("Andre Altmann, Mina Ryten, Martina Di Nunzio, Teresa Ravizza, Daniele Tolomeo, Regina H Reynolds, Alyma Somani, Marco Bacigaluppi, Valentina Iori, Edoardo Micotti, Juan A Botia, Julie Absil, Saud Alhusaini, Marina K. M. Alvim, Pia Auvinen, Nuria Bargallo, Emanuele Bartolini, Benjamin Bender, Felipe Bergo, Tauana Bernardes, Andrea Bernasconi, Neda Bernasconi, Boris C Bernhardt, Karen Blackmon, Barbara Braga, Maria E Caligiuri, Anna Cavalo, Chad Carlson, Sarah Carr, Gianpiero Cavalleri, Fernando Cendes, Jian Chen, Shuai Chen, Andrea Cherubini, Luis Concha, Philippe David, Norman Delanty, Chantal Depondt, Orrin Devinsky, Colin P Doherty, Martin Domin, Niels Focke, Sonya Foley, Wendy Franca, Antonio Gambardella, Renzo Guerrini, Khalid Hamandi, Derrek P Hibar, Dmitry Y Isaev, Graeme Jackson, Neda Jahanshad, Reetta Kalviainen, Simon Keller, Peter Kochunov, Raviteja Kotikalapudi, Magdalena A Kowalczyk, Ruben Kuzniecky, Patrick Kwan, Angelo Labate, Soenke Langer, Matteo Lenge, Min Liu, Pascal Martin, Mario Mascalchi, Stefano Meletti, Marcia E Morita, Terence J O'Brien, Jose C Pariente, Mark P Richardson, Raul Rodriguez-Cruces, Christian Rummel, Taavi Saavalainen, Mira K Semmelroch, Mariasavina Severino, Pasquale Striano, Thomas Thesen, Rhys H Thomas, Manuela Tondelli, Domenica Tortora, Anna Elisabetta Vaudano, Lucy Vivash, Felix von Podewils, Jan Wagner, Bernd Weber, Roland Wiest, Clarissa L Yasuda, Guohao Zhang, Junsong Zhang, ENIGMA-Epilepsy Working Group, Costin Leu, Andreja Avbersek, EpiPGX Consortium, Maria Thom, Christopher D Whelan, Paul Thompson, Carrie McDonald, Annamaria Vezzani, Sanjay M Sisodiya");
                publication4.Link = "https://www.biorxiv.org/content/early/2018/11/14/470518";
                publication4.Date = "November 14, 2018";





                //ViewData["Message"] = "Your application description page.";
                Team teamMembers = new Team();

                ////////////////////////////////////////////
                /////////////////// MINA ///////////////////
                ////////////////////////////////////////////
                Person mina = new Person();
                mina.ID = 0;
                mina.Name = "Mina Ryten";
                mina.Title = "Dr (MBBS, PhD)";
                mina.Job = "MRC Clinician Scientist/ Proleptic Clinical Lecturer";
                mina.Email = "mina.ryten@ucl.ac.uk";
                mina.ResearchInterest = "Transcriptomics; Data Analysis of High-throughput Techniques for complex neurological diseases; Data Analysis of High-throughput Techniques to improve the diagnostic yield for rare neurogenetic disorders";
                mina.Biography = "<b>Mina Ryten </b>is a clinician scientist with roughly equivalent experience in clinical and research settings. In her clinical practice she cares for individuals and families with, or at risk of, a range of conditions which may have a genetic basis. As well as providing a diagnosis, the aim of her clinics is to help individuals affected by a genetic disorder live as normally as possible with their condition. Mina’s research lab focuses on the use of transcriptomics, primarily derived from human brain, to improve the molecular understanding of complex and rare neurological disorders.";
                //mina.NCBIPublicationsID = "30328509,30225556,30066433,29930110,29365066,29127725,28899015,28602509,28575651,28403906,28137300,28098162,28097204,28076797,28004117,27694991,27500074,27073233,26912063,26707700";
                mina.ImagePath = "mina.jpg";
                /*mina.PreAcceptedPublicationsList.Add(publication4);
                mina.PreAcceptedPublicationsList.Add(publication);
                mina.PreAcceptedPublicationsList.Add(publication3);*/
                mina.ResearchGate = "Mina_Ryten";
                teamMembers.TeamMembers.Add(mina);

                ////////////////////////////////////////////
                /////////////////// JUAN ///////////////////
                ////////////////////////////////////////////
                Person botia = new Person();
                botia.ID = 1;
                botia.Name = "Juan A. Botía";
                botia.Title = "PhD";
                botia.Job = "Professor/Honorary Senior Research<br/><br/>";
                botia.Email = "j.botia@ucl.ac.uk";
                botia.GitHub = "juanbot";
                botia.ResearchGate = "Juan_Botia";
                botia.ResearchInterest = "Machine Learning; Algorithmic Design; Statistical Learning; Neuro-degeneration; Genetics of disease; Transcriptomics; Interplay between mendelian and complex diseases.";
                botia.Biography = "<b>Juan A. Botía</b>, Phd. is Professor in Computer Science and Artificial Intelligence at the University of Murcia, Murcia, Spain. He is also Honorary Senior Research Fellow at the Institute of Neurology, University College London, UK since July, 2017. Juan A. Botía is PhD in Computational Science and Artificial Intelligence(March 2002).He obtained a position at Universidad de Murcia as Reader in April 2009. His research interests include, from the very beginning of his career, multi - agent systems, distributed artificial intelligence and machine learning with an emphasis on applications of AI. He has been involved in research and innovation projects with a common aspect: applying AI and algorithm approaches to real life problems, including domains like agriculture, multi-media content recommendation, indoor location of mobile devices and ambient assisted living. During 2013 Dr.Botía moved to London to enjoy a sabbatical period with Dr.Juan C. Augusto at Middlesex University. In 2014 he joined the UKBEC project at King’s College London to work as Research Associate, in the Department of Molecular and Medical Genetics, School of Medicine under the supervision of Mike Weale and Mina Ryten. In 2015, within the same project, he was honoured to start working with John Hardy and Mina Ryten at the Department of Molecular Neuroscience, University College London, until mid 2017 when he returned to Universidad de Murcia. During his period at the UK, he started applying AI techniques to transcriptomics and genetics within the area of neurology, until now. Currently, he is member of the Ryten Lab.";
                //botia.NCBIPublicationsID = "30328509,30225556,29365066,29127725,28899015,28575651,28403906,28137300,26912063,26707700,22778642,15484912";
                //botia.PreAcceptedPublicationsList.Add(publication4);
                //botia.PreAcceptedPublicationsList.Add(publication);
                //botia.PreAcceptedPublicationsList.Add(publication3);
                botia.ImagePath = "botia.jpg";
                teamMembers.TeamMembers.Add(botia);

                ////////////////////////////////////////////
                ////////////////// SANCHEZ /////////////////
                ////////////////////////////////////////////
                Person sanchez = new Person();
                sanchez.ID = 2;
                sanchez.Name = "Juan A. Sanchez";
                sanchez.Title = "PhD";
                sanchez.Job = "Associate Lecturer<br/><br/>";
                sanchez.Email = "jlaguna@um.es";
                sanchez.ResearchInterest = "Applying artificial intelligence, machine learning and data mining techniques to help MDs intepretate the aetiology of neurological diseases such as Alzheimer or Parkinson.";
                sanchez.Biography = "<b>Juan A. Sánchez</b> is an Associate Professor in the Department of Communications and Information Engineering (DIIC) at the Computer Science Faculty, of the University of Murcia, Spain. He received a B.Sc. (1997), M.Sc. (1999) and Ph.D. (2006) degree in Computer Science from the University of Murcia.";
                //sanchez.NCBIPublicationsID = "30328509";
                sanchez.ImagePath = "sanchez.jpg";
                sanchez.ResearchGate = "Juan_Sanchez23";
                teamMembers.TeamMembers.Add(sanchez);

                //////////////////////////////////////////////
                ////////////////// KARISHMA //////////////////
                //////////////////////////////////////////////
                Person karishma = new Person();
                karishma.ID = 3;
                karishma.Name = "Karishma D'Sa";
                karishma.Title = "MSc";
                karishma.Job = "Research assistant/PhD student";
                karishma.Email = "k.d'sa@ucl.ac.uk";
                //karishma.NCBIPublicationsID = "28403906";
                karishma.ResearchInterest = "Transcriptomics; Genetics; Neurodegeneration; Bioinformatics; Personalized medicine.";
                karishma.Biography = "<b>Karishma</b>’s research focuses on the analysis of transcriptomic data with the aim of understanding how genetic variation affects gene expression in human brain using allele specific expression. She holds a Master’s degree in Bioinformatics from King’s College London.";
                karishma.ImagePath = "kd.png";
                teamMembers.TeamMembers.Add(karishma);

                
                /////////////////////////////////////////
                ////////////////// SEB //////////////////
                /////////////////////////////////////////
                Person seb = new Person();
                seb.ID = 4;
                seb.Name = "Sebastian Guelfi";
                seb.Title = "PhD";
                seb.Job = "Research Associate";
                seb.Email = "m.guelfi@ucl.ac.uk";
                seb.ResearchGate = "Sebastian_Guelfi";
                //seb.NCBIPublicationsID = "28403906,28391543,28098162,27899424,27694991,26912063,25620700,25607358,25174004";
                seb.ImagePath = "seb.jpg";
                seb.ResearchInterest = "Genomics; Genetics; Bioinformatics; Novel transcription; Gene regulation; RNA Splicing; Neurodegeneration; Machine Learning;  Biostatistics, Data integration.";
                seb.Biography = "<b>Sebastian Guelfi</b>, is Postdoctoral Research Fellow in the Ryten Lab. Currently, he studies RNA splicing by leveraging large genomic datasets. He obtained his PhD in bioinformatics at University College London where he integrated different forms of genomic data to investigate the relationship between gene regulation and neurodegenerative diseases. Before pursuing his interests in data analysis and health care, Sebastian worked for 6 years in the private sector designing and developing software to solve logistics problems.";
                seb.GitHub = "SebGuelfi";
                teamMembers.TeamMembers.Add(seb);


                ////////////////////////////////////////////
                ////////////////// REGINA //////////////////
                ////////////////////////////////////////////
                Person regina = new Person();
                regina.ID = 5;
                regina.Name = "Regina H. Reynolds";
                regina.Title = "MSc";
                regina.Job = "PhD Student";
                regina.Email = "regina.reynolds.16@ucl.ac.uk";
                regina.ResearchInterest = "Functional genomics; Neurodegeneration; Statistical Genetics; Transcriptomics.";
                regina.Biography = "<b>Regina H. Reynolds</b> is a PhD student in the Leonard Wolfson Programme at UCL. After a year of rotations, she joined the Ryten lab in 2017 where her research involves integrating in-house RNA-sequencing, publicly available -omics data, and novel methods of analysis to understand the effect of genetic variation on the brain transcriptome in health and disease. Regina completed her Bachelor’s and Master’s degree in Molecular Biomedicine at the University of Copenhagen. During this time, she accumulated 2 years of wet lab experience, interrogating the interactions between miR-34a, Sirt1 and p53 in a Huntington’s disease mouse model. As a student making the transition from molecular biology to bioinformatics, Regina is a strong supporter of interdisciplinary collaboration and research.";
                //regina.NCBIPublicationsID = "29289683,30066433";
                regina.ImagePath = "regina.jpg";
                //regina.PreAcceptedPublicationsList.Add(publication4);
                //regina.PreAcceptedPublicationsList.Add(publication);
                regina.GitHub = "RHReynolds";
                regina.ResearchGate = "Regina_Reynolds";
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
                david.Title = "MSc";
                david.Job = "PhD Student";
                david.Email = "david.zhang.12@ucl.ac.uk";
                david.ResearchInterest = "Transcriptomics; Genetics; Bioinformatics; Novel transcription; Molecular diagnosis; Neurodegeneration; Mendelian Disease; Machine Learning; Statistical Modelling.";
                david.Biography = "<b>David Zhang</b> chose genetics because it allowed him to combine his practical enjoyment of computational analysis with his interest in human biology. His PhD is focussed on developing algorithms to improve the molecular diagnosis of Mendelian disease patients.";
                //david.NCBIPublicationsID = "30066433";
                david.ImagePath = "david.jpg";
                david.GitHub = "dzhang32";
                david.ResearchGate = "David_Zhang98";
                //david.CrossRefPublicationsTitles.Add("Regulatory sites for known and novel splicing in human basal ganglia are enriched for disease-relevant information");
                //david.CrossRefPublicationsTitles.Add("G2P: Using machine learning to understand and predict genes causing rare neurological disorders");
                teamMembers.TeamMembers.Add(david);

                ///////////////////////////////////////////
                ////////////////// SONIA //////////////////
                ///////////////////////////////////////////
                Person sonia = new Person();
                sonia.ID = 7;
                sonia.Name = "Sonia García Ruiz";
                sonia.Title = "MSc";
                sonia.Job = "Research assistant";
                sonia.Email = "s.ruiz@ucl.ac.uk";
                sonia.ResearchInterest = "Web Development; Artificial Intelligence; Machine Learning, Software Development;  Transcriptomics.";
                sonia.Biography = "<b>Sonia García Ruiz</b> is a software developer at UCL. She completed her Bachelor’s in Computer Science at the University of Miguel Hernández (Spain) in 2014. After that, she accumulated 2 years of experience as a web developer, working with clients such as Microsoft and Deloitte. Nevertheless, in 2017 she decided to return to university and completed her Master’s degree in Artificial Intelligence at the University of Murcia in 2018. In the Ryten lab, Sonia uses her knowledge of web development to help build analysis and visualisation tools for easier data interpretation.";
                //sonia.NCBIPublicationsID = "30328509";
                sonia.ImagePath = "sonia.jpg";
                sonia.GitHub = "SoniaRuiz";
                sonia.ResearchGate = "Sonia_Garcia_Ruiz";
                teamMembers.TeamMembers.Add(sonia);


                ///////////////////////////////////////////
                ///////////////// ZHONGBO /////////////////
                ///////////////////////////////////////////
                Person zhongbo = new Person();
                zhongbo.ID = 8;
                zhongbo.Name = "Zhongbo Chen";
                zhongbo.Title = "MA BMBCh MRCP";
                zhongbo.Job = "PhD Student";
                zhongbo.Email = "zhongbo.chen@ucl.ac.uk";
                zhongbo.ResearchInterest = "Genetics; Neurodegenerative diseases; Clinical Neurology; Bioinformatics.";
                zhongbo.Biography = "<b>Zhongbo Chen</b> is a first-year PhD student and clinical research fellow on the Leonard Wolfson Programme at UCL. She is excited to be on her first rotation in the Ryten Lab. Zhongbo qualified as a doctor in 2010.Before embarking on the PhD, she was a specialist registrar in Neurology working at the National Hospital for Neurology and Neurosurgery.Zhongbo’s clinical and academic research interests are in studying the underlying genetics and molecular mechanisms of neurodegenerative diseases, including amyotrophic lateral sclerosis and progressive supranuclear palsy. Zhongbo’s research interests started during her undergraduate degree in Physiology and Neuroscience at the University of Cambridge, where she studied the electrophysiology of skeletal muscle using microelectrodes for her final year project She completed her clinical medicine degree at the University of Oxford.After graduating from Oxford, Zhongbo was awarded an academic foundation post at Imperial College London investigating the epidemiology of stroke, which was followed by a three - year NIHR - funded academic clinical fellowship(ACF) in Neurology at King’s College London.Alongside clinical neurology training, she developed her interests in the genetics of neurodegenerative diseases during the ACF, which culminated in the award of the Leonard Wolfson PhD fellowship.";
                //zhongbo.NCBIPublicationsID = "30089514,28010125,27584932,26968196,24259043,24175058,20849322,20842366,PMC2045119";
                zhongbo.ImagePath = "zhongbo.jpg";
                zhongbo.GitHub = "";
                //david.CrossRefPublicationsTitles.Add("Regulatory sites for known and novel splicing in human basal ganglia are enriched for disease-relevant information");
                //david.CrossRefPublicationsTitles.Add("G2P: Using machine learning to understand and predict genes causing rare neurological disorders");
                teamMembers.TeamMembers.Add(zhongbo);



                ///////////////////////////////////////
                ///////////////// SID /////////////////
                ///////////////////////////////////////
                Person sethi = new Person();
                sethi.ID = 9;
                sethi.Name = "Siddharth Sethi";
                sethi.Title = "MSc";
                sethi.Job = "Postdoctoral Research Fellow";
                sethi.Email = "siddharth.sethi@astx.com";
                sethi.ResearchInterest = "Transcriptomics; UTRs; MicroRNAs; Enhancers; Regulatory domains; Chromatin interactions; 3D genome; Big data analysis; Machine learning; Statistical modelling; Data visualisation.";
                sethi.Biography = "<b>Siddharth Sethi</b> is a joint Postdoctoral Research Fellow between Ryten lab and Astex Pharmaceuticals in Cambridge. His research focuses on alternate 3’UTR mediated regulation in neurodegenerative disorders. Siddharth completed his graduation in Bio-technology in India and moved to the UK to pursue MSc in Bioinformatics from the University of Leicester. Soon after that he joined Mallon lab at MRC Harwell Institute as a Bioinformatics scientist, where he worked on several different projects before starting his PhD. He developed a deep interest in the functional properties of the non-coding part of the genome and focused his PhD research on deciphering regulatory networks and their impact on mouse phenotypes.";
                sethi.NCBIPublicationsID = "30395686,29632379,27534441,27373158,26232227,24249052";
                sethi.ImagePath = "sethi.png";
                sethi.GitHub = "sid-sethi";
                //david.CrossRefPublicationsTitles.Add("Regulatory sites for known and novel splicing in human basal ganglia are enriched for disease-relevant information");
                //david.CrossRefPublicationsTitles.Add("G2P: Using machine learning to understand and predict genes causing rare neurological disorders");
                teamMembers.TeamMembers.Add(sethi);


                ////////////////////////////////////////
                ///////////////// AINE /////////////////
                ////////////////////////////////////////
                Person aine = new Person();
                aine.ID = 10;
                aine.Name = "Aine Fairbrother-Browne";
                aine.Title = "BSc, MSc";
                aine.Job = "PhD student";
                aine.Email = "aine.fairbrother-browne.18@ucl.ac.uk";
                aine.ResearchInterest = "Neurodegenerative disease, medical genetics, bioinformatics.";
                aine.Biography = "<b>Aine Fairbrother-Browne</b> Aine is a BBSRC funded LIDo PhD student in both the Ryten lab at UCL and the Hodgkinson Medical and Molecular Genetics lab at King’s. She completed at BSc in Biology at Bristol University (2016), and then did an MSc in Bioinformatics and Systems Biology at Birkbeck (2017). In 2018 she started on the BBSRC funded LIDo PhD programme. Whilst working with Mina Ryten and Alan Hodgkinson, she is focused on nuclear regulation of the mitochondrial genome in brain and its role in age-related pathologies.";
                //aine.NCBIPublicationsID = "";
                aine.ImagePath = "aine.png";
                aine.GitHub = "ainefairbrother";
                //david.CrossRefPublicationsTitles.Add("Regulatory sites for known and novel splicing in human basal ganglia are enriched for disease-relevant information");
                //david.CrossRefPublicationsTitles.Add("G2P: Using machine learning to understand and predict genes causing rare neurological disorders");
                teamMembers.TeamMembers.Add(aine);



                return View(teamMembers);
            }
            catch (Exception e)
            {
                ErrorViewModel errorModel = new ErrorViewModel();
                errorModel.Message = e.Message;
                return View("Error", errorModel);
            }
        }
        /// <summary>
        /// Controller method for 'Data' page.
        /// </summary>
        /// <returns>Returns 'Data' view.</returns>
        public IActionResult Data()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
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
        /// Controller method for 'Publications' page.
        /// </summary>
        /// <returns>
        /// If everything is ok: Returns 'Publications' view.
        /// If an error occurs: returns 'Error' view
        /// </returns>
        public IActionResult Publications()
        {
            try
            {
                Person publicationsPerson = new Person();
                PublicationRepository publications = new PublicationRepository();

                //NCBI publications ID (from all team members)
                publicationsPerson.NCBIPublicationsID = "30328509,30225556,30089514,30066433,29930110,29365066,29127725,29289683,28899015,28764847,28602509,28575651,28403906,28391543,28137300,28098162,28097204,28076797,28010125,28004117,27899424,27694991,27584932,27500074,27073233,26968196,26912063,26707700,26468326,26085604,25983243,25970246,25799108,25620700,25607358,25568836,25439728,25174004,24862029,24503276,24399358,24336208,24264146,24259043,24241535,24198383,24175058,24014518,23967090,23889843,23855984,23435227,23424103,23360175,23200863,23177596,22778642,22723018,22681703,22504417,22433082,21944779,21863007,21848658,21799870,20849322,20842366,19909261,19734301,18005209,17941929,15911103,15231720,15484912,14517997,12135987";
                publicationsPerson = publications.GetPublicationsDataNCBI(publicationsPerson);

                return View(publicationsPerson);
            }
            catch (Exception e)
            {
                ErrorViewModel errorModel = new ErrorViewModel();
                errorModel.Message = e.Message;
                return View("Error", errorModel);
            }
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
                if(person.Id == "8774A_!52101")
                {
                    person.Name = "Mina Ryten";
                    person.Title = "Dr (MBBS, PhD)";
                    person.Job = "MRC Clinician Scientist/ Proleptic Clinical Lecturer";
                    person.Email = "mina.ryten@ucl.ac.uk";
                    person.ResearchInterest = "Transcriptomics; Data Analysis of High-throughput Techniques for complex neurological diseases; Data Analysis of High-throughput Techniques to improve the diagnostic yield for rare neurogenetic disorders";
                    person.Biography = "<b>Mina Ryten </b>is a clinician scientist with roughly equivalent experience in clinical and research settings. In her clinical practice she cares for individuals and families with, or at risk of, a range of conditions which may have a genetic basis. As well as providing a diagnosis, the aim of her clinics is to help individuals affected by a genetic disorder live as normally as possible with their condition. Mina’s research lab focuses on the use of transcriptomics, primarily derived from human brain, to improve the molecular understanding of complex and rare neurological disorders.";
                    person.ImagePath = "mina.jpg";
                    person.ResearchGate = "Mina_Ryten";
                }
                else if(person.Id == "BP98-F74160")
                {
                    person.Name = "Juan A. Botía";
                    person.Title = "PhD";
                    person.Job = "Professor/Honorary Senior Research<br/><br/>";
                    person.Email = "j.botia@ucl.ac.uk";
                    person.GitHub = "juanbot";
                    person.ResearchGate = "Juan_Botia";
                    person.ResearchInterest = "Machine Learning; Algorithmic Design; Statistical Learning; Neuro-degeneration; Genetics of disease; Transcriptomics; Interplay between mendelian and complex diseases.";
                    person.Biography = "<b>Juan A. Botía</b>, Phd. is Professor in Computer Science and Artificial Intelligence at the University of Murcia, Murcia, Spain. He is also Honorary Senior Research Fellow at the Institute of Neurology, University College London, UK since July, 2017. Juan A. Botía is PhD in Computational Science and Artificial Intelligence(March 2002).He obtained a position at Universidad de Murcia as Reader in April 2009. His research interests include, from the very beginning of his career, multi - agent systems, distributed artificial intelligence and machine learning with an emphasis on applications of AI. He has been involved in research and innovation projects with a common aspect: applying AI and algorithm approaches to real life problems, including domains like agriculture, multi-media content recommendation, indoor location of mobile devices and ambient assisted living. During 2013 Dr.Botía moved to London to enjoy a sabbatical period with Dr.Juan C. Augusto at Middlesex University. In 2014 he joined the UKBEC project at King’s College London to work as Research Associate, in the Department of Molecular and Medical Genetics, School of Medicine under the supervision of Mike Weale and Mina Ryten. In 2015, within the same project, he was honoured to start working with John Hardy and Mina Ryten at the Department of Molecular Neuroscience, University College London, until mid 2017 when he returned to Universidad de Murcia. During his period at the UK, he started applying AI techniques to transcriptomics and genetics within the area of neurology, until now. Currently, he is member of the Ryten Lab.";
                    person.ImagePath = "botia.jpg";
                }
                else if (person.Id == "1A_P04986")
                {
                    person.Name = "Juan A. Sanchez";
                    person.Title = "PhD";
                    person.Job = "Associate Lecturer<br/><br/>";
                    person.Email = "jlaguna@um.es";
                    person.ResearchInterest = "Applying artificial intelligence, machine learning and data mining techniques to help MDs intepretate the aetiology of neurological diseases such as Alzheimer or Parkinson.";
                    person.Biography = "<b>Juan A. Sánchez</b> is an Associate Professor in the Department of Communications and Information Engineering (DIIC) at the Computer Science Faculty, of the University of Murcia, Spain. He received a B.Sc. (1997), M.Sc. (1999) and Ph.D. (2006) degree in Computer Science from the University of Murcia.";
                    person.ImagePath = "sanchez.jpg";
                    person.ResearchGate = "Juan_Sanchez23";
                }
                else if (person.Id == "2548LOP641")
                {
                    person.Name = "Karishma D'Sa";
                    person.Title = "MSc";
                    person.Job = "Research assistant/PhD student";
                    person.Email = "k.d'sa@ucl.ac.uk";
                    person.ResearchInterest = "Transcriptomics; Genetics; Neurodegeneration; Bioinformatics; Personalized medicine.";
                    person.Biography = "<b>Karishma</b>’s research focuses on the analysis of transcriptomic data with the aim of understanding how genetic variation affects gene expression in human brain using allele specific expression. She holds a Master’s degree in Bioinformatics from King’s College London.";
                    person.ImagePath = "kd.png";
                }
                else if (person.Id == "91AA_B35843")
                {
                    person.Name = "Sebastian Guelfi";
                    person.Title = "PhD";
                    person.Job = "Research Associate";
                    person.Email = "m.guelfi@ucl.ac.uk";
                    person.ResearchGate = "Sebastian_Guelfi";
                    person.ImagePath = "seb.jpg";
                    person.ResearchInterest = "Genomics; Genetics; Bioinformatics; Novel transcription; Gene regulation; RNA Splicing; Neurodegeneration; Machine Learning;  Biostatistics, Data integration.";
                    person.Biography = "<b>Sebastian Guelfi</b>, is Postdoctoral Research Fellow in the Ryten Lab. Currently, he studies RNA splicing by leveraging large genomic datasets. He obtained his PhD in bioinformatics at University College London where he integrated different forms of genomic data to investigate the relationship between gene regulation and neurodegenerative diseases. Before pursuing his interests in data analysis and health care, Sebastian worked for 6 years in the private sector designing and developing software to solve logistics problems.";
                    person.GitHub = "SebGuelfi";
                }
                else if (person.Id == "103698KFT714")
                {
                    person.Name = "Regina H. Reynolds";
                    person.Title = "MSc";
                    person.Job = "PhD Student";
                    person.Email = "regina.reynolds.16@ucl.ac.uk";
                    person.ResearchInterest = "Functional genomics; Neurodegeneration; Statistical Genetics; Transcriptomics.";
                    person.Biography = "<b>Regina H. Reynolds</b> is a PhD student in the Leonard Wolfson Programme at UCL. After a year of rotations, she joined the Ryten lab in 2017 where her research involves integrating in-house RNA-sequencing, publicly available -omics data, and novel methods of analysis to understand the effect of genetic variation on the brain transcriptome in health and disease. Regina completed her Bachelor’s and Master’s degree in Molecular Biomedicine at the University of Copenhagen. During this time, she accumulated 2 years of wet lab experience, interrogating the interactions between miR-34a, Sirt1 and p53 in a Huntington’s disease mouse model. As a student making the transition from molecular biology to bioinformatics, Regina is a strong supporter of interdisciplinary collaboration and research.";
                    person.ImagePath = "regina.jpg";
                    person.GitHub = "RHReynolds";
                    person.ResearchGate = "Regina_Reynolds";
                }
                else if (person.Id == "103PO8741457")
                {
                    person.Name = "David Zhang";
                    person.Title = "MSc";
                    person.Job = "PhD Student";
                    person.Email = "david.zhang.12@ucl.ac.uk";
                    person.ResearchInterest = "Transcriptomics; Genetics; Bioinformatics; Novel transcription; Molecular diagnosis; Neurodegeneration; Mendelian Disease; Machine Learning; Statistical Modelling.";
                    person.Biography = "<b>David Zhang</b> chose genetics because it allowed him to combine his practical enjoyment of computational analysis with his interest in human biology. His PhD is focussed on developing algorithms to improve the molecular diagnosis of Mendelian disease patients.";
                    person.ImagePath = "david.jpg";
                    person.GitHub = "dzhang32";
                    person.ResearchGate = "David_Zhang98";
                }
                else if (person.Id == "LO96_F34158")
                {
                    person.Name = "Sonia García Ruiz";
                    person.Title = "MSc";
                    person.Job = "Research assistant";
                    person.Email = "s.ruiz@ucl.ac.uk";
                    person.ResearchInterest = "Web Development; Artificial Intelligence; Machine Learning, Software Development;  Transcriptomics.";
                    person.Biography = "<b>Sonia García Ruiz</b> is a software developer at UCL. She completed her Bachelor’s in Computer Science at the University of Miguel Hernández (Spain) in 2014. After that, she accumulated 2 years of experience as a web developer, working with clients such as Microsoft and Deloitte. Nevertheless, in 2017 she decided to return to university and completed her Master’s degree in Artificial Intelligence at the University of Murcia in 2018. In the Ryten lab, Sonia uses her knowledge of web development to help build analysis and visualisation tools for easier data interpretation.";
                    person.ImagePath = "sonia.jpg";
                    person.GitHub = "SoniaRuiz";
                    person.ResearchGate = "Sonia_Garcia_Ruiz";
                }
                else if (person.Id == "189635LLDP42")
                {
                    person.Name = "Zhongbo Chen";
                    person.Title = "MA BMBCh MRCP";
                    person.Job = "PhD Student";
                    person.Email = "zhongbo.chen@ucl.ac.uk";
                    person.ResearchInterest = "Genetics; Neurodegenerative diseases; Clinical Neurology; Bioinformatics.";
                    person.Biography = "<b>Zhongbo Chen</b> is a first-year PhD student and clinical research fellow on the Leonard Wolfson Programme at UCL. She is excited to be on her first rotation in the Ryten Lab. Zhongbo qualified as a doctor in 2010.Before embarking on the PhD, she was a specialist registrar in Neurology working at the National Hospital for Neurology and Neurosurgery.Zhongbo’s clinical and academic research interests are in studying the underlying genetics and molecular mechanisms of neurodegenerative diseases, including amyotrophic lateral sclerosis and progressive supranuclear palsy. Zhongbo’s research interests started during her undergraduate degree in Physiology and Neuroscience at the University of Cambridge, where she studied the electrophysiology of skeletal muscle using microelectrodes for her final year project She completed her clinical medicine degree at the University of Oxford.After graduating from Oxford, Zhongbo was awarded an academic foundation post at Imperial College London investigating the epidemiology of stroke, which was followed by a three - year NIHR - funded academic clinical fellowship(ACF) in Neurology at King’s College London.Alongside clinical neurology training, she developed her interests in the genetics of neurodegenerative diseases during the ACF, which culminated in the award of the Leonard Wolfson PhD fellowship.";
                    person.ImagePath = "zhongbo.jpg";
                    person.GitHub = "";
                }
                else if (person.Id == "3DD_P9652844")
                {
                    person.Name = "Siddharth Sethi";
                    person.Title = "MSc";
                    person.Job = "Postdoctoral Research Fellow";
                    person.Email = "siddharth.sethi@astx.com";
                    person.ResearchInterest = "Transcriptomics; UTRs; MicroRNAs; Enhancers; Regulatory domains; Chromatin interactions; 3D genome; Big data analysis; Machine learning; Statistical modelling; Data visualisation.";
                    person.Biography = "<b>Siddharth Sethi</b> is a joint Postdoctoral Research Fellow between Ryten lab and Astex Pharmaceuticals in Cambridge. His research focuses on alternate 3’UTR mediated regulation in neurodegenerative disorders. Siddharth completed his graduation in Bio-technology in India and moved to the UK to pursue MSc in Bioinformatics from the University of Leicester. Soon after that he joined Mallon lab at MRC Harwell Institute as a Bioinformatics scientist, where he worked on several different projects before starting his PhD. He developed a deep interest in the functional properties of the non-coding part of the genome and focused his PhD research on deciphering regulatory networks and their impact on mouse phenotypes.";
                    person.NCBIPublicationsID = "30395686,29632379,27534441,27373158,26232227,24249052";
                    person.ImagePath = "sethi.png";
                    person.GitHub = "sid-sethi";
                }
                else if (person.Id == "1_FON05125800")
                {
                    person.Name = "Aine Fairbrother-Browne";
                    person.Title = "BSc, MSc";
                    person.Job = "PhD student";
                    person.Email = "aine.fairbrother-browne.18@ucl.ac.uk";
                    person.ResearchInterest = "Neurodegenerative disease, medical genetics, bioinformatics.";
                    person.Biography = "<b>Aine Fairbrother-Browne</b> Aine is a BBSRC funded LIDo PhD student in both the Ryten lab at UCL and the Hodgkinson Medical and Molecular Genetics lab at King’s. She completed at BSc in Biology at Bristol University (2016), and then did an MSc in Bioinformatics and Systems Biology at Birkbeck (2017). In 2018 she started on the BBSRC funded LIDo PhD programme. Whilst working with Mina Ryten and Alan Hodgkinson, she is focused on nuclear regulation of the mitochondrial genome in brain and its role in age-related pathologies.";
                    person.ImagePath = "aine.png";
                    person.GitHub = "ainefairbrother";
                }
                return View(person);
            }
            catch (Exception e)
            {
                ErrorViewModel errorModel = new ErrorViewModel();
                errorModel.Message = e.Message;
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
