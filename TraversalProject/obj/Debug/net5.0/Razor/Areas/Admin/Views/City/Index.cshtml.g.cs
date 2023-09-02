#pragma checksum "C:\Users\hmyrg\source\repos\TraversalProject\TraversalProject\Areas\Admin\Views\City\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bbf6ba8b742684e57dac78fdb5b394ff12a5df8b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_City_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/City/Index.cshtml")]
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
#line 3 "C:\Users\hmyrg\source\repos\TraversalProject\TraversalProject\Areas\Admin\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbf6ba8b742684e57dac78fdb5b394ff12a5df8b", @"/Areas/Admin/Views/City/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83c5243a24abcea5d596907d5c37bff6fbb80278", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_City_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\hmyrg\source\repos\TraversalProject\TraversalProject\Areas\Admin\Views\City\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script src=""//ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js""></script>

<h2>Şehir - Ülke İşlemleri</h2>
<br />

<button type=""button"" id=""btngetlist"" class=""btn btn-outline-info"">Şehir Listesi</button>
<button type=""button"" id=""btngetbyid"" class=""btn btn-outline-primary"">Şehir Getir</button>
<button type=""button"" id=""btnaddcity"" class=""btn btn-outline-warning"">Şehir Ekle</button>
<button type=""button"" id=""btndeletecity"" class=""btn btn-outline-danger"">Şehir Sil</button>
<button type=""button"" id=""btnupdatecity"" class=""btn btn-outline-success"">Şehir Güncelle</button>

<br />
<br />

<div id=""citylist"">
    Buraya Şehir Listesi Gelecek
</div>
<br />
<div>
    <input type=""text"" id=""txtid"" placeholder=""Şehir ID değerini giriniz"" class=""form-control"" />
</div>
<br />
<div>
    <input type=""text"" id=""txtcityid"" placeholder=""Silinecek ID değerini giriniz"" class=""form-control"" />
</div>
<br />
<div>
    <input type=""text"" id=""txtcityeditid"" placeholder=""güncellenecek ID değerini ");
            WriteLiteral(@"giriniz"" class=""form-control"" />
    <br />
    <input type=""text"" id=""txtcityname"" placeholder=""güncellenecek şehir değerini giriniz"" class=""form-control"" />
    <br />
    <input type=""text"" id=""txtcitdaynightname"" placeholder=""güncellenecek gün gece bilgisini giriniz"" class=""form-control"" />
</div>
<br />
<div id=""destinationlistbyid"">

</div>

<br />
<div>
    <input type=""text"" id=""txtcity"" placeholder=""Şehir adını giriniz"" class=""form-control"" />
    <br />
    <input type=""text"" id=""txtdaynight"" placeholder=""Gün - gece sayısı"" class=""form-control"" />
    <br />
    <input type=""text"" id=""txtprice"" placeholder=""Fiyat"" class=""form-control"" />
    <br />
    <input type=""text"" id=""txtcapacity"" placeholder=""Konaklayacak kişi sayısı"" class=""form-control"" />
</div>

<script>
    $(""#btngetlist"").click(function () {
        $.ajax({
            contentType: ""application/json"",
            dataType: ""json"",
            type: ""Get"",
            url: ""/Admin/City/CityList/"",
        ");
            WriteLiteral(@"    success: function (func) {
                let w = jQuery.parseJSON(func);
                console.log(w);
                let tablehtml = ""<table class=table table-bordered> <tr><th> Şehir Adı </th> <th> Gün-Gece </th> <th> Fiyatı </th> </tr>"";
                $.each(w, (index, value) => {
                    tablehtml += `<tr><td>${value.City}</td> <td>${value.DayNight}</td> <td> ${value.Price} ₺ </td> </tr>`
                });
                tablehtml += ""</table>"";
                $(""#citylist"").html(tablehtml);
            }
        });
    });

    $(""#btnaddcity"").click(function () {
        let cityvalues = {
            City: $(""#txtcity"").val(),
            DayNight: $(""#txtdaynight"").val(),
            Price: $(""#txtprice"").val(),
            Capacity: $(""#txtcapacity"").val()
        };

        $.ajax({
            type: ""post"",
            url: ""/Admin/City/AddCityDestination/"",
            data: cityvalues,
            success: function (func) {
                le");
            WriteLiteral(@"t result = jQuery.parseJSON(func);
                alert(""Şehir - Rota Başarılı Bir Şekilde Eklendi"");
            }
        });
    });

    $(""#btngetbyid"").click(x => {
        let id = $(""#txtid"").val();

        $.ajax({
            contentType: ""application/json"",
            dataType: ""json"",
            type: ""Get"",
            url: ""/Admin/City/GetById/"",
            data: { DestinationID: id },
            success: function (fun2) {
                let result = jQuery.parseJSON(fun2);
                console.log(result);
                let htmlstr = `<table class=table table-bordered><tr><th>Şehir Adı</th><th>Gün-Gece</th><th>Fiyatı</th></tr><tr><td>${result.City}</td><td>${result.DayNight}</td><td>${result.Capacity}</td></tr></table>`;
                $(""#destinationlistbyid"").html(htmlstr);
            }
        });
    });

    $(""#btndeletecity"").click(x => {
        let id = $(""#txtcityid"").val();
        $.ajax({
            url: ""/Admin/City/DeleteCity/"" + id,
   ");
            WriteLiteral(@"         type: ""post"",
            contentType: ""application/json"",
            dataType: ""json"",
            success: function (fun3) {
                alert(""şehir silindi"");
            }
        });
    });

    $(""#btnupdatecity"").click(function () {
        let values = {
            DestinationID: $(""#txtcityeditid"").val(),
            City: $(""#txtcityname"").val(),
            DayNight: $(""#txtcitdaynightname"").val()
        };

        $.ajax({
            type: ""post"",
            url: ""/Admin/City/UpdateCity/"",
            data: values,
            success: function (fun4) {
                alert(""Güncelleme işlemi yapıldı"");
            }
        });
    });

</script>");
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
