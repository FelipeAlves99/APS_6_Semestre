using System;

namespace APS_6.Domain.Entities
{
    public class Tickets
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime DeadlineDate { get; set; }
        public double Value { get; set; }
        public string Description { get; set; }
        public int CompanyId { get; set; }
        public RuralProperty RuralProperty { get; set; }
    }
}
