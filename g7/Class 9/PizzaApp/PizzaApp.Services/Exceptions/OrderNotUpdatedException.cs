using System;

namespace PizzaApp.Services.Exceptions
{
    public class OrderNotUpdatedException : Exception
    {
        public OrderNotUpdatedException()
        {
                
        }

        public OrderNotUpdatedException(string message) : base(message)
        {

        }

        public OrderNotUpdatedException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
