using MultiPlug.Base.Http;
using MultiPlug.Extension.Core.Attribute;

namespace MultiPlug.Ext.Demo.Controllers.Apps.DemoDashboard3
{
    [Name("Extensions Demonstration")]
    [ViewAs(ViewAs.Partial)]
    [HttpEndpointType(HttpEndpointType.App)]
    public class DemoDashboardApp3 : Controller
    {
    }
}
