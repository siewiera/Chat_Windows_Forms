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

        public void GetPermissionNewData()
        {

        }
    }
}
