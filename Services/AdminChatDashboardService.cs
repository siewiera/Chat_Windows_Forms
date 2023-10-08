using Chat.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
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
        public AdminChatDashboardService(){}

        public class Permissions
        {
            public int id;
            public int idRole;
            public string nameRole;
            public int idPermission;
            public string namePermission;
        };

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

        public List<Permissions> GetAllPermission()
        {
            using (var _dbContext = new ChatDbContext())
            {
                var query = (from rr in _dbContext.RightRoles
                                   join r in _dbContext.Rights on rr.RightId equals r.Id
                                   join ro in _dbContext.Roles on rr.RoleId equals ro.Id
                                   orderby r.Name
                                   select new Permissions
                                   {
                                       id = rr.Id,
                                       idRole = ro.Id,
                                       nameRole = ro.Name,
                                       idPermission = r.Id,
                                       namePermission = r.Name
                                   })
                                   .ToList();
                return query;
            }
        }

        public bool existsRole(string nameRole, ChatDbContext _dbContext)
        {
            int countExistsRole;
             
            countExistsRole = _dbContext.Set<Role>()
                .Where(s => s.Name == nameRole)
                .Count();
            
            if (countExistsRole > 0) return false;
            return true;
        }

        public void addingRole(string nameRole)
        {        
            using (var _dbContext = new ChatDbContext())
            {
                if (!existsRole(nameRole, _dbContext))
                {
                    MessageBox.Show($"Name role already exists!");
                    return;
                }

                var role = new Role()
                {
                    Name = nameRole,
                };

                _dbContext.AddRange(role);
                _dbContext.SaveChanges();
            }
        }

        
    }
}
