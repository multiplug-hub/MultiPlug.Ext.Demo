
using System;
using MultiPlug.Base.Exchange;
using MultiPlug.Extension.Core;
using MultiPlug.Ext.Demo.Controllers;
using MultiPlug.Ext.Demo.Properties;
using MultiPlug.Extension.Core.Http;
using MultiPlug.Ext.Demo.Components.SettingsFile;

namespace MultiPlug.Ext.Demo
{
    public class Demo : MultiPlugExtension
    {
        private Models.Load.Root m_LoadModel = null;

        private void SlowReturningFunction(int theDelay)
        {
            if(theDelay == 0)
            {
                return;
            }

            var endTime = DateTime.Now.AddSeconds(theDelay);

            while (true)
            {
                if (DateTime.Now >= endTime)
                    break;
            }
        }

        public Demo()
        {
            var LocalSettings = SettingsFileComponent.Instance.Load();
            SlowReturningFunction(LocalSettings.ConstructorDelay);
            if ( LocalSettings.ConstructorException )
            {
                LocalSettings.ConstructorException = false;
                SettingsFileComponent.Instance.Save(LocalSettings);
                throw new Exception("Constructor Exception");
            }
        }


        public override Event[] Events
        {
            get
            {
                var LocalSettings = SettingsFileComponent.Instance.Load();
                SlowReturningFunction(LocalSettings.EventsDelay);
                if (LocalSettings.EventsException)
                {
                    throw new Exception("Events Exception");
                }

                return Core.Instance.Events();
            }
        }

        public override RazorTemplate[] RazorTemplates
        {
            get
            {
                var LocalSettings = SettingsFileComponent.Instance.Load();
                SlowReturningFunction(LocalSettings.RazorTemplatesDelay);
                if (LocalSettings.RazorTemplatesException)
                {
                    LocalSettings.RazorTemplatesException = false;
                    SettingsFileComponent.Instance.Save(LocalSettings);
                    throw new Exception("RazorTemplates Exception");
                }

                return new RazorTemplate[]
                {
                    new RazorTemplate(Templates.SettingsNavigation, Resources.SettingsNavigation),
                    new RazorTemplate(Templates.SettingsHome, Resources.SettingsHome),
                    new RazorTemplate(Templates.SettingsEventTrace, Resources.SettingsEventTrace),
                    new RazorTemplate(Templates.SettingsExceptions, Resources.SettingsExceptions),
                    new RazorTemplate("Demo-Home" , Resources.Home_cshtml),
                    new RazorTemplate("Demo-Home2", "@model MultiPlug.Base.Http.EdgeApp\r\n<html><body><h1>Demo2</h1></body></html>"),
                    new RazorTemplate("Demo-Projector", Resources.ProjectorApp),
                    new RazorTemplate(Templates.AppEventTrace, Resources.EventTrace_cshtml),
                    new RazorTemplate(Templates.ExampleAppFileUpload, Resources.ExampleFileUpload_cshtml),
                    new RazorTemplate(Templates.ExampleAppRazorError, Resources.RazorError_cshtml)
                };
            }
        }

        public override void Initialise()
        {
            var LocalSettings = SettingsFileComponent.Instance.Load();
            SlowReturningFunction(LocalSettings.InitialiseDelay);
            if (LocalSettings.InitialiseException)
            {
                throw new Exception("Initialise Exception");
            }

            if (m_LoadModel != null)
            {
                if(m_LoadModel.EventTrace != null)
                {
                    Core.Instance.EventTrace.AddSubscriptions(m_LoadModel.EventTrace.Subscriptions);
                }
                m_LoadModel = null;
            }

            Core.Instance.Initialise();
        }

        public override void Start()
        {
            var LocalSettings = SettingsFileComponent.Instance.Load();
            SlowReturningFunction(LocalSettings.StartDelay);
            if (LocalSettings.StartException)
            {
                throw new Exception("Start Exception");
            }

            Core.Instance.Start();
        }


        public override void Pause()
        {
            var LocalSettings = SettingsFileComponent.Instance.Load();
            SlowReturningFunction(LocalSettings.PauseDelay);
            if (LocalSettings.PauseException)
            {
                throw new Exception("Start Exception");
            }
        }

        public override Subscription[] Subscriptions
        {
            get
            {
                var LocalSettings = SettingsFileComponent.Instance.Load();
                SlowReturningFunction(LocalSettings.SubscriptionsDelay);
                if (LocalSettings.SubscriptionsException)
                {
                    throw new Exception("Subscriptions Exception");
                }

                return new Subscription[0];
            }
        }

        public void Load(Models.Load.Root theLoadModel)
        {
            var LocalSettings = SettingsFileComponent.Instance.Load();
            SlowReturningFunction(LocalSettings.LoadDelay);
            if (LocalSettings.LoadException)
            {
                throw new Exception("Load Exception");
            }

            m_LoadModel = theLoadModel;
        }

        public override object Save()
        {
            var LocalSettings = SettingsFileComponent.Instance.Load();
            SlowReturningFunction(LocalSettings.SaveDelay);
            if (LocalSettings.SaveException)
            {
                throw new Exception("Save Exception");
            }

            return Core.Instance;
        }

        public override void Shutdown()
        {
            var LocalSettings = SettingsFileComponent.Instance.Load();
            SlowReturningFunction(LocalSettings.ShutdownDelay);
            if (LocalSettings.ShutdownException)
            {
                throw new Exception("Save Exception");
            }
        }
    }
}
