using flight_app.Interfaces;

namespace flight_app.Models.Tenants
{
    public class TenantA : Tenant
    {
        public TenantA(string name) : base(name) { }

        public override void RecordAppliedDiscounts(Passenger passenger, List<IDiscountCriteria> appliedCriterias)
        {
            // Record the applied discounts (e.g., log them or save to database)
            Console.WriteLine($"Recording discounts for {passenger.Name}: {string.Join(", ", appliedCriterias.Select(c => c.GetType().Name))}");
        }
    }
}
