using System;
using MultiPlug.Base.Exchange;
using MultiPlug.Ext.Demo.Models.Properties;

namespace MultiPlug.Ext.Demo.Components.Exceptions
{
    public class EventExceptionComponent : EventExceptionProperties
    {
        public EventExceptionComponent()
        {
            var Id = Guid.NewGuid().ToString();

            Event = new Base.Exchange.EventExternal
            {
                Guid = Guid.NewGuid().ToString(),
                Id = Id,
                Description = "Triggers an Event Exception"
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
            throw new Exception();
        }
    }
}
