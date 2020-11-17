using APS_6.Domain.Entities;
using APS_6.Domain.Enums;
using APS_6.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace APS.Client.UserForms
{
    public partial class frmConsultUser : Form
    {
        private IUserService _userService;
        private Guid _userId;
        private IEnumerable<User> _userList;
        public frmConsultUser(IUserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }

        private void frmConsultUser_Load(object sender, EventArgs e)
        {
            UpdateDataGrid();
            cmbPermission.DataSource = Enum.GetValues(typeof(EAccessLevel));
        }

        private void dgvUserList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvUserList.Rows [e.RowIndex];
                txtUsername.Text = row.Cells [0].Value.ToString();
                txtPassword.Text = row.Cells [1].Value.ToString();
                txtName.Text = row.Cells [2].Value.ToString();
                cmbPermission.SelectedItem = Enum.Parse<EAccessLevel>(row.Cells [3].Value.ToString());
                Guid.TryParse(row.Cells [4].Value.ToString(), out _userId);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnUpdate.Text == "Editar")
            {
                btnUpdate.Text = "Salvar";
                btnDelete.Enabled = false;
                txtName.Enabled = true;
                txtUsername.Enabled = true;
                txtPassword.Enabled = true;
                cmbPermission.Enabled = true;
            }
            else
            {
                var selectedUser = _userList.FirstOrDefault(u => u.Id == _userId);
                selectedUser.UpdateUserName(txtUsername.Text);
                selectedUser.UpdatePassword(txtPassword.Text);
                selectedUser.UpdateName(txtName.Text);
                selectedUser.UpdatePermission(Enum.Parse<EAccessLevel>(cmbPermission.SelectedValue.ToString()));
                _userService.PatchUser(selectedUser);

                UpdateDataGrid();
                btnUpdate.Text = "Editar";
                btnDelete.Enabled = true;
                txtName.Enabled = false;
                txtUsername.Enabled = false;
                txtPassword.Enabled = false;
                cmbPermission.Enabled = false;
            }
        }

        private void UpdateDataGrid()
        {
            _userList = _userService.GetAllUsers();
            dgvUserList.DataSource = _userList;
            dgvUserList.Columns ["Id"].Visible = false;
            dgvUserList.Columns ["Notifications"].Visible = false;
            dgvUserList.Columns ["Invalid"].Visible = false;
            dgvUserList.Columns ["Valid"].Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Admin")
                MessageBox.Show("Impossível deletar o usuário Admin", "Exclusão proibida", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else if (!string.IsNullOrWhiteSpace(_userId.ToString()))
            {
                _userService.DeleteUser(_userId);
                UpdateDataGrid();
            }
        }
    }
}
