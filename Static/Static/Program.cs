using Static.Extension;
using Static.Models;

namespace Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Sealed
            //Teacher t = new Teacher();
            //Student s = new Student();
            //s.Salam();
            #endregion
            #region Static
            //Human.SayHi();
            //Human.SayHi();
            //Human.SayHi();
            //Human.SayHi();
            //Human h = new Human();
            //h.Jump();
            //h.Jump();
            //h.Jump();
            //h.Jump();
            //Human h1 = new Human();
            //Human h2 = new Human();
            //Human h3 = new Human();
            //Circle c = new Circle(7);
            //Console.WriteLine();
            //c.PrintArea();
            #endregion
            #region Extension
            //string text = "sAlAm DunYa";
            //Console.WriteLine(text.ToLower());
            //Console.WriteLine(text.ToUpper());
            //Console.WriteLine(text.ToCapitalize());
            //Console.WriteLine(StringExtension.ToCapitalize(text));
            //int a = 2;
            //NumberExtension.Power(a, 5);
            //Console.WriteLine(2.Power(5));
            #endregion
            #region Struct
            ClassA cA;
            //cA.x = 22;

            StructA sA = new();
            //sA.x = 7;
            //Console.WriteLine(sA.x);
            #endregion
        }
    }
    class ClassA
    {
        public int x;
        public ClassA()
        {
            
        }
    }
    struct StructA
    {
        //public int x;
        public int A { get; set; }
        public string B { get; set; }
        public StructA(int a, string b)
        {
            A = a;
            B = b;
        }
    }
}
