using APS_6.Domain.Interfaces.Services;
using System;
using System.Windows.Forms;

namespace APS.ClientCore
{
    public partial class Form1 : Form
    {
        private readonly IUserService _userService;
        private readonly IPesticideService _pesticideService;
        private readonly IRuralPropertyService _ruralPropertyService;
        private readonly ITicketService _ticketService;

        public Form1(IUserService userService, IPesticideService pesticideService, IRuralPropertyService ruralPropertyService,
            ITicketService ticketService)
        {
            _userService = userService;
            _pesticideService = pesticideService;
            _ruralPropertyService = ruralPropertyService;
            _ticketService = ticketService;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //User user = new User("test2", "test2", "test2", EAccessLevel.Analyst);
                //_userService.PostUser(user);


                //Pesticide pesticide = new Pesticide("Test", true, EToxicityLevel.Dangerous, null);
                //_pesticideService.PostPesticide(pesticide);


                //RuralProperty ruralProperty = new RuralProperty("name", "street", 472, "District", "18065-215", "City", "SP", null, null);
                //_ruralPropertyService.PostRuralProperty(ruralProperty);


                //Ticket ticket = new Ticket(478, "test description", ruralProperty);
                //_ticketService.PostTicket(ticket);

                var property = _ruralPropertyService.GetAllRuralProperty();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
