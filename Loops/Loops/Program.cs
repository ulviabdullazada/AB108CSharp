#region For
//int sum = 0;
//for(int i = 1; i < 6; i++)
//{
//    sum += i;
//}
//Console.WriteLine(sum);
//for(int i = -5; true; i++)
//{
//    if (i % 6 == 0)
//    {
//        Console.WriteLine("Ədəd cütdür");
//        break;
//    }
//    Console.WriteLine(i);
//}
//Console.WriteLine("For bitdi");
#endregion
#region While, Do while
//int i = 0;
//for (; i < 10; i++)
//{
//    Console.WriteLine(i);
//}
//int num = 0;

//Console.WriteLine("Adinizi daxil edin:");
//string name = Console.ReadLine();
//while (name.Any(x=> char.IsDigit(x)))
//{
//    Console.WriteLine("Adinizi daxil edin:");
//    name = Console.ReadLine();
//}
string name = "";
do
{
    Console.WriteLine("Adinizi daxil edin:");
    name = Console.ReadLine();
} while (name.Any(x => char.IsDigit(x)));
Console.WriteLine("Adiniz " + name + " olaraq qeyd olundu.");
#endregion