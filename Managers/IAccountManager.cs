using SomethingBlue.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SomethingBlue.Managers
{
    public interface IAccountManager
    {
        public void SignUpUser(User user);

        public bool LoginUser(string email, string password);
   
       
    }
}
