namespace flight_app.Models
{
    public class Passenger
    {
        public string Name { get; }
        public DateTime DateOfBirth { get; }

        public Passenger(string name, DateTime dateOfBirth)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
        }
    }
}
