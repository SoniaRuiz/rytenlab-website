#pragma checksum "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\Tools.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b9bfc1ba4695f045cf5cd8e0cf2d76056193e03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RytenLab_Tools), @"mvc.1.0.view", @"/Views/RytenLab/Tools.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/RytenLab/Tools.cshtml", typeof(AspNetCore.Views_RytenLab_Tools))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b9bfc1ba4695f045cf5cd8e0cf2d76056193e03", @"/Views/RytenLab/Tools.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f78d5f209256c59520799611eb314f91f8cbec80", @"/Views/_ViewImports.cshtml")]
    public class Views_RytenLab_Tools : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\Tools.cshtml"
  
    //View for 'Tools' page
    ViewData["Title"] = "Software Tools";

#line default
#line hidden
            BeginContext(79, 35, true);
            WriteLiteral("\r\n<header class=\"header\">\r\n    <h1>");
            EndContext();
            BeginContext(115, 17, false);
#line 7 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\Tools.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(132, 725, true);
            WriteLiteral(@"</h1>
    <hr />
</header>
<article>
    <h4>We have many tools and all of them are available on the following links:</h4>
    <br />
    <div class=""well"">
        <h3>vizER</h3>
        <small>
            vizER is a platform that enables the visualisation of individual genes for evidence of reannotation (full publication: <a href=""https://www.biorxiv.org/content/10.1101/499103v1"" title=""full publication"" target=""_blank"">here</a>). Complete, annotation-agnostic transcriptome definitions for 41 GTEx tissues can be also downloaded via the vizER webpage. The primary aim of vizER is to facilitate more accurate interpretation of variants and therefore, improve genetic diagnosis.
        </small><br /><br />
");
            EndContext();
            BeginContext(944, 724, true);
            WriteLiteral(@"        <a class=""btn btn-primary"" href=""http://www.rytenlab.com/browser/app/vizER"" role=""button"" target=""_blank"">View »</a>
    </div>
    <br />
    <div class=""well"">
        <h3>CoExp</h3>
        <small>
            CoExp is a framework for the generation, deployment, sharing and exploitation of co-expression networks as annotation models of genes and their role in transcription. It is a family of R packages that you can separately download from GitHub, but also a Web page in which all models available can be accessed and used for your own research.
            <br /><br />
            Published on <a href=""https://github.com/juanbot/CoExpNets"" target=""_blank"">GitHub</a>
        </small><br /><br />
");
            EndContext();
            BeginContext(1824, 159, true);
            WriteLiteral("        <a class=\"btn btn-primary button\" href=\"https://snca.atica.um.es/coexp/Run/Catalog/\" role=\"button\" target=\"_blank\">View »</a>\r\n    </div>\r\n</article>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
