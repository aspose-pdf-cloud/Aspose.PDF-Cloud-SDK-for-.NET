using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Model;
using RestSharp;

namespace CreateDocument
{
    public class ClreatePdfDocumentSimple
    {
        public ClreatePdfDocumentSimple(CrateDocumentHelper helper)
        {
            string PDF_DOCUMENT = "output_created_simple.pdf";

            DocumentResponse response = helper.pdfApi.PutCreateDocument(PDF_DOCUMENT, folder: helper.config.TEMP_FOLDER);
            if (response.Code != 200)
                Console.WriteLine("ClreatePdfDocumentSimple(): Unexpected error: {0}", response.Messages[0]);
            else
            {
                Console.WriteLine("ClreatePdfDocumentSimple():Document '{0}' successfully created.", PDF_DOCUMENT);
            }
        }
    }
}
