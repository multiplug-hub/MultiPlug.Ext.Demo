using System.Runtime.Serialization;
using MultiPlug.Base;
using MultiPlug.Base.Exchange;


namespace MultiPlug.Ext.Demo.Models.Properties
{
    public class Timer : MultiPlugBase
    {
        [DataMember]
        public EventExternal Start { get; set; }

        [DataMember]
        public EventExternal Stop { get; set; }
    }
}
