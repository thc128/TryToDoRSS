using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BL
{
    public static class Helpers
    {
        public static String RegexRemove(this string input, string pattern) =>
           Regex.Replace(input, pattern, string.Empty);
    }
}
