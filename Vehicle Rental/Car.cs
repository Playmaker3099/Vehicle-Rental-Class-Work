using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental
{
    public class Car : Vehicle
    {
        public Car(string make, string model, decimal rentalprice) : base(make, model, rentalprice) { }
        
        public override decimal CalculateRentalFee(int days)
        {
            return RentalPrice * days;
        }
    }
}
