using System;
using System.Runtime.Serialization;

namespace MultiPlug.Ext.Demo.Components.Timer
{
    public class TimerComponent
    {
        private Models.Properties.Timer m_Properties = new Models.Properties.Timer();

        [DataMember]
        public Models.Properties.Timer Properties { get { return m_Properties; } }

        public TimerComponent()
        {
            m_Properties.Start = new Base.Exchange.EventExternal { Guid = Guid.NewGuid().ToString(), Id = "Start-Timer"  };
            m_Properties.Stop = new Base.Exchange.EventExternal { Guid = Guid.NewGuid().ToString(), Id = "Stop-Timer" };

        }

    }
}
