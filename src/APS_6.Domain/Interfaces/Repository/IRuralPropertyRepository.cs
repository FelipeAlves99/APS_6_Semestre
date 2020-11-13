using APS_6.Domain.Entities;
using System.Collections.Generic;

namespace APS_6.Domain.Interfaces.Repository
{
    public interface IRuralPropertyRepository
    {
        void PostRuralProperty(RuralProperty ruralProperty);
        void PutRuralProperty(RuralProperty ruralProperty);
        IEnumerable<RuralProperty> GetAllRuralProperty();
        RuralProperty GetRuralPropertyByName(string name);
    }
}
