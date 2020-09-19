using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace PizzaApp.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public IActionResult Add(int id)
        {
            _orderService.AddOrderForCustomer(id);

            return RedirectToAction("Details", "Customer", new { id });
        }

        public IActionResult Details(int id)
        {
            var orderViewModel = _orderService.GetById(id);
            return View(orderViewModel);
        }

        public IActionResult Delete(int id)
        {
            var orderViewModel = _orderService.GetById(id);
            _orderService.Delete(id);

            var dynamic = new { Id = orderViewModel.CustomerId};

            return RedirectToAction("Details", "Customer", dynamic);
        }
    }
}
