using APS_6.Domain.Entities;
using APS_6.Domain.Interfaces.Repository;
using APS_6.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace APS_6.Domain.Services
{
    public class RuralPropertyService : IRuralPropertyService
    {
        private readonly IRuralPropertyRepository _ruralPropertyRepository;

        public RuralPropertyService(IRuralPropertyRepository ruralPropertyRepository)
        {
            _ruralPropertyRepository = ruralPropertyRepository;
        }

        public IEnumerable<RuralProperty> GetAllRuralProperty()
            => _ruralPropertyRepository.GetAllRuralProperty();

        public RuralProperty GetRuralPropertyByName(string name)
            => _ruralPropertyRepository.GetRuralPropertyByName(name);

        public void PostRuralProperty(RuralProperty ruralProperty)
            => _ruralPropertyRepository.PostRuralProperty(ruralProperty);

        public void PutRuralProperty(RuralProperty ruralProperty)
            => _ruralPropertyRepository.PutRuralProperty(ruralProperty);
    }
}
