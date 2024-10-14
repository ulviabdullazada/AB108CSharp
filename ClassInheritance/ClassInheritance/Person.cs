namespace ClassInheritance
{
    class Person
    {
        //class members - field, property, method, indexer
        //fields
        public string Name;
        public string Surname = "XXX";
        public int Age = 0;
        //this keyword-u yazilan classi geri qaytarir.
        public Person()
        {
            
        }
        public Person(string name, string surname)
            : this(name)
        {
            this.Surname = surname;
        }
        public Person(string name)
        {
            if (name.Length < 3 || name.Length > 20)
                return;
            this.Name = name;
        }
        public Person(string name, string surname, int age = 17)
            :this(name, surname)
        {
            Age = age;
        }
        //methods
        public void PrintInfo()
        {
            Console.WriteLine($"{Name} {Surname} {Age}");
        }
    }
}
