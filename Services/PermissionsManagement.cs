using Chat.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Chat.InitializingEnviroment;
using static Chat.Services.ControlsFromFormsService;

namespace Chat.Services
{
    internal class PermissionsManagement
    {
        private InitializingEnviroment initializing = new InitializingEnviroment();
        static System.Timers.Timer timer;

        private Form _form;
        private int _loggedUserId;

        public PermissionsManagement(Form form)
        {
            this._form = form;
            this._loggedUserId = GlobalVariables.Instance.globalId;
            if(_loggedUserId == null) return;
        }

        public class PermissionDetails
        {
            public int tabIndex;
        }

        private List<PermissionDetails> GetPermissionsDetails()
        {
            using (var _dbContext = new ChatDbContext())
            {
                var query = (from u in _dbContext.Users
                             join ro in _dbContext.Roles 
                                on u.RoleId equals ro.Id
                             join rir in _dbContext.RightRoles 
                                on ro.Id equals rir.RoleId
                             join rrc in _dbContext.RightControls 
                                on rir.RightId equals rrc.RightId
                             join cf in _dbContext.ControlForms 
                                on rrc.ControlId equals cf.Id
                             where cf.Active == true
                             where u.Id == this._loggedUserId
                             select new PermissionDetails
                             {
                                 tabIndex = cf.TabIndex,
                             }).ToList();

                return query;
            }
        }

        private void BlockingAllControlsInForm()
        {
            
            foreach (Control control in initializing.getFormsControls(_form))
            {
                control.Invoke((MethodInvoker)delegate
                {
                    control.Visible = false;
                });
            }
        }


        private async Task UnBlockingControlsInForm()
        {
            await Task.Run(() =>
            {
                BlockingAllControlsInForm();
                List<PermissionDetails> list = GetPermissionsDetails();

                foreach (PermissionDetails item in list)
                {
                    foreach (Control control in initializing.getFormsControls(_form))
                    {
                        control.Invoke((MethodInvoker)delegate
                        {
                            if (control.TabIndex == item.tabIndex)
                            control.Visible = true;
                        });
                    }
                }
            });
        }

        public async void CheckingPermissions()
        {
            UnBlockingControlsInForm();

            timer = new System.Timers.Timer(5000);
            timer.Elapsed += async (se, ev) => await UnBlockingControlsInForm();
            timer.Start();
        }
    }
}
