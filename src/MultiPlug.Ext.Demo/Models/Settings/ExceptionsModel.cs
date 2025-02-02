
namespace MultiPlug.Ext.Demo.Models.Settings
{
    public class ExceptionsModel
    {
        public bool ConstructorException { get; set; }
        public bool EventsException { get; set; }
        public bool RazorTemplatesException { get; set; }
        public bool InitialiseException { get; set; }
        public bool StartException { get; set; }
        public bool SubscriptionsException { get; set; }
        public bool LoadException { get; set; }
        public bool SaveException { get; set; }
        public bool PauseException { get; set; }
        public bool ShutdownException { get; set; }
        public int ConstructorDelay { get; set; }
        public int EventsDelay { get; set; }
        public int RazorTemplatesDelay { get; set; }
        public int InitialiseDelay { get; set; }
        public int StartDelay { get; set; }
        public int PauseDelay { get; set; }
        public int SubscriptionsDelay { get; set; }
        public int LoadDelay { get; set; }
        public int SaveDelay { get; set; }
        public int ShutdownDelay { get; set; }
    }
}
