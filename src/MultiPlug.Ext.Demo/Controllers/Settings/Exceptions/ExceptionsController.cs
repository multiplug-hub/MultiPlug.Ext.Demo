using MultiPlug.Base.Attribute;
using MultiPlug.Base.Http;
using MultiPlug.Ext.Demo.Components.SettingsFile;
using MultiPlug.Ext.Demo.Models.Settings;

namespace MultiPlug.Ext.Demo.Controllers.Settings.Exceptions
{
    [Route("exceptions")]
    public class ExceptionsController : SettingsApp
    {
        public Response Get()
        {
            var LocalSettings = SettingsFileComponent.Instance.Load();

            return new Response
            {
                Model = new ExceptionsModel
                {
                    ConstructorException = LocalSettings.ConstructorException,
                    EventsException = LocalSettings.EventsException,
                    RazorTemplatesException = LocalSettings.RazorTemplatesException,
                    InitialiseException = LocalSettings.InitialiseException,
                    StartException = LocalSettings.StartException,
                    SubscriptionsException = LocalSettings.SubscriptionsException,
                    LoadException = LocalSettings.LoadException,
                    SaveException = LocalSettings.SaveException,
                    PauseException = LocalSettings.PauseException,
                    ShutdownException = LocalSettings.ShutdownException,
                    ConstructorDelay = LocalSettings.ConstructorDelay,
                    EventsDelay = LocalSettings.EventsDelay,
                    RazorTemplatesDelay = LocalSettings.RazorTemplatesDelay,
                    InitialiseDelay = LocalSettings.InitialiseDelay,
                    StartDelay = LocalSettings.StartDelay,
                    SubscriptionsDelay = LocalSettings.SubscriptionsDelay,
                    LoadDelay = LocalSettings.LoadDelay,
                    SaveDelay = LocalSettings.SaveDelay,
                    PauseDelay = LocalSettings.PauseDelay,
                    ShutdownDelay = LocalSettings.ShutdownDelay
                },
                Template = Templates.SettingsExceptions
            };
        }

        public Response Post(ExceptionsModel theModel)
        {
            var LocalSettings = SettingsFileComponent.Instance.Load();
            LocalSettings.ConstructorException = theModel.ConstructorException;
            LocalSettings.EventsException = theModel.EventsException;
            LocalSettings.RazorTemplatesException = theModel.RazorTemplatesException;
            LocalSettings.InitialiseException = theModel.InitialiseException;
            LocalSettings.StartException = theModel.StartException;
            LocalSettings.SubscriptionsException = theModel.SubscriptionsException;
            LocalSettings.LoadException = theModel.LoadException;
            LocalSettings.SaveException = theModel.SaveException;
            LocalSettings.PauseException = LocalSettings.PauseException;
            LocalSettings.ShutdownException = LocalSettings.ShutdownException;
            LocalSettings.ConstructorDelay = theModel.ConstructorDelay;
            LocalSettings.EventsDelay = theModel.EventsDelay;
            LocalSettings.RazorTemplatesDelay = theModel.RazorTemplatesDelay;
            LocalSettings.InitialiseDelay = theModel.InitialiseDelay;
            LocalSettings.StartDelay = theModel.StartDelay;
            LocalSettings.SubscriptionsDelay = theModel.SubscriptionsDelay;
            LocalSettings.LoadDelay = theModel.LoadDelay;
            LocalSettings.SaveDelay = theModel.SaveDelay;
            LocalSettings.PauseDelay = LocalSettings.PauseDelay;
            LocalSettings.ShutdownDelay = LocalSettings.ShutdownDelay;

            SettingsFileComponent.Instance.Save(LocalSettings);

            return new Response
            {
                StatusCode = System.Net.HttpStatusCode.Moved,
                Location = Context.Referrer
            };
        }
    }
}
