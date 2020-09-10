using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PizzaApp.Helper;
using PizzaApp.Models.DomainModels;
using PizzaApp.Models.ViewModels;

namespace PizzaApp.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            var customersViewModels = Data.Customers.Select(Customer.ToViewModel).ToList();
            return View(customersViewModels);
        }

        public IActionResult Details(int id)
        {
            var customer = Data.Customers.FirstOrDefault(x => x.Id == id);

            if (customer == null)
            {
                return NotFound();
            }
            
            var customerViewModel = Customer.ToViewModel(customer);

            customerViewModel.Orders = customer.Orders.Select(x => new OrderViewModel
            {
                Id = x.Id,
                OrderNumber = x.OrderNumber
            }).ToList();

            return View(customerViewModel);
        }

        public IActionResult Edit(int id)
        {
            var customer = Data.Customers.FirstOrDefault(x => x.Id == id);

            if (customer == null)
            {
                return NotFound();
            }

            return View(Customer.ToViewModel(customer));
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

            Customer existingCustomer = Data.Customers.FirstOrDefault(x => x.Id == customer.Id);

            if (existingCustomer == null)
            {
                Customer newCustomer = new Customer
                {
                    Id = customer.Id,
                    FirstName = customer.FirstName,
                    LastName = customer.LastName,
                    Address = customer.Address,
                    Phone = customer.Phone
                };

                Data.Customers.Add(newCustomer);
                return RedirectToAction("Index");
            }

            int indexOfExistingCustomer = Data.Customers.IndexOf(existingCustomer);
            Data.Customers.RemoveAt(indexOfExistingCustomer);

            existingCustomer.FirstName = customer.FirstName;
            existingCustomer.LastName = customer.LastName;
            existingCustomer.Address = customer.Address;
            existingCustomer.Phone = customer.Phone;

            Data.Customers.Add(existingCustomer);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            Customer existingCustomer = Data.Customers.FirstOrDefault(x => x.Id == id);

            if (existingCustomer == null)
            {
                return NotFound();
            }

            int indexOfExistingCustomer = Data.Customers.IndexOf(existingCustomer);
            Data.Customers.RemoveAt(indexOfExistingCustomer);

            return RedirectToAction("Index");
        }
    }
}
