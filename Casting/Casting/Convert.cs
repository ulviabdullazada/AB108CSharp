using Casting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    static class Convert
    {
        public static Shark ToShark(Animal animal)
        {
            if (animal is Shark)
            {
                return (Shark)animal;
            }
            return null;
        }
    }
}
