using flight_app.Interfaces;
using flight_app.Models;

namespace flight_app.Services
{
    public class DiscountEngine
    {
        private readonly List<IDiscountCriteria> _discountCriterias;

        public DiscountEngine(IEnumerable<IDiscountCriteria> discountCriterias)
        {
            _discountCriterias = discountCriterias.ToList();
        }

        public (decimal FinalPrice, List<IDiscountCriteria> AppliedCriterias) ApplyDiscounts(FlightPrice flightPrice, Passenger passenger, DateTime bookingDate)
        {
            decimal price = flightPrice.BasePrice;
            var appliedCriterias = new List<IDiscountCriteria>();

            foreach (var criteria in _discountCriterias)
            {
                if (criteria.IsApplicable(flightPrice, passenger, bookingDate))
                {
                    price = criteria.ApplyDiscount(price);
                    appliedCriterias.Add(criteria);
                }
            }

            return (price, appliedCriterias);
        }
    }
}
