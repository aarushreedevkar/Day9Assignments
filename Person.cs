﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
  public  class Person
    {
        string firstName;
        string lastName;
        string address;
        string city;
        string state;
        string zip;
        string phoneNumber;
        string email;
        internal int PhoneNumber;
        internal string? Email;
        internal string? State;
        internal string? City;
        internal string? Address;
        internal string? LastName;
        internal readonly string FirstName;

        public Person(string firstName, string lastName, string address, string city, string state, string zip, string phoneNumber, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }

        public Person()
        {
        }

        public string getName()
        {
            return this.firstName;
        }
        public string getlastName()
        {
            return this.lastName;
        }
        public string getaddress()
        {
            return this.address;
        }
        public string getcity()
        {
            return this.city;
        }
        public string getstate()
        {
            return this.state;
        }
        public string getzip()
        {
            return this.zip;
        }
        public string getphone()
        {
            return this.phoneNumber;
        }
        public string getemail()
        {
            return this.email;
        }
        public string Tostring()
        {
            return "First Name:" + firstName + "\nLast Name:" + lastName + "\nAddress:" + address + "\nState:" + state + "\nCity:" + city + "\nZip:" + zip + "\nPhoneNumber:" + phoneNumber;
            // return "Name is:" + this.firstName +\n+ this.lastName+
        }

    }











    //public string Email { get; set; }
       // public long PhoneNumber { get; set; }

    }

