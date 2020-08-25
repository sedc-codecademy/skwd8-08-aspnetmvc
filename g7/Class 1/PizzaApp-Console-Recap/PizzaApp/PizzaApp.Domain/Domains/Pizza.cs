using PizzaApp.Domain.Enums;

namespace PizzaApp.Domain.Domains
{
    public class Pizza : BaseEntity
    {
        public static int PizzasCount { get; set; }
        public Pizza()
        {
            PizzasCount++;
        }
        protected override int ID { get; set; } = PizzasCount;
        public PizzaType Type { get; set; }
        private double _price;
        public double Price 
        {
            get
            {
                return _price;
            }
            set
            {
                if (value < 0)
                {
                    throw new System.Exception("The price can not be less then 0");
                }
                _price = value;
            }
        }
        public PizzaSize Size { get; set; }
        public User User { get; set; }
    }
}
