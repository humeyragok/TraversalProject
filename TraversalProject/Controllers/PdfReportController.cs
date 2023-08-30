using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalProject.Controllers
{
    public class PdfReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StaticPdfReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdfreports/" + "dosya1.pdf");
            var stream = new FileStream(path, FileMode.Create);

            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);

            document.Open();

            Paragraph paragraph = new Paragraph("Traversal Rezervasyon Pdf Raporu");

            document.Add(paragraph);
            document.Close();
            return File("/pdfreports/dosya1.pdf", "application/pdf", "dosya1.pdf");
        }
        public IActionResult StaticCustomerReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdfreports/" + "dosya2.pdf");
            var stream = new FileStream(path, FileMode.Create);

            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);

            document.Open();

            PdfPTable pdfPTable = new PdfPTable(3);

            pdfPTable.AddCell("Misafir Adı");
            pdfPTable.AddCell("Misafir Soyadı");
            pdfPTable.AddCell("Misafir TC");

            pdfPTable.AddCell("Melisa");
            pdfPTable.AddCell("Koca");
            pdfPTable.AddCell("6161616161");
            pdfPTable.AddCell("Hakan");
            pdfPTable.AddCell("Seven");
            pdfPTable.AddCell("00011122233");

            pdfPTable.AddCell("Barış");
            pdfPTable.AddCell("Koçak");
            pdfPTable.AddCell("1111144445");

            document.Add(pdfPTable);

            document.Close();
            return File("/pdfreports/dosya2.pdf", "application/pdf", "dosya2.pdf");
        }
    }
}