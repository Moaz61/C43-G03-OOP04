using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass5OOP.Interfaces
{
    internal interface INotificationService
    {
        void SendNotification(string recipient, string message);
    }
}
