using System;
using MultiPlug.Base.Http;
using MultiPlug.Base.Attribute;
using MultiPlug.Base.Exchange.API;
using System.Linq;

namespace MultiPlug.Ext.Demo.Controllers.Settings.Notifications
{
    [Route("notifications")]
    public class NotificationsController : SettingsApp
    {
        internal static IMultiPlugServices MultiPlugServices { get; set; }

        public Response Get()
        {
            string[] Notifications = new string[0];

            try
            {
                Notifications = NotificationsList();
            }
            catch (TypeLoadException)
            {
                // Support earlier versions of MultiPlug
            }

            return new Response
            {
                Model = Notifications,
                Template = Templates.SettingsNotifications
            };
        }

        /// <summary>
        /// To Support earlier versions of MultiPlug, wrap this API in a method so the TypeLoadException can be caught 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="type"></param>
        private void NotificationsAdd(string message, string type)
        {
            MultiPlugServices.Notifications.Add(new Notification(message, type));
        }

        /// <summary>
        /// To Support earlier versions of MultiPlug, wrap this API in a method so the TypeLoadException can be caught 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="type"></param>
        private string[] NotificationsList()
        {
            return MultiPlugServices.Notifications.List().Select(Notification => Notification.Id).ToArray();
        }

        public Response Post( string message, string type)
        {
            try
            {
                NotificationsAdd(message, type);
            }
            catch (TypeLoadException)
            {
                // Support earlier versions of MultiPlug
            }

            return new Response
            {
                StatusCode = System.Net.HttpStatusCode.Moved,
                Location = Context.Referrer
            };
        }
    }
}
