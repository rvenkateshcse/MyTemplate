namespace Templates
{
    internal class PDF
    {
        private void CreatePDF()
        {
            var Renderer = new IronPdf.HtmlToPdf();
            var PDF = Renderer.RenderHtmlAsPdf("<h1>Hello IronPdf</h1>");
            var OutputPath = "HtmlToPDF.pdf";
            PDF.SaveAs(OutputPath);
        }
    }
}