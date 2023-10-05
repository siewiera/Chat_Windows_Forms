using Chat.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
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

        public IEnumerable<> GetAllPermission()
        {
            using (ChatDbContext _dbContext = new ChatDbContext())
            {
                /*var permissions = _dbContext.Set<RightRole>()
                    .Join(_dbContext.Set<Right>,
                    rr => rr.RightId,
                    (rr) => new { Name = rr.Name })
                                   .ToList();*/
                var permissions = (from rr in _dbContext.RightRoles
                                   join r in _dbContext.Rights on rr.RightId equals r.Id
                                   join ro in _dbContext.Rights on rr.RoleId equals ro.Id
                                   orderby r.Name
                                   select new
                                   {
                                       Id = rr.Id,
                                       idRole = ro.Id,
                                       nameRole = ro.Name,
                                       idPermission = r.Id,
                                       namePermission = r.Name
                                   })
                                   .ToList();

                return permissions;
            }
        }
    }
}
