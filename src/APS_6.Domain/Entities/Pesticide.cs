namespace APS_6.Domain.Entities
{
    public class Pesticide
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Legal { get; set; }
        public ToxicityLevel ToxicLevel { get; set; }
        public int CompanyId { get; set; }
        public RuralProperty RuralProperty { get; set; }

        public enum ToxicityLevel
        {
            Dangerous,
            High,
            Caution,
            NoRisk,
        }
    }
}
