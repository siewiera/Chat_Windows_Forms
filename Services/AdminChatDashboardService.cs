using Chat.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat.Services
{
    internal class AdminChatDashboardService
    {
        private readonly ChatDbContext _dbContext;
        private  ChatService _chatService = new ChatService();
        public AdminChatDashboardService()
        {
            _dbContext = new ChatDbContext();
        }

        public IEnumerable<User> GetAllUsers() 
        {    
            var users = _dbContext.Set<User>()
                .ToList();
            return users;
        }
    }
}
