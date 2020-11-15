using System.Collections.Generic;

namespace APS_6.Domain.Entities
{
    public class RuralProperty : Entity
    {
        public RuralProperty(string companyName, string street, int buildingNumber,
            string district, string postalCode, string city, string state,
            ICollection<PesticideRuralProperty> pesticideRuralProperties, ICollection<Ticket> tickets)
        {
            CompanyName = companyName;
            Street = street;
            BuildingNumber = buildingNumber;
            District = district;
            PostalCode = postalCode;
            City = city;
            State = state;
            PesticideRuralProperties = pesticideRuralProperties;
            Tickets = tickets;
        }

        private RuralProperty()
        { }

        public string CompanyName { get; set; }
        public string Street { get; set; }
        public int BuildingNumber { get; set; }
        public string District { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public ICollection<PesticideRuralProperty> PesticideRuralProperties { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
    }
}
