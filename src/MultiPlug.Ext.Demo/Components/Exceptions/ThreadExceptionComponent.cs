using System;
using System.Threading;
using MultiPlug.Ext.Demo.Models.Properties;

namespace MultiPlug.Ext.Demo.Components.Exceptions
{
    public class ThreadExceptionComponent : ThreadExceptionProperties
    {

        public ThreadExceptionComponent()
        {
        }

        internal void InvokeException()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                Thread.Sleep(1000);
                throw new Exception("Unhandled Exception started by user");
            }).Start();
        }
    }
}
