using APS_6.Domain.Entities;
using System.Collections.Generic;

namespace APS_6.Domain.Interfaces.Repository
{
    public interface IPesticideRepository
    {
        void PostPesticide(Pesticide pesticide);
        void PutPesticide(Pesticide pesticide);
        IEnumerable<Pesticide> GetAllPesticides();
        Pesticide GetPesticideByName(string name);
        Pesticide GetPesticidesByCompanyName(string name);
    }
}
