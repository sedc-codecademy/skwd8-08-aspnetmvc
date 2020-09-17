using System;
using System.Collections.Generic;
using System.Text;
using Services.Interfaces;

namespace Services.Implementations
{
    public class YahooNotificationService : INotificationService
    {
        public string Send(string text, string emailAddress)
        {
            //create mail
            //Send via Yahoo
            return "Mail Send via Yahoo";
        }
    }
}
