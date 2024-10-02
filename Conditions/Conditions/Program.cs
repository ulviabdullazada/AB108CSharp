#region If, Else
//int number = int.Parse(Console.ReadLine());
//if(number > 0)
//{
//    if (number % 2 == 0)
//    {
//        Console.WriteLine("Even");
//    }
//    else
//    {
//        Console.WriteLine("Odd");
//    }
//    Console.WriteLine("Positive");

//}
//else if(number == 0)
//{
//    Console.WriteLine("Zero");
//}
//else
//{
//    Console.WriteLine("Negative");
//}
#endregion

#region Switch, case

//int dayOfWeek = int.Parse(Console.ReadLine());
//switch (dayOfWeek)
//{
//	case 1:
//        Console.WriteLine("Monday");
//        break;
//    case 2:
//        Console.WriteLine("Tuesday");
//        break;
//    case 3:
//        Console.WriteLine("Wednesday");
//        break;
//    case 4:
//        Console.WriteLine("Thursday");
//        break;
//    case 5:
//        Console.WriteLine("Friday");
//        break;
//    case 6:
//        Console.WriteLine("Saturday");
//        break;
//    case 7:
//        Console.WriteLine("Sunday");
//        break;
//    default:
//        Console.WriteLine("Input is not valid");
//        break;
//}
//if (dayOfWeek > 0 && dayOfWeek < 8)
//{
//    if (dayOfWeek == 1)
//    {
//        Console.WriteLine("Monday");
//    }
//    else if (dayOfWeek == 2)
//    {
//        Console.WriteLine("Tuesday");
//    }
//    else if (dayOfWeek == 3)
//    {
//        Console.WriteLine("Wednesday");
//    }
//    else if (dayOfWeek == 4)
//    {
//        Console.WriteLine("Thursday");
//    }
//    else if (dayOfWeek == 5)
//    {
//        Console.WriteLine("Friday");
//    }
//    else if (dayOfWeek == 6)
//    {
//        Console.WriteLine("Saturday");
//    }
//    else
//    {
//        Console.WriteLine("Sunday");
//    }
//}
//else
//{
//    Console.WriteLine("Input is not valid");
//}

int number = int.Parse(Console.ReadLine());
switch (number)
{
    case > 15:
        Console.WriteLine("Greater than 15");
        break;
	case > 0:
        Console.WriteLine("Positive");
        break;
    case < 0:
        Console.WriteLine("Negative");
        break;
    default:
        Console.WriteLine("Zero");
		break;
}
#endregion