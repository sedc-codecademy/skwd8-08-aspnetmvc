using PizzaApp.DataAccess.Core.Enums;

namespace PizzaApp.PresentationLayer.ViewModels
{
    public class PizzaVM
    {
        public string Name { get; set; }
        public PizzaSize Size { get; set; }
        public double Price { get; set; }
    }
}
