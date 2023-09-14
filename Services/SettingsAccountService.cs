using Chat.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Services
{
    internal class SettingsAccountService
    {
        private readonly LoggedUserService _loggedUserService;

        public SettingsAccountService()
        {
            /*_loggedUserService = new LoggedUserService();*/
        }

        public object GetData() 
        {
            return _loggedUserService;
        }
    }
}
