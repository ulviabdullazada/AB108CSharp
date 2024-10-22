using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static.Models
{
    class Human
    {
        static Human()
        {
            Console.WriteLine("Static ctor");
        }
        public Human()
        {
            Console.WriteLine("Human spawned");
        }
        public void Jump()
        {
            //SayHi();
            Console.WriteLine("Human jumpped");
        }
        public static void SayHi()
        {
            //Jump();
            Console.WriteLine("Salam");
        }
    }
}
