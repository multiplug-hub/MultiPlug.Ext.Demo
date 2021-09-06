using System;
using MultiPlug.Base.Attribute;
using MultiPlug.Base.Http;
using MultiPlug.Base.Exchange;

namespace MultiPlug.Ext.Demo.Controllers.Apps.Projector
{
    [Route("")]
    public class HomeController : ProjectorApp
    {
        public string SubGuid { get; private set; } = Guid.NewGuid().ToString();
        public Response Get()
        {
            return new Response
            {
                Template = "Demo-Projector",
                Subscriptions = new Subscription[]
                {
                    new Subscription { Guid = SubGuid, Id = "greentimeout" },
                    new Subscription { Guid = SubGuid, Id = "yellowtimeout" },
                    new Subscription { Guid = SubGuid, Id = "redtimeout" },
                    new Subscription { Guid = SubGuid, Id = "2583dac7-0fc5-4c78-92fd-b2b86e2ca98c" },
                },
                Model = new Models.View.ProjectorApp()
            };
        }
    }
}
