using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SEDC.CLASS_02.Controlers.Models;

namespace SEDC.CLASS_02.Controlers.Controllers
{
    [Route("users")]
    public class UserController : Controller
    {
        
        //[HttpPost]
        [HttpGet]
        [Route("Start")]
        public IActionResult Index() // localhost:[PORT]/user/index
        {
            var users = StaticDb.Users;
            return View(users);
        }

        [Route("details/{id:int}")]
        public IActionResult UserDetails(int id)
        {
            UserModel model = StaticDb.Users.SingleOrDefault(user => user.Id == id);
            return View(model);
        }

        [HttpGet]
        [Route("createUserForm")]
        public IActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        [Route("CreateNewUser")]
        public IActionResult CreateUser(UserModel model) // localhost:[PORT]/user/index
        {
            UserModel user = new UserModel()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Id = StaticDb.Users.Count + 1
            };
            StaticDb.Users.Add(user);
            // localhost:[Port]/user/index
            return RedirectToAction("Index");
            
        }
    }
}

// 
