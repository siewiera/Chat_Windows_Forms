using Chat.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat.Services
{
    internal class AdminChatDashboardService
    {
        private readonly ChatDbContext _dbContext;
        public AdminChatDashboardService()
        {
            _dbContext = new ChatDbContext();
        }

        public IList<User> GetAllUsers() 
        {
            
            
            var users = _dbContext.Set<User>()
                .ToList();

            /*string[][] users_detail = new string[5][];
            foreach (var elem in users)
            {
                users_detail[users_detail.Length - 1][0]
            }*/

            /*item = new ListViewItem(users);*/
            return users;
        }
    }
}
