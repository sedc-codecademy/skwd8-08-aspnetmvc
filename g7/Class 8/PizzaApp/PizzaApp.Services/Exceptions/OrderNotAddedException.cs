using System;

namespace PizzaApp.Services.Exceptions
{
    public class OrderNotAddedException : Exception
    {
        public OrderNotAddedException() : base()
        {

        }

        public OrderNotAddedException(string message) : base(message)
        {

        }

        public OrderNotAddedException(string message, Exception inner) : base(message, inner)
        {
                
        }
    }
}
