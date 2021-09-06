using MultiPlug.Base.Http;
using MultiPlug.Extension.Core.Attribute;

namespace MultiPlug.Ext.Demo.Controllers.Apps.ExampleFileUpload
{
    [Name("Example File Upload")]
    [ViewAs(ViewAs.Partial)]
    [HttpEndpointType(HttpEndpointType.App)]
    public class ExampleFileUploadApp : Controller
    {
    }
}
