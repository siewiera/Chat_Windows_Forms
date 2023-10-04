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
        private  ChatService _chatService = new ChatService();
        public AdminChatDashboardService()
        {
        }

        public IEnumerable<User> GetAllUsers() 
        {
            using (var _dbContext = new ChatDbContext())
            {
                var users = _dbContext.Set<User>()
                                   .ToList();
                return users;
            }
        }

        public IEnumerable<Role> GetAllRoles()
        {
            using (var _dbContext = new ChatDbContext())
            {
                var roles = _dbContext.Set<Role>()
                                   .ToList();
                return roles;
            }
        }

        public IEnumerable<RightRole> GetAllPermission()
        {
            using (var _dbContext = new ChatDbContext())
            {
                var permissions = _dbContext.Set<RightRole>()
                                   .ToList();
                return permissions;
            }
        }
    }
}
