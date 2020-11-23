using Flunt.Validations;
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

            Validate();
        }

        private void Validate()
        {
            AddNotifications(new Contract()
                .Requires()
                .HasExactLengthIfNotNullOrEmpty(State, 2, "State", "O estado deve ser apenas a sigla de dois digitos")
                .HasMaxLen(CompanyName, 50, "CompanyName", "O nome da propriedade deve ter no máximo 50 caracteres")
                .HasMaxLen(Street, 50, "Street", "A rua deve ter no máximo 50 caracteres")
                .HasMaxLen(District, 50, "District", "O bairro deve ter no máximo 50 caracteres")
                .HasMaxLen(City, 30, "City", "O nome da cidade deve ter no máximo 30 caracteres")
            );
        }

        private RuralProperty()
        { }

        public string CompanyName { get; private set; }
        public string Street { get; private set; }
        public int BuildingNumber { get; private set; }
        public string District { get; private set; }
        public string PostalCode { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public ICollection<PesticideRuralProperty> PesticideRuralProperties { get; private set; }
        public ICollection<Ticket> Tickets { get; private set; }

        public void AddTicket(Ticket ticket)
        {
            Tickets.Add(ticket);
            AddNotifications(ticket);
        }
    }
}
