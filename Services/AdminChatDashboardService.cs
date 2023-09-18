using Chat.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Services
{
    internal class AdminChatDashboardService
    {
        private readonly ChatDbContext _dbContext;
        public AdminChatDashboardService()
        {
            _dbContext = new ChatDbContext();
        }

        public IList<User> GetAllUsers() 
        {
            var users = _dbContext.Set<User>().
                ToList();

            return users;
        }
    }
}
