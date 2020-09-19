using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using ViewModels;

namespace PizzaApp.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public IActionResult Index()
        {
            return View(_customerService.GetAll());
        }

        public IActionResult Details(int id)
        {
            return View(_customerService.GetById(id));
        }

        public IActionResult Edit(int id)
        {
            return View(_customerService.GetById(id));
        }

        public IActionResult Add()
        {
            return View("Edit", new CustomerViewModel());
        }

        [HttpPost]
        public IActionResult Save(CustomerViewModel customer)
        {
            if (customer == null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return View("Edit", customer);
            }

            _customerService.Save(customer);

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            _customerService.Delete(id);

            return RedirectToAction("Index");
        }
    }
}
