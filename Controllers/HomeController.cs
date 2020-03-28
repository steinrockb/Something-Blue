using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SomethingBlue.Controllers;
using SomethingBlue.Data;
using SomethingBlue.Managers;
using SomethingBlue.Models;
using SomethingBlueWeb.Models;

namespace SomethingBlueWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAccountManager _accountManager;
        private readonly IUserProperties _userProperties;

        public HomeController(ILogger<HomeController> logger, IAccountManager accountManager)
        {
            _logger = logger;
            _accountManager = accountManager;
        }
       
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public User CurrentUser { get; set; }
        public IActionResult OnPostSignUp()
        {
            _accountManager.SignUpUser(CurrentUser);

            return View("Views/User/LandPage.cshtml");

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
