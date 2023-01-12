//writing a program for an ATM machine.
int amount = 10000;
Console.WriteLine("Enter the 5 digit card number");
int cardNumber1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your pin");
int userPin = Convert.ToInt32(Console.ReadLine());
bool checkcredentials(int cardNumber1 , int userPin)
{
    int pin = 9876;
    int cardNumber = 12345;
    bool input = false;
    if (cardNumber == cardNumber1 && userPin == pin)
    {
        return true;
    }
    else
    {
        Console.WriteLine("Entered cardnumber or pin is incorrect. Please check and try again");
        return false;
    }
}
bool input = checkcredentials(cardNumber1, userPin);

int  Menu(bool input) 
{
    int option =  0;
    if (input == true)
    {
        while (option != 4)
        {
            Console.WriteLine("1.To check balance");
            Console.WriteLine("2.To withdraw money");
            Console.WriteLine("3.To deposit Money");
            Console.WriteLine("4.Quit the transaction");
            Console.WriteLine("Enter your choice");
            option = Convert.ToInt32(Console.ReadLine());
           if (option != 4)
            {
               return option;
            }

        }
            Console.WriteLine("Thanku for using our Service");
    }
    return option;
}
int option = Menu(input);
void Balance()
{
    Console.WriteLine($"The current balance in your account is : {amount}");
}
void Withdraw()
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
void Deposit()
{
    Console.WriteLine("Enter the amount to be deposit");
    int a = Convert.ToInt32(Console.ReadLine());
    int newDeposit = amount + a;
    Console.WriteLine($"The current balance in the account is: {newDeposit}");
}
void CheckOptions(int option)
 {
    
        switch (option)
        {
            case 1:
                Balance();
                break;

            case 2:
                Withdraw();
                break;

            case 3:
                Deposit();
                break;
            default:
                Console.WriteLine("Thankyou");
                break;
        }
}
CheckOptions(option);





