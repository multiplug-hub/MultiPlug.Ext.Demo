using MultiPlug.Base.Http;
using MultiPlug.Extension.Core.Attribute;

namespace MultiPlug.Ext.Demo.Controllers.Apps.DemoDashboard
{
    [Name("Example Full Screen")]
    [ViewAs(ViewAs.FullScreen)]
    [HttpEndpointType(HttpEndpointType.App)]
    public class DemoDashboardApp : Controller
    {
    }
}
