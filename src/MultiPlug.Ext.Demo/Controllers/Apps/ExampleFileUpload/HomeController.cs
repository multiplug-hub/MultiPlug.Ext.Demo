using MultiPlug.Base.Http;

namespace MultiPlug.Ext.Demo.Controllers.Apps.ExampleFileUpload
{
    public class HomeController : ExampleFileUploadApp
    { 
        public Response Get()
        {
            return new Response
            {
                Model = string.Empty,
                Template = Templates.ExampleAppFileUpload,
            };
        }
        public Response Post(UploadFilePaths theFiles)
        {
            string Result;

            if (theFiles.Files.Length > 0)
            {
                Result = System.IO.File.ReadAllText(theFiles.Files[0].Path);
            }
            else
            {
                Result = string.Empty;
            }

            return new Response
            {
                StatusCode = System.Net.HttpStatusCode.OK,
                Model = Result,
                Template = Templates.ExampleAppFileUpload,
            };
        }
    }
}
