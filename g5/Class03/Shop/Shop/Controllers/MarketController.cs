using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop.Helpers;
using Shop.Models;

namespace Shop.Controllers
{
    public class MarketController : Controller
    {
        public IActionResult Index()
        {
            var products = DataHelper.Products;
            return View(products);
        }

        public IActionResult Details(int id)
        {
            var product = DataHelper.Products.FirstOrDefault(x => x.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        public IActionResult Edit(int id)
        {
            var product = DataHelper.Products.FirstOrDefault(x => x.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(int id, 
            [Bind("Id,Name,Quantity,Category,Price,ProducedBy,ImageUrl")] Product product)
        {
            var existingProduct = DataHelper.Products.FirstOrDefault(x => x.Id == id);

            if (existingProduct == null)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return View(product);
            }

            var index = DataHelper.Products.IndexOf(existingProduct);
            DataHelper.Products.RemoveAt(index);
            DataHelper.Products.Add(product);

            return RedirectToAction("Index");
        }
    }
}
