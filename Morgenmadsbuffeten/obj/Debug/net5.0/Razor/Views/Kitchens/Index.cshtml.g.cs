#pragma checksum "C:\IKT\GUI\Morgenmadsbuffeten\Morgenmadbuffet\Morgenmadsbuffeten\Views\Kitchens\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "117eae83cfa305d25d5cad9bb79504fde46854a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Kitchens_Index), @"mvc.1.0.view", @"/Views/Kitchens/Index.cshtml")]
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
#line 1 "C:\IKT\GUI\Morgenmadsbuffeten\Morgenmadbuffet\Morgenmadsbuffeten\Views\_ViewImports.cshtml"
using Morgenmadsbuffeten;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\IKT\GUI\Morgenmadsbuffeten\Morgenmadbuffet\Morgenmadsbuffeten\Views\_ViewImports.cshtml"
using Morgenmadsbuffeten.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"117eae83cfa305d25d5cad9bb79504fde46854a8", @"/Views/Kitchens/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d9e52588916624b22220100ad0a205eb3322ab7", @"/Views/_ViewImports.cshtml")]
    public class Views_Kitchens_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\IKT\GUI\Morgenmadsbuffeten\Morgenmadbuffet\Morgenmadsbuffeten\Views\Kitchens\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"center\">\r\n   \r\n");
#nullable restore
#line 7 "C:\IKT\GUI\Morgenmadsbuffeten\Morgenmadbuffet\Morgenmadsbuffeten\Views\Kitchens\Index.cshtml"
     using (Html.BeginForm("Info", "Kitchens", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <label class=\"labelclass\" for=\"datoInput\">Vælg en dato</label>\r\n        <input type=\"date\" name=\"datoInput\" id=\"datoInput\" />\r\n        <input type=\"submit\" value=\"Vis Info\" />\r\n");
#nullable restore
#line 12 "C:\IKT\GUI\Morgenmadsbuffeten\Morgenmadbuffet\Morgenmadsbuffeten\Views\Kitchens\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
