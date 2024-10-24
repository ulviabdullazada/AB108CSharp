namespace Enum_Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Enum
            //foreach (var item in Enum.GetValuesAsUnderlyingType(typeof(Roles)))
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Indexer
            //new Object
            //{

            //}.ToString();
            //Group ab108 = new Group(5);
            //Student musa = new Student()
            //{
            //    Name = "Musa",
            //    Age = 20,
            //    Surname = "Abdullayev"
            //};
            //ab108[0] = musa;
            //ab108[1] = new Student
            //{
            //    Name = "Ali",
            //    Surname = "Jafarzada",
            //    Age= 20,
            //};
            //ab108[2] = new Student
            //{
            //    Name = "Elmin",
            //    Surname = "Alizada",
            //    Age = 19,
            //};
            //ab108[3] = new Student
            //{
            //    Name = "Ravan",
            //    Surname = "Bayramov",
            //    Age = 21,
            //};
            //new Student
            //{
            //    Name = "Elxan",
            //    Surname = "Babakishiyev",
            //    Age = 27,
            //};
            //ab108[4] = new Student
            //{
            //    Name = "Farid",
            //    Surname = "Najafov",
            //    Age = 49
            //};

            //Console.WriteLine(ab108["elmin"]);

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(ab108[i]);
            //}
            //Elmin e = new Elmin();
            //Console.WriteLine(e[4]);
            #endregion
            //int? num = null;
            Ruslan(null);
            Ruslan(2);
            Console.Read();
        }
        static void Ruslan(int? num)
        {
            if (num == null)
            {
                Console.WriteLine("Yeke kiwisen duz emelli shey gonder");
            }
            Console.WriteLine(num);

        }
    }
}
