using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PizzaApp.Helper;
using PizzaApp.Models.DomainModels;
using PizzaApp.Models.ViewModels;

namespace PizzaApp.Controllers
{
    public class SizeController : Controller
    {
        public IActionResult Index()
        {
            var sizesViewModels = Data.Sizes.Select(Size.ToViewModel).ToList();
            return View(sizesViewModels);
        }

        public IActionResult Details(int id)
        {
            var size = Data.Sizes.FirstOrDefault(x => x.Id == id);

            if (size == null)
            {
                return NotFound();
            }

            return View(Size.ToViewModel(size));
        }

        public IActionResult Edit(int id)
        {
            var size = Data.Sizes.FirstOrDefault(x => x.Id == id);

            if (size == null)
            {
                return NotFound();
            }

            return View(Size.ToViewModel(size));
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

            Size existingSize = Data.Sizes.FirstOrDefault(x => x.Id == size.Id);

            if (existingSize == null)
            {
                Size newSize = new Size
                {
                    Id = size.Id,
                    Name = size.Name,
                    Description = size.Description
                };

                Data.Sizes.Add(newSize);
                return RedirectToAction("Index");
            }

            int indexOfExistingSize = Data.Sizes.IndexOf(existingSize);
            Data.Sizes.RemoveAt(indexOfExistingSize);

            existingSize.Name = size.Name;
            existingSize.Description = size.Description;

            Data.Sizes.Add(existingSize);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            Size existingSize = Data.Sizes.FirstOrDefault(x => x.Id == id);

            if (existingSize == null)
            {
                return NotFound();
            }

            int indexOfExistingSize = Data.Sizes.IndexOf(existingSize);
            Data.Sizes.RemoveAt(indexOfExistingSize);

            return RedirectToAction("Index");
        }
    }
}
