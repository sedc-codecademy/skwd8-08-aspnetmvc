using System;
using System.Collections.Generic;
using System.Text;
using Services.Interfaces;

namespace Services.Implementations
{
    public class GoogleNotificationService : INotificationService
    {
        public string Send(string text, string emailAddress)
        {
            //create mail
            //Send via Gmail
            return "Mail send via Gmail";
        }
    }
}
