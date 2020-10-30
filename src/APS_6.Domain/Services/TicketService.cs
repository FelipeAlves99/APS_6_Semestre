using APS_6.Domain.Entities;
using APS_6.Domain.Interfaces.Repository;
using APS_6.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace APS_6.Domain.Services
{
    public class TicketService : ITicketService
    {
        private readonly ITicketRepository _ticketRepository;

        public TicketService(ITicketRepository ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }

        public Ticket GetAllTicketById(Guid ticketId)
            => _ticketRepository.GetAllTicketById(ticketId);

        public IEnumerable<Ticket> GetAllTickets()
            => _ticketRepository.GetAllTickets();

        public IEnumerable<Ticket> GetAllTicketsByCompany(Guid companyId)
            => _ticketRepository.GetAllTicketsByCompany(companyId);

        public void PatchTicket(Ticket ticket)
            => _ticketRepository.PatchTicket(ticket);

        public Guid PostTicket(Ticket ticket)
            => _ticketRepository.PostTicket(ticket);
    }
}
