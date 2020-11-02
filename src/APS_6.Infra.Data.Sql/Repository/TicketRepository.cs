using APS_6.Domain.Entities;
using APS_6.Domain.Interfaces.Repository;
using APS_6.Infra.Data.Sql.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace APS_6.Infra.Data.Sql.Repository
{
    public class TicketRepository : ITicketRepository
    {
        private readonly APSContext _context;

        public TicketRepository(APSContext context)
        {
            _context = context;
        }

        public Ticket GetAllTicketById(Guid ticketId)
            => _context.Tickets
                .AsNoTracking()
                .Include(t => t.RuralProperty)
                .FirstOrDefault(t => t.Id == ticketId);

        public IEnumerable<Ticket> GetAllTickets()
            => _context.Tickets
                .AsNoTracking()
                .Include(t => t.RuralProperty)
                .ToList();

        public IEnumerable<Ticket> GetAllTicketsByCompany(Guid companyId)
            => _context.Tickets
                .AsNoTracking()
                .Where(t => t.CompanyId == companyId)
                .Include(t => t.RuralProperty)
                .ToList();

        public void PatchTicket(Ticket ticket)
        {
            _context.Attach(ticket);
            _context.Entry(ticket).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public Guid PostTicket(Ticket ticket)
        {
            _context.Set<Ticket>().Add(ticket);
            _context.SaveChanges();
            return ticket.Id;
        }
    }
}
