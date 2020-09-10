using PizzaApp.Web.Models.Enums;

namespace PizzaApp.Web.Models.Domain
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price {get; set;}
        public PizzaSize Size { get; set; }
    }
}
