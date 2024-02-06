using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1_dziedziczenie.classes
{
    internal class Teacher : Person
    {
        public List<string> Subjects = new List<string>();

        public Teacher(string name, string surname, DateTime DateOfBirth, Address address, List<string> Subjects) : base(name, surname, DateOfBirth, address)
        {
            Subjects = Subjects;
        }
    }
}
