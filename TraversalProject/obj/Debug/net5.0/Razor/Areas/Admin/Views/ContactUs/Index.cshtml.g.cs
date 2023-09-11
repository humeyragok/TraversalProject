#pragma checksum "C:\Users\hmyrg\OneDrive\Masaüstü\traversal\TraversalProject\Areas\Admin\Views\ContactUs\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb27b1b2315922a8e6c25d69bb83f3d758cd2f44"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ContactUs_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/ContactUs/Index.cshtml")]
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
#line 1 "C:\Users\hmyrg\OneDrive\Masaüstü\traversal\TraversalProject\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hmyrg\OneDrive\Masaüstü\traversal\TraversalProject\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalProject.Areas.Member.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hmyrg\OneDrive\Masaüstü\traversal\TraversalProject\Areas\Admin\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hmyrg\OneDrive\Masaüstü\traversal\TraversalProject\Areas\Admin\Views\_ViewImports.cshtml"
using DTOLayer.DTOs.AnnouncementDTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\hmyrg\OneDrive\Masaüstü\traversal\TraversalProject\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalProject.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\hmyrg\OneDrive\Masaüstü\traversal\TraversalProject\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalProject.CQRS.Results.DestinationResults;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\hmyrg\OneDrive\Masaüstü\traversal\TraversalProject\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalProject.CQRS.Results.GuideResults;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\hmyrg\OneDrive\Masaüstü\traversal\TraversalProject\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalProject.CQRS.Commands.DestinationCommands;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\hmyrg\OneDrive\Masaüstü\traversal\TraversalProject\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalProject.CQRS.Commands.GuideCommands;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb27b1b2315922a8e6c25d69bb83f3d758cd2f44", @"/Areas/Admin/Views/ContactUs/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83c5243a24abcea5d596907d5c37bff6fbb80278", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_ContactUs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ContactUs>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\hmyrg\OneDrive\Masaüstü\traversal\TraversalProject\Areas\Admin\Views\ContactUs\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";
    int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Bize Ulaşın Mesajları</h1>\r\n\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Gönderen</th>\r\n        <th>Konu</th>\r\n        <th>Tarih</th>\r\n        <th>Sil</th>\r\n        <th>Mesajı Aç</th>\r\n    </tr>\r\n");
#nullable restore
#line 19 "C:\Users\hmyrg\OneDrive\Masaüstü\traversal\TraversalProject\Areas\Admin\Views\ContactUs\Index.cshtml"
     foreach (var item in Model)
    {
        count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th>");
#nullable restore
#line 23 "C:\Users\hmyrg\OneDrive\Masaüstü\traversal\TraversalProject\Areas\Admin\Views\ContactUs\Index.cshtml"
           Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\hmyrg\OneDrive\Masaüstü\traversal\TraversalProject\Areas\Admin\Views\ContactUs\Index.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\hmyrg\OneDrive\Masaüstü\traversal\TraversalProject\Areas\Admin\Views\ContactUs\Index.cshtml"
           Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\hmyrg\OneDrive\Masaüstü\traversal\TraversalProject\Areas\Admin\Views\ContactUs\Index.cshtml"
           Write(item.MessageDate.ToString("dd.MMM.yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a href=\"#\" class=\"btn btn-outline-danger\">Sil</a></td>\r\n            <td><a href=\"#\" class=\"btn btn-outline-dark\">Mesajı Aç</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 30 "C:\Users\hmyrg\OneDrive\Masaüstü\traversal\TraversalProject\Areas\Admin\Views\ContactUs\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ContactUs>> Html { get; private set; }
    }
}
#pragma warning restore 1591
