using flight_app.Interfaces;

namespace flight_app.Models.Tenants
{
    public class TenantB : Tenant
    {
        public TenantB(string name) : base(name) { }

        public override void RecordAppliedDiscounts(Passenger passenger, List<IDiscountCriteria> appliedCriterias)
        {
            // Do not record discounts as per Tenant B requirements
        }
    }
}
