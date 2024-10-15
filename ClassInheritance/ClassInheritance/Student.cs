using System.Globalization;

namespace ClassInheritance
{
    //Inheritance
    class Student : Person
    {
        public string Code;
        public University University;
        public float[] Grades;
        //base - miras alınan classı-ı bildirir
        public Student(string Name, string surname, 
            int age, string code, University uni) : base(Name, surname,age)
        {
            Code = code;
            University = uni;
            Grades = new float[10];
        }
        public void PrintInfo()
        {
            Console.WriteLine($"{Name} {Surname} {Age} {Code} {University}");
        }
        public float Overall()
        {
            float sum = 0;
            foreach (var grade in Grades)
            {
                sum += grade;
            }
            return sum / Grades.Length;
        }
        public void Test()
        {
            base.PrintInfo();
        }
    }
}
