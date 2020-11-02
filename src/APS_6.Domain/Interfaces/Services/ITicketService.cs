using APS_6.Domain.Entities;
using System;
using System.Collections.Generic;

namespace APS_6.Domain.Interfaces.Services
{
    public interface ITicketService
    {
        Guid PostTicket(Ticket ticket);
        void PatchTicket(Ticket ticket);
        IEnumerable<Ticket> GetAllTickets();
        IEnumerable<Ticket> GetAllTicketsByCompany(Guid companyId);
        Ticket GetAllTicketById(Guid ticketId);
    }
}
