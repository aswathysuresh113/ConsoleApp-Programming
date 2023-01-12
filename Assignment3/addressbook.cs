using addressbook;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class addressbookapp
    {
        private Hashtable addressBook = new Hashtable();
        public void AddContact(contact contact)
        {
            addressBook.Add(contact.FirstName,contact);
            addressBook.Add(contact.LastName, contact);
            addressBook.Add(contact.Email, contact);
            addressBook.Add(contact.PhoneNumber, contact);
        }
        public void RemoveContact(contact contact)
        {
            addressBook.Remove(contact.FirstName);
            addressBook.Remove(contact.LastName);
            addressBook.Remove(contact.Email);
            addressBook.Remove(contact.PhoneNumber);
        }
      
            
    
    }
}
