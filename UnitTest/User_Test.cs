using Sample.Logic;
using Xunit;

public class User_Test
{
    [Fact]
    public void ValidateRegister()
    {
        var user = new User
        {
            Name = "Jua"
        };

        var userViewModel = new UserViewModel();

        Assert.True(userViewModel.Register(user), userViewModel.Notification.Message);
    }
}
