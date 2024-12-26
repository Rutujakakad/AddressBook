// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
namespace AddressBook
{
    class AddressBookMain
    {
        static void Main(string[] args)
        {

            AddressBook address = new AddressBook();
            Contact newContact = new Contact();

            Console.WriteLine("\nAddress Book Menu:");
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. Edit Contact");
            Console.WriteLine("3. Delete Contact");
            Console.WriteLine("4. Display Contacts");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 0:
                    Console.WriteLine("First Name");
                    newContact.FirstName = Console.ReadLine();
                    Console.WriteLine("Last Name");
                    newContact.LastName = Console.ReadLine();
                    Console.WriteLine("Address");
                    newContact.Address = Console.ReadLine();
                    Console.WriteLine("City");
                    newContact.City = Console.ReadLine();
                    Console.WriteLine("State");
                    newContact.State = Console.ReadLine();
                    Console.WriteLine("Zip");
                    newContact.Zip = Console.ReadLine();
                    Console.WriteLine("PhoneNo");
                    newContact.PhoneNo = Console.ReadLine();
                    Console.WriteLine("Email");
                    newContact.Email = Console.ReadLine();

                    address.AddContacts(newContact);
                    break;
                case 1:
                    Console.Write("Enter the Firsname of contact to edit: ");
                    string editFirstName = Console.ReadLine();
                    Console.Write("Enter the Lastname of contact to edit: ");
                    string editLastName = Console.ReadLine();
                    address.EditContact(editFirstName, editLastName);
                    break;
                case 2:
                    Console.Write("Enter the Firsname of contact to delete: ");
                    string deleteFirstName = Console.ReadLine();
                    Console.Write("Enter the Lastname of contact to delete: ");
                    string deleteLastName = Console.ReadLine();
                    address.EditContact(deleteFirstName, deleteLastName);
                    break;
                case 3:
                    address.DisplayContact();
                    break;


            }
        }
            
    }
}
