using APS_6.Domain.Entities;
using APS_6.Domain.Interfaces.Repository;
using APS_6.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace APS_6.Domain.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public void DeleteUser(string userName)
        {
            _repository.DeleteUser(userName);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _repository.GetAllUsers();
        }

        public User GetUserByUserName(string userName)
        {
            return _repository.GetUserByUserName(userName);
        }

        public User Login(string name, string password, string fingerPath)
        {
            var result = _repository.Login(name, password);

            var fingerResult = RunCmd(@"C:\Users\FELIPEDECARVALHOALVE\repos\APS_6_Semestre\src\APS.FirgerprintRecognition\APS.FirgerprintRecognition.py",
                $@"-un { name } -fp { fingerPath }");

            if (fingerResult == "Failed" || result == null)
            {
                result = new User("", "", "", Enums.EAccessLevel.None);
                result.AddNotification("Username/password", "O nome de usuário, senha ou digital estão incorretas");
            }

            return result;
        }

        public void PatchUser(User user)
        {
            _repository.PatchUser(user);
        }

        public void PostUser(User user)
        {
            _repository.PostUser(user);
        }

        private string RunCmd(string cmd, string args)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = @"C:\Program Files (x86)\Microsoft Visual Studio\Shared\Python37_64\python.exe";
            start.Arguments = string.Format("{0} {1}", cmd, args);
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            using (Process process = Process.Start(start))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    return reader.ReadToEnd();
                }
            }

        }
    }
}
