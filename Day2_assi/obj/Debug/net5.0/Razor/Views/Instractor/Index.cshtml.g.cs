#pragma checksum "E:\ITI\MVC\Day8\Day2_assi\Day2_assi\Views\Instractor\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9fa4d803553aafee007ec4712bd338f81958c5ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Instractor_Index), @"mvc.1.0.view", @"/Views/Instractor/Index.cshtml")]
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
#nullable restore
#line 1 "E:\ITI\MVC\Day8\Day2_assi\Day2_assi\Views\_ViewImports.cshtml"
using Day2_assi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\ITI\MVC\Day8\Day2_assi\Day2_assi\Views\_ViewImports.cshtml"
using Day2_assi.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\ITI\MVC\Day8\Day2_assi\Day2_assi\Views\_ViewImports.cshtml"
using Day2_assi.View_Model;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fa4d803553aafee007ec4712bd338f81958c5ac", @"/Views/Instractor/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79def73523820b4d5ce0b19739828ff4ea350a5b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Instractor_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Instractor>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Index</h1>\r\n");
#nullable restore
#line 3 "E:\ITI\MVC\Day8\Day2_assi\Day2_assi\Views\Instractor\Index.cshtml"
        
         Layout = "_MyLayout";
     

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table table-hover table-bordered\">\r\n");
#nullable restore
#line 7 "E:\ITI\MVC\Day8\Day2_assi\Day2_assi\Views\Instractor\Index.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>");
#nullable restore
#line 10 "E:\ITI\MVC\Day8\Day2_assi\Day2_assi\Views\Instractor\Index.cshtml"
       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td><img");
            BeginWriteAttribute("src", " src=\"", 229, "\"", 253, 2);
            WriteAttributeValue("", 235, "/Image/", 235, 7, true);
#nullable restore
#line 11 "E:\ITI\MVC\Day8\Day2_assi\Day2_assi\Views\Instractor\Index.cshtml"
WriteAttributeValue("", 242, item.Image, 242, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style =\"width:100px; height:100px\" /></td>\r\n        <td><a");
            BeginWriteAttribute("href", " href=\"", 313, "\"", 348, 2);
            WriteAttributeValue("", 320, "/Instractor/Details/", 320, 20, true);
#nullable restore
#line 12 "E:\ITI\MVC\Day8\Day2_assi\Day2_assi\Views\Instractor\Index.cshtml"
WriteAttributeValue("", 340, item.Id, 340, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Get Details</a></td>\r\n    </tr>\r\n");
#nullable restore
#line 14 "E:\ITI\MVC\Day8\Day2_assi\Day2_assi\Views\Instractor\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Instractor>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
