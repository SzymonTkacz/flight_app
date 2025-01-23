using flight_app.Interfaces;

namespace flight_app.Models.Tenants
{
    public abstract class Tenant
    {
        public string Name { get; }

        protected Tenant(string name)
        {
            Name = name;
        }

        public abstract void RecordAppliedDiscounts(Passenger passenger, List<IDiscountCriteria> appliedCriterias);
    }
}
