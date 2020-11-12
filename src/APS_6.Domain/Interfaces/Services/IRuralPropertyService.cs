using APS_6.Domain.Entities;
using System.Collections.Generic;

namespace APS_6.Domain.Interfaces.Services
{
    public interface IRuralPropertyService
    {
        void PostRuralProperty(RuralProperty ruralProperty);
        void PutRuralProperty(RuralProperty ruralProperty);
        IEnumerable<RuralProperty> GetAllRuralProperty();
        RuralProperty GetPRuralPropertyByName(string name);
    }
}
