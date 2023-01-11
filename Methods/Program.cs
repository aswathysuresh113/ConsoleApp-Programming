//Methods
//returnType MethodName(paramType paramName......){}
//with returntypes
//without returntypes

Console.Write("Enter number 1:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number 2:");
int num2 = Convert.ToInt32(Console.ReadLine());

void Add(int a, int b)
{
    Console.WriteLine($"Addition: {a + b}");
}
Add(num1, num2);
Add(1, 3);

int GreaterThan(int a, int b, int c)
{
    int largest = a;
    if (b > largest)
    {
        largest = b;
    }
    if (c > largest)
    {
        largest = c;
    }
    return largest;
}
int largest = GreaterThan(10, 15, 8);
Console.WriteLine($"largest number is :{largest}");

