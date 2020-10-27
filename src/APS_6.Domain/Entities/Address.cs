namespace APS_6.Domain.Entities
{
    public class Address : Entity
    {
        public string Street { get; set; }
        public int BuildingNumber { get; set; }
        public string District { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int CompanyId { get; set; }
        public RuralProperty RuralProperty { get; set; }
    }
}
