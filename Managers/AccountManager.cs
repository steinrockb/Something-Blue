using Microsoft.EntityFrameworkCore;
using SomethingBlue.Data;
using SomethingBlue.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SomethingBlue.Managers
{
    public class AccountManager : IAccountManager
    {
        private readonly SomethingBlueDBContext _context;
        private readonly IUserProperties _userProperties;

        public AccountManager(SomethingBlueDBContext context, IUserProperties userProperties)
        {
            _context = context;
            _userProperties = userProperties;
        }

        public bool LoginUser(string email, string password)
        {
            User user = _context.Users.FirstOrDefault(x => x.Email == email);

            if (user != null)
            {
                if (user.Password == password)
                {
                    _userProperties.CurrentUser = user;
                    return true;
                }

                return false;
            }

            return false;
        }

        public void SignUpUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();

            _userProperties.CurrentUser = user;
        }
    }
}
