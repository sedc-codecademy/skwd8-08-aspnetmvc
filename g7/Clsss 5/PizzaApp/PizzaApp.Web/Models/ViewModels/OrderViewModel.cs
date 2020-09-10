using PizzaApp.Web.Models.Enums;

namespace PizzaApp.Web.Models.ViewModels
{
    public class OrderViewModel
    {
        public string UserFullName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string PizzaName { get; set; }
        public PizzaSize Size { get; set; }
    }
}
