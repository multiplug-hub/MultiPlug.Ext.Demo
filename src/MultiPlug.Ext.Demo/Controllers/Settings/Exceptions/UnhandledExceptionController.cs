using MultiPlug.Base.Attribute;
using MultiPlug.Base.Http;

namespace MultiPlug.Ext.Demo.Controllers.Settings.Exceptions
{
    [Route("exceptions/unhandled")]
    public class UnhandledExceptionController : SettingsApp
    {
        public Response Post()
        {
            Core.Instance.ThreadException.InvokeException();

            return new Response
            {
                StatusCode = System.Net.HttpStatusCode.OK,
            };
        }
    }
}
