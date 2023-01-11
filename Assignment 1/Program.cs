
//Ask the user to enter two numbers and print their sum and product on screen.

Console.Write("Enter the first number:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the Second number:");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Sum of the two numbers :{num1 + num2}");
Console.WriteLine($"Product of the two numbers:{num1 * num2}");

//Declare 3 variables a, b and c. Get the input from the user for these variables. Implement the equation (((a + b) / c) * a)

Console.Write("Enter the value of a:");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the value of b:");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the value of :c");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"The result of (((a + b) / c) * a) is :{(((a + b) / c) * a)}");

//Fortune game

Random r = new Random();
int x = r.Next(0, 100);
bool GuessedCorrectly = false;
Console.WriteLine("Welcome to Guess the number Game (0-100) with in 5 attempts.");
for (int i = 1; i <= 5; i++)
{
    Console.Write($"Enter your {i} number:");
    int newnumber = Convert.ToInt32(Console.ReadLine());
    if (newnumber == x)
    {
        Console.WriteLine($"Entered number is Correct");
        Console.WriteLine("YOU WIN THE GAME ");
        GuessedCorrectly = true;
        break;
    }
    else if (newnumber >= x)
    {
        Console.WriteLine($"Entered number is greater than original number ");
        GuessedCorrectly = false;
    }
    else if (newnumber <= x)
    {
        Console.WriteLine($"Entered number is less than original number");
        GuessedCorrectly = false;
    }
}
if (GuessedCorrectly == false)
{
    Console.WriteLine("Unfortunately you did not guess it correctly. The correct number is: " + x);
}






