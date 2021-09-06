using System.Runtime.Serialization;
using MultiPlug.Base;
using MultiPlug.Base.Exchange;

namespace MultiPlug.Ext.Demo.Models.Properties
{
    public class ThreadExceptionProperties : MultiPlugBase
    {
        [DataMember]
        public EventExternal Event { get; set; }

        [DataMember]
        public Subscription Subscription { get; set; }
    }
}
