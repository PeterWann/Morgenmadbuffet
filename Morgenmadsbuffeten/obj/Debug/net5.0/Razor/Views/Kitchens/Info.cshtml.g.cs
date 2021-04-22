#pragma checksum "C:\IKT\GUI\Morgenmadsbuffeten\Morgenmadsbuffeten\Views\Kitchens\Info.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd2edf668ec73a506e5fd4d1b6f29a6078f66784"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Kitchens_Info), @"mvc.1.0.view", @"/Views/Kitchens/Info.cshtml")]
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
#line 1 "C:\IKT\GUI\Morgenmadsbuffeten\Morgenmadsbuffeten\Views\_ViewImports.cshtml"
using Morgenmadsbuffeten;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\IKT\GUI\Morgenmadsbuffeten\Morgenmadsbuffeten\Views\_ViewImports.cshtml"
using Morgenmadsbuffeten.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\IKT\GUI\Morgenmadsbuffeten\Morgenmadsbuffeten\Views\Kitchens\Info.cshtml"
using Microsoft.IdentityModel.Protocols;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\IKT\GUI\Morgenmadsbuffeten\Morgenmadsbuffeten\Views\Kitchens\Info.cshtml"
using Microsoft.EntityFrameworkCore.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\IKT\GUI\Morgenmadsbuffeten\Morgenmadsbuffeten\Views\Kitchens\Info.cshtml"
using Microsoft.EntityFrameworkCore.Metadata.Internal;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd2edf668ec73a506e5fd4d1b6f29a6078f66784", @"/Views/Kitchens/Info.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d9e52588916624b22220100ad0a205eb3322ab7", @"/Views/_ViewImports.cshtml")]
    public class Views_Kitchens_Info : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Morgenmadsbuffeten.Models.ViewModel.Kitchen>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\IKT\GUI\Morgenmadsbuffeten\Morgenmadsbuffeten\Views\Kitchens\Info.cshtml"
  
    ViewData["Title"] = "Info";

    int amountOfChildren = 0;
    int amountOfAdults = 0;
    foreach (var a in Model.Receptions)
    {
        amountOfChildren += a.ChildrenAmount;
        amountOfAdults += a.AdultAmounts;
    }

    var totalAmount = amountOfChildren + amountOfAdults;

    int amountChildrenRestaurant = 0;
    int amountAdultRestaurant = 0;
    int notCheckedIn = 0;
    int notCheckedInAdults = 0;
    int notCheckedInChildren = 0;
    foreach (var a in Model.Restaurants)
    {
        amountChildrenRestaurant += a.AmountChildren;
        amountAdultRestaurant += a.AmountAdults;
    }

    notCheckedIn = totalAmount - (amountChildrenRestaurant + amountAdultRestaurant);
    notCheckedInAdults = amountOfAdults - amountAdultRestaurant;
    notCheckedInChildren = amountOfChildren - amountChildrenRestaurant;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Køkkenet</h1>\r\n<br />\r\n<h2>Dato: ");
#nullable restore
#line 36 "C:\IKT\GUI\Morgenmadsbuffeten\Morgenmadsbuffeten\Views\Kitchens\Info.cshtml"
     Write(ViewBag.Dato.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<br />\r\n<h3>Forventet antal gæster</h3>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 44 "C:\IKT\GUI\Morgenmadsbuffeten\Morgenmadsbuffeten\Views\Kitchens\Info.cshtml"
           Write(Html.DisplayNameFor(model => model.Receptions[0].AdultAmounts));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 47 "C:\IKT\GUI\Morgenmadsbuffeten\Morgenmadsbuffeten\Views\Kitchens\Info.cshtml"
           Write(Html.DisplayNameFor(model => model.Receptions[0].ChildrenAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Total Antal\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 58 "C:\IKT\GUI\Morgenmadsbuffeten\Morgenmadsbuffeten\Views\Kitchens\Info.cshtml"
           Write(amountOfAdults);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 61 "C:\IKT\GUI\Morgenmadsbuffeten\Morgenmadsbuffeten\Views\Kitchens\Info.cshtml"
           Write(amountOfChildren);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 64 "C:\IKT\GUI\Morgenmadsbuffeten\Morgenmadsbuffeten\Views\Kitchens\Info.cshtml"
           Write(totalAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n        </tr>\r\n    </tbody>\r\n</table>\r\n<br />\r\n<br />\r\n<h3>Antal gæster tjekket ind</h3>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 77 "C:\IKT\GUI\Morgenmadsbuffeten\Morgenmadsbuffeten\Views\Kitchens\Info.cshtml"
           Write(Html.DisplayNameFor(model => model.Restaurants[0].AmountAdults));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 80 "C:\IKT\GUI\Morgenmadsbuffeten\Morgenmadsbuffeten\Views\Kitchens\Info.cshtml"
           Write(Html.DisplayNameFor(model => model.Restaurants[0].AmountChildren));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 88 "C:\IKT\GUI\Morgenmadsbuffeten\Morgenmadsbuffeten\Views\Kitchens\Info.cshtml"
           Write(amountAdultRestaurant);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 91 "C:\IKT\GUI\Morgenmadsbuffeten\Morgenmadsbuffeten\Views\Kitchens\Info.cshtml"
           Write(amountChildrenRestaurant);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n        </tr>\r\n    </tbody>\r\n</table>\r\n<br />\r\n<br />\r\n<h3>Antal gæster <u>ikke</u> tjekket ind</h3>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 104 "C:\IKT\GUI\Morgenmadsbuffeten\Morgenmadsbuffeten\Views\Kitchens\Info.cshtml"
           Write(Html.DisplayNameFor(model => model.Restaurants[0].AmountAdults));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 107 "C:\IKT\GUI\Morgenmadsbuffeten\Morgenmadsbuffeten\Views\Kitchens\Info.cshtml"
           Write(Html.DisplayNameFor(model => model.Restaurants[0].AmountChildren));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Total Antal\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n    <tr>\r\n        <td>\r\n            ");
#nullable restore
#line 118 "C:\IKT\GUI\Morgenmadsbuffeten\Morgenmadsbuffeten\Views\Kitchens\Info.cshtml"
       Write(notCheckedInAdults);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 121 "C:\IKT\GUI\Morgenmadsbuffeten\Morgenmadsbuffeten\Views\Kitchens\Info.cshtml"
       Write(notCheckedInChildren);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 124 "C:\IKT\GUI\Morgenmadsbuffeten\Morgenmadsbuffeten\Views\Kitchens\Info.cshtml"
       Write(notCheckedIn);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n\r\n    </tr>\r\n    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Morgenmadsbuffeten.Models.ViewModel.Kitchen> Html { get; private set; }
    }
}
#pragma warning restore 1591