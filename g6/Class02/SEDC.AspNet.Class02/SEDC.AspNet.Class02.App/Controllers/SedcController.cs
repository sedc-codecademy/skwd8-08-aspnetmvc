using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SEDC.AspNet.Class02.App.Controllers
{
    public class SedcController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}