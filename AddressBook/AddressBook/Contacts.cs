﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class Contact 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address {  get; set; }
        public string City { get; set; }    
        public string State {  get; set; }
        public string Zip {  get; set; }
        public string PhoneNo {  get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"Name: {FirstName} {LastName}, Address: {Address}, City: {City}, State: {State}, Zip: {Zip}, Phone: {PhoneNo}, Email: {Email}";
        }

        
    }
}
