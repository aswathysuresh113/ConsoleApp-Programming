int num1 = 11;
int num2 = 12;
Console.WriteLine($"addition :{num1 + num2}");
Console.WriteLine($"subtraction :{num1 - num2}");
Console.WriteLine($"division :{num1 * num2}");
Console.WriteLine($"multiplication :{num1 / num2}");
Console.WriteLine($"modulus :{num1 % num2}");
num1 = num1 + 4;
Console.WriteLine($"New value for num1 is:{num1}");
Console.WriteLine($"addition :{num1 + num2}");
Console.WriteLine($"subtraction :{num1 - num2}");
Console.WriteLine($"division :{num1 * num2}");
Console.WriteLine($"multiplication :{num1 / num2}");
Console.WriteLine($"modulus :{num1 % num2}");

num1 += 4;
Console.WriteLine($"New value for num1 after += :{num1}");
num1 -= 4;
Console.WriteLine($"New value for num1 after -= :{num1}");
num1 *= 4;
Console.WriteLine($"New value for num1 after *= :{num1}");
num1 /= 4;
Console.WriteLine($"New value for num1 after /= :{num1}");

