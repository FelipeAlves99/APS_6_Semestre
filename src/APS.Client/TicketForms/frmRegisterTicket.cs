using APS_6.Domain.Entities;
using APS_6.Domain.Enums;
using APS_6.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace APS.Client.TicketForms
{
    public partial class frmRegisterTicket : Form
    {
        private ITicketService _ticketService;
        private IRuralPropertyService _ruralPropertyService;
        private Guid _propertyId;
        private IEnumerable<RuralProperty> _propertyList;

        public frmRegisterTicket(ITicketService ticketService, IRuralPropertyService ruralProperty)
        {
            InitializeComponent();
            _ticketService = ticketService;
            _ruralPropertyService = ruralProperty;
            cmbStatus.DataSource = Enum.GetValues(typeof(ETicketStatus));
            mtbStartDate.Text = DateTime.Now.ToString();
            mtbEndDate.Text = DateTime.Now.AddMonths(6).ToString();
            UpdateDataGrid();
        }

        private void UpdateDataGrid()
        {
            _propertyList = _ruralPropertyService.GetAllRuralProperty();
            dgvProperties.DataSource = _propertyList;
            dgvProperties.Columns ["Id"].Visible = false;
            dgvProperties.Columns ["Notifications"].Visible = false;
            dgvProperties.Columns ["Invalid"].Visible = false;
            dgvProperties.Columns ["Valid"].Visible = false;
            dgvProperties.Columns ["Tickets"].Visible = false;
            dgvProperties.Columns ["PesticideRuralProperties"].Visible = false;
        }

        private void btnRegister_Click(object sender, System.EventArgs e)
        {
            try
            {
                var selectedProperty = _propertyList.FirstOrDefault(p => p.Id == _propertyId);
                Ticket ticket = new Ticket(double.Parse(txtValue.Text), txtDescription.Text, selectedProperty);
                selectedProperty.AddTicket(ticket);

                _ruralPropertyService.PutRuralProperty(selectedProperty);
                ClearFields();
                UpdateDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClean_Click(object sender, System.EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtDescription.Clear();
            txtValue.Clear();
        }

        private void dgvProperties_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvProperties.Rows [e.RowIndex];
                Guid.TryParse(row.Cells [9].Value.ToString(), out _propertyId);
            }
        }
    }
}
