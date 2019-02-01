namespace Sample.UI
{
    using Sample.Logic;
    using System;

    public class NotificationService : INotification
    {
        public String Message { get; set; }

        public void ShowMessage(String message)
        {
            Console.WriteLine(message);

            Message = message;
        }
    }
}
