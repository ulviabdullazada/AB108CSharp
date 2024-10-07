#region Linear search

//string[] students = {
//    "Ilgar",
//    "Sabuhi",
//    "Naciba",
//    "Ruslan",
//    "Selcan",
//    "Rafiga"
//};

//for (int i = 0; i < students.Length; i++)
//{
//    Console.WriteLine(i+1 + ". addim");
//    if (students[i] == "Rafiga")
//    {
//        Console.WriteLine("Element found at " + i + ". index");
//        break;
//    }
//}
#endregion

#region Binary search
int[] numbers = { 2, 4, 7, 11, 16, 22, 29, 35 };
int leftI = 0;
int rightI = numbers.Length;
int search = -100;
//Binary
for (int i = 0; leftI < rightI; i++)
{
    Console.WriteLine(i+1 + ". addim");
    int middleI = (leftI + rightI) / 2;
    if (search == numbers[middleI])
    {
        Console.WriteLine("Element found at " + middleI + ". index");
        break;
    }
    else if(leftI == rightI-1)
    {
        Console.WriteLine("Not found");
        break;
    }
    else if (search > numbers[middleI])
    {
        leftI = middleI;
    }
    else
    {
        rightI = middleI;
    }
}
Console.WriteLine("------------------------------------");
//Linear
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(i + 1 + ". addim");
    if (numbers[i] == search)
    {
        Console.WriteLine("Element found at " + i + ". index");
        break;
    }
}
#endregion