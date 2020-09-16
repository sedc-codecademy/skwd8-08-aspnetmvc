using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SEDC.MVC.BuildingApps.Domain.Models;
using SEDC.MVC.BuildingApps.Services;
using SEDC.MVC.BuildingApps.Web.Models;

namespace SEDC.MVC.BuildingApps.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserService _userService;

        public HomeController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            List<string> userEmails = _userService.GetUserEmails();

            List<UserViewModel> userViewList = userEmails
                .Select(email => new UserViewModel { Email = email })
                .ToList();

            return View(userViewList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
