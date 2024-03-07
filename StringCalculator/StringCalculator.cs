using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    public class StringCalculator
    {
        public static int Parse(string str)
        {
            var parts = str.Split(',');
            return int.Parse(parts.First()) + int.Parse(parts.Last());
        }
    }
}
