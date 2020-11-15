using APS_6.Domain.Enums;
using System.Collections.Generic;

namespace APS_6.Domain.Entities
{
    public class Pesticide : Entity
    {
        public Pesticide(string name, bool legal, EToxicityLevel toxicLevel,
            ICollection<PesticideRuralProperty> pesticideRuralProperties)
        {
            Name = name;
            Legal = legal;
            ToxicLevel = toxicLevel;
            PesticideRuralProperties = pesticideRuralProperties;
        }

        private Pesticide()
        { }

        public string Name { get; set; }
        public bool Legal { get; set; }
        public EToxicityLevel ToxicLevel { get; set; }
        public ICollection<PesticideRuralProperty> PesticideRuralProperties { get; private set; }
    }
}
