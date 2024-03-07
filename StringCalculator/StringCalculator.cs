using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace StringCalculator
{
    public class StringCalculator
    {
        public static int Parse(string str)
        {

            str=str.Replace(" ", "");
            var parts = str.Split(',');
            return parts.Select(int.Parse).Sum();
        }
    }
}
