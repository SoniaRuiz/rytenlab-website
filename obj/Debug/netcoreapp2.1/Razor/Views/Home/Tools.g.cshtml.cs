#pragma checksum "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Tools.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "283ef508521f20e9a45be33b60cfcffe31ab733d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Tools), @"mvc.1.0.view", @"/Views/Home/Tools.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Tools.cshtml", typeof(AspNetCore.Views_Home_Tools))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"283ef508521f20e9a45be33b60cfcffe31ab733d", @"/Views/Home/Tools.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f78d5f209256c59520799611eb314f91f8cbec80", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Tools : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Tools.cshtml"
  
    ViewData["Title"] = "Software Tools";

#line default
#line hidden
            BeginContext(52, 35, true);
            WriteLiteral("\r\n<header class=\"header\">\r\n    <h1>");
            EndContext();
            BeginContext(88, 17, false);
#line 7 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Tools.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(105, 520, true);
            WriteLiteral(@"</h1>
    <hr />
</header>
<article>
    <h4>We have many tools and we host all them at <a href=""#"">RytenLab GitHub</a>.</h4>
    <br />
    <div class=""well"">
        <h4>Genome Browser</h4>
        <small>
            Brief description about this tool.
        </small><br /><br />
        <p class=""publication"">Published on <a href=""#"">GitHub</a> - 2018 Nov</p>
        <a class=""btn btn-primary"" href=""https://snca.atica.um.es/browser/"" role=""button"" target=""_blank"">View »</a>
    </div>
</article>
");
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
