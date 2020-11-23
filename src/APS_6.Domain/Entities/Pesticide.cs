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

        public string Name { get; private set; }
        public bool Legal { get; private set; }
        public EToxicityLevel ToxicLevel { get; private set; }
        public ICollection<PesticideRuralProperty> PesticideRuralProperties { get; private set; }

        public void UpdateName(string name)
            => Name = name;

        public void UpdateLegal(bool legal)
            => Legal = legal;

        public void UpdateToxicityLevel(EToxicityLevel eToxicityLevel)
            => ToxicLevel = eToxicityLevel;
    }
}
