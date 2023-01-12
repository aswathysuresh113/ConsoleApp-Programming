
namespace addressbook
{
    public class contact
    {
        //public  Product(string firstName ,string lastName , char email ,int phoneNumber)
        //{
        //   FirstName = firstName;
        // LastName = lastName;
        //Email = email;
        //PhoneNumber = phoneNumber;
        //}
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public  contact(string firstName ,string lastName , string email ,int phoneNumber)
        {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        PhoneNumber = phoneNumber;
        }

        
    }
}