using APS_6.Domain.Entities;
using APS_6.Domain.Interfaces.Repository;
using APS_6.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace APS_6.Domain.Services
{
    public class PesticideService : IPesticideService
    {
        private readonly IPesticideRepository _pesticideRepository;

        public PesticideService(IPesticideRepository pesticideRepository)
        {
            _pesticideRepository = pesticideRepository;
        }

        public IEnumerable<Pesticide> GetAllPesticides()
            => _pesticideRepository.GetAllPesticides();

        public Pesticide GetPesticideByName(string name)
            => _pesticideRepository.GetPesticideByName(name);

        public Pesticide GetPesticidesByCompanyName(string name)
            => _pesticideRepository.GetPesticidesByCompanyName(name);

        public void PostPesticide(Pesticide pesticide)
            => _pesticideRepository.PostPesticide(pesticide);

        public void PutPesticide(Pesticide pesticide)
            => _pesticideRepository.PutPesticide(pesticide);
    }
}
