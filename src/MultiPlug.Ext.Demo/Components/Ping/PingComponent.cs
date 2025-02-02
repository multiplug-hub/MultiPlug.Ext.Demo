using MultiPlug.Base;
using MultiPlug.Base.Exchange;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace MultiPlug.Ext.Demo.Components.Ping
{
    public class PingComponent : MultiPlugBase
    {
        public Event Event { get; set; }

        private static System.Timers.Timer aTimer;

        public PingComponent()
        {

            Event = new Base.Exchange.Event
            {
                Guid = Guid.NewGuid().ToString(),
                Id = "Ping"
            };

            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer(1);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = false;
            //aTimer.Enabled = true;

            //  Subscription.Event += OnEvent;
        }

        int count = 0;

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Event.Invoke(new Payload("Ping", new PayloadSubject[] { new PayloadSubject("c", count.ToString()) }));
            count++;

            if (count % 1000 == 0)
            {
                aTimer.Interval = 1000;
            }
            else
            {
                aTimer.Interval = 1;
            }

            aTimer.Enabled = true;
        }

        internal void Initialise()
        {
            count = 0;

            if ( aTimer.Enabled)
            {
                aTimer.Enabled = false;
            }
        }

        internal void Start()
        {
            aTimer.Enabled = true;
        }
    }
}
