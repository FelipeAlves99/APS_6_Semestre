using APS_6.Domain.Entities;
using APS_6.Domain.Enums;
using APS_6.Domain.Interfaces.Repository;
using APS_6.Infra.Data.Sql.Repository;
using System;
using System.Windows.Forms;

namespace APS.ClientCore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User("test", "test", "test", EAccessLevel.Admin);
                UserRepository repo = new UserRepository();
                repo.AddUser(user);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
