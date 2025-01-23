using flight_app.Interfaces;

namespace flight_app.Models.Discounts
{
    public class BirthdayDiscount : IDiscountCriteria
    {
        public bool IsApplicable(FlightPrice flightPrice, Passenger passenger, DateTime bookingDate)
        {
            return passenger.DateOfBirth.Date == bookingDate.Date;
        }

        public decimal ApplyDiscount(decimal currentPrice)
        {
            return Math.Max(currentPrice - 5, 20);
        }
    }
}
