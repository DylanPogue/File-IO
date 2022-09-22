using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_IO
{
    internal class Address
    {
        //Properties
        public string address { get; init; } = String.Empty;
        public string City { get; init; } = String.Empty;
        public string State { get; init; } = String.Empty;
        public string PostalCode { get; init; } = String.Empty;

        //Constructor
        public Address(string Addr, string city, string state, string postalCode)
        {
            address = Addr;
            City = city;
            State = state;
            PostalCode = postalCode;
        }

        //ToString
        public override string ToString()
        {
            return ($"{address}|{City}|{State}|{PostalCode}");
        }
    }
}
