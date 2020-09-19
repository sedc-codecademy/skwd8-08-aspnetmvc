using SEDC.PizzaApp.Domain.Enums;

namespace SEDC.PizzaApp.BusinessModels.ViewModels
{
    public class PizzaViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public PizzaSize Size { get; set; }
        public string Image { get; set; }
    }
}
