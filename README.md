<div align="center">

# 🧬 RytenLab Website

**The official website of the [Ryten Laboratory](https://rytenlab.com/)**
<br>
*Transcriptomics as a functional read-out of the genome, to improve human health.*

[![.NET](https://img.shields.io/badge/.NET-10.0-512BD4?logo=dotnet&logoColor=white)](https://dotnet.microsoft.com)
[![ASP.NET Core MVC](https://img.shields.io/badge/ASP.NET%20Core-MVC-512BD4?logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/apps/aspnet/mvc)
[![Bootstrap](https://img.shields.io/badge/Bootstrap-3-7952B3?logo=bootstrap&logoColor=white)](https://getbootstrap.com/docs/3.4/)
[![Visual Studio](https://img.shields.io/badge/Visual%20Studio-2026-5C2D91?logo=visualstudio&logoColor=white)](https://visualstudio.microsoft.com)
[![Website](https://img.shields.io/badge/website-rytenlab.com-blue)](https://rytenlab.com/)

[About the lab](#-about-the-lab) · [Features](#-features) · [Getting started](#-getting-started) · [Maintaining content](#-maintaining-content) · [API](#-coexp-api) · [Deployment](#-deployment)

</div>

---

## 🔬 About the lab

The major focus of the Ryten Laboratory is the use of transcriptomic data as a functional read-out of the genome and how that read-out can inform our understanding of biological processes to improve human health. We work in neurogenetics, one of the most challenging disease areas and use transcriptomic data, primarily derived from human brain or brain relevant cell types, to build the resources required to improve the molecular understanding of complex and rare neurological diseases with a particular focus on neurodegenerative diseases.

We are highly collaborative and we are interested in making our work accessible and useful within the neuroscience research community, but also within clinical and diagnostic settings. As part of UCL Great Ormond Street Institute of Child Health (London), and in collaboration with UCL Queen Square Institute of Neurology and University of Murcia (Spain), our on-going work covers the genetic regulation of gene expression in human brain, gene co-expression networks, re-annotation of genes associated with neurological diseases and the use of transcriptomics to improve diagnostic yield. We have released many of the outputs of these projects through the development of different web tools.

To find out more about our work and the people behind it just take a look at our [Team](https://rytenlab.com/RytenLab/Team) webpage.

## 📖 About this project

This repository contains the source code of the lab website, built as an **ASP.NET Core MVC** application (Model–View–Controller) on **.NET 10**.

## ✨ Features

| Area | What it provides |
|---|---|
| **About / Research / Tools** | Descriptions of the lab's research and links to its published software and web tools |
| **Publications** | Publication list loaded from `wwwroot/xml/publications.xml`, ordered by year |
| **Team** | Current members, former members and the "furry members", loaded from `App_Data/team.xml`, with one profile page per person |
| **Contact** | Location and contact details |
| **CoExp API** | A small REST API (`/rytenlab_api/Coexp/...`) that forwards requests to the CoExp R service |
| **Cookie consent** | Google Analytics only loads after a visitor accepts cookies |
| **Privacy** | A privacy policy page at `/RytenLab/Privacy` |

## 🧰 Tech stack

| Layer | Technology |
|---|---|
| Framework | [ASP.NET Core MVC](https://dotnet.microsoft.com/apps/aspnet/mvc) on [.NET 10](https://dotnet.microsoft.com) |
| Server | [Kestrel](https://learn.microsoft.com/aspnet/core/fundamentals/servers/kestrel), deployed behind the [Apache HTTP Server](http://httpd.apache.org/) |
| Front end | [Bootstrap 3](https://getbootstrap.com/docs/3.4/), [jQuery 3](https://jquery.com/), [Font Awesome 5.15.1](https://fontawesome.com/) (all served from `wwwroot/lib`) |
| Data | XML files (team and publications), no database |
| API | ASP.NET Core Web API controllers with input validation and rate limiting |

## 📁 Project structure

```
RytenLab_Web
├── Adapters/            HTTP helper used to call the CoExp R service
├── App_Data/            team.xml (team and pets data, not publicly downloadable)
├── Controllers/
│   ├── API/             CoexpController (REST API)
│   └── RytenLabController.cs   Website pages
├── Models/              Person, Pet, Publication, API request models
├── Repositories/API/    CoexpRepository (calls the CoExp R service)
├── Views/
│   ├── RytenLab/        Page views
│   └── Shared/          Layout, error page, cookie consent banner
├── wwwroot/
│   ├── css/, js/, lib/  Styles, scripts and front-end libraries
│   ├── images/          Logos and team photos
│   └── xml/             publications.xml
├── Program.cs
└── Startup.cs
```

## 🚀 Getting started

### Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- Optional: [Visual Studio 2026](https://visualstudio.microsoft.com) with the *ASP.NET and web development* workload

### Run locally

```bash
git clone https://github.com/SoniaRuiz/rytenlab-website.git
cd rytenlab-website
dotnet restore
dotnet run
```

The console shows the address the site is listening on. Or open `RytenLab_Web.sln` in Visual Studio and press **F5**.

> **Note:** the CoExp API pages call the live CoExp R service. Its base URL is set in `Repositories/API/coexpRepository.cs`.

## 📝 Maintaining content

### Team members and pets: `App_Data/team.xml`

Each person is a `<Person>` element, and each pet is a `<Pet>` element. Every field below must be present, even if empty. The `ID` values must be unique across the whole file.

```xml
<Person>
  <ID>40</ID>
  <Name>Jane Doe</Name>
  <Title>PhD</Title>
  <Job>Postdoctoral Researcher</Job>
  <Email>jane.doe@example.ac.uk</Email>
  <ResearchInterest>...</ResearchInterest>
  <Biography>...</Biography>
  <ImagePath>jane.jpg</ImagePath>
  <GitHub>janedoe</GitHub>
  <GoogleScholar></GoogleScholar>
  <ResearchGate>Jane_Doe</ResearchGate>
  <CurrentMember>Y</CurrentMember>   <!-- Y = current member, N = former member -->
</Person>
```

- Photos go in `wwwroot/images/modified/filter/` and `ImagePath` is the file name.
- A member's email address is only shown on the profile of current members (`CurrentMember` = `Y`).
- Pets use the fields `ID`, `Name`, `Nickname`, `HumanName`, `ImagePath` and `Bio`.

### Publications: `wwwroot/xml/publications.xml`

Each `<Publication>` has `Title`, `Authors`, `Abstract`, `JournalInfo`, `Year` and `DOI`. The `DOI` field holds the full link (starting with `https://`). Entries without a valid web link show no *Read* button.

## 🔌 CoExp API

Base path: `/rytenlab_api/Coexp/`

| Method | Endpoint | Purpose |
|---|---|---|
| `GET` | `GetNetworkCategories` | List the available network categories |
| `POST` | `GetAvailableNetworks` | Networks in a category |
| `POST` | `GetAvailableModules` | Modules in a network |
| `POST` | `GetMM` | Module membership of each gene |
| `POST` | `GetGOFromTissue` | Gene Ontology terms for a network |
| `POST` | `GetCellTypeFromTissue` | Cell-type association p-values per module |
| `POST` | `ReportOnGenesMultipleTissue` | Gene report across networks of one category |
| `POST` | `GlobalReportOnGenes` | Gene report across several categories and networks |
| `POST` | `GetModuleTOMGraph` | Top genes of a module (graph) |
| `POST` | `GetModuleTOMGenes` | All genes of a module |

Example:

```bash
curl -X POST https://localhost:<port>/rytenlab_api/Coexp/GetAvailableNetworks \
  -H "Content-Type: application/json" \
  -d '{"Category": "CoExpROSMAP"}'
```

Request bodies use the keys `Category`, `Network`, `Module`, `Categories`, `Networks`, `Genes` and `TopGenes`. All values are validated for length and allowed characters, and the API is rate limited per client IP address (30 requests per minute).

## 🔒 Security notes

- Team data lives in `App_Data`, which is not served as a static file.
- Member and pet pages are looked up on the server by ID, and nothing submitted by the visitor is shown back on the page.
- Error pages show only a request ID, and details go to the application log.
- Google Analytics is loaded only after cookie consent.

## 🌐 Deployment

The site runs on Kestrel behind the Apache HTTP Server. The app reads the `X-Forwarded-For` and `X-Forwarded-Proto` headers from the proxy.

```bash
dotnet publish -c Release -o publish
```

Before deploying, check that `App_Data/team.xml` is in the publish output, or the Team pages will fail. Old files are not removed from the server by a new publish, so delete anything you have removed from the project (for example, a previous `wwwroot/xml/team.xml`).

## 👩‍💻 Author

**Sonia García-Ruiz** - Website UI developer.

Get in touch with Sonia at [s.ruiz@ucl.ac.uk](mailto:s.ruiz@ucl.ac.uk).

## 🙏 Acknowledgments

- All [RytenLab](https://rytenlab.com/RytenLab/Team) members.
- [University of Murcia](https://www.um.es/).
- [University College of London](https://www.ucl.ac.uk/).

## 📄 License

See the [LICENSE](LICENSE) file.
