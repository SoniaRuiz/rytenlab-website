#pragma checksum "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04ce65c4ddcfc94e51eb49569d1d93451f0b57c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RytenLab_MemberInfo), @"mvc.1.0.view", @"/Views/RytenLab/MemberInfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/RytenLab/MemberInfo.cshtml", typeof(AspNetCore.Views_RytenLab_MemberInfo))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04ce65c4ddcfc94e51eb49569d1d93451f0b57c7", @"/Views/RytenLab/MemberInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f78d5f209256c59520799611eb314f91f8cbec80", @"/Views/_ViewImports.cshtml")]
    public class Views_RytenLab_MemberInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Person>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("media-object little-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/mina-bio.PNG"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mina-biography"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
  
    //View to show 'Member Info' page
    ViewData["Title"] = "Member Info";

#line default
#line hidden
            BeginContext(101, 37, true);
            WriteLiteral("\r\n\r\n<header class=\"header\">\r\n    <h1>");
            EndContext();
            BeginContext(139, 10, false);
#line 9 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
   Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(149, 102, true);
            WriteLiteral("</h1>\r\n    <hr />\r\n</header>\r\n<article>\r\n    <div class=\"media-left media-top little-image\">\r\n        ");
            EndContext();
            BeginContext(251, 125, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d6cd777f8c80479ab998217b07bb1928", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 261, "~/images/modified/filter/", 261, 25, true);
#line 14 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
AddHtmlAttributeValue("", 286, Model.ImagePath, 286, 16, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 14 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
AddHtmlAttributeValue("", 311, Model.Name, 311, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 14 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
AddHtmlAttributeValue("", 329, Model.Name, 329, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(376, 131, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"media-body\">\r\n        <address style=\"padding-top:5px;\">\r\n            <strong style=\"font-size:17px\">");
            EndContext();
            BeginContext(508, 10, false);
#line 18 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                                      Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(518, 50, true);
            WriteLiteral("</strong><br />\r\n            <p>\r\n                ");
            EndContext();
            BeginContext(569, 11, false);
#line 20 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
           Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(580, 24, true);
            WriteLiteral("<br />\r\n                ");
            EndContext();
            BeginContext(605, 20, false);
#line 21 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
           Write(Html.Raw(@Model.Job));

#line default
#line hidden
            EndContext();
            BeginContext(625, 84, true);
            WriteLiteral("\r\n            </p>\r\n            <small>\r\n                <strong>E-mail: </strong><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 709, "\"", 735, 2);
            WriteAttributeValue("", 716, "mailto:", 716, 7, true);
#line 24 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
WriteAttributeValue("", 723, Model.Email, 723, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(736, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(738, 11, false);
#line 24 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                                                                  Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(749, 12, true);
            WriteLiteral("</a><br />\r\n");
            EndContext();
#line 25 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                 if (!String.IsNullOrEmpty(Model.GitHub))
                {

#line default
#line hidden
            BeginContext(839, 47, true);
            WriteLiteral("                    <strong>GitHub: </strong><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 886, "\"", 925, 2);
            WriteAttributeValue("", 893, "https://github.com/", 893, 19, true);
#line 27 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
WriteAttributeValue("", 912, Model.GitHub, 912, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(926, 17, true);
            WriteLiteral(" target=\"_blank\">");
            EndContext();
            BeginContext(944, 12, false);
#line 27 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                                                                                                   Write(Model.GitHub);

#line default
#line hidden
            EndContext();
            BeginContext(956, 12, true);
            WriteLiteral("</a><br />\r\n");
            EndContext();
#line 28 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                }

#line default
#line hidden
            BeginContext(987, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 29 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                 if (!String.IsNullOrEmpty(Model.ResearchGate))
                {

#line default
#line hidden
            BeginContext(1071, 53, true);
            WriteLiteral("                    <strong>ResearchGate: </strong><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1124, "\"", 1187, 2);
            WriteAttributeValue("", 1131, "https://www.researchgate.net/profile/", 1131, 37, true);
#line 31 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
WriteAttributeValue("", 1168, Model.ResearchGate, 1168, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1188, 17, true);
            WriteLiteral(" target=\"_blank\">");
            EndContext();
            BeginContext(1206, 18, false);
#line 31 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                                                                                                                                 Write(Model.ResearchGate);

#line default
#line hidden
            EndContext();
            BeginContext(1224, 12, true);
            WriteLiteral("</a><br />\r\n");
            EndContext();
#line 32 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                }

#line default
#line hidden
            BeginContext(1255, 110, true);
            WriteLiteral("            </small>\r\n        </address>\r\n    </div>\r\n    <br />\r\n\r\n\r\n    <h3>Research Interests</h3>\r\n    <p>");
            EndContext();
            BeginContext(1366, 22, false);
#line 40 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
  Write(Model.ResearchInterest);

#line default
#line hidden
            EndContext();
            BeginContext(1388, 41, true);
            WriteLiteral("</p>\r\n\r\n\r\n    <h3>Biography</h3>\r\n    <p>");
            EndContext();
            BeginContext(1430, 26, false);
#line 44 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
  Write(Html.Raw(@Model.Biography));

#line default
#line hidden
            EndContext();
            BeginContext(1456, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 45 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
     if (@Model.Name.Contains("Mina"))
    {

#line default
#line hidden
            BeginContext(1509, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(1517, 94, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9f096055d83c4498b536d8f97437113f", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 47 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
AddHtmlAttributeValue("", 1557, Model.Name, 1557, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 47 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
AddHtmlAttributeValue("", 1575, Model.Name, 1575, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1611, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 48 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
    }

#line default
#line hidden
            BeginContext(1620, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 49 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
     if (!String.IsNullOrEmpty(Model.ResearchGate))
    {

#line default
#line hidden
            BeginContext(1680, 78, true);
            WriteLiteral("        <h3>Publications</h3>\r\n        <p>Latest publications available via <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1758, "\"", 1821, 2);
            WriteAttributeValue("", 1765, "https://www.researchgate.net/profile/", 1765, 37, true);
#line 52 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
WriteAttributeValue("", 1802, Model.ResearchGate, 1802, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1822, 48, true);
            WriteLiteral(" target=\"_blank\">ResearchGate</a> profile.</p>\r\n");
            EndContext();
#line 53 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
    }

#line default
#line hidden
            BeginContext(1877, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 54 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
     if (Model.PreAcceptedPublicationsList.Count > 0 || Model.NCBIPublicationsList.Count > 0)
    {

#line default
#line hidden
            BeginContext(1979, 31, true);
            WriteLiteral("        <h3>Publications</h3>\r\n");
            EndContext();
#line 57 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
    }

#line default
#line hidden
            BeginContext(2017, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 58 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
     if (Model.PreAcceptedPublicationsList.Count > 0)
    {

#line default
#line hidden
            BeginContext(2079, 46, true);
            WriteLiteral("        <h4 class=\"year-main\">Pre-print</h4>\r\n");
            EndContext();
#line 61 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
         foreach (var publication in Model.PreAcceptedPublicationsList)
        {

#line default
#line hidden
            BeginContext(2209, 52, true);
            WriteLiteral("            <div class=\"well\">\r\n                <h4>");
            EndContext();
            BeginContext(2262, 17, false);
#line 64 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
               Write(publication.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2279, 34, true);
            WriteLiteral("</h4>\r\n                <small>\r\n\r\n");
            EndContext();
#line 67 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                     for (var i = 0; i < publication.Authors.Count; i++)
                    {
                        if (i < publication.Authors.Count - 1)
                        {
                            if (i == 22)
                            {

#line default
#line hidden
            BeginContext(2574, 38, true);
            WriteLiteral("                                <span>");
            EndContext();
            BeginContext(2613, 22, false);
#line 73 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                                 Write(publication.Authors[i]);

#line default
#line hidden
            EndContext();
            BeginContext(2635, 12, true);
            WriteLiteral("...</span>\r\n");
            EndContext();
#line 74 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                                break;
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(2783, 38, true);
            WriteLiteral("                                <span>");
            EndContext();
            BeginContext(2822, 22, false);
#line 78 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                                 Write(publication.Authors[i]);

#line default
#line hidden
            EndContext();
            BeginContext(2844, 11, true);
            WriteLiteral(", </span>\r\n");
            EndContext();
#line 79 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                            }
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(2970, 34, true);
            WriteLiteral("                            <span>");
            EndContext();
            BeginContext(3005, 22, false);
#line 83 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                             Write(publication.Authors[i]);

#line default
#line hidden
            EndContext();
            BeginContext(3027, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 84 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                        }
                    }

#line default
#line hidden
            BeginContext(3086, 90, true);
            WriteLiteral("                </small><br /><br />\r\n                <p class=\"publication\">Published in ");
            EndContext();
            BeginContext(3177, 23, false);
#line 87 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                                               Write(publication.JournalName);

#line default
#line hidden
            EndContext();
            BeginContext(3200, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(3204, 16, false);
#line 87 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                                                                          Write(publication.Date);

#line default
#line hidden
            EndContext();
            BeginContext(3220, 48, true);
            WriteLiteral("</p>\r\n                <a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3268, "\"", 3292, 1);
#line 88 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
WriteAttributeValue("", 3275, publication.Link, 3275, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3293, 63, true);
            WriteLiteral(" role=\"button\" target=\"_blank\">View »</a>\r\n            </div>\r\n");
            EndContext();
#line 90 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
        }

#line default
#line hidden
#line 90 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
         
    }

#line default
#line hidden
            BeginContext(3374, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 92 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
     if (Model.NCBIPublicationsList.Count > 0)
    {

#line default
#line hidden
            BeginContext(3429, 40, true);
            WriteLiteral("        <h4 class=\"year\">Accepted</h4>\r\n");
            EndContext();
#line 95 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
         foreach (var publication in Model.NCBIPublicationsList)
        {

#line default
#line hidden
            BeginContext(3546, 52, true);
            WriteLiteral("            <div class=\"well\">\r\n                <h4>");
            EndContext();
            BeginContext(3599, 17, false);
#line 98 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
               Write(publication.Title);

#line default
#line hidden
            EndContext();
            BeginContext(3616, 34, true);
            WriteLiteral("</h4>\r\n                <small>\r\n\r\n");
            EndContext();
#line 101 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                     for (var i = 0; i < publication.Authors.Count; i++)
                    {
                        if (i < publication.Authors.Count - 1)
                        {
                            if (i == 22)
                            {

#line default
#line hidden
            BeginContext(3911, 38, true);
            WriteLiteral("                                <span>");
            EndContext();
            BeginContext(3950, 22, false);
#line 107 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                                 Write(publication.Authors[i]);

#line default
#line hidden
            EndContext();
            BeginContext(3972, 12, true);
            WriteLiteral("...</span>\r\n");
            EndContext();
#line 108 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                                break;
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(4120, 38, true);
            WriteLiteral("                                <span>");
            EndContext();
            BeginContext(4159, 22, false);
#line 112 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                                 Write(publication.Authors[i]);

#line default
#line hidden
            EndContext();
            BeginContext(4181, 11, true);
            WriteLiteral(", </span>\r\n");
            EndContext();
#line 113 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                            }
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(4307, 34, true);
            WriteLiteral("                            <span>");
            EndContext();
            BeginContext(4342, 22, false);
#line 117 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                             Write(publication.Authors[i]);

#line default
#line hidden
            EndContext();
            BeginContext(4364, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 118 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                        }
                    }

#line default
#line hidden
            BeginContext(4423, 108, true);
            WriteLiteral("                </small><br />\r\n                <br />\r\n                <p class=\"publication\">Published in ");
            EndContext();
            BeginContext(4532, 23, false);
#line 122 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                                               Write(publication.JournalName);

#line default
#line hidden
            EndContext();
            BeginContext(4555, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(4559, 16, false);
#line 122 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                                                                          Write(publication.Date);

#line default
#line hidden
            EndContext();
            BeginContext(4575, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 123 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                 if (@publication.Title.Contains("Genetic variability in the regulation of gene expression in ten regions of the human brain"))
                {

#line default
#line hidden
            BeginContext(4745, 115, true);
            WriteLiteral("                    <p class=\"publication\">Supporting <a href=\"http://braineac.org/\" target=\"_blank\">data</a></p>\r\n");
            EndContext();
#line 126 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                }

#line default
#line hidden
            BeginContext(4879, 42, true);
            WriteLiteral("                <a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4921, "\"", 4945, 1);
#line 127 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
WriteAttributeValue("", 4928, publication.Link, 4928, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4946, 63, true);
            WriteLiteral(" role=\"button\" target=\"_blank\">View »</a>\r\n            </div>\r\n");
            EndContext();
#line 129 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
        }

#line default
#line hidden
#line 129 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
         
    }

#line default
#line hidden
            BeginContext(5027, 12, true);
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
