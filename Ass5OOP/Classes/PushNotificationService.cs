using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ass5OOP.Interfaces;

namespace Ass5OOP.Classes
{
    internal class PushNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"Push Notification sent to {recipient}");
        }
    }
}
