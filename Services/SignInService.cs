using Chat.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat.Services
{
    internal class SignInService
    {
        private readonly ChatDbContext _dbContext;
        public int _userID;

        public SignInService(ChatDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int GetDataInLogin(string login, string password)
        {
            var username = _dbContext.Set<User>()
                .Where(u => u.UserName == login)
                .Where(u => u.Password == password);

            return CheckDataLogin(username);
        }

        private int CheckDataLogin(IQueryable<User> username)
        {
            int count = username.Count();

            if (count == 1)
            {
                if (username.First().Blocked == true)
                {
                    MessageBox.Show("Your account is blocked!");
                    return 103;
                }

                _userID = username.First().Id;
                GlobalVariables.Instance.globalId = _userID;

                return 100;
            }
            else if (count == 0)
            {
                MessageBox.Show("Invalid login details!");
                return 101;
            }
            else if (count >= 2)
            {
                AccountBlocking(username);
                MessageBox.Show("Please contact your administrator! Error: 102");
                return 102;
            }
            else
            {
                MessageBox.Show("Something went wrong! :(");
                return -1;
            }
        }

        private void AccountBlocking(IQueryable<User> username)
        {
            username.First().Blocked = true;
            _dbContext.SaveChanges();
        }
    }
}
