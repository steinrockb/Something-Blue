using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SomethingBlue.Data;
using SomethingBlue.Managers;

namespace SomethingBlue.Controllers
{
    public class GlobalController : Controller
    {
        private readonly IAccountManager _accountManager;

        public GlobalController(IAccountManager accountManager)
        {
            _accountManager = accountManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public string SignUp(string firstName,string lastName, string email, string password)
        {
            User user = new User { FirstName = firstName, LastName = lastName, Email = email, Password = password };

            _accountManager.SignUpUser(user);

            var redirectUrl = "Users/LandingPage";
            return redirectUrl;
        }
    
        public string LoginUser(string email, string password)
        {
            bool loginSuccessful = _accountManager.LoginUser(email, password);

            if (loginSuccessful)
            {
                var redirectUrl = "Users/LandingPage";
                return redirectUrl;
            }

            return "Error";
        }
    }
}