using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Indexer
{
    class Student
    {
        static int _count;
        public int Id { get; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public Student()
        {
            Id = ++_count;
        }
        public override string ToString()
        {
            return $"{Id}. {Name} {Surname} {Age}";
        }
    }
}
