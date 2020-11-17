using APS_6.Domain.Entities;
using APS_6.Domain.Enums;
using APS_6.Domain.Interfaces.Services;
using System;
using System.Windows.Forms;

namespace APS.Client.UserForms
{
    public partial class frmRegisterUser : Form
    {
        private readonly IUserService _userService;
        public frmRegisterUser(IUserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }

        private void frmRegisterUser_Load(object sender, EventArgs e)
        {
            cmbPermission.DataSource = Enum.GetValues(typeof(EAccessLevel));
        }

        private void btnClear_Click(object sender, EventArgs e)
            => ClearFields();

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var user = new User(txtUsername.Text, txtPassword.Text, txtName.Text, Enum.Parse<EAccessLevel>(cmbPermission.SelectedValue.ToString()));
            _userService.PostUser(user);
            MessageBox.Show("usuário cadastrado", "Cadastro efetuado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearFields();
        }

        private void ClearFields()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtName.Text = "";
        }
    }
}
