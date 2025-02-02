using MultiPlug.Base.Http;
using MultiPlug.Extension.Core.Attribute;

namespace MultiPlug.Ext.Demo.Controllers.Apps.RazorError
{
    [Name("Example Razor Error")]
    [ViewAs(ViewAs.FullScreen)]
    [HttpEndpointType(HttpEndpointType.App)]
    public class RazorErrorApp : Controller
    {
    }
}
