using System.Collections.Generic;
using Shop.Models;

namespace Shop.Helpers
{
    public static class DataHelper
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product("Coca Cola", 30, ProductCategory.Drinks, 70, "Pivara", ""),
            new Product("Skopsko", 100, ProductCategory.Drinks, 40, "Skopska Pivara", "https://www.paket.mk/wp-content/uploads/2020/05/ZMA13072.jpg"),
            new Product("Chicken stek", 50, ProductCategory.Meat, 150, "Ptuj", ""),
            new Product("Potatos", 80, ProductCategory.Vegetables, 30, "Fresh Market", ""),
            new Product("Apples", 50, ProductCategory.Fruits, 50, "Fresh Market", "")
        };
    }
}
