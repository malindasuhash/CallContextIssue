namespace CallContextNotWorking
{
    [EndpointBehaviuor]
    public class Service : IService
    {
        private const string LookupKey = "Infomation";

        public string GetPaymentDetails()
        {
            var data = CallContextWrapper.Get<DataItem>(LookupKey);

            if (data != null)
            {
                return "(GetPaymentDetails) CallContext already has \"DataItem\" set!. The value is " + data.Id;
            }

            data = new DataItem() { Id = "GetPaymentDetails" };
            
            CallContextWrapper.Set(LookupKey, data);

            return "OK";
        }

        public string GetCardDetails()
        {
            var data = CallContextWrapper.Get<DataItem>(LookupKey);

            if (data != null)
            {
                return "(GetCardDetails) CallContext already has \"DataItem\" set!. The value is " + data.Id;
            }

            data = new DataItem() { Id = "GetCardDetails" };

            CallContextWrapper.Set(LookupKey, data);

            return "OK";
        }
    }
}
