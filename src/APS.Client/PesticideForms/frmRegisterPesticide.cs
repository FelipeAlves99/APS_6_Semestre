using APS_6.Domain.Entities;
using APS_6.Domain.Enums;
using APS_6.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace APS.Client.PesticideForms
{
    public partial class frmRegisterPesticide : Form
    {
        private IPesticideService _pesticideService;

        public frmRegisterPesticide(IPesticideService pesticideService)
        {
            InitializeComponent();
            _pesticideService = pesticideService;
        }

        private void frmRegisterPesticide_Load(object sender, EventArgs e)
        {
            cmbIsLegal.DataSource = new List<string>() { "Sim", "Não" };
            cmbToxicity.DataSource = Enum.GetValues(typeof(EToxicityLevel));
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                var pesticide = new Pesticide(txtName.Text, cmbIsLegal.SelectedIndex.ToString() == "Sim",
                    Enum.Parse<EToxicityLevel>(cmbToxicity.SelectedValue.ToString()), null);
                _pesticideService.PostPesticide(pesticide);
                MessageBox.Show("Pesticida cadastrado", "Cadastro concluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}
