using System;
using System.Collections.Generic;
using System.Linq;
using DomainModels;

namespace DataAccess.Implementations
{
    public class OrderItemRepository : IRepository<OrderItem>
    {
        public List<OrderItem> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public OrderItem GetById(int id)
        {
            Customer customer =
                StaticDatabase.Customers.FirstOrDefault(
                    x => x.Orders.Any(y => y.OrderItems.Any(z => z.Id == id)));

            if (customer == null)
            {
                throw new Exception("Customer not found");
            }

            Order order = customer.Orders.FirstOrDefault(x => x.OrderItems.Any(y => y.Id == id));

            if (order == null)
            {
                throw new Exception("Order not found");
            }

            OrderItem orderItem = order.OrderItems.FirstOrDefault(x => x.Id == id);

            if (orderItem == null)
            {
                throw new Exception("Order item not found");
            }

            return orderItem;
        }

        public int Insert(OrderItem entity)
        {
            Customer customer =
                StaticDatabase.Customers.FirstOrDefault(
                    x => x.Orders.Any(y => y.Id == entity.OrderId));

            if (customer == null)
            {
                throw new Exception("Customer not found");
            }

            Order order = customer.Orders.FirstOrDefault(x => x.Id == entity.OrderId);

            if (order == null)
            {
                throw new Exception("Order not found");
            }

            int customerIndex = StaticDatabase.Customers.IndexOf(customer);
            int orderIndex = customer.Orders.IndexOf(order);

            order.OrderItems.Add(entity);

            customer.Orders[orderIndex] = order;
            StaticDatabase.Customers[customerIndex] = customer;

            return entity.Id;
        }

        public void Update(OrderItem entity)
        {
            Customer customer =
                StaticDatabase.Customers.FirstOrDefault(
                    x => x.Orders.Any(y => y.Id == entity.OrderId));

            if (customer == null)
            {
                throw new Exception("Customer not found");
            }

            Order order = customer.Orders.FirstOrDefault(x => x.Id == entity.OrderId);

            if (order == null)
            {
                throw new Exception("Order not found");
            }

            OrderItem orderItem = order.OrderItems.FirstOrDefault(x => x.Id == entity.Id);

            if (orderItem == null)
            {
                throw new Exception("Order item not found");
            }

            int customerIndex = StaticDatabase.Customers.IndexOf(customer);
            int orderIndex = customer.Orders.IndexOf(order);
            int orderItemIndex = order.OrderItems.IndexOf(orderItem);

            order.OrderItems[orderItemIndex] = entity;
            customer.Orders[orderIndex] = order;
            StaticDatabase.Customers[customerIndex] = customer;
        }

        public void Delete(int id)
        {
            Customer customer =
                StaticDatabase.Customers.FirstOrDefault(
                    x => x.Orders.Any(y => y.OrderItems.Any(z => z.Id == id)));

            if (customer == null)
            {
                throw new Exception("Customer not found");
            }

            Order order = customer.Orders.FirstOrDefault(x => x.OrderItems.Any(y => y.Id == id));

            if (order == null)
            {
                throw new Exception("Order not found");
            }

            OrderItem orderItem = order.OrderItems.FirstOrDefault(x => x.Id == id);

            if (orderItem == null)
            {
                throw new Exception("Order item not found");
            }

            int customerIndex = StaticDatabase.Customers.IndexOf(customer);
            int orderIndex = customer.Orders.IndexOf(order);
            int orderItemIndex = order.OrderItems.IndexOf(orderItem);

            order.OrderItems.RemoveAt(orderItemIndex);
            customer.Orders[orderIndex] = order;
            StaticDatabase.Customers[customerIndex] = customer;
        }
    }
}
