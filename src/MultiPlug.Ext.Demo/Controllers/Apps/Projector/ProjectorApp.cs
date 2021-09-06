using MultiPlug.Base.Http;
using MultiPlug.Extension.Core.Attribute;

namespace MultiPlug.Ext.Demo.Controllers.Apps.Projector
{
    [Name("Projector Demo")]
    [ViewAs(ViewAs.FullScreen)]
    [HttpEndpointType(HttpEndpointType.App)]
    public class ProjectorApp// : Controller
    {
    }
}
