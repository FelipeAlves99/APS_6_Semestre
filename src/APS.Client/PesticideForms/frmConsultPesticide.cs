using APS_6.Domain.Entities;
using APS_6.Domain.Enums;
using APS_6.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace APS.Client.PesticideForms
{
    public partial class frmConsultPesticide : Form
    {
        private IPesticideService _pesticideService;
        private IEnumerable<Pesticide> _pesticides;
        private Guid _pesticideId;
        public frmConsultPesticide(IPesticideService pesticideService)
        {
            InitializeComponent();
            _pesticideService = pesticideService;
        }

        private void frmConsultPesticide_Load(object sender, EventArgs e)
        {
            _pesticides = _pesticideService.GetAllPesticides();
            cmbIsLegal.DataSource = new List<string>() { "Sim", "Não" };
            cmbToxicity.DataSource = Enum.GetValues(typeof(EToxicityLevel));
            UpdateDataGrid();
        }

        private void dgvPesticides_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvPesticides.Rows [e.RowIndex];
                txtName.Text = row.Cells [0].Value.ToString();
                cmbIsLegal.SelectedItem = row.Cells [1].Value.ToString() == "True" ? "Sim" : "Não";
                cmbToxicity.SelectedItem = Enum.Parse<EToxicityLevel>(row.Cells [2].Value.ToString());
                Guid.TryParse(row.Cells [4].Value.ToString(), out _pesticideId);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnEdit.Text == "Editar")
                {
                    btnEdit.Text = "Salvar";
                    txtName.Enabled = true;
                    cmbIsLegal.Enabled = true;
                    cmbToxicity.Enabled = true;
                }
                else
                {
                    var selectedPesticide = _pesticides.FirstOrDefault(u => u.Id == _pesticideId);
                    selectedPesticide.UpdateName(txtName.Text);
                    selectedPesticide.UpdateLegal(cmbIsLegal.SelectedValue.ToString() == "Sim");
                    selectedPesticide.UpdateToxicityLevel(Enum.Parse<EToxicityLevel>(cmbToxicity.SelectedValue.ToString()));
                    _pesticideService.PutPesticide(selectedPesticide);

                    UpdateDataGrid();
                    btnEdit.Text = "Editar";
                    txtName.Enabled = false;
                    cmbIsLegal.Enabled = false;
                    cmbToxicity.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void UpdateDataGrid()
        {
            _pesticides = _pesticideService.GetAllPesticides();
            dgvPesticides.DataSource = _pesticides;

            dgvPesticides.Columns ["Id"].Visible = false;
            dgvPesticides.Columns ["Notifications"].Visible = false;
            dgvPesticides.Columns ["Invalid"].Visible = false;
            dgvPesticides.Columns ["Valid"].Visible = false;
        }
    }
}
