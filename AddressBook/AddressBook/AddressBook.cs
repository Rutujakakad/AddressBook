using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class AddressBook 
    {
            public List<Contact> contacts = new List<Contact>();
        
        

        public void AddContacts(Contact contact)
        {
            contacts.Add(contact);
            Console.WriteLine("Contacts added to the AddressBook");

        }

       public void EditContact(string firstName, string lastName)
       {
            var contact = contacts.Where( x => x.FirstName == firstName  && x.LastName == lastName).FirstOrDefault();
            if (contact != null)
            {
                Console.WriteLine("Enter new details:");
                Console.Write("Address: ");
                contact.Address = Console.ReadLine();
                Console.Write("City: ");
                contact.City = Console.ReadLine();
                Console.Write("State: ");
                contact.State = Console.ReadLine();
                Console.Write("Zip: ");
                contact.Zip = Console.ReadLine();
                Console.Write("Phone Number: ");
                contact.PhoneNo = Console.ReadLine();
                Console.Write("Email: ");
                contact.Email = Console.ReadLine();
                Console.WriteLine("Contact updated successfully.");
            }
            else
            {
                Console.WriteLine("Contact is not valid");
            }
       }
        public void DeleteContact(string firstName, string lastName)
        {
            var contact = contacts.FirstOrDefault(y => y.FirstName == firstName && y.LastName == lastName);
            if (contact != null)
            {
                contacts.Remove(contact);
                Console.WriteLine("Contact deleted successfully");
            }
        }

        public void DisplayContact()
        {
            if (contacts.Count == 0)
            {
                Console.WriteLine("AddressBook is empty");
            }
            else
            {
                foreach (var contact in contacts)
                {
                    Console.WriteLine(contact);
                }
            }
        }
       
            
            


    }
}
