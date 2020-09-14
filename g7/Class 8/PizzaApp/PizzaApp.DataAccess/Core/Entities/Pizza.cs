using PizzaApp.DataAccess.Core.Enums;

namespace PizzaApp.DataAccess.Core.Entities
{
    public class Pizza
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public PizzaSize Size { get; set; }
        public double Price { get; set; }
    }
}
