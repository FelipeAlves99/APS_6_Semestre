using System;

namespace APS_6.Domain.Entities
{
    public class PesticideRuralProperty
    {
        public Guid RuralPropertyId { get; private set; }
        public RuralProperty RuralProperty { get; private set; }
        public Guid PesticideId { get; private set; }
        public Pesticide Pesticide { get; private set; }
    }
}
