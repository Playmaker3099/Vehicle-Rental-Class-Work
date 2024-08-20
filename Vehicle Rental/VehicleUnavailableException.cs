using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental
{
    public class VehicleUnavailableException : Exception
    {
        public VehicleUnavailableException(string message) : base(message) { }
    }
}
