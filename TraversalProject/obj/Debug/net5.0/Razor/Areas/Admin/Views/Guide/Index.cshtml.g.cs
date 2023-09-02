#pragma checksum "C:\Users\hmyrg\source\repos\TraversalProject\TraversalProject\Areas\Admin\Views\Guide\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d13ed3c67f9b6080bdcca60592c14bdb6671be3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Guide_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Guide/Index.cshtml")]
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
#line 1 "C:\Users\hmyrg\source\repos\TraversalProject\TraversalProject\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hmyrg\source\repos\TraversalProject\TraversalProject\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalProject.Areas.Member.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hmyrg\source\repos\TraversalProject\TraversalProject\Areas\Admin\Views\_ViewImports.cshtml"
using DTOLayer.DTOs.AnnouncementDTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\hmyrg\source\repos\TraversalProject\TraversalProject\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalProject.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\hmyrg\source\repos\TraversalProject\TraversalProject\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalProject.CQRS.Results.DestinationResults;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\hmyrg\source\repos\TraversalProject\TraversalProject\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalProject.CQRS.Results.GuideResults;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\hmyrg\source\repos\TraversalProject\TraversalProject\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalProject.CQRS.Commands.DestinationCommands;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\hmyrg\source\repos\TraversalProject\TraversalProject\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalProject.CQRS.Commands.GuideCommands;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\hmyrg\source\repos\TraversalProject\TraversalProject\Areas\Admin\Views\Guide\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d13ed3c67f9b6080bdcca60592c14bdb6671be3", @"/Areas/Admin/Views/Guide/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83c5243a24abcea5d596907d5c37bff6fbb80278", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Guide_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Guide>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\hmyrg\source\repos\TraversalProject\TraversalProject\Areas\Admin\Views\Guide\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";
    int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    img {
        border-radius: 50%;
    }
</style>

<h1>Rehber Listesi</h1>

<table class=""table table-bordered"">
    <tr>
        <th>#</th>
        <th>Görsel</th>
        <th>Ad Soyad</th>
        <th>Açıklama</th>
        <th>Durum</th>
        <th>Düzenle</th>
    </tr>
");
#nullable restore
#line 26 "C:\Users\hmyrg\source\repos\TraversalProject\TraversalProject\Areas\Admin\Views\Guide\Index.cshtml"
     foreach (var item in Model)
    {
        count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\hmyrg\source\repos\TraversalProject\TraversalProject\Areas\Admin\Views\Guide\Index.cshtml"
           Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><img");
            BeginWriteAttribute("src", " src=\"", 589, "\"", 606, 1);
#nullable restore
#line 31 "C:\Users\hmyrg\source\repos\TraversalProject\TraversalProject\Areas\Admin\Views\Guide\Index.cshtml"
WriteAttributeValue("", 595, item.Image, 595, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"50\" width=\"50\" /></td>\r\n            <td>");
#nullable restore
#line 32 "C:\Users\hmyrg\source\repos\TraversalProject\TraversalProject\Areas\Admin\Views\Guide\Index.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 33 "C:\Users\hmyrg\source\repos\TraversalProject\TraversalProject\Areas\Admin\Views\Guide\Index.cshtml"
           Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n");
#nullable restore
#line 36 "C:\Users\hmyrg\source\repos\TraversalProject\TraversalProject\Areas\Admin\Views\Guide\Index.cshtml"
              
                if (item.Status == true)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td><a");
            BeginWriteAttribute("href", " href=\"", 820, "\"", 867, 2);
            WriteAttributeValue("", 827, "/Admin/Guide/ChangeToFalse/", 827, 27, true);
#nullable restore
#line 39 "C:\Users\hmyrg\source\repos\TraversalProject\TraversalProject\Areas\Admin\Views\Guide\Index.cshtml"
WriteAttributeValue("", 854, item.GuideID, 854, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-warning\">Pasif Yap</a></td>\r\n");
#nullable restore
#line 40 "C:\Users\hmyrg\source\repos\TraversalProject\TraversalProject\Areas\Admin\Views\Guide\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td><a");
            BeginWriteAttribute("href", " href=\"", 1007, "\"", 1053, 2);
            WriteAttributeValue("", 1014, "/Admin/Guide/ChangeToTrue/", 1014, 26, true);
#nullable restore
#line 43 "C:\Users\hmyrg\source\repos\TraversalProject\TraversalProject\Areas\Admin\Views\Guide\Index.cshtml"
WriteAttributeValue("", 1040, item.GuideID, 1040, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info\">Aktif Yap</a></td>\r\n");
#nullable restore
#line 44 "C:\Users\hmyrg\source\repos\TraversalProject\TraversalProject\Areas\Admin\Views\Guide\Index.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <td><a href=\"/Admin/Guide/EditGuide/\" class=\"btn btn-outline-success\">Düzenle</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 49 "C:\Users\hmyrg\source\repos\TraversalProject\TraversalProject\Areas\Admin\Views\Guide\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Admin/Guide/AddGuide/\" class=\"btn btn-outline-primary\">Yeni Rehber Girişi</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Guide>> Html { get; private set; }
    }
}
#pragma warning restore 1591
