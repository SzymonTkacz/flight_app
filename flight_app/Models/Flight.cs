namespace flight_app.Models
{
    public class Flight
    {
        public string FlightId { get; }
        public string From { get; }
        public string To { get; }
        public TimeSpan DepartureTime { get; }
        public DayOfWeek[] DepartureDays { get; }

        public Flight(string flightId, string from, string to, TimeSpan departureTime, DayOfWeek[] departureDays)
        {
            if (string.IsNullOrWhiteSpace(flightId)) throw new ArgumentException("Flight ID cannot be null or empty.", nameof(flightId));
            FlightId = flightId;
            From = from;
            To = to;
            DepartureTime = departureTime;
            DepartureDays = departureDays;
        }
    }
}
