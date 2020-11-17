using APS_6.Domain.Interfaces.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace APS.ClientTest
{
    public partial class frmLogin : Form
    {
        private readonly IUserService _userService;
        private readonly IPesticideService _pesticideService;
        private readonly IRuralPropertyService _ruralPropertyService;
        private readonly ITicketService _ticketService;
        private string fingerPath;

        public frmLogin(IUserService userService, IPesticideService pesticideService,
            IRuralPropertyService ruralPropertyService, ITicketService ticketService)
        {
            InitializeComponent();
            _userService = userService;
            _ticketService = ticketService;
            _ruralPropertyService = ruralPropertyService;
            _pesticideService = pesticideService;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(fingerPath))
            {
                var user = _userService.Login(txtUserName.Text, txtPassword.Text, fingerPath);

                if (user.Valid)
                {
                    frmMenu menu = new frmMenu(user, this, _userService, _ticketService, _ruralPropertyService, _pesticideService);
                    menu.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show($@"Um erro ocorreu: {user.Notifications.FirstOrDefault().Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSelectFingerprint_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"; ;
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() == DialogResult.OK)
                fingerPath = fileDialog.FileName;
        }
    }
}
