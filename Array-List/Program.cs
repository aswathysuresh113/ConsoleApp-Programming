//Array
//initialize a fixed size array
using System.ComponentModel.DataAnnotations;

int[] marks = new int[5];
// itreate an array
for (int i = 0; i < marks.Length; i++)
{
    Console.Write("Enter marks:");
    marks[i] = Convert.ToInt32(Console.ReadLine());
}
//print an array element
for (int i = 0; i < marks.Length; i++)
{
    Console.WriteLine(marks[i]);

}
string[] names = new string[] { "aswathy", "anjaly", "divya" };
Console.WriteLine(names[1]);

//list
List<string> devs = new List<string>();
string dev = string.Empty;

while (!dev.Equals("-1"))
{
    Console.WriteLine("enter name of the developer:");
    dev = Console.ReadLine();
    if (dev != string.Empty && !dev.Equals("-1"))
    {
        devs.Add(dev);
    }
}

foreach (string name in devs)
{
    Console.WriteLine(name);
}