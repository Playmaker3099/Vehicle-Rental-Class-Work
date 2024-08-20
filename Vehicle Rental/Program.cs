using System;
using System.Diagnostics;
using Vehicle_Rental;

public class Program 
{
    public static void Main(string[] args) 
    {
        try
        {
            //to show that a number is a decimal in code is by adding the m eg: 0.5m


            //Create some vehicles
            Vehicle car = new Car("Toyota", "CAMRY", 50m);
            Vehicle truck = new Truck("Ford", "RAPTOR", 70m, true, 1000);
            Vehicle motorcycle = new MotorCycle("Harley-Davidson", "Street 750", 40m, true);

            //Create a customer
            Customer customer = new Customer("John Wick", "D12345678");
            Customer customer1 = new Customer("James Bond", "NUZ795360");
            Customer customer2 = new Customer("Bruce Banner", "SWAY-ZN");

            //Create a reservation
            Reservation reservation = new Reservation(customer, car, DateTime.Now.AddDays(1));
            reservation.Display();

            //Rent a Vehicle
            car.Rent();
            car.isRented = true;
            Rental rental = new Rental(customer, car, DateTime.Now, DateTime.Now.AddDays(3));
            Console.WriteLine($"Total rental fee for {rental.Customer.Name}: {rental.GetTotalRentalFee()}");

            truck.Rent();
            Rental rental1 = new Rental(customer1, truck, DateTime.Now, DateTime.Now.AddDays(5));
            Console.WriteLine($"Car Rentals: ");
            Console.WriteLine($"--------------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"Customer \tVehicle \t\t");
            Console.WriteLine($"Car Rentals: ");
            Console.WriteLine($"Car Rentals: ");
            Console.WriteLine($"Car Rentals: ");
            Console.WriteLine($"Car Rentals: ");




            Customer customer4 = new Customer("Erick", "L76463468");
            Customer customer5 = new Customer("Owami", "L76463468");
            Customer customer6 = new Customer("Erick", "L76463468");
            Customer customer7 = new Customer("Erick", "L76463468");

            string reserverDate1 = DateTime.Now.ToString();
            string reserverDate2 = DateTime.Now.AddDays(3).ToString();
            string reserverDate3 = DateTime.Now.AddDays(5).ToString();

            Reservation reservation1 = new Reservation(customer4, truck, DateTime.Parse(reserverDate1));
            Reservation reservation2 = new Reservation(customer5, car, DateTime.Parse(reserverDate2));
            Reservation reservation3 = new Reservation(customer6, motorcycle, DateTime.Parse(reserverDate3));

            Console.WriteLine($" Vehicle Reservations: ");
            Console.WriteLine($"----------------------------------------------------------------------------------------------");
            Console.WriteLine($" Customer \tVehicle \t\tReservation Date ");
            Console.WriteLine($"----------------------------------------------------------------------------------------------");
            Console.WriteLine($"{}");
            //Return a Vehicle
            car.Return();
        }
        catch (VehicleUnavailableException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (Exception ex) 
        {
            Console.WriteLine($"Unexpected Error: {ex.Message}");
        }
    }
}

