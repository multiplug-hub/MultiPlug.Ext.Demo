using System.Text;
using MultiPlug.Base.Http;
using MultiPlug.Ext.Demo.Properties;
using MultiPlug.Base.Attribute;

namespace MultiPlug.Ext.Demo.Controllers.Assets.CSS
{
    [Route("css/*")]
    public class GetCss : CssAssetsHandler
    {
        public Response Get(string theFileName)
        {
            string result = "";

            if (theFileName == "material-components-web.min.css")
            {
                result = Resources.material_components_web_min_css;
            }

            if (result != "")
            {
                return new Response { MediaType = "text/css", RawBytes = Encoding.ASCII.GetBytes(result) };
            }
            else
            {
                return new Response { StatusCode = System.Net.HttpStatusCode.NotFound };
            }
        }
    }
}
