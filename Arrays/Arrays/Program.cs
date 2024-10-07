//int[] numbers = { 2,3,4 };
//numbers[numbers.Length-1];
//for(int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine(numbers[0]);

//}


//int length = int.Parse(Console.ReadLine());
//int[] numbers = new int[length];
//for (int i = 0; i < numbers.Length; i++)
//{
//    numbers[i] = int.Parse(Console.ReadLine());
//}
//Console.WriteLine("----------------------------------------------------------");
//int sum = 0;
//foreach (int number in numbers)
//{
//    sum += number;
//}
//Console.WriteLine(sum);


//for (int i = 0; i < numbers.Length; i++)
//{
//    int number = numbers[i];
//    sum += number;
//}
//Console.WriteLine(sum);


//int[,] numbers =
//{
//    {1, 2},
//    {4, 9},
//    {5, 10}
//};

//for (int i = 0; i < numbers.GetLength(0); i++)
//{
//    for (int j = 0; j < numbers.GetLength(1); j++)
//    {
//        Console.WriteLine(numbers[i,j]);
//    }
//}


int[,] numbers =
{
    {2,4,6,8 }, //0,3
    {1,3,5,7 }, //1,2
    {1,2,3,5 }, //2,1
    {4,6,9,10 } //3,0
};
int sum = 0;
for (int i = 0; i < numbers.GetLength(0); i++)
{
    //                  4          3
    int j = numbers.GetLength(1) - i - 1;
    Console.WriteLine(numbers[i,j]);
}
