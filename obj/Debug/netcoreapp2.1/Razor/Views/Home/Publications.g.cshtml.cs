#pragma checksum "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26955fb9442166c964b0e4e553746635ea013838"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Publications), @"mvc.1.0.view", @"/Views/Home/Publications.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Publications.cshtml", typeof(AspNetCore.Views_Home_Publications))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\_ViewImports.cshtml"
using RytenLab_Web;

#line default
#line hidden
#line 2 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\_ViewImports.cshtml"
using RytenLab_Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26955fb9442166c964b0e4e553746635ea013838", @"/Views/Home/Publications.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f78d5f209256c59520799611eb314f91f8cbec80", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Publications : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Person>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
  
    ViewData["Title"] = "Publications";

#line default
#line hidden
            BeginContext(63, 33, true);
            WriteLiteral("<header class=\"header\">\r\n    <h1>");
            EndContext();
            BeginContext(97, 17, false);
#line 6 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(114, 101, true);
            WriteLiteral("</h1>\r\n    <hr />\r\n</header>\r\n<article>\r\n    <h2>Accepted</h2>\r\n    <h3 class=\"year-main\">2018</h3>\r\n");
            EndContext();
#line 12 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
     foreach (var publication in Model.NCBIPublicationsList)
    {
        

#line default
#line hidden
#line 14 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
         if (@publication.Date.Contains("2018"))
        {

#line default
#line hidden
            BeginContext(345, 52, true);
            WriteLiteral("            <div class=\"well\">\r\n                <h4>");
            EndContext();
            BeginContext(398, 17, false);
#line 17 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
               Write(publication.Title);

#line default
#line hidden
            EndContext();
            BeginContext(415, 34, true);
            WriteLiteral("</h4>\r\n                <small>\r\n\r\n");
            EndContext();
#line 20 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
                     for (var i = 0; i < publication.Authors.Count; i++)
                    {
                        if (i < publication.Authors.Count - 1)
                        {

#line default
#line hidden
            BeginContext(637, 34, true);
            WriteLiteral("                            <span>");
            EndContext();
            BeginContext(672, 22, false);
#line 24 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
                             Write(publication.Authors[i]);

#line default
#line hidden
            EndContext();
            BeginContext(694, 11, true);
            WriteLiteral(", </span>\r\n");
            EndContext();
#line 25 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(789, 34, true);
            WriteLiteral("                            <span>");
            EndContext();
            BeginContext(824, 22, false);
#line 28 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
                             Write(publication.Authors[i]);

#line default
#line hidden
            EndContext();
            BeginContext(846, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 29 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
                        }
                    }

#line default
#line hidden
            BeginContext(905, 90, true);
            WriteLiteral("                </small><br /><br />\r\n                <p class=\"publication\">Published in ");
            EndContext();
            BeginContext(996, 23, false);
#line 32 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
                                               Write(publication.JournalName);

#line default
#line hidden
            EndContext();
            BeginContext(1019, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(1023, 16, false);
#line 32 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
                                                                          Write(publication.Date);

#line default
#line hidden
            EndContext();
            BeginContext(1039, 48, true);
            WriteLiteral("</p>\r\n                <a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1087, "\"", 1111, 1);
#line 33 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
WriteAttributeValue("", 1094, publication.Link, 1094, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1112, 63, true);
            WriteLiteral(" role=\"button\" target=\"_blank\">View »</a>\r\n            </div>\r\n");
            EndContext();
#line 35 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
        }

#line default
#line hidden
#line 35 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
         
    }

#line default
#line hidden
            BeginContext(1193, 37, true);
            WriteLiteral("    <h3 class=\"year-main\">2017</h3>\r\n");
            EndContext();
#line 38 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
     foreach (var publication in Model.NCBIPublicationsList)
    {
        

#line default
#line hidden
#line 40 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
         if (@publication.Date.Contains("2017"))
        {

#line default
#line hidden
            BeginContext(1360, 52, true);
            WriteLiteral("            <div class=\"well\">\r\n                <h4>");
            EndContext();
            BeginContext(1413, 17, false);
#line 43 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
               Write(publication.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1430, 34, true);
            WriteLiteral("</h4>\r\n                <small>\r\n\r\n");
            EndContext();
#line 46 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
                     for (var i = 0; i < publication.Authors.Count; i++)
                    {
                        if (i < publication.Authors.Count - 1)
                        {

#line default
#line hidden
            BeginContext(1652, 34, true);
            WriteLiteral("                            <span>");
            EndContext();
            BeginContext(1687, 22, false);
#line 50 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
                             Write(publication.Authors[i]);

#line default
#line hidden
            EndContext();
            BeginContext(1709, 11, true);
            WriteLiteral(", </span>\r\n");
            EndContext();
#line 51 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(1804, 34, true);
            WriteLiteral("                            <span>");
            EndContext();
            BeginContext(1839, 22, false);
#line 54 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
                             Write(publication.Authors[i]);

#line default
#line hidden
            EndContext();
            BeginContext(1861, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 55 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
                        }
                    }

#line default
#line hidden
            BeginContext(1920, 90, true);
            WriteLiteral("                </small><br /><br />\r\n                <p class=\"publication\">Published in ");
            EndContext();
            BeginContext(2011, 23, false);
#line 58 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
                                               Write(publication.JournalName);

#line default
#line hidden
            EndContext();
            BeginContext(2034, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(2038, 16, false);
#line 58 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
                                                                          Write(publication.Date);

#line default
#line hidden
            EndContext();
            BeginContext(2054, 48, true);
            WriteLiteral("</p>\r\n                <a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2102, "\"", 2126, 1);
#line 59 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
WriteAttributeValue("", 2109, publication.Link, 2109, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2127, 63, true);
            WriteLiteral(" role=\"button\" target=\"_blank\">View »</a>\r\n            </div>\r\n");
            EndContext();
#line 61 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
        }

#line default
#line hidden
#line 61 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
         
    }

#line default
#line hidden
            BeginContext(2208, 37, true);
            WriteLiteral("    <h3 class=\"year-main\">2016</h3>\r\n");
            EndContext();
#line 64 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
     foreach (var publication in Model.NCBIPublicationsList)
    {
        

#line default
#line hidden
#line 66 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
         if (@publication.Date.Contains("2016"))
        {

#line default
#line hidden
            BeginContext(2375, 52, true);
            WriteLiteral("            <div class=\"well\">\r\n                <h4>");
            EndContext();
            BeginContext(2428, 17, false);
#line 69 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
               Write(publication.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2445, 34, true);
            WriteLiteral("</h4>\r\n                <small>\r\n\r\n");
            EndContext();
#line 72 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
                     for (var i = 0; i < publication.Authors.Count; i++)
                    {
                        if (i < publication.Authors.Count - 1)
                        {

#line default
#line hidden
            BeginContext(2667, 34, true);
            WriteLiteral("                            <span>");
            EndContext();
            BeginContext(2702, 22, false);
#line 76 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
                             Write(publication.Authors[i]);

#line default
#line hidden
            EndContext();
            BeginContext(2724, 11, true);
            WriteLiteral(", </span>\r\n");
            EndContext();
#line 77 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(2819, 34, true);
            WriteLiteral("                            <span>");
            EndContext();
            BeginContext(2854, 22, false);
#line 80 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
                             Write(publication.Authors[i]);

#line default
#line hidden
            EndContext();
            BeginContext(2876, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 81 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
                        }
                    }

#line default
#line hidden
            BeginContext(2935, 90, true);
            WriteLiteral("                </small><br /><br />\r\n                <p class=\"publication\">Published in ");
            EndContext();
            BeginContext(3026, 23, false);
#line 84 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
                                               Write(publication.JournalName);

#line default
#line hidden
            EndContext();
            BeginContext(3049, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(3053, 16, false);
#line 84 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
                                                                          Write(publication.Date);

#line default
#line hidden
            EndContext();
            BeginContext(3069, 48, true);
            WriteLiteral("</p>\r\n                <a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3117, "\"", 3141, 1);
#line 85 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
WriteAttributeValue("", 3124, publication.Link, 3124, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3142, 63, true);
            WriteLiteral(" role=\"button\" target=\"_blank\">View »</a>\r\n            </div>\r\n");
            EndContext();
#line 87 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
        }

#line default
#line hidden
#line 87 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
         
    }

#line default
#line hidden
            BeginContext(3223, 32, true);
            WriteLiteral("    <h3 class=\"year\">2014</h3>\r\n");
            EndContext();
#line 90 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
     foreach (var publication in Model.NCBIPublicationsList)
    {
        

#line default
#line hidden
#line 92 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
         if (@publication.Date.Contains("2014"))
        {

#line default
#line hidden
            BeginContext(3385, 52, true);
            WriteLiteral("            <div class=\"well\">\r\n                <h4>");
            EndContext();
            BeginContext(3438, 17, false);
#line 95 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
               Write(publication.Title);

#line default
#line hidden
            EndContext();
            BeginContext(3455, 34, true);
            WriteLiteral("</h4>\r\n                <small>\r\n\r\n");
            EndContext();
#line 98 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
                     for (var i = 0; i < publication.Authors.Count; i++)
                    {
                        if (i < publication.Authors.Count - 1)
                        {

#line default
#line hidden
            BeginContext(3677, 34, true);
            WriteLiteral("                            <span>");
            EndContext();
            BeginContext(3712, 22, false);
#line 102 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
                             Write(publication.Authors[i]);

#line default
#line hidden
            EndContext();
            BeginContext(3734, 11, true);
            WriteLiteral(", </span>\r\n");
            EndContext();
#line 103 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(3829, 34, true);
            WriteLiteral("                            <span>");
            EndContext();
            BeginContext(3864, 22, false);
#line 106 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
                             Write(publication.Authors[i]);

#line default
#line hidden
            EndContext();
            BeginContext(3886, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 107 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
                        }
                    }

#line default
#line hidden
            BeginContext(3945, 90, true);
            WriteLiteral("                </small><br /><br />\r\n                <p class=\"publication\">Published in ");
            EndContext();
            BeginContext(4036, 23, false);
#line 110 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
                                               Write(publication.JournalName);

#line default
#line hidden
            EndContext();
            BeginContext(4059, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(4063, 16, false);
#line 110 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
                                                                          Write(publication.Date);

#line default
#line hidden
            EndContext();
            BeginContext(4079, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 111 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
                 if (@publication.Title.Contains("Genetic variability in the regulation of gene expression in ten regions of the human brain"))
                {

#line default
#line hidden
            BeginContext(4249, 95, true);
            WriteLiteral("                    <p>Supporting <a href=\"http://braineac.org/\" target=\"_blank\">data</a></p>\r\n");
            EndContext();
#line 114 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
                }

#line default
#line hidden
            BeginContext(4363, 42, true);
            WriteLiteral("                <a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4405, "\"", 4429, 1);
#line 115 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
WriteAttributeValue("", 4412, publication.Link, 4412, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4430, 63, true);
            WriteLiteral(" role=\"button\" target=\"_blank\">View »</a>\r\n            </div>\r\n");
            EndContext();
#line 117 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
        }

#line default
#line hidden
#line 117 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
         
    }

#line default
#line hidden
            BeginContext(4511, 37, true);
            WriteLiteral("    <h3 class=\"year-main\">2013</h3>\r\n");
            EndContext();
#line 120 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
     foreach (var publication in Model.NCBIPublicationsList)
    {
        

#line default
#line hidden
#line 122 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
         if (@publication.Date.Contains("2013"))
        {

#line default
#line hidden
            BeginContext(4678, 52, true);
            WriteLiteral("            <div class=\"well\">\r\n                <h4>");
            EndContext();
            BeginContext(4731, 17, false);
#line 125 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
               Write(publication.Title);

#line default
#line hidden
            EndContext();
            BeginContext(4748, 34, true);
            WriteLiteral("</h4>\r\n                <small>\r\n\r\n");
            EndContext();
#line 128 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
                     for (var i = 0; i < publication.Authors.Count; i++)
                    {
                        if (i < publication.Authors.Count - 1)
                        {

#line default
#line hidden
            BeginContext(4970, 34, true);
            WriteLiteral("                            <span>");
            EndContext();
            BeginContext(5005, 22, false);
#line 132 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
                             Write(publication.Authors[i]);

#line default
#line hidden
            EndContext();
            BeginContext(5027, 11, true);
            WriteLiteral(", </span>\r\n");
            EndContext();
#line 133 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(5122, 34, true);
            WriteLiteral("                            <span>");
            EndContext();
            BeginContext(5157, 22, false);
#line 136 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
                             Write(publication.Authors[i]);

#line default
#line hidden
            EndContext();
            BeginContext(5179, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 137 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
                        }
                    }

#line default
#line hidden
            BeginContext(5238, 90, true);
            WriteLiteral("                </small><br /><br />\r\n                <p class=\"publication\">Published in ");
            EndContext();
            BeginContext(5329, 23, false);
#line 140 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
                                               Write(publication.JournalName);

#line default
#line hidden
            EndContext();
            BeginContext(5352, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(5356, 16, false);
#line 140 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
                                                                          Write(publication.Date);

#line default
#line hidden
            EndContext();
            BeginContext(5372, 48, true);
            WriteLiteral("</p>\r\n                <a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5420, "\"", 5444, 1);
#line 141 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
WriteAttributeValue("", 5427, publication.Link, 5427, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5445, 63, true);
            WriteLiteral(" role=\"button\" target=\"_blank\">View »</a>\r\n            </div>\r\n");
            EndContext();
#line 143 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
        }

#line default
#line hidden
#line 143 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
         
    }

#line default
#line hidden
            BeginContext(5526, 37, true);
            WriteLiteral("    <h3 class=\"year-main\">2012</h3>\r\n");
            EndContext();
#line 146 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
     foreach (var publication in Model.NCBIPublicationsList)
    {
        

#line default
#line hidden
#line 148 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
         if (@publication.Date.Contains("2012"))
        {

#line default
#line hidden
            BeginContext(5693, 52, true);
            WriteLiteral("            <div class=\"well\">\r\n                <h4>");
            EndContext();
            BeginContext(5746, 17, false);
#line 151 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
               Write(publication.Title);

#line default
#line hidden
            EndContext();
            BeginContext(5763, 34, true);
            WriteLiteral("</h4>\r\n                <small>\r\n\r\n");
            EndContext();
#line 154 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
                     for (var i = 0; i < publication.Authors.Count; i++)
                    {
                        if (i < publication.Authors.Count - 1)
                        {

#line default
#line hidden
            BeginContext(5985, 34, true);
            WriteLiteral("                            <span>");
            EndContext();
            BeginContext(6020, 22, false);
#line 158 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
                             Write(publication.Authors[i]);

#line default
#line hidden
            EndContext();
            BeginContext(6042, 11, true);
            WriteLiteral(", </span>\r\n");
            EndContext();
#line 159 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(6137, 34, true);
            WriteLiteral("                            <span>");
            EndContext();
            BeginContext(6172, 22, false);
#line 162 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
                             Write(publication.Authors[i]);

#line default
#line hidden
            EndContext();
            BeginContext(6194, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 163 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
                        }
                    }

#line default
#line hidden
            BeginContext(6253, 90, true);
            WriteLiteral("                </small><br /><br />\r\n                <p class=\"publication\">Published in ");
            EndContext();
            BeginContext(6344, 23, false);
#line 166 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
                                               Write(publication.JournalName);

#line default
#line hidden
            EndContext();
            BeginContext(6367, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(6371, 16, false);
#line 166 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
                                                                          Write(publication.Date);

#line default
#line hidden
            EndContext();
            BeginContext(6387, 48, true);
            WriteLiteral("</p>\r\n                <a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 6435, "\"", 6459, 1);
#line 167 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
WriteAttributeValue("", 6442, publication.Link, 6442, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6460, 63, true);
            WriteLiteral(" role=\"button\" target=\"_blank\">View »</a>\r\n            </div>\r\n");
            EndContext();
#line 169 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
        }

#line default
#line hidden
#line 169 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
         
    }

#line default
#line hidden
            BeginContext(6541, 12, true);
            WriteLiteral("</article>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Person> Html { get; private set; }
    }
}
#pragma warning restore 1591
