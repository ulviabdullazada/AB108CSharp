using AccessModifiers.Models;

namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person p = new Person();
            //p.Age = 123123;
            //p.Surname = "asdasd";

            Human h = new Human();
            h.Name = "Test";
            Console.WriteLine(h.Name);
            //h.SetName("Mahmud");
            //Console.WriteLine(h.GetName());

        }
    }
}
