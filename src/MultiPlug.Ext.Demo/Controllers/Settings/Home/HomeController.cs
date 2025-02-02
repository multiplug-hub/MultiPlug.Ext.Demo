using MultiPlug.Base.Attribute;
using MultiPlug.Base.Http;
using System.Reflection;

namespace MultiPlug.Ext.Demo.Controllers.Settings.Home
{
    [Route("")]
    public class HomeController : SettingsApp
    {
        public Response Get()
        {
            Assembly ExecutingAssembly = Assembly.GetExecutingAssembly();

            return new Response
            {
                Template = Templates.SettingsHome,
                Model = new Models.Settings.HomeModel
                {
                    Title = ExecutingAssembly.GetCustomAttribute<AssemblyTitleAttribute>().Title,
                    Description = ExecutingAssembly.GetCustomAttribute<AssemblyDescriptionAttribute>().Description,
                    Company = ExecutingAssembly.GetCustomAttribute<AssemblyCompanyAttribute>().Company,
                    Product = ExecutingAssembly.GetCustomAttribute<AssemblyProductAttribute>().Product,
                    Copyright = ExecutingAssembly.GetCustomAttribute<AssemblyCopyrightAttribute>().Copyright,
                    Trademark = ExecutingAssembly.GetCustomAttribute<AssemblyTrademarkAttribute>().Trademark,
                    Version = ExecutingAssembly.GetCustomAttribute<AssemblyFileVersionAttribute>().Version,
                }
            };
        }
    }
}
