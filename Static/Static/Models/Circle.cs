using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static.Models
{
    class Circle
    {
        public float R { get; }
        public static float Pi { get; } = 3.14f;
        //public const float Pi = 3.14f;
        public Circle(float r)
        {
            R = r;
        }
        public void PrintArea()
        {
            Console.WriteLine(Pi * R * R);
        }
    }
}
