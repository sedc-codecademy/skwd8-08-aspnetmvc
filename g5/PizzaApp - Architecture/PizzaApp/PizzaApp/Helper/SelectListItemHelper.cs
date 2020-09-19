using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using ViewModels;

namespace PizzaApp.Helper
{
    public static class SelectListItemHelper
    {
        public static List<SelectListItem> ToSelectListItems(this List<SizeViewModel> sizes)
        {
            return sizes.Select(x => new SelectListItem(x.Name, x.Id.ToString())).ToList();
        }

        public static List<SelectListItem> ToSelectListItems(this List<PizzaViewModel> pizzas)
        {
            return pizzas.Select(x => new SelectListItem(x.Name, x.Id.ToString())).ToList();
        }

        public static List<SelectListItem> ToSelectListItems(this List<PizzaSizeViewModel> pizzaSizes)
        {
            return pizzaSizes.Select(x =>
                    new SelectListItem(
                        $"{x.PizzaViewModel.Name} - {x.SizeViewModel.Name} ({x.Price.ToString("C", new CultureInfo("mk-MK"))})",
                        x.Id.ToString())).ToList();
        }
    }
}
