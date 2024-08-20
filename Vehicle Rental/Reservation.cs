using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental
{
    public class Reservation
    {
        public Customer Customer { get; set; }
        public Vehicle Vehicle { get; set; }
        public DateTime ReservationDate {  get; set; }

        public Reservation(Customer customer, Vehicle vehicle, DateTime reservationdate) 
        {
            Customer = customer;
            Vehicle = vehicle;
            ReservationDate = reservationdate;
        }

        public void Display() 
        {
            Console.WriteLine(Customer);
            Console.WriteLine(Vehicle);
            Console.WriteLine(ReservationDate);
        }
    }
}
