for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"inside loop{i}");

}
Console.WriteLine();
Console.WriteLine("forloop exited");

int n = 10;
while (n < 5)
{
    Console.Write("enter the value for n:");
    n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"inside while loop {n}");
}
Console.WriteLine();
Console.WriteLine("whileloop exited");

int j = 10;
do
{
    Console.Write("enter the value for j:");
    j = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"inside while loop {j}");
} while (j < 5);
Console.WriteLine();
Console.WriteLine("dowhileloop exited");

