Console.WriteLine("Enter The number Month [1 - 12]");
int Month = Convert.ToInt32(Console.ReadLine());
switch(Month)
{
    case 1: Console.WriteLine($"The Month {Month} => (January) => 31 days");
        break;
    case 2:
        Console.WriteLine($"The Month {Month} => (February) => 28 days");
        break;
    case 3:
        Console.WriteLine($"The Month {Month} => (March) => 31 days");
        break;
    case 4:
        Console.WriteLine($"The Month {Month} => (April) => 30 days");
        break;
    case 5:
        Console.WriteLine($"The Month {Month} => (May) => 31 days");
        break;
    case 6:
        Console.WriteLine($"The Month {Month} => (June) => 30 days");
        break;
    case 7:
        Console.WriteLine($"The Month {Month} => (July) => 31 days");
        break;
    case 8:
        Console.WriteLine($"The Month {Month} => (August) => 31 days");
        break;
    case 9:
        Console.WriteLine($"The Month {Month} => (September) => 30 days");
        break;
    case 10:
        Console.WriteLine($"The Month {Month} => (October) => 31 days");
        break;
    case 11:
        Console.WriteLine($"The Month {Month} => (November) => 30 days");
        break;
    case 12:
        Console.WriteLine($"The Month {Month} => (December) => 31 days");
        break;
    default: Console.WriteLine("Invalid Number");
        break;
}