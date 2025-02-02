using MultiPlug.Base.Attribute;
using MultiPlug.Base.Http;
using MultiPlug.Ext.Demo.Models.Apps;

namespace MultiPlug.Ext.Demo.Controllers.Settings.EventTrace
{
    [Route("subscriptions")]
    public class EventTraceController : SettingsApp
    {
        public Response Get()
        {
            return new Response
            {
                Model = Core.Instance.EventTrace.Subscriptions,
                Template = Templates.SettingsEventTrace
            };
        }

        public Response Post(SubscriptionsPostModel theModel)
        {
            if (theModel != null && theModel.SubscriptionId != null )
            {
                Core.Instance.EventTrace.AddSubscriptions(theModel.SubscriptionId);
            }

            return new Response
            {
                StatusCode = System.Net.HttpStatusCode.Moved,
                Location = Context.Referrer
            };
        }

    }
}
