using System.Runtime.Serialization;
using MultiPlug.Base.Exchange;
using MultiPlug.Ext.Demo.Components.Timer;
using MultiPlug.Ext.Demo.Components.Exceptions;
using MultiPlug.Ext.Demo.Components.EventTrace;

namespace MultiPlug.Ext.Demo
{
    public class Core
    {
        private static Core m_Instance = null;

        private TimerComponent Timer = new TimerComponent();
        private EventExceptionComponent m_EventException = new EventExceptionComponent();
        private ThreadExceptionComponent m_ThreadException = new ThreadExceptionComponent();

        [DataMember]
        public EventTraceComponent EventTrace { get; private set; } = new EventTraceComponent();

        public static Core Instance
        {
            get
            {
                if (m_Instance == null)
                {
                    m_Instance = new Core();
                }
                return m_Instance;
            }
        }

        public string EventExceptionId { get { return m_EventException.Event.Id;  } }
        public string ThreadedEventExceptionId { get { return m_ThreadException.Event.Id; } }

        private Core()
        {
        }

        public Event[] Events()
        {
            return new Event[]
            {
                Timer.Properties.Start,
                Timer.Properties.Stop,
                m_EventException.Event,
                m_ThreadException.Event
            };
        }

        public Subscription[] Subscriptions()
        {
            return new Subscription[]
            {
                m_EventException.Subscription,
                m_ThreadException.Subscription
            };
        }

        public EventExternal[] EventsExternal()
        {
            return new EventExternal[]
            {
                Timer.Properties.Start,
                Timer.Properties.Stop,
                m_EventException.Event,
                m_ThreadException.Event
            };
        }
    }
}
