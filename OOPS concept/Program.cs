
//basic syntax
string firstname = string.Empty;
string lastname = string.Empty;
string middlename = string.Empty;
int age = 0;



Console.Write("please enter your firstname:");
firstname = Console.ReadLine();
Console.Write("please enter your middlename:");
middlename = Console.ReadLine();
Console.Write("please enter your lastname:");
lastname = Console.ReadLine();
Console.Write("please enter your age:");
age = Convert.ToInt32(Console.ReadLine());

person person = new person();
person.firstname = firstname;
person.lastname = lastname;
person.age = age;
//person.SetSalary(salary);

if (string.IsNullOrEmpty(middlename))
{
    Console.WriteLine($"Entered full name is :{person.GetFullName()}");
}
else
{
    Console.WriteLine($"Entered full name is :{person.GetFullName(middlename)}");
}




//Console.WriteLine($"entered fullName is {fullname}");
//Console.WriteLine($"entered age is {age}");

