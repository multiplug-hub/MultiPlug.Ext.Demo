using MultiPlug.Base.Attribute;
using MultiPlug.Base.Exchange;
using MultiPlug.Base.Http;

namespace MultiPlug.Ext.Demo.Controllers.Apps.RazorError
{
    [Route("")]
    public class HomeController : RazorErrorApp
    {
        public Response Get()
        {
            return new Response
            {
                Template = Templates.ExampleAppRazorError,
                Subscriptions = new Subscription[0],
                Events = new EventExternal[0],
                Model = new Models.View.RazorErrorModel()
            };
        }
    }
}
