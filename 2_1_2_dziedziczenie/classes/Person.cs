using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1_dziedziczenie.classes
{
    internal class Person
    {
        public string name { get; set; }
        public string surname { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Address Address { get; set; }

        public byte Age 
        {
            get
            {
                TimeSpan difference = DateTime.Now - DateOfBirth;
                return (byte)(difference.Days / 365.25);
            }
        
        }

        public Person(string name, string surname, DateTime DateOfBirth, Address address)
        {
            this.name = name;
            this.surname = surname;
            this.DateOfBirth = DateTime.Now;
            Address = address;
        }
		
		 public Person(string name, string surname, DateTime DateOfBirth)
        {
            this.name = name;
            this.surname = surname;
            this.DateOfBirth = DateTime.Now;
        }

        public string getFullName ()
        {
            return $"{name} {surname} lat: {Age}";
        }
    }
}
