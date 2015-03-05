using System;
using System.ServiceModel.Configuration;

namespace CallContextNotWorking
{
    public class BehaviourExtension : BehaviorExtensionElement
    {
        protected override object CreateBehavior()
        {
            return new EndpointBehaviuor();
        }

        public override Type BehaviorType
        {
            get { return typeof(EndpointBehaviuor); }
        }
    }
}