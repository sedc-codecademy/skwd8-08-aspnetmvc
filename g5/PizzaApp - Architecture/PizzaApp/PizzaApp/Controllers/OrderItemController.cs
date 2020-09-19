using System.Linq;
using DomainModels;
using Microsoft.AspNetCore.Mvc;
using ViewModels;

namespace PizzaApp.Controllers
{
    public class OrderItemController : Controller
    {
        //public IActionResult Add(int id)
        //{
        //    Customer customer = Data.Customers.FirstOrDefault(x => x.Orders.Any(y => y.Id == id));

        //    if (customer == null)
        //    {
        //        return NotFound();
        //    }

        //    Order order = customer.Orders.FirstOrDefault(x => x.Id == id);

        //    if (order == null)
        //    {
        //        return NotFound();
        //    }

        //    OrderItem orderItem = new OrderItem(order.Id);
        //    OrderItemViewModel orderItemViewModel = OrderItem.ToViewModel(orderItem);

        //    ViewBag.PizzaSizesForSelect = Data.PizzaSizesToSelectListItems();
        //    return View(orderItemViewModel);
        //}

        //[HttpPost]
        //public IActionResult Save(OrderItemViewModel orderItem)
        //{
        //    if (orderItem == null)
        //    {
        //        return BadRequest();
        //    }

        //    if (!ModelState.IsValid)
        //    {
        //        return View("Add", orderItem);
        //    }

        //    Customer customer = Data.Customers.FirstOrDefault(x => x.Orders.Any(y => y.Id == orderItem.OrderId));

        //    if (customer == null)
        //    {
        //        return NotFound();
        //    }

        //    Order order = customer.Orders.FirstOrDefault(x => x.Id == orderItem.OrderId);

        //    if (order == null)
        //    {
        //        return NotFound();
        //    }

        //    PizzaSize pizzaSize = Data.PizzaSizes.FirstOrDefault(x => x.Id == orderItem.PizzaSizeId);

        //    if (pizzaSize == null)
        //    {
        //        return NotFound();
        //    }

        //    OrderItem existingOrderItemForSamePizza =
        //        order.OrderItems.FirstOrDefault(x => x.PizzaSizeId == orderItem.PizzaSizeId);

        //    if (existingOrderItemForSamePizza != null)
        //    {
        //        int indexOfExistingOrderItem = order.OrderItems.IndexOf(existingOrderItemForSamePizza);
        //        order.OrderItems.RemoveAt(indexOfExistingOrderItem);

        //        existingOrderItemForSamePizza.Quantity += orderItem.Quantity;
                
        //        order.OrderItems.Add(existingOrderItemForSamePizza);
        //    }
        //    else
        //    {
        //        OrderItem newOrderItem = new OrderItem(pizzaSize, orderItem.Quantity, order.Id);
        //        order.OrderItems.Add(newOrderItem);
        //    }


        //    return RedirectToAction("Details", "Order", new {order.Id});
        //}

        //public IActionResult Delete(int id)
        //{
        //    Customer customer =
        //        Data.Customers.FirstOrDefault(x => x.Orders.Any(y => y.OrderItems.Any(z => z.Id == id)));
            
        //    if (customer == null)
        //    {
        //        return NotFound();
        //    }

        //    Order order = customer.Orders.FirstOrDefault(x => x.OrderItems.Any(y => y.Id == id));

        //    if (order == null)
        //    {
        //        return NotFound();
        //    }

        //    OrderItem orderItem = order.OrderItems.FirstOrDefault(x => x.Id == id);

        //    if (orderItem == null)
        //    {
        //        return NotFound();
        //    }

        //    int indexOrderItem = order.OrderItems.IndexOf(orderItem);
        //    order.OrderItems.RemoveAt(indexOrderItem);

        //    return RedirectToAction("Details", "Order", new {order.Id});
        //}
    }
}
