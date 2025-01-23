namespace flight_app.Models
{
    public class FlightPrice
    {
        public Flight Flight { get; }
        public decimal BasePrice { get; }

        public FlightPrice(Flight flight, decimal basePrice)
        {
            Flight = flight;
            BasePrice = basePrice;
        }
    }
}
