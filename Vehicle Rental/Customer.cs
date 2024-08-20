using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental
{
    public class Customer
    {
        public string Name { get; set; }
        public string LicenseNumber { get; set; }

        public Customer(string name, string liscensenumber)
        { 
            Name = name;
            LicenseNumber = liscensenumber;
        }
        
    }
}
