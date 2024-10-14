namespace ClassInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Anonymous objects
            //object said = new 
            //{
            //    Name = "Said",
            //    Surname = "Gambarli"
            //};
            //object murad = new
            //{
            //    Name = "Murad",
            //    Surname = "Cavadov"
            //};
            //object huseyn = new
            //{
            //    Ad = "Huseyn",
            //    Age = 19
            //};
            #endregion
            #region Class intro, Fields
            //Person ilqar = new Person
            //{
            //    Name = "Ilqar",
            //    Surname = "Hajizada",
            //    Age = 19
            //};
            //ilqar.PrintInfo();
            //Console.WriteLine("1. " + ilqar.Age);
            //ilqar.Age = 19;
            //Console.WriteLine(". " + ilqar.Age);

            //Person p = new Person();
            //p.Name = Console.ReadLine();
            //p.Surname = Console.ReadLine();
            //p.Age = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Daxil olunan melumatlar :");
            //p.PrintInfo();
            #endregion
            #region Constructor
            //Person selcan = new Person("Selcan");
            //Person rafiga = new Person("Rafiga", "Mirzazada");
            //Person fidan = new Person("Fidan", "Sultanli", 19);
            //selcan.PrintInfo();
            //rafiga.PrintInfo();
            //fidan.PrintInfo();
            #endregion
            #region Inheritance
            University uni = new University
            {
                Name = "AzTU",
                BuiltDate = new DateOnly(1957, 7, 1)
            };      
            University bdu = new University
            {
                Name = "Baku State University"
            };
            Student musa = new Student("Musa", "Abdullayev", 19, "A001", uni); //instance
            Student ali = new Student("Ali", "Jafarzada", 19, "A002", uni);
            Console.WriteLine(ali.University.BuiltDate);
            //musa.Grades[0] = 55;
            //musa.Grades[1] = 66.3f;
            //musa.Grades[2] = 67;
            //musa.Grades[3] = 75;
            //musa.Grades[4] = 90;
            //musa.Grades[5] = 80;
            //musa.Grades[6] = 87;
            //musa.Grades[7] = 41;
            //musa.Grades[8] = 59;
            //musa.Grades[9] = 95;
            //Console.WriteLine(musa.Overall());
            //Console.WriteLine(musa.ToString());
            //musa.PrintInfo();
            #endregion
        }
    }
}
