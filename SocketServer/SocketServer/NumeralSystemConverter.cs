using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SocketServer
{
    class NumeralSystemConverter
    {
        public static string HEXtoDEC(string hexText)
        {
            string[] hexNumbers = hexText.Split(" ");
            IEnumerable<string> decNumbers = hexNumbers.Select(hex => Convert.ToInt32(hex, 16).ToString());
            return String.Join(" ", decNumbers);
        }
    }
}
