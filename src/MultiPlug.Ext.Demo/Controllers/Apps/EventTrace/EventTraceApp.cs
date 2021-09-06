using MultiPlug.Base.Http;
using MultiPlug.Extension.Core.Attribute;

namespace MultiPlug.Ext.Demo.Controllers.Apps.EventTrace
{
    [Name("Example Event Trace")]
    [ViewAs(ViewAs.Partial)]
    [HttpEndpointType(HttpEndpointType.App)]
    public class EventTraceApp : Controller
    {
    }
}
