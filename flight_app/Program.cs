using flight_app.Interfaces;
using flight_app.Models.Discounts;
using flight_app.Models.Tenants;
using flight_app.Models;
using flight_app.Services;

namespace flight_app
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var flight = new Flight("KLM12345BCA", "Amsterdam", "Africa", new TimeSpan(14, 0, 0), new[] { DayOfWeek.Thursday });
            var flightPrice = new FlightPrice(flight, 30);

            var discountEngine = new DiscountEngine(
            [
                new BirthdayDiscount(),
                new AfricaThursdayDiscount()
            ]);

            var tenantA = new TenantA("Tenant A");
            var tenantB = new TenantB("Tenant B");

            var passenger = new Passenger("John Doe", DateTime.Today);

            var bookingServiceA = new BookingService(discountEngine, tenantA);
            var finalPriceA = bookingServiceA.BookFlight(flightPrice, passenger, DateTime.Today);
            Console.WriteLine($"Final price for Tenant A: {finalPriceA} EUR");

            var bookingServiceB = new BookingService(discountEngine, tenantB);
            var finalPriceB = bookingServiceB.BookFlight(flightPrice, passenger, DateTime.Today);
            Console.WriteLine($"Final price for Tenant B: {finalPriceB} EUR");
        }
    }
}
