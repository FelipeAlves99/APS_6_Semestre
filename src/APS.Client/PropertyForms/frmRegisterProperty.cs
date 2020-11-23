using APS_6.Domain.Entities;
using APS_6.Domain.Interfaces.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace APS.Client.PropertyForms
{
    public partial class frmRegisterProperty : Form
    {
        private IRuralPropertyService _propertyService;
        public frmRegisterProperty(IRuralPropertyService propertyService)
        {
            InitializeComponent();
            _propertyService = propertyService;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                RuralProperty property = new RuralProperty(txtName.Text, txtStreet.Text, int.Parse(txtNumber.Text),
                    txtDistrict.Text, mtbCep.Text, txtCity.Text, txtState.Text, null, null);
                if (property.Valid)
                {
                    _propertyService.PostRuralProperty(property);
                    ClearFields();
                }
                else
                    MessageBox.Show($"O cadstro possui o seguinte erro: {property.Notifications.FirstOrDefault()}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        public void ClearFields()
        {
            txtName.Clear();
            txtDistrict.Clear();
            txtCity.Clear();
            txtNumber.Clear();
            txtState.Clear();
            txtStreet.Clear();
            mtbCep.Clear();
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
