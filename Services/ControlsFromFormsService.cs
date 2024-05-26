using Chat.Admin_panel;
using Chat.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Services
{
    internal class ControlsFromFormsService
    {
        public ControlsFromFormsService()
        {}
        public class ControlsDetails
        {
            public int id;
            public string description;
            public string formName;
            public string controlType;
        };

        public List<ControlsDetails> GetUsedControlsFromPermission(int id_permisson)
        {
            using (var _dbContext = new ChatDbContext())
            {
                var query = (from rr in _dbContext.RightControls
                             join r in _dbContext.ControlForms on rr.ControlId equals r.Id
                             where rr.RightId == id_permisson
                             where r.Active == true
                             orderby r.Name
                             select new ControlsDetails
                             {
                                 id = r.Id,
                                 description = r.Name + "-" + r.Description,
                                 formName = r.FormName,
                                 controlType = r.ControlType
                             })
                             .ToList();

                return query;
            }
        }

        public List<ControlsDetails> GetNewContorlsFromPermission(int id_permisson)
        {
            using (var _dbContext = new ChatDbContext())
            {
                /*var query = (from r in _dbContext.ControlForms
                             join rr in _dbContext.RightControls on r.Id equals rr.ControlId
                             into gj
                             from subRightControl in gj.DefaultIfEmpty()
                             where subRightControl.RightId != id_permisson
                             where r.Active == true
                             orderby r.Name
                             select new ControlsDetails
                             {
                                 id = r.Id,
                                 description = r.Name + "-" + r.Description,
                                 formName = r.FormName,
                                 controlType = r.ControlType
                             })
                             .ToList();*/

                var query = (from r in _dbContext.ControlForms
                             where !_dbContext.RightControls
                                .Where(rc => rc.RightId == id_permisson)
                                .Select(rc => rc.ControlId)
                                .Contains(r.Id)
                             orderby r.Name
                             select new ControlsDetails
                             {
                                 id = r.Id,
                                 description = r.Name + "-" + r.Description,
                                 formName = r.FormName,
                                 controlType = r.ControlType
                             })
                             .Distinct()
                             .ToList();

                return query;
            }
        }

        public void SaveNewContorlsFromPermission(int id_permission, int id_controls)
        {
            using (var _dbContext = new ChatDbContext())
            {
                var newControlsFromPermission = new RightControl()
                {
                    RightId = id_permission,
                    ControlId = id_controls,
                };

                _dbContext.Set<RightControl>()
                    .AddRange(newControlsFromPermission);
                _dbContext.SaveChanges();
            }
        }


        public void RemoveAllControlsFromPermission(int id_permission)
        {
            using (var _dbContext = new ChatDbContext())
            {
                var oldControlsFromPermisison = _dbContext.Set<RightControl>()
                    .Where(rr => rr.RightId == id_permission)
                    .ToList();

                /*foreach (var oldControl in oldControlsFromPermisison)
                {*/
                _dbContext.Set<RightControl>().RemoveRange(oldControlsFromPermisison);
                _dbContext.SaveChanges();
               /* }*/
            }
        }
    }

}
