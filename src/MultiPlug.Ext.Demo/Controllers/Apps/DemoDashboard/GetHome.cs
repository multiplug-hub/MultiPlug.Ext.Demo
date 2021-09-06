using MultiPlug.Base.Attribute;
using MultiPlug.Base.Http;

namespace MultiPlug.Ext.Demo.Controllers.Apps.DemoDashboard
{
    [Route("")]
    public class GetHome : DemoDashboardApp
    {
        public Response Get()
        {
            return new Response { Template = "Demo-Home" };
        }
    }
}
