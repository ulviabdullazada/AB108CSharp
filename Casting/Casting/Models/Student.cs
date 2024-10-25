using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Casting.Models
{
    internal class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public static bool operator ==(Student std1, Student std2)
        {
            return std1.Age == std2.Age && std1.Name == std2.Name;
        }
        public static bool operator !=(Student std1, Student std2)
        {
            return !(std1 == std2);
        }
        public static bool operator ==(Student std1, int num)
        {
            return std1.Age == num;
        }
        public static bool operator !=(Student std1, int num)
        {
            return !(std1 == num);
        }
        public static int operator +(Student std1, Student std2)
        {
            return std1.Age + std2.Age;
        }
        public static bool operator >(Student std1, Student std2)
        {
            //std1.Name = "Sabuhi";
            return std1.Age > std2.Age;
        }
        public static bool operator <(Student std1, Student std2)
        {
            return std1.Age < std2.Age;
        }
        public static Student operator ++(Student std1)
        {
            std1.Age++;
            return std1;
        }
        public static Student operator --(Student std1)
        {
            std1.Age--;
            return std1;
        }
    }
}
