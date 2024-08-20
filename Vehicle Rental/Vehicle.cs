using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental
{
    public abstract class Vehicle : IRentable
    {
        public string Model { get; set; }
        public string Make {  get; set; }
        public decimal RentalPrice { get; set; }
        public bool isRented { get; set; }

        public Vehicle(string model, string make, decimal rentalprice) 
        {
            this.Model = model;
            this.Make = make;
            this.RentalPrice = rentalprice;
            isRented = false;
        }

        public void Rent() 
        {
            if (isRented) 
            {
                throw new VehicleUnavailableException($"");
            }

            isRented = true;
        }

        public void Return() 
        {
            if (!isRented) 
            {
                throw new VehicleUnavailableException($"Vehicle is not currently rented");    
            }

            isRented= false;
        }

        public abstract decimal CalculateRentalFee(int days);
    }
}
