using Chat.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Chat.Services
{
    internal class ChatService
    {
        private readonly ChatDbContext _dbContext;

        public ChatService()
        {
            _dbContext = new ChatDbContext();
        }

        public void AddDataToDatabase()
        {
            if (!_dbContext.Database.CanConnect()) return;
            
            if (!_dbContext.Roles.Any()) 
            {
                var role = GetRole();
                _dbContext.Roles.AddRange(role);
            }
            if (!_dbContext.Rights.Any())
            {
                var right = GetRight();
                _dbContext.Rights.AddRange(right);                  
            }
            _dbContext.SaveChanges();                 
        }

        private IEnumerable<Role> GetRole()
        {
            var role = new List<Role>()
            {
                new Role()
                {
                    Name = "User",
                },
                new Role()
                {
                    Name = "Chat_Admin",
                },
                new Role()
                {
                    Name = "Master_Admin",
                },
            };

            return role;
        }

        private IEnumerable<Right> GetRight()
        {
            var right = new List<Right>()
            {
                new Right()
                {
                    Name = "creating_rooms",
                },
                new Right()
                {
                    Name = "writing_message",
                },
                new Right()
                {
                    Name = "deleting_messages",
                },
                new Right()
                {
                    Name = "blocking_accounts",
                },
            };

            return right;
        }

        public IList<Role> ListRole()
        {
            var role = _dbContext.Set<Role>()
                .ToList();

            return role;
        }
    }
}
