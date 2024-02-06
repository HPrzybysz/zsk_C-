using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1_dziedziczenie.classes
{
    internal class Address
    {
        public string city { get; set; }
        public string street { get; set; }
        public string houseNumber { get; set; }
        public string PostalCode { get; set; }

        public Address(string city, string street, string houseNumber, string PostalCode)
        {
            this.city = city;
            this.street = street;
            this.houseNumber = houseNumber;
            this.PostalCode = PostalCode;
        }

    }


}
