using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static.Extension
{
    static class NumberExtension
    {
        public static int Power(this int number, int pow)
        {
            int result = 1;
            for (int i = 0; i < pow; i++)
            {
                result *= number;
            }
            return result;
        }
    }
}
