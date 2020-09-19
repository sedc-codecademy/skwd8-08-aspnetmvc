using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.BusinessLayer.Interfaces;
using SEDC.PizzaApp.BusinessModels.ViewModels;

namespace SEDC.PizzaApp.Application.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPizzaOrderService _pizzaOrderService;
        private readonly IUserService _userService;

        public HomeController(IPizzaOrderService pizzaOrderService,
            IUserService userService)
        {
            _pizzaOrderService = pizzaOrderService;
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new HomeViewModel());
        }

        [HttpPost]
        public IActionResult Index(HomeViewModel model)
        {
            return RedirectToAction("Order", "Order", new { pizzas = model.NumberOfPizzas });
        }

        [HttpGet]
        public IActionResult Menu()
        {
            var menu = _pizzaOrderService.GetMenu();
            return View(menu);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Feedback()
        {
            return View(new FeedbackViewModel());
        }

        [HttpPost]
        public IActionResult Feedback(FeedbackViewModel model)
        {
            _userService.GiveFeedback(model);
            return RedirectToAction("Index");
        }
    }
}
