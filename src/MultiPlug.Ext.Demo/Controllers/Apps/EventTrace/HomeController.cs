using System.Linq;
using MultiPlug.Base.Exchange;
using MultiPlug.Base.Http;
using MultiPlug.Ext.Demo.Models.View;

namespace MultiPlug.Ext.Demo.Controllers.Apps.EventTrace
{
    public class HomeController : EventTraceApp
    {
        public Response Get()
        {
            Subscription[] VisualSubscriptions = Core.Instance.EventTrace.Subscriptions.Select(Sub => new Subscription { Guid = System.Guid.NewGuid().ToString(), Id = Sub }).ToArray();

            return new Response
            {
                Model = new EventTraceModel { SubscriptionIds = Core.Instance.EventTrace.Subscriptions },
                Template = Templates.AppEventTrace,
                Subscriptions = VisualSubscriptions
            };
        }
    }
}
