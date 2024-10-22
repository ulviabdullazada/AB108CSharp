using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static.Extension
{
    static class StringExtension
    {
        public static string ToCapitalize(this string text)
        {
            return Char.ToUpper(text[0]) + text.Substring(1).ToLower();
        }
    }
}
