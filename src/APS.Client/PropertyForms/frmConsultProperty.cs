using APS_6.Domain.Entities;
using APS_6.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace APS.Client.PropertyForms
{
    public partial class frmConsultProperty : Form
    {
        private IRuralPropertyService _propertyService;
        private Guid _propertyId;
        private IEnumerable<RuralProperty> _propertiesList;
        public frmConsultProperty(IRuralPropertyService propertyService)
        {
            InitializeComponent();
            _propertyService = propertyService;
        }

        private void frmConsultProperty_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void UpdateGrid()
        {
            _propertiesList = _propertyService.GetAllRuralProperty();
            dgvProperties.DataSource = _propertiesList;
        }

        private void dgvProperties_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvProperties.Rows [e.RowIndex];
                txtName.Text = row.Cells [0].Value.ToString();
                txtCity.Text = row.Cells [5].Value.ToString();
                txtDistrict.Text = row.Cells [3].Value.ToString();
                txtNumber.Text = row.Cells [2].Value.ToString();
                txtState.Text = row.Cells [6].Value.ToString();
                txtStreet.Text = row.Cells [1].Value.ToString();
                mtbCep.Text = row.Cells [4].Value.ToString();
                Guid.TryParse(row.Cells [9].Value.ToString(), out _propertyId);

                var selectedProperty = _propertiesList.FirstOrDefault(p => p.Id == _propertyId);
                dgvTickets.DataSource = selectedProperty.Tickets;
                dgvPesticides.DataSource = selectedProperty.PesticideRuralProperties.Select(p => p.Pesticide);
            }
        }
    }
}
