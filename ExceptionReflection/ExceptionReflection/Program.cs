using System.Reflection;

namespace ExceptionReflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exception
            //try
            //{
            //    int number = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(120 / number);
            //    return;
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("0-a bolmek olmaz");
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("Daxil etdiyiniz deyer ya cox boyukdur ya da cox kicikdir");
            //}
            //catch (FormatException)
            //{
            //    throw new Exception();
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Xeta bas verdi");
            //}
            //finally
            //{
            //    Console.WriteLine("En sonda ishleyir");
            //}
            #endregion
            //foreach (var typ in Assembly.GetExecutingAssembly().GetTypes())
            //{
            //    if (typ.Name == "Person")
            //    {
            //        foreach (var member in typ.GetMethods())
            //        {
            //            Console.WriteLine(member.Name);
            //        }
            //    }
            //}
            Person s = new Person();
            var prop = s.GetType().GetField("_age", System.Reflection.BindingFlags.NonPublic
            | System.Reflection.BindingFlags.Instance);
            Console.WriteLine(prop.GetValue(s));
            prop.SetValue(s, 14);
            Console.WriteLine(prop.GetValue(s));
        }
    }
}
