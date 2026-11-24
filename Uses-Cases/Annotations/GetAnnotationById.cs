using Aspose.Pdf.Cloud.Sdk.Model;
using Newtonsoft.Json;

namespace Annotations
{
    public class GetAnnotationById
    {
        public static async Task RequestTextAnnotationAsync(AnnotationsHelper helper, string documentName, string annotationId, string remoteFolder)
        {
            // Get annotation by Id in the PDF document.
            await helper.UploadFile(documentName);

            TextAnnotationResponse response = await helper.pdfApi.GetTextAnnotationAsync(documentName, annotationId, folder: remoteFolder);

            Console.WriteLine(JsonConvert.SerializeObject(response));

            if (response == null)
                Console.WriteLine("RequestTextAnnotationAsync(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("RequestTextAnnotationAsync(): Failed to request text annotation from the document.");
            else
                Console.WriteLine("RequestTextAnnotationAsync(): annotation '{0}' with '{1}' contents successfully found in the document '{2}.", response.Annotation.Id, response.Annotation.Contents, documentName);
        }
    }
}
