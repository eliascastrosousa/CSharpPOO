#pragma checksum "C:\Users\elias\Documents\Github\CSharpPOO\SalesWebMvc\SalesWebMvc\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6cb87334fb692638653623d2c847a34dc7dbf27e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
#line 1 "C:\Users\elias\Documents\Github\CSharpPOO\SalesWebMvc\SalesWebMvc\Views\_ViewImports.cshtml"
using SalesWebMvc;

#line default
#line hidden
#line 2 "C:\Users\elias\Documents\Github\CSharpPOO\SalesWebMvc\SalesWebMvc\Views\_ViewImports.cshtml"
using SalesWebMvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cb87334fb692638653623d2c847a34dc7dbf27e", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70dafd425af89a5439216963c7093f2ead686e4a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\elias\Documents\Github\CSharpPOO\SalesWebMvc\SalesWebMvc\Views\Home\About.cshtml"
  
    ViewData["Title"] = "Sobre";
    ViewData["Message"] = "Sales Web MVC from C# Course";
    ViewData["Aluno"] = "Elias Castro Sousa Junior";
    ViewData["linkedin"]= "https://www.linkedin.com/in/eliascastrosousa/";

#line default
#line hidden
            BeginContext(230, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(235, 17, false);
#line 7 "C:\Users\elias\Documents\Github\CSharpPOO\SalesWebMvc\SalesWebMvc\Views\Home\About.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(252, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(264, 19, false);
#line 8 "C:\Users\elias\Documents\Github\CSharpPOO\SalesWebMvc\SalesWebMvc\Views\Home\About.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(283, 10, true);
            WriteLiteral("</h3>\r\n<p>");
            EndContext();
            BeginContext(294, 17, false);
#line 9 "C:\Users\elias\Documents\Github\CSharpPOO\SalesWebMvc\SalesWebMvc\Views\Home\About.cshtml"
Write(ViewData["Aluno"]);

#line default
#line hidden
            EndContext();
            BeginContext(311, 108, true);
            WriteLiteral("</p>\r\n\r\n\r\n<strong>More information: </strong>\r\n<a href=\"https://www.linkedin.com/in/eliascastrosousa/\"> <p> ");
            EndContext();
            BeginContext(420, 20, false);
#line 13 "C:\Users\elias\Documents\Github\CSharpPOO\SalesWebMvc\SalesWebMvc\Views\Home\About.cshtml"
                                                        Write(ViewData["linkedin"]);

#line default
#line hidden
            EndContext();
            BeginContext(440, 11, true);
            WriteLiteral(" </p></a>\r\n");
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
