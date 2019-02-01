using Sample.Logic;
using System;

namespace UnitTest
{
    public class NotificationService_Mock : INotification
    {
        public String Message { get; set; }

        public void ShowMessage(String message)
        {
            Message = message;
        }
    }
}
