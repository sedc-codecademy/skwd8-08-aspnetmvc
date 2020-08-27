using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Class02.Controllers
{
    public class CommonController : Controller
    {
        public IActionResult InProgress()
        {
            return View();
        }
    }
}
