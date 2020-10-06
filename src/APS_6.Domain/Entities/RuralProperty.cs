using System.Collections.Generic;

namespace APS_6.Domain.Entities
{
    public class RuralProperty
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public List<Pesticide> Pesticides { get; set; }
        public List<Address> Addresses { get; set; }
        public List<Ticket> Tickets { get; set; }
    }
}
