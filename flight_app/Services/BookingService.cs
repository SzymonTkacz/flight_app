using flight_app.Models.Tenants;
using flight_app.Models;

namespace flight_app.Services
{
    public class BookingService
    {
        private readonly DiscountEngine _discountEngine;
        private readonly Tenant _tenant;

        public BookingService(DiscountEngine discountEngine, Tenant tenant)
        {
            _discountEngine = discountEngine;
            _tenant = tenant;
        }

        public decimal BookFlight(FlightPrice flightPrice, Passenger passenger, DateTime bookingDate)
        {
            var (finalPrice, appliedCriterias) = _discountEngine.ApplyDiscounts(flightPrice, passenger, bookingDate);

            _tenant.RecordAppliedDiscounts(passenger, appliedCriterias);

            return finalPrice;
        }
    }
}
