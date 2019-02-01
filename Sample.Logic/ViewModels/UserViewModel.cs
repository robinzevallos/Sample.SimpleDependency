namespace Sample.Logic
{
    using System;

    public class UserViewModel
    {
        public INotification Notification => Instance<INotification>.Get();

        public Boolean Register(User user)
        {
            if (user.Name == String.Empty)
            {
                Notification.ShowMessage("Ingrese un nombre.");
                return false;
            }

            if (user.Name.Length < 5)
            {
                Notification.ShowMessage("Ingrese un nombre mayor o igual a 5 caracteres.");
                return false;
            }

            Notification.ShowMessage("Usuario Registrado.");
            return true;
        }
    }
}
