using InvoiceApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace InvoiceApp.Controllers
{
    public class InvoiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View(new Invoice());
        }

        [HttpPost]
        public IActionResult Add(Invoice model)
        {
            if (!ModelState.IsValid)
                return View(model);

            //TODO: save invoice
            return RedirectToAction("Index");
        }
    }
}
