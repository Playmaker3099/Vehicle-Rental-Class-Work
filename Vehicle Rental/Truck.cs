using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental
{
    public class Truck : Vehicle
    {
        public int CargoCapacity { get; set; }

        public Truck(string make, string model, decimal rentalprice, bool isRented, int cargocapcity) :
            base(make, model, rentalprice)
        {
            CargoCapacity = cargocapcity;
        }

        public override decimal CalculateRentalFee(int days)
        {
            return RentalPrice * days * 1.2m; //Extra charge for trucks
        }
    }
}
