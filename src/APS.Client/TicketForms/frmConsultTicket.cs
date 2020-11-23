using APS_6.Domain.Entities;
using APS_6.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace APS.Client.TicketForms
{
    public partial class frmConsultTicket : Form
    {
        private ITicketService _ticketService;
        private IEnumerable<Ticket> _ticketList;
        public frmConsultTicket(ITicketService ticketService)
        {
            InitializeComponent();
            _ticketService = ticketService;
        }

        private void frmConsultTicket_Load(object sender, EventArgs e)
        {
            _ticketList = _ticketService.GetAllTickets();
            dgvTickets.DataSource = _ticketList;
        }
    }
}
