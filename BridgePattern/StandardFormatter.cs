using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    public class StandardFormatter : IPrintFormatter
    {      
        public string Format(string key, string value)
        {
            return $"{key}: {value}";
        }
    }
}
