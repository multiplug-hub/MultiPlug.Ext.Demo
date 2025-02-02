using MultiPlug.Base.Attribute;
using MultiPlug.Base.Http;

namespace MultiPlug.Ext.Demo.Controllers.Settings.EventTrace
{
    [Route("subscription/delete")]
    public class SubscriptionDeleteController : SettingsApp
    {
        public Response Post(string id)
        {
            if (Core.Instance.EventTrace.RemoveSubscription(id))
            {
                return new Response
                {
                    StatusCode = System.Net.HttpStatusCode.OK
                };
            }
            else
            {
                return new Response
                {
                    StatusCode = System.Net.HttpStatusCode.NotFound
                };
            }
        }
    }
}
