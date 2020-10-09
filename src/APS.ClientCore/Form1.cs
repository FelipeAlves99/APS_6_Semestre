using APS_6.Domain.Entities;
using APS_6.Domain.Enums;
using APS_6.Domain.Interfaces.Services;
using System;
using System.Windows.Forms;

namespace APS.ClientCore
{
    public partial class Form1 : Form
    {
        private readonly IUserService _userService;

        public Form1(IUserService userService)
        {
            _userService = userService;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User("test2", "test2", "test2", EAccessLevel.Analyst);
                _userService.PostUser(user);               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
