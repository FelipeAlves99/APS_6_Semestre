using APS_6.Domain.Interfaces.Services;
using System;
using System.Diagnostics;
using System.Text;
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

        private void button2_Click(object sender, EventArgs e)
        {
            var processInfo = new ProcessStartInfo("cmd.exe", "/c systeminfo")
            {
                CreateNoWindow = true,
                UseShellExecute = false,
                RedirectStandardError = true,
                RedirectStandardOutput = true,
                WorkingDirectory = @"C:\Users\FELIPEDECARVALHOALVE\repos\APS_6_Semestre\src\APS.FirgerprintRecognition"
            };

            StringBuilder sb = new StringBuilder();
            Process p = Process.Start(processInfo);
            p.OutputDataReceived += (sender, args) => sb.AppendLine(args.Data);
            p.BeginOutputReadLine();
            p.WaitForExit();
            MessageBox.Show(sb.ToString());



            //try
            //{
            //    var start = new ProcessStartInfo();
            //    start.UseShellExecute = false;
            //    start.RedirectStandardOutput = true;
            //    start.RedirectStandardInput = true;
            //    start.Arguments = "python APS.FirgerprintRecognition.py -un user_2 -fp dataset/user_1/1.png";
            //    start.FileName = "cmd.exe";

            //    using (Process process = Process.Start(start))
            //    {
            //        using (StreamReader reader = process.StandardOutput)
            //        {
            //            string result = reader.ReadToEnd();
            //            MessageBox.Show(result);
            //        }
            //        process.WaitForExit();
            //    }
            //}
            //catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
