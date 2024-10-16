namespace AccessModifiers.Models
{
    class Employee : Person
    {
        public float Salary;
        public Employee()
        {
            Name = "asdasd";
            Surname = "q712736";
            //Age = 123;
            Person p = new Person();
            //p.Name = "123123";
            //p.Surname = "ajsdhajks";
            //p.Age = 123;
        }
    }
}
