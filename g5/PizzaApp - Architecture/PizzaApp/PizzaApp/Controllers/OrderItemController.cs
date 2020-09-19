using System.Linq;
using DomainModels;
using Microsoft.AspNetCore.Mvc;
using PizzaApp.Helper;
using Services.Interfaces;
using ViewModels;

namespace PizzaApp.Controllers
{
    public class OrderItemController : Controller
    {
        private readonly IOrderItemService _orderItemService;
        private readonly IPizzaSizeService _pizzaSizeService;

        public OrderItemController(IOrderItemService orderItemService, 
            IPizzaSizeService pizzaSizeService)
        {
            _orderItemService = orderItemService;
            _pizzaSizeService = pizzaSizeService;
        }

        public IActionResult Add(int id)
        {
            OrderItemViewModel orderItemViewModel = _orderItemService.CreateNewOrderItem(id);

            ViewBag.PizzaSizesForSelect = _pizzaSizeService.GetAll().ToSelectListItems();
            return View(orderItemViewModel);
        }

        [HttpPost]
        public IActionResult Save(OrderItemViewModel orderItem)
        {
            if (orderItem == null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return View("Add", orderItem);
            }

            _orderItemService.Save(orderItem);


            return RedirectToAction("Details", "Order", new { Id = orderItem.OrderId });
        }

        public IActionResult Delete(int id)
        {
            var orderItem = _orderItemService.GetById(id);
            _orderItemService.Delete(id);

            return RedirectToAction("Details", "Order", new { Id = orderItem.OrderId });
        }
    }
}
