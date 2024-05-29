using Xunit;
using Atividade07;
using NSubstitute;
namespace Atividade07.Tests;

public class UserServiceTests
{
    [Fact]
    public void Register_WithValidUser_ReturnsTrue()
    {
        var db= Substitute.For<IDatabase>();
        var user = new User("John Doe", "email@email.com");
        var userService = new UserService(db);

        userService.SaveUser(user);
        db.Received().SaveUser(user);

    }

    // [Fact]
    // public void Register_WithInvalidUser_ThrowsArgumentException()
    // {
    //     var db= Substitute.For<IDatabase>();
    //     var user = new User("", "");
    //     var userService = new UserService(db);

    //     Assert.Throws<ArgumentException>(() => userService.SaveUser(user));
    // }

    [Fact]
    public void Register_WithNullUser_ThrowsArgumentException()
    {
        var db= Substitute.For<IDatabase>();
        var userService = new UserService(db);
        var user = new User(null, null);

        Assert.Throws<ArgumentException>(() => userService.SaveUser(user));
    }

    [Fact]
    public void Register_WithNullName_ThrowsArgumentException()
    {
        var db= Substitute.For<IDatabase>();
        var user = new User(null, "email");
        var userService = new UserService(db);

        Assert.Throws<ArgumentException>(() => userService.SaveUser(user));
    }

    [Fact]
    public void Register_WithNullEmail_ThrowsArgumentException()
    {
        var db= Substitute.For<IDatabase>();
        var user = new User("name", null);
        var userService = new UserService(db);

        Assert.Throws<ArgumentException>(() => userService.SaveUser(user));
    }
}
