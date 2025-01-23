using flight_app.Interfaces;

namespace flight_app.Models.Discounts
{
    public class AfricaThursdayDiscount : IDiscountCriteria
    {
        public bool IsApplicable(FlightPrice flightPrice, Passenger passenger, DateTime bookingDate)
        {
            return flightPrice.Flight.To.Equals("Africa", StringComparison.OrdinalIgnoreCase) &&
                   bookingDate.DayOfWeek == DayOfWeek.Thursday;
        }

        public decimal ApplyDiscount(decimal currentPrice)
        {
            return Math.Max(currentPrice - 5, 20);
        }
    }
}
