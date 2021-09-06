
using MultiPlug.Base.Exchange;
using MultiPlug.Extension.Core;
using MultiPlug.Ext.Demo.Controllers;
using MultiPlug.Ext.Demo.Properties;
using MultiPlug.Extension.Core.Http;

namespace MultiPlug.Ext.Demo
{
    public class Demo : MultiPlugExtension
    {
        private Models.Load.Root m_LoadModel = null;

        public override Event[] Events
        {
            get
            {
                return Core.Instance.Events();
            }
        }

        public override RazorTemplate[] RazorTemplates
        {
            get
            {
                return new RazorTemplate[]
                {
                    new RazorTemplate("Demo-Home" , Resources.Home_cshtml),
                    new RazorTemplate("Demo-Home2", "@model MultiPlug.Base.Http.EdgeApp\r\n<html><body><h1>Demo2</h1></body></html>"),
                    new RazorTemplate("Demo-Home3", Resources.DemoDashboardApp3_cshtml),
                    new RazorTemplate("Demo-Projector", Resources.ProjectorApp),
                    new RazorTemplate(Templates.AppEventTrace, Resources.EventTrace_cshtml),
                    new RazorTemplate(Templates.SettingsEventTrace, Resources.SettingsEventTrace_cshtml),
                    new RazorTemplate(Templates.ExampleAppFileUpload, Resources.ExampleFileUpload_cshtml)
                };
            }
        }

        public override void Initialise()
        {
            if (m_LoadModel != null)
            {
                if(m_LoadModel.EventTrace != null)
                {
                    Core.Instance.EventTrace.Update(m_LoadModel.EventTrace);
                }
                m_LoadModel = null;
            }
        }

        public override Subscription[] Subscriptions
        {
            get
            {
                return Core.Instance.Subscriptions();
            }
        }

        public void Load(Models.Load.Root theLoadModel)
        {
            m_LoadModel = theLoadModel;
        }

        public override object Save()
        {
            return Core.Instance;
        }
    }
}
