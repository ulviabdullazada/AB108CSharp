using System.Text;

namespace RefOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Value and reference types
            //int a = 22;
            //int b = a;
            //b = 15;
            //Console.WriteLine(a);
            //int[] arr = [1,6,9,12];
            //int[] arr2 = arr;
            //arr2[0] = 1000;
            //Console.WriteLine(arr[0]);
            #endregion
            #region Mutable and immutable
            //A obj1 = new A();
            //obj1.x = 22;
            //A obj2 = new A();
            //obj2.x = 22;
            //Console.WriteLine(obj1.x);

            //string name = "S";
            //name += "a";
            //string ad = "Sa";
            //Console.WriteLine(name == ad);

            //Console.WriteLine(obj1 == obj2);
            #endregion
            #region Ref, out, in
            //int number = 100;
            //Square(number);
            //Console.WriteLine(number);
            //string input = Console.ReadLine();
            //bool cavab = int.TryParse(input, out int res);
            //if (cavab)
            //{
            //    Console.WriteLine(res);
            //}
            //else
            //{
            //    Console.WriteLine("Daxil etdiyiniz deyer yalnisdir");
            //}
            //int[] arr = [1, 23, 4, 5];
            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //}
            //Array.Resize(ref arr, 5);
            //Console.WriteLine("-----------------------------------");
            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
            #region StringBuilder
            //string name = "S";
            //name += "a";
            //name += "l";
            //name += "a";
            //name += "m";
            //StringBuilder sb = new StringBuilder();
            //sb.Append("S");
            //sb.Append("a");
            //sb.Append("l");
            //sb.Append("a");
            //sb.Insert(0,"m");
            //sb.Replace("a", "");
            ////sb.Remove(2, 2);
            //Console.WriteLine(sb.ToString());
            //string text = "Salam aleykum. Allah sizi oldursun";
            string code = "1231231";
            Console.WriteLine(code.PadRight(10,'0'));
            
            #endregion
        }
        //static void Square(in int num)
        //{
        //    Console.WriteLine(num * 12);
        //}
    }
    //class A
    //{
    //    public int x;
    //}
}
