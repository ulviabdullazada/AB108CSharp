namespace Delegate
{
    public delegate bool Ruslan(int num);
    public delegate void Yazi();
    class Program
    {
        //Func
        //Predicate
        static int[] numbers = [1, 2, 3, 4, 5, 6, 7, 8, 19, 10];
        static void Main(string[] args)
        {
            #region Delegate
            //PrintNumbers(IsDivisible3);
            //PrintNumbers(IsEven);
            //PrintNumbers(IsOdd);
            //Ruslan r = delegate (int num) //Anonym function
            //{
            //    return num % 5 == 0;
            //};
            //Ruslan r = num => num % 5 == 0; //lambda expression | arrow function (js)

            //PrintNumbers(delegate (int num)
            //{
            //    return num % 5 == 0;
            //});
            //PrintNumbers(num => num % 5 == 0);
            //Yazi yazilar = PrintSalam;
            //yazilar += PrintHello;
            //yazilar -= PrintSalam;
            //yazilar += () =>
            //{
            //    Console.WriteLine("AB108");
            //};
            //yazilar = () =>
            //{
            //    Console.WriteLine("AB107");
            //};
            //yazilar();
            #endregion
            List<Student> students = [
            new Student {
                Name = "Ravan",
                Surname = "Bayramov",
                Age = 19
            },
            new Student {
                Name = "Elmin",
                Surname = "Alizada",
                Age = 18
            },
            new Student {
                Name = "Ali",
                Surname = "Jafarzada",
                Age = 21
            },
            new Student {
                Name = "Musa",
                Surname = "Abdullayev",
                Age = 10
            },
            new Student {
                Name = "Huseyn",
                Surname = "Eyvazli",
                Age = 39
            },
            new Student {
                Name = "Farid",
                Surname = "Najafov",
                Age = 22
            }];
            //students.FindAll(x => x.Age > 18).ForEach(x =>
            //{
            //    Console.WriteLine(x.Name + ", " + x.Age);
            //});
            Console.WriteLine(students.TrueForAll(x=> x.Age > 9));
        }
        static void PrintSalam()
        {
            Console.WriteLine("Salam");
        }
        static void PrintHello()
        {
            Console.WriteLine("Hello");
        }
        static void PrintNumbers(Predicate<int> method)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (method(numbers[i]))
                {
                    Console.WriteLine(numbers[i]);
                }
            }
        }
        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
        static bool IsOdd(int number)
        {
            return number % 2 == 1;
        }
        static bool IsDivisible3(int num)
        {
            return num % 3 == 0;
        }
    }
}
