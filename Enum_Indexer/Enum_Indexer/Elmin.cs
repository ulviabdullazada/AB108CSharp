using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Indexer
{
    class Elmin
    {
        public int this[int number]
        {
            get => number * number;
        }
    }
}
