namespace Sample.UI
{
    using Sample.Logic;
    using System;

    public class UserView
    {
        public UserView()
        {
            Console.WriteLine("--Registro de usuario--");
            Console.WriteLine("");
            Console.Write("Nombre: ");

            var user = new User
            {
                Name = Console.ReadLine()
            };

            new UserViewModel().Register(user);

            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}
