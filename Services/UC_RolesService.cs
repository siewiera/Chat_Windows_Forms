using Chat.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Services
{
    internal class UC_RolesService
    {
        private Notification notification = new Notification();
        public UC_RolesService() { }


        public bool existsRole(string nameRole, ChatDbContext _dbContext)
        {
            int countExistsRole;

            countExistsRole = _dbContext.Set<Role>()
                .Where(s => s.Name == nameRole)
                .Count();

            if (countExistsRole > 0) return true;
            return false;
        }

        public void addingRole(string nameRole)
        {
            using (var _dbContext = new ChatDbContext())
            {
                if (nameRole == "")
                {
                    notification.GetNotification("error", "Role name cannot be empty!");
                    return;
                }
                if (existsRole(nameRole, _dbContext))
                {
                    /*MessageBox.Show($"Name role already exists!");*/
                    notification.GetNotification("error", "Name role already exists!");
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

        public void EditNameRole(int idRole, string newRoleName)
        {
            using (var _dbContext = new ChatDbContext())
            {
                if (newRoleName == "")
                {
                    notification.GetNotification("error", "Role name cannot be empty!");
                    return;
                }
                if (existsRole(newRoleName, _dbContext))
                {
                    notification.GetNotification("error", "Name role already exists!");
                    return;
                }

                _dbContext.Set<Role>()
                    .Where(u => u.Id == idRole)
                    .First()
                    .Name = newRoleName;

                _dbContext.SaveChanges();

                notification.GetNotification("success", "Role name updated!");
            }
        }

    }
}
