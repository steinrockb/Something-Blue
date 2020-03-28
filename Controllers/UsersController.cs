using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SomethingBlue.Managers;
using SomethingBlue.Models;

namespace SomethingBlueWeb.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUserProperties _userProperties;

        public UsersController(IAccountManager accountManager, IUserProperties userProperties)
        {
            _userProperties = userProperties;
        }

        public IActionResult LandingPage()
        {
           // _eventManager.GetEvents(_userProperties.CurrentUser.ID);
            return View();
        }

    }
}