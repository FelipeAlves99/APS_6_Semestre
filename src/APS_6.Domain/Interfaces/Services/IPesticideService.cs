using APS_6.Domain.Entities;
using System.Collections.Generic;

namespace APS_6.Domain.Interfaces.Services
{
    public interface IPesticideService
    {
        void PostPesticide(Pesticide pesticide);
        void PutPesticide(Pesticide pesticide);
        IEnumerable<Pesticide> GetAllPesticides();
        Pesticide GetPesticideByName(string name);
        Pesticide GetPesticidesByCompanyName(string name);
    }
}
