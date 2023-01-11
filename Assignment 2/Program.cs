//writing a program for an ATM machine.

int amount = 10000;
int pin = 9876;
int cardNumber = 12345;
Boolean input = false;

Console.WriteLine("Welcome to the ATM Transactions.");
Console.WriteLine("Enter the 5 digit card number");
int cardNumber1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your pin");
int pin1 = Convert.ToInt32(Console.ReadLine());

if (cardNumber == cardNumber1 && pin1 == pin)
{
    Console.WriteLine("1.To check balance");
    Console.WriteLine("2.To withdraw money");
    Console.WriteLine("3.To deposit Money");
    Console.WriteLine("4.Quit the transaction ");
    Console.WriteLine("Enter your choice");
    int options = Convert.ToInt32(Console.ReadLine()); ;
    switch (options)
    {
        case 1:
            Console.WriteLine($"The current balance in your account is : {amount}");
            break;

        case 2:
            {
                Console.WriteLine("Enter the amount to withdraw");
                int x = Convert.ToInt32(Console.ReadLine());
                if (amount >= x)
                {
                    if (x % 100 == 0 || x % 200 == 0 || x % 500 == 0)
                    {
                        Console.WriteLine($"Please collect the cash{x}");
                        int newBalance = amount - x;
                        Console.WriteLine($"The current balance is now is :{newBalance}");
                    }
                    else
                        Console.WriteLine("Please enter the amount to withdraw in the multiples of 100 ,200,500");
                }
                else
                    Console.WriteLine("Your account does not have sufficient balance");
            }

            break;

        case 3:
            Console.WriteLine("Enter the amount to be deposit");
            int a = Convert.ToInt32(Console.ReadLine());
            int newDeposit = amount + a;
            Console.WriteLine($"The current balance in the account is: {newDeposit}");
            break;
        case 4:
            Console.WriteLine($"Do you wants to quit the transaction:");
            input = Convert.ToBoolean(Console.ReadLine());
            if (input == true)
            {
                Console.WriteLine("Thanks for using our Services");
            }
            break;
        default:
            Console.WriteLine("Please select correct options");
            break;
    }
}
else
    Console.WriteLine("Entered cardnumber or pin is incorrect. Please check and try again");




