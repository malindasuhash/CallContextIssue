using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CallContextNotWorking
{
    public class DataItem
    {
        private string _data;
        private bool _initialised;

        public string Id
        {
            get { return _data; }
            set
            {
                if (_initialised)
                {
                    throw new InvalidOperationException(string.Format("Attempt to set Id again!. Id is currently set to {0}", _data));
                }

                _data = value;
                _initialised = true;
            }
        }
    }
}