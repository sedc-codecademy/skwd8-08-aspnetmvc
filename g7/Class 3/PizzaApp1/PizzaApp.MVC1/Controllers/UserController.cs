using Microsoft.AspNetCore.Mvc;
using PizzaApp.MVC1.Models;
using PizzaApp.MVC1.Models.ViewModels;

namespace PizzaApp.MVC1.Controllers
{
    public class UserController : Controller
    {
        UserViewModel result;
        [Route("user/create")]
        public IActionResult CreateUser()
        {
            return View();
        }

        public IActionResult CreateView()
        {
            UserViewModel userViewModel = new UserViewModel();
            User user = new User() { ID = 1, Address = "street no1", Email = "mail@mail", FirstName = "Greg", LastName = "Gregsky", UserName = "greg1234", Password = "password123", PhoneNumber = "075 322 222" };
            userViewModel.Email = user.Email;
            userViewModel.Address = user.Address;
            userViewModel.FullName = user.FirstName + user.LastName;
            userViewModel.Password = user.Password;
            userViewModel.Username = user.UserName;
            userViewModel.PhoneNumber = user.PhoneNumber;
            result = userViewModel;

            return RedirectToAction("GetUser");
        }

        public IActionResult GetUser()
        {
            return View(result);
        }
    }
}