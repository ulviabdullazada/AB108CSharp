using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting.Models
{
    internal class Manat
    {
        public float Azn { get; set; }
        public Manat(float azn)
        {
            Azn = azn;
        }
        public static implicit operator Manat(Dollar d)
        {
            return new Manat(d.Usd * 1.7f);
        }

        public static implicit operator Manat(int num) 
            => new Manat(num * 1.7f);

        public static implicit operator Dollar(Manat man)
        {
            Dollar d = new Dollar();
            d.Usd = man.Azn / 1.7f;
            return d;
        }
    }
    class Dollar
    {
        public float Usd { get; set; }
    }
}
