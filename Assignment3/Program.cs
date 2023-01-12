using addressbook;
namespace Assignment3
{
    class programm
    {
        static void Main(string[] args)
        {

            string firstName = string.Empty;
            string lastName = string.Empty;
            string email = string.Empty;
            int phoneNumber = 0;

            Console.Write("please enter your firstname:");
            firstName = Console.ReadLine();
            Console.Write("please enter your lastname:");
            lastName = Console.ReadLine();
            Console.Write("please enter your email:");
           email = Console.ReadLine();
            Console.Write("please enter your phonenumber:");
            phoneNumber = Convert.ToInt32(Console.ReadLine());


            contact cont = new contact(firstName,lastName,email,phoneNumber);
            cont.FirstName =firstName;
            cont.LastName = lastName;
            cont.Email = email;
            cont.PhoneNumber = phoneNumber;


            addressbookapp address = new addressbookapp();
            address.AddContact(cont);
            Console.WriteLine(address);

            address.RemoveContact(cont);
            Console.WriteLine(address);
        }
    }

   
}