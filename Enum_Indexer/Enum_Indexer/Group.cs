using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Indexer
{
    class Group
    {
        public string Name { get; set; }
        private Student[] Students;
        public Group(int studentCount)
        {
            Students = new Student[studentCount];
        }
        public Student this[int index]
        {
            get => Students[index];
            set
            {
                if (index < 0 || index > Students.Length - 1)
                    return;

                if (value.Age > 14 && value.Age < 36)
                    Students[index] = value;
            }
        }
        public Student this[string name]
        {
            get
            {
                foreach (Student student in Students)
                {
                    if (student.Name.ToLower() == name.ToLower())
                    {
                        return student;
                    }
                }
                return null;
            }
        }
    }
}
