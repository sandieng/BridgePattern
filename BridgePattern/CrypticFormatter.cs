using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    public class CrypticFormatter : IPrintFormatter
    {
        public string Format(string key, string value)
        {
            var charArray = value.ToCharArray();
            Array.Reverse(charArray);
            return $"{key}: {new string (charArray)}";
        }
    }
}
