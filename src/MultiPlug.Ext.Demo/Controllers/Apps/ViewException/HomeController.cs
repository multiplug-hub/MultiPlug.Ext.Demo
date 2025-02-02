using MultiPlug.Base.Attribute;
using MultiPlug.Base.Http;

namespace MultiPlug.Ext.Demo.Controllers.Apps.ViewException
{
    [Route("")]
    public class HomeController : ViewExceptionApp
    {
        public Response Get()
        {
            throw new System.Exception("Exception by View Exception Example App");
        }
    }
}
