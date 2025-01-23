using flight_app.Models;

namespace flight_app.Interfaces
{
    public interface IDiscountCriteria
    {
        bool IsApplicable(FlightPrice flightPrice, Passenger passenger, DateTime bookingDate);
        decimal ApplyDiscount(decimal currentPrice);
    }
}
