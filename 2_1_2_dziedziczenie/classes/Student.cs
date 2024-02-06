using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1_dziedziczenie.classes
{
    internal class Student : Person
    {

        public string studentNumber { get; set; }
        public Student(string name, string surname, DateTime DateOfBirth, Address address, string studentNumber) : base(name, surname, DateOfBirth, address)
        {
                studentNumber = studentNumber;
            }
        }
}

