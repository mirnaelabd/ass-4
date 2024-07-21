using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_4.Interface
{
    public class PushNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
           
            Console.WriteLine($"Sending push notification to {recipient}: {message}");
        }
    }
}
