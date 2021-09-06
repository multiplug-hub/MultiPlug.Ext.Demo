using System.Runtime.Serialization;

namespace MultiPlug.Ext.Demo.Models.Components.EventTrace
{
    public class EventTraceProperties
    {
        [DataMember]
        public string[] Subscriptions { set; get; } = new string[0];
    }
}
