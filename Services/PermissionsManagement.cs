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

        private List<PermissionDetails> GetAllControlsForm()
        {
            using (var _dbContext = new ChatDbContext())
            {
                var query = (from cf in _dbContext.ControlForms
                             where cf.Active == true
                             where cf.FormName == _form.Name
                             select new PermissionDetails
                             {
                                 tabIndex = cf.TabIndex,
                             }).ToList();

                return query;
            }
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

        private void BlockingControlsInForm(List<PermissionDetails> listOfUnavailableControls)
        {
            foreach (PermissionDetails item in listOfUnavailableControls)
            { 
                foreach (Control control in initializing.getFormsControls(_form))
                {
                    if (control.TabIndex == item.tabIndex)
                    {
                        if (control.IsHandleCreated && !control.IsDisposed)
                        {
                            control.Invoke((MethodInvoker)delegate
                            {
                                control.Visible = false;
                            });
                        }
                    } 
                }
            }
        }

        private async Task CheckingPermissionsForControls()
        {
            await Task.Run(() => 
            { 
                List<PermissionDetails> listOfAvailableControls = GetPermissionsDetails();
                List<PermissionDetails> listOfUnavailableControls = GetAllControlsForm();

                foreach(PermissionDetails item in listOfAvailableControls)
                { 
                    foreach (Control control in initializing.getFormsControls(_form))
                    {
                        if (control.TabIndex == item.tabIndex)
                        {
                            if (control.IsHandleCreated && !control.IsDisposed)
                            { 
                                control.Invoke((MethodInvoker)delegate
                                {
                                    control.Visible = true;
                                });
                                listOfUnavailableControls.RemoveAll(i => i.tabIndex == item.tabIndex);
                            }
                        }                   
                    }
                }
                BlockingControlsInForm(listOfUnavailableControls);
            });
        }


        public async void CheckingPermissions()
        {
            timer = new System.Timers.Timer(5000);

            if (!_form.IsDisposed && _form.Visible)
            {
                timer.Elapsed += async (se, ev) => await CheckingPermissionsForControls();
                timer.Start();
            }
            else
            {
                timer.Stop();
                return;
            }
            
        }
    }
}
