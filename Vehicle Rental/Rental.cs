using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental
{
    public class Rental
    {
        public Customer Customer { get; set; }
        public Vehicle Vehicle { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime ReturnDate { get; set; }

        public Rental(Customer cutsomer, Vehicle vehicle, DateTime rentaldate, DateTime returndate)
        {
            Customer = cutsomer;
            Vehicle = vehicle;
            RentalDate = rentaldate;
            ReturnDate = returndate;
        }

        public decimal GetTotalRentalFee() 
        {
            int rentalDays = (RentalDate - ReturnDate).Days;
            return Vehicle.CalculateRentalFee(rentalDays);
        }
    }
}
