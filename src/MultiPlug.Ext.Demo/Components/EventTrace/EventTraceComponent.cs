using MultiPlug.Ext.Demo.Models.Components.EventTrace;

namespace MultiPlug.Ext.Demo.Components.EventTrace
{
    public class EventTraceComponent : EventTraceProperties
    {

        public EventTraceComponent()
        {
        }

        internal void Update(EventTraceProperties theEventTraceProperties)
        {
            Subscriptions = theEventTraceProperties.Subscriptions;
        }
    }
}
