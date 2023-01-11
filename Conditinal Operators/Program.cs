using System.Linq.Expressions;
//if else
Console.Write("Enter number of apples:");
int apples = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number of oranges:");
int oranges = Convert.ToInt32(Console.ReadLine());
if (apples > oranges)
{
    Console.WriteLine("There are more apples than oranges");
}
else if (apples < oranges)
{
    Console.WriteLine("There are more orenges than apples");
}
else
{
    Console.WriteLine("invalid");
}

//switch
Console.Write("Enter your Mark:");
int mark = Convert.ToInt32(Console.ReadLine());

switch (mark)
{
    case int n when (n < 50):
        Console.WriteLine("you are failed");
        break;
    case int n when (n >= 50 && n <= 100):
        Console.WriteLine("you are Passed");
        break;
    default:
        Console.WriteLine("invalid input for mark");
        break;
}

//ternary
var message = apples > oranges ? "we have more apples" : "we have more oranges";
Console.WriteLine(message);
