using System.Text;
using MultiPlug.Base.Http;
using MultiPlug.Ext.Demo.Properties;
using MultiPlug.Base.Attribute;

namespace MultiPlug.Ext.Demo.Controllers.Assets.JS
{
    [Route("js/*")]
    class GetJs : JsAssetsHandler
    {
        public Response Get(string theFileName)
        {
            string result = "";

            if (theFileName == "material-components-web.min.js")
            {
                result = Resources.material_components_web_min_js;
            }

            if (result != "")
            {
                return new Response { MediaType = "text/javascript", RawBytes = Encoding.ASCII.GetBytes(result) };
            }
            else
            {
                return new Response { StatusCode = System.Net.HttpStatusCode.NotFound };
            }
        }
    }
}
