namespace Sample.Logic
{
    using System;

    public interface INotification
    {
        String Message { get; set; }

        void ShowMessage(String message);
    }
}
