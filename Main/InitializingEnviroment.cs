using Chat.Admin_panel;
using Chat.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Chat
{
    public partial class InitializingEnviroment : Form
    {
        public InitializingEnviroment()
        {
            InitializeComponent();
        }

        /*######################    Adding and updating form controls    ##########################*/
        public List<Control> getFormsControls(Control root)
        {
            List<Control> allAdminControls = new List<Control>();

            foreach (Control control in root.Controls)
            {
                if (control is Button || control is CheckBox || control is TextBox)
                    allAdminControls.Add(control);

                if (control.HasChildren)
                    allAdminControls.AddRange(getFormsControls(control));
            }

            return allAdminControls;
        }

        public class ControlFormClass
        {
            public int tabIndex;
            public string name;
            public string description;
            public string controlType;
            public string formName;
        };

        private void UpdatingStatusOfControls()
        {
            List<Control> allForm = new List<Control>();
            List<int> tabIndex = new List<int>();

            Form[] forms = new Form[]
            {
                new AdminChatDashboard(),
                new ControlsFromForms(),
                new SettingsAccount(),
                new MainPanel(),
                new Permissions(),
            };

            foreach (Form form_ in forms)
            {
                allForm.Add(form_);
            }

            UserControl[] userControl = new UserControl[]
            {
                new UC_Chat(),
                new UC_Roles(),
                new UC_Users(),
            };

            foreach (UserControl control in userControl)
            {
                allForm.Add(control);
            }

            changinngStatusControl(false, tabIndex);

            foreach (Control control in allForm)
            {
                foreach (Control control_ in getFormsControls(control))
                {
                    var controlFormClass = new ControlFormClass();

                    controlFormClass.tabIndex = Int32.Parse(control_.TabIndex.ToString());
                    controlFormClass.name = control_.Name;
                    controlFormClass.description = control_.AccessibleDescription;
                    controlFormClass.controlType = control_.GetType().Name;
                    controlFormClass.formName = control.Name;

                    CheckStatusControl(controlFormClass);
                }
            }
        }
        
        private void CheckStatusControl(ControlFormClass controlFormClass)
        {
            using (var _dbContext = new ChatDbContext())
            {
                int controlFormCount = _dbContext.Set<ControlForm>()
                    .Where(c => c.TabIndex == controlFormClass.tabIndex)               
                    .Count();

                if (controlFormCount == 0)
                    AddingControls(controlFormClass, _dbContext);
                else
                    UpdatingControls(controlFormClass, _dbContext);
            }
        }

        private void UpdatingControls(ControlFormClass controlFormClass, ChatDbContext _dbContext) 
        {
            var updateItems = _dbContext.Set<ControlForm>()
                .Where(c => c.TabIndex == controlFormClass.tabIndex);

            string description = controlFormClass.description;
            if (controlFormClass.description == null)
                description = "";

            foreach (var item in updateItems)
            { 
                item.Name = controlFormClass.name;
                item.Description = description;
                item.ControlType = controlFormClass.controlType;
                item.FormName = controlFormClass.formName;
                item.Active = true;
                
            };

            _dbContext.SaveChanges();
        }

        private void AddingControls(ControlFormClass controlFormClass, ChatDbContext _dbContext)
        {
            string description = controlFormClass.description;
            if (controlFormClass.description == null)
                description = "";

            var controlForm = new ControlForm()
            {
                TabIndex = controlFormClass.tabIndex,
                Name = controlFormClass.name,
                Description = description,
                ControlType = controlFormClass.controlType,
                FormName = controlFormClass.formName,
                Active = true,
            };

            _dbContext.Set<ControlForm>().AddRange(controlForm);
            _dbContext.SaveChanges();
        }

        private void changinngStatusControl(bool status, List<int> tabIndex )
        {
            using (var _dbContext = new ChatDbContext())
            {
                if (!tabIndex.Any())
                {
                    var allTabIndex = _dbContext.Set<ControlForm>();
                    foreach (var item in allTabIndex)
                    {
                        item.Active = status;                        
                    }
                    _dbContext.SaveChanges();
                }
                else
                {
                    foreach (int item in tabIndex)
                    {
                        _dbContext.Set<ControlForm>()
                            .Where(c => c.TabIndex == item)
                            .FirstOrDefault().Active = status;

                        
                    }
                    _dbContext.SaveChanges();
                }
            };
        }

        private void InitializingEnviroment_Load(object sender, EventArgs e)
        {
            /*UpdatingStatusOfControls();*/
        }


        public async Task LoadInitData(Form hideForm, Form showForm, string[] exe)
        {
            hideForm.Hide();
            Show();

            if (!exe.Any())
                await Task.Delay(3000);
            else
            {
                foreach (string item in exe)
                {
                    switch (item.ToLower())
                    {
                        case "updatecontrols":

                            UpdatingStatusOfControls();
                            break;

                        case "updaterooms":

                            /*Console.WriteLine("updateRoom");*/
                            break;

                        default:

                            /*Console.WriteLine("default");*/
                            break;
                    };
                }

                await Task.Delay(3000);
            }

            showForm.Show();
            this.Hide();

        }

    }
}
