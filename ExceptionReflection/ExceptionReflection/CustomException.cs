using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionReflection
{
    class CustomException : Exception
    {
        public CustomException() : base("Xeta bash verdi") { }
        public CustomException(string message) : base(message) { }
    }
}
