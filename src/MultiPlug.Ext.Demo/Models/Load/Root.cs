using System.Runtime.Serialization;
using MultiPlug.Ext.Demo.Models.Components.EventTrace;

namespace MultiPlug.Ext.Demo.Models.Load
{
    public class Root
    {
        [DataMember]
        public EventTraceProperties EventTrace { get; set; }
    }
}
