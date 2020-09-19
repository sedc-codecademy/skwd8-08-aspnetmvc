using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using ViewModels;

namespace PizzaApp.Controllers
{
    public class SizeController : Controller
    {
        private readonly ISizeService _sizeService;

        public SizeController(ISizeService sizeService)
        {
            _sizeService = sizeService;
        }

        public IActionResult Index()
        {
            return View(_sizeService.GetAll());
        }

        public IActionResult Details(int id)
        {
            return View(_sizeService.GetById(id));
        }

        public IActionResult Edit(int id)
        {
            return View(_sizeService.GetById(id));
        }

        public IActionResult Add()
        {
            return View("Edit", new SizeViewModel());
        }

        [HttpPost]
        public IActionResult Save(SizeViewModel size)
        {
            if (size == null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return View("Edit", size);
            }

            _sizeService.Save(size);

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            _sizeService.Delete(id);

            return RedirectToAction("Index");
        }
    }
}
