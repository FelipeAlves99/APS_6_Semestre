using APS_6.Domain.Entities;
using APS_6.Domain.Interfaces.Repository;
using APS_6.Infra.Data.Sql.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace APS_6.Infra.Data.Sql.Repository
{
    public class PesticideRepository : IPesticideRepository
    {
        private readonly APSContext _context;

        public PesticideRepository(APSContext context)
        {
            _context = context;
        }

        public IEnumerable<Pesticide> GetAllPesticides()
            => _context.Pesticides
                .AsNoTracking()
                .Include(p => p.RuralProperty)
                .ToList();

        public Pesticide GetPesticideByName(string name)
            => _context.Pesticides
                .AsNoTracking()
                .Include(p => p.RuralProperty)
                .FirstOrDefault(p => p.Name == name);

        public Pesticide GetPesticidesByCompanyName(string name)
            => _context.Pesticides
                .AsNoTracking()
                .Include(p => p.RuralProperty)
                .FirstOrDefault(p => p.RuralProperty.CompanyName == name);

        public void PostPesticide(Pesticide pesticide)
        {
            _context.Set<Pesticide>().Add(pesticide);
            _context.SaveChanges();
        }

        public void PutPesticide(Pesticide pesticide)
        {
            _context.Attach(pesticide);
            _context.Entry(pesticide).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
