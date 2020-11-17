using APS.Client.PesticideForms;
using APS.Client.PropertyForms;
using APS.Client.TicketForms;
using APS.Client.UserForms;
using APS_6.Domain.Entities;
using APS_6.Domain.Enums;
using APS_6.Domain.Interfaces.Services;
using System;
using System.Windows.Forms;

namespace APS.ClientTest
{
    public partial class frmMenu : Form
    {
        private User _user;
        private frmLogin _frm_Login;
        private readonly IUserService _userService;
        private readonly IPesticideService _pesticideService;
        private readonly IRuralPropertyService _ruralPropertyService;
        private readonly ITicketService _ticketService;

        public frmMenu(User user, frmLogin frm_Login, IUserService userService, ITicketService ticketService,
            IRuralPropertyService ruralPropertyService, IPesticideService pesticideService)
        {
            InitializeComponent();
            _userService = userService;
            _ticketService = ticketService;
            _ruralPropertyService = ruralPropertyService;
            _pesticideService = pesticideService;
            _user = user;
            _frm_Login = frm_Login;
            SetPermissions(_user);
        }

        private void SetPermissions(User user)
        {
            if (user.Permission == EAccessLevel.Reporter)
            {
                btnConsultUser.Enabled = false;
                btnRegisterUser.Enabled = false;
                btnRegisterProperty.Enabled = false;
                btnRegisterPesticide.Enabled = false;
            }

            else if (user.Permission == EAccessLevel.Analyst)
            {
                btnConsultUser.Enabled = false;
                btnRegisterUser.Enabled = false;
            }

            else if (user.Permission == EAccessLevel.Manager)
            {
                btnRegisterPesticide.Enabled = false;
                btnRegisterProperty.Enabled = false;
                btnRegisterTicket.Enabled = false;
            }

            else if (user.Permission == EAccessLevel.None)
            {
                btnRegisterPesticide.Enabled = false;
                btnRegisterProperty.Enabled = false;
                btnRegisterTicket.Enabled = false;
                btnRegisterUser.Enabled = false;
                btnConsultUser.Enabled = false;
                btnConsultPesticide.Enabled = false;
                btnConsultProperty.Enabled = false;
                btnConsultTicket.Enabled = false;
            }
        }

        private void btnLogoff_Click(object sender, EventArgs e)
        {
            this.Close();
            _frm_Login.Show();
        }

        private void btnRegisterUser_Click(object sender, EventArgs e)
        {
            frmRegisterUser frmRegisterUser = new frmRegisterUser(_userService);
            frmRegisterUser.MdiParent = this;
            frmRegisterUser.Show();
        }

        private void btnConsultUser_Click(object sender, EventArgs e)
        {
            frmConsultUser consultUser = new frmConsultUser(_userService);
            consultUser.MdiParent = this;
            consultUser.Show();
        }

        private void btnRegisterProperty_Click(object sender, EventArgs e)
        {
            frmRegisterProperty registerProperty = new frmRegisterProperty();
            registerProperty.MdiParent = this;
            registerProperty.Show();
        }

        private void btnRegisterTicket_Click(object sender, EventArgs e)
        {
            frmRegisterTicket registerTicket = new frmRegisterTicket();
            registerTicket.MdiParent = this;
            registerTicket.Show();
        }

        private void btnRegisterPesticide_Click(object sender, EventArgs e)
        {
            frmRegisterPesticide registerPesticide = new frmRegisterPesticide();
            registerPesticide.MdiParent = this;
            registerPesticide.Show();
        }

        private void btnConsultProperty_Click(object sender, EventArgs e)
        {
            frmConsultProperty consultProperty = new frmConsultProperty();
            consultProperty.MdiParent = this;
            consultProperty.Show();
        }

        private void btnConsultTicket_Click(object sender, EventArgs e)
        {
            frmConsultTicket consultTicket = new frmConsultTicket();
            consultTicket.MdiParent = this;
            consultTicket.Show();
        }

        private void btnConsultPesticide_Click(object sender, EventArgs e)
        {
            frmConsultPesticide consultPesticide = new frmConsultPesticide();
            consultPesticide.MdiParent = this;
            consultPesticide.Show();
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            _frm_Login.Show();
        }
    }
}
