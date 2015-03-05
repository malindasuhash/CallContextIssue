using System.Runtime.Remoting.Messaging;

namespace CallContextNotWorking
{
    public class CallContextWrapper
    {
        public static void Set<T>(string key, T data) where T : class
        {
            CallContext.LogicalSetData(key, data);
        }

        public static T Get<T>(string key) where T : class
        {
            var ctx = CallContext.LogicalGetData(key) as T;

            return ctx;
        }

        public static void Clear(string key)
        {
            CallContext.FreeNamedDataSlot(key);
        }
    }
}