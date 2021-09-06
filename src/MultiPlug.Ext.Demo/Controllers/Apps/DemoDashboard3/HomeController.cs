using System;
using MultiPlug.Base.Attribute;
using MultiPlug.Base.Http;
using MultiPlug.Base.Exchange;

namespace MultiPlug.Ext.Demo.Controllers.Apps.DemoDashboard3
{
    [Route("")]
    public class HomeController : DemoDashboardApp3
    {
        public string SubGuid { get; private set; } = Guid.NewGuid().ToString();

        public Response Get()
        {
            return new Response
            {
                Template = "Demo-Home3",
                Subscriptions = new Subscription[]
                {
                    new Subscription { Guid = SubGuid, Id = "2a4c7bc2-ba5d-4522-9d91-19c79f68f1cc" },
                    new Subscription { Guid = SubGuid, Id = "2a4c7bc2-ba5d-4522-9d91-19c79f68f1cd" },
                    new Subscription { Guid = SubGuid, Id = "2a4c7bc2-ba5d-4522-9d91-19c79f68f1ce" },
                    new Subscription { Guid = SubGuid, Id = "2a4c7bc2-ba5d-4522-9d91-19c79f68f1cf" }
                },
                Events = Core.Instance.EventsExternal(),
                Model = new Models.View.DemoDashboardApp3
                {
                    ExceptionEventId = Core.Instance.EventExceptionId,
                    ThreadedExceptionEventId = Core.Instance.ThreadedEventExceptionId,
                }
            };
        }
    }
}
