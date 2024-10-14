using static System.Net.Mime.MediaTypeNames;

namespace Methods
{
    internal class Program
    {
        //DRY - Dont repeat yourself
        static void Main()
        {
            //int salary = Convert.ToInt32(Console.ReadLine());
            //float result = Percent(salary, 7.5f);
            //Console.WriteLine(result + salary);
            //Console.WriteLine(Min(12, 19, 11, 12, -13, 14, 16));

            //string result = Substring(endIndex:2);

            //Console.WriteLine(result);
            SayHi();
        }

        //Method signature
        // 1 - Name
        // 2 - Parameter count
        // 3 - Parameter type

        static string SayHi(params string[] names)
        {
            Console.WriteLine(names[0]);
            return names[0];
        }
        static void SayHi(string name = "Ruslan")
        {
            Console.WriteLine($"Salam {name}. {name.Length}");
        }
        static void SayHi()
        {
            Console.WriteLine("Prosta salam");
        }
 


        static string Substring(string text = "Elvin", int startIndex = 0, int endIndex = 4) //Default value
        {
            if (endIndex > text.Length - 1)
            {
                Console.WriteLine("Olmaz");
                return "";
            }
            string result = "";
            for (int i = startIndex; i <= endIndex; i++)
            {
                result += text[i];
            }
            return result;
        }
        static int Min(params int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }
        static float Percent(int number, float percentage)
        {
            return number * percentage / 100;
        }
    }
}
