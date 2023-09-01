#pragma checksum "C:\Users\hmyrg\source\repos\TraversalProject\TraversalProject\Areas\Admin\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d80cee05dbd4d861b768c9b7c3ac38be6fa4052"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_User_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/User/Index.cshtml")]
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
using TraversalProject.CQRS.Commands.DestinationCommands;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\hmyrg\source\repos\TraversalProject\TraversalProject\Areas\Admin\Views\User\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d80cee05dbd4d861b768c9b7c3ac38be6fa4052", @"/Areas/Admin/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75f8bd27e4ac6a24e1cb8a0b94d9660eb6300bc3", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AppUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\hmyrg\source\repos\TraversalProject\TraversalProject\Areas\Admin\Views\User\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";
    int sayac = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Kullanıcı Listesi</h1>

<table class=""table table-bordered"">
    <tr>
        <th>#</th>
        <th>Ad Soyad</th>
        <th>Kullanıcı Adı</th>
        <th>Mail</th>
        <th>Sil</th>
        <th>Düzenle</th>
        <th>Yorumlar</th>
        <th>Tur Geçmişi</th>
    </tr>
");
#nullable restore
#line 23 "C:\Users\hmyrg\source\repos\TraversalProject\TraversalProject\Areas\Admin\Views\User\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n");
#nullable restore
#line 26 "C:\Users\hmyrg\source\repos\TraversalProject\TraversalProject\Areas\Admin\Views\User\Index.cshtml"
              sayac = sayac + 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>");
#nullable restore
#line 27 "C:\Users\hmyrg\source\repos\TraversalProject\TraversalProject\Areas\Admin\Views\User\Index.cshtml"
           Write(sayac);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\hmyrg\source\repos\TraversalProject\TraversalProject\Areas\Admin\Views\User\Index.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 28 "C:\Users\hmyrg\source\repos\TraversalProject\TraversalProject\Areas\Admin\Views\User\Index.cshtml"
                      Write(item.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\hmyrg\source\repos\TraversalProject\TraversalProject\Areas\Admin\Views\User\Index.cshtml"
           Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\hmyrg\source\repos\TraversalProject\TraversalProject\Areas\Admin\Views\User\Index.cshtml"
           Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 719, "\"", 757, 2);
            WriteAttributeValue("", 726, "/Admin/User/DeleteUser/", 726, 23, true);
#nullable restore
#line 31 "C:\Users\hmyrg\source\repos\TraversalProject\TraversalProject\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 749, item.Id, 749, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 822, "\"", 858, 2);
            WriteAttributeValue("", 829, "/Admin/User/EditUser/", 829, 21, true);
#nullable restore
#line 32 "C:\Users\hmyrg\source\repos\TraversalProject\TraversalProject\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 850, item.Id, 850, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Düzenle</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 928, "\"", 967, 2);
            WriteAttributeValue("", 935, "/Admin/User/CommentUser/", 935, 24, true);
#nullable restore
#line 33 "C:\Users\hmyrg\source\repos\TraversalProject\TraversalProject\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 959, item.Id, 959, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info\">Yorumlar</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 1035, "\"", 1078, 2);
            WriteAttributeValue("", 1042, "/Admin/User/ReservationUser/", 1042, 28, true);
#nullable restore
#line 34 "C:\Users\hmyrg\source\repos\TraversalProject\TraversalProject\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 1070, item.Id, 1070, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-secondary\">Tur Geçmişi</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 36 "C:\Users\hmyrg\source\repos\TraversalProject\TraversalProject\Areas\Admin\Views\User\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n<a href=\"/Login/SignUp/\" class=\"btn btn-outline-primary\">Yeni Kullanıcı Kaydı</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AppUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
