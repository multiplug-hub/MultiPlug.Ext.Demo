using MultiPlug.Base.Http;
using MultiPlug.Extension.Core.Attribute;

namespace MultiPlug.Ext.Demo.Controllers.Apps.ViewException
{
    [Name("Example Internal Server Error")]
    [ViewAs(ViewAs.FullScreen)]
    [HttpEndpointType(HttpEndpointType.App)]
    public class ViewExceptionApp : Controller
    {
    }
}
