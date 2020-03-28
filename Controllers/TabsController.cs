using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SomethingBlue.Controllers
{
    public class TabsController : Controller
    {
        public IActionResult IndexII()
        {
            return View();
        }
    }
}