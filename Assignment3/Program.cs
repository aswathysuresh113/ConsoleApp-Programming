var addressBook = new AddressBook();


List<Contact> catchedContacts = new List<Contact>();
for (int i = 0; i < 5; i++)
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


    var contact = new Contact(firstName, lastName, email, phoneNumber);
    addressBook.AddContact(contact);
    catchedContacts.Add(contact);

}
Console.WriteLine("Printing Contacts");
addressBook.PrintContacts();

Console.WriteLine("Sorting Contacts");
addressBook.SortContacts();


for (int i = 0; i < 5; i++)
{
    Console.WriteLine("removing contacts" + catchedContacts[i]);
    addressBook.RemoveContact(catchedContacts[i]);
    addressBook.PrintContacts();
}