using APS_6.Domain.Entities;
using APS_6.Domain.Interfaces.Repository;
using APS_6.Infra.Data.Sql.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace APS_6.Infra.Data.Sql.Repository
{
    public class RuralPropertyRepository : IRuralPropertyRepository
    {
        private readonly APSContext _context;

        public RuralPropertyRepository(APSContext context)
        {
            _context = context;
        }

        public IEnumerable<RuralProperty> GetAllRuralProperty()
            => _context.RuralProperties
                .AsNoTracking()
                .Include(r => r.PesticideRuralProperties)
                .ThenInclude(pr => pr.Pesticide)
                .Include(r => r.Tickets)
                .ToList();

        public RuralProperty GetRuralPropertyByName(string name)
            => _context.RuralProperties
                .AsNoTracking()
                .Include(r => r.PesticideRuralProperties)
                .ThenInclude(pr => pr.Pesticide)
                .Include(r => r.Tickets)
                .FirstOrDefault(p => p.CompanyName == name);

        public void PostRuralProperty(RuralProperty ruralProperty)
        {
            _context.Set<RuralProperty>().Add(ruralProperty);
            _context.SaveChanges();
        }

        public void PutRuralProperty(RuralProperty ruralProperty)
        {
            _context.Attach(ruralProperty);
            _context.Entry(ruralProperty).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
