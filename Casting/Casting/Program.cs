using Casting.Models;

namespace Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Upcasting, Downcasting
            //Upcasting
            //Animal[] animals = [new Cat(), new Sparrow(), new Shark()];
            //foreach (var anm in animals)
            //{
            //    ////Downcasting
            //    if (anm is Shark newShark)
            //    {
            //        //Shark newShark = (Shark)anm;
            //        newShark.SayMeyxana();
            //    }
            //    //Cat c = (Cat)anm;
            //    Cat c = anm as Cat;
            //    if (c != null)
            //    {
            //        c.InLive();
            //    }
            //}
            //var shark = Convert.ToShark(animals[0]);
            #endregion
            #region Implicit and explicit
            //Dollar dollar = new Dollar();
            //dollar.Usd = 70;
            //Manat manat = dollar;

            //Manat manat1 = new Manat(10);
            //Dollar dollar1 = manat1;

            //Console.WriteLine(dollar.Usd);
            //Dollar dollar = new Manat(50);
            //Manat manat = 100;
            //Console.WriteLine(dollar.Usd);
            #endregion
            #region Boxing, Unboxing
            //int number = int.Parse("123123");
            #endregion  
            #region Operator overloading
            Student std1 = new Student{
                Name = "Ruslan",
                Surname = "Bayramov",
                Age = 19
            };
            Student std2 = new Student
            {
                Name = "Selcan",
                Surname = "Karimli",
                Age = 19
            };
            Console.WriteLine(std1.Name);
            Console.WriteLine(std1 > std2);
            Console.WriteLine(std1.Name);
            //if (std1.Age == std2.Age)
            //{
                
            //}
            #endregion
        }
    }
}
