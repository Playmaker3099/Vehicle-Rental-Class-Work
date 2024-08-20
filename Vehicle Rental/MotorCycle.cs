using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental
{
    public class MotorCycle : Vehicle
    {
        public bool hasSideCar { get; set; }

        public MotorCycle(string make, string model, decimal rentalprice, bool hasSidecar) : 
            base(make, model, rentalprice) 
        {
            hasSideCar = hasSidecar;

            if (hasSidecar) 
            {
                hasSidecar = true;
            }
        }

        public override decimal CalculateRentalFee(int days)
        {
            return RentalPrice * days * 0.8m; //Discount for motorcycle
        }
    }
}
