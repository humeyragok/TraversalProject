#pragma checksum "C:\Users\hmyrg\source\repos\TraversalProject\TraversalProject\Areas\Admin\Views\Comment\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a0fac2f1e8f9fd6efe72bc46603cbd59c5d7ac3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Comment_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Comment/Index.cshtml")]
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
#line 1 "C:\Users\hmyrg\source\repos\TraversalProject\TraversalProject\Areas\Admin\Views\Comment\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a0fac2f1e8f9fd6efe72bc46603cbd59c5d7ac3", @"/Areas/Admin/Views/Comment/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9108bca35cd76bb621b63eaa31acd78cf5f75c15", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Comment_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Comment>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\hmyrg\source\repos\TraversalProject\TraversalProject\Areas\Admin\Views\Comment\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Yorum Listesi</h1>\r\n\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Kullanıcı</th>\r\n        <th>Rota</th>\r\n        <th>Tarih</th>\r\n        <th>Sil</th>\r\n    </tr>\r\n");
#nullable restore
#line 18 "C:\Users\hmyrg\source\repos\TraversalProject\TraversalProject\Areas\Admin\Views\Comment\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\hmyrg\source\repos\TraversalProject\TraversalProject\Areas\Admin\Views\Comment\Index.cshtml"
           Write(item.CommentID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\hmyrg\source\repos\TraversalProject\TraversalProject\Areas\Admin\Views\Comment\Index.cshtml"
           Write(item.CommentUser);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\hmyrg\source\repos\TraversalProject\TraversalProject\Areas\Admin\Views\Comment\Index.cshtml"
           Write(item.Destination.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\hmyrg\source\repos\TraversalProject\TraversalProject\Areas\Admin\Views\Comment\Index.cshtml"
            Write(((DateTime)item.CommentDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 622, "\"", 673, 2);
            WriteAttributeValue("", 629, "/Admin/Comment/DeleteComment/", 629, 29, true);
#nullable restore
#line 25 "C:\Users\hmyrg\source\repos\TraversalProject\TraversalProject\Areas\Admin\Views\Comment\Index.cshtml"
WriteAttributeValue("", 658, item.CommentID, 658, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 27 "C:\Users\hmyrg\source\repos\TraversalProject\TraversalProject\Areas\Admin\Views\Comment\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Comment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
