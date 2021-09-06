using System;
using System.Threading;
using MultiPlug.Base.Exchange;
using MultiPlug.Ext.Demo.Models.Properties;

namespace MultiPlug.Ext.Demo.Components.Exceptions
{
    public class ThreadExceptionComponent : ThreadExceptionProperties
    {

        public ThreadExceptionComponent()
        {
            var Id = Guid.NewGuid().ToString();

            Event = new Base.Exchange.EventExternal
            {
                Guid = Guid.NewGuid().ToString(),
                Id = Id,
                Description = "Triggers a threaded Event Exception"
            };
            Subscription = new Base.Exchange.Subscription
            {
                Guid = Guid.NewGuid().ToString(),
                Id = Id
            };

            Subscription.Event += OnEvent;
        }

        private void OnEvent(SubscriptionEvent obj)
        {
            new System.Threading.Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                throw new Exception();
            }).Start();
        }
    }
}
