using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_4.Interface
{
    public class SmsNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            s
            Console.WriteLine($"Sending SMS to {recipient}: {message}");
        }
    }
}
