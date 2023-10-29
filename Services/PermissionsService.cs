using Chat.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Services
{
    internal class PermissionsService
    {

        public PermissionsService()
        {

        }
        public class Permissions
        {
            public int id;
            public int idRole;
            public string nameRole;
            public int idPermission;
            public string namePermission;
        };

        public List<Permissions> GetPermissionUsedData()
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

        public void removeOldPermissions(int idRole)
        {
            using (var _dbContext = new ChatDbContext())
            {
                var oldPermissions = _dbContext.Set<RightRole>()
                    .Where(rr => rr.RoleId == idRole)
                    .ToList();

                foreach (var oldPermission in oldPermissions)
                {
                    _dbContext.Set<RightRole>().Remove(oldPermission);
                    _dbContext.SaveChanges();
                }
            }
        }

        public void saveNewPermissions(int idRole, int idPermission)
        {
            using (var _dbContext = new ChatDbContext())
            {
                var newPermissions = new RightRole()
                {
                    RoleId = idRole,
                    RightId = idPermission,
                };

                _dbContext.Set<RightRole>() 
                    .AddRange(newPermissions);
                _dbContext.SaveChanges();
            };
        }

    }
}

