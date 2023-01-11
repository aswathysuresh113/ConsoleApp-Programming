Console.Write("Enter number 1:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number 2:");
int num2 = Convert.ToInt32(Console.ReadLine());

try
{
    double quotiant = num1 / num2;
    Console.WriteLine($"the result is :{quotiant}");
}
catch (DivideByZeroException e)
{
    Console.WriteLine($"illigel operation performed:{e.Message}");
}
catch (Exception ex)
{
    throw ex;
}
finally
{
    Console.WriteLine("Exited the program");
}