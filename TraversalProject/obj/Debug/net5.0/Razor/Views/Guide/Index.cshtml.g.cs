#pragma checksum "C:\Users\hmyrg\OneDrive\Masaüstü\traversal\TraversalProject\Views\Guide\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d838f2ed9bdbd581c289b58efb3a45822ac066ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Guide_Index), @"mvc.1.0.view", @"/Views/Guide/Index.cshtml")]
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
#line 1 "C:\Users\hmyrg\OneDrive\Masaüstü\traversal\TraversalProject\Views\_ViewImports.cshtml"
using TraversalProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hmyrg\OneDrive\Masaüstü\traversal\TraversalProject\Views\_ViewImports.cshtml"
using TraversalProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hmyrg\OneDrive\Masaüstü\traversal\TraversalProject\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d838f2ed9bdbd581c289b58efb3a45822ac066ba", @"/Views/Guide/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f278c2e195091e15ef6b360e804c00589ff5a5c4", @"/Views/_ViewImports.cshtml")]
    public class Views_Guide_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EntityLayer.Concrete.Guide>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\hmyrg\OneDrive\Masaüstü\traversal\TraversalProject\Views\Guide\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_UILayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""w3l-team"" id=""team"">
    <div class=""team-block py-5"">
        <div class=""container py-lg-5"">
            <div class=""title-content text-center mb-lg-3 mb-4"">
                <h6 class=""sub-title"">Ekip Arkadaşlarımız</h6>
                <h3 class=""hny-title"">Rehberlerimizle Tanışın</h3>
            </div>
            <div class=""row"">
");
#nullable restore
#line 16 "C:\Users\hmyrg\OneDrive\Masaüstü\traversal\TraversalProject\Views\Guide\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-3 col-6 mt-lg-5 mt-4\">\r\n                        <div class=\"box16\">\r\n                            <a href=\"#url\"><img");
            BeginWriteAttribute("src", " src=\"", 718, "\"", 744, 1);
#nullable restore
#line 20 "C:\Users\hmyrg\OneDrive\Masaüstü\traversal\TraversalProject\Views\Guide\Index.cshtml"
WriteAttributeValue("", 724, item.GuideListImage, 724, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"height:330px;width:500px\"");
            BeginWriteAttribute("alt", " alt=\"", 778, "\"", 784, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\" /></a>\r\n                            <div class=\"box-content\">\r\n                                <h3 class=\"title\"><a href=\"#url\">");
#nullable restore
#line 22 "C:\Users\hmyrg\OneDrive\Masaüstü\traversal\TraversalProject\Views\Guide\Index.cshtml"
                                                            Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                                <span class=\"post\">");
#nullable restore
#line 23 "C:\Users\hmyrg\OneDrive\Masaüstü\traversal\TraversalProject\Views\Guide\Index.cshtml"
                                              Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                <ul class=""social"">
                                    <li>
                                        <a href=""#"" class=""facebook"">
                                            <span class=""fa fa-facebook-f""></span>
                                        </a>
                                    </li>
                                    <li>
                                        <a href=""#"" class=""twitter"">
                                            <span class=""fa fa-twitter""></span>
                                        </a>
                                    </li>
                                </ul>
                            </div>
                        </div>
                    </div>
");
#nullable restore
#line 39 "C:\Users\hmyrg\OneDrive\Masaüstü\traversal\TraversalProject\Views\Guide\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EntityLayer.Concrete.Guide>> Html { get; private set; }
    }
}
#pragma warning restore 1591
