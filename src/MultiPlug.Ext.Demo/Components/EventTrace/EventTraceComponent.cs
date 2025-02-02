using System.Linq;
using MultiPlug.Ext.Demo.Models.Components.EventTrace;

namespace MultiPlug.Ext.Demo.Components.EventTrace
{
    public class EventTraceComponent : EventTraceProperties
    {

        public EventTraceComponent()
        {
        }

        internal void AddSubscriptions(string[] theSubscriptionIds)
        {
            if(theSubscriptionIds == null)
            {
                return;
            }

            var SubscriptionsList = Subscriptions.ToList();

            foreach ( var SubscriptionId in theSubscriptionIds )
            {
                if( ! SubscriptionsList.Contains( SubscriptionId ) )
                {
                    SubscriptionsList.Add( SubscriptionId );
                }
            }

            Subscriptions = SubscriptionsList.ToArray();
        }

        internal bool RemoveSubscription(string theSubscriptionId)
        {
            if(theSubscriptionId == null)
            {
                return false;
            }

            var SubscriptionsList = Subscriptions.ToList();
            var Result = SubscriptionsList.Remove( theSubscriptionId );
            Subscriptions = SubscriptionsList.ToArray();
            return Result;
        }
    }
}
