using System.Runtime.Serialization;
using MultiPlug.Base.Exchange;
using MultiPlug.Ext.Demo.Components.Timer;
using MultiPlug.Ext.Demo.Components.Exceptions;
using MultiPlug.Ext.Demo.Components.EventTrace;
using MultiPlug.Ext.Demo.Components.Ping;
using System;

namespace MultiPlug.Ext.Demo
{
    public class Core
    {
        private static Core m_Instance = null;

        private TimerComponent Timer = new TimerComponent();
        public ThreadExceptionComponent ThreadException = new ThreadExceptionComponent();
        private PingComponent m_PingComponent = new PingComponent();

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

        private Core()
        {
        }

        public Event[] Events()
        {
            return new Event[]
            {
                Timer.Properties.Start,
                Timer.Properties.Stop,
                m_PingComponent.Event
            };
        }

        internal void Initialise()
        {
            m_PingComponent.Initialise();
        }

        internal void Start()
        {
            m_PingComponent.Start();
        }

        public EventExternal[] EventsExternal()
        {
            return new EventExternal[]
            {
                Timer.Properties.Start,
                Timer.Properties.Stop
            };
        }
    }
}
