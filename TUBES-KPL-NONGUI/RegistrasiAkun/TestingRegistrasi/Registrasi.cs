using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

using TestingRegistrasi;

[TestFixture]
public class UserTests
{
    private List<User> users;

    [SetUp]
    public void SetUp()
    {
        users = new List<User>();
    }

    [Test]
    public void Register_WhenUsernameExists_ShouldReturnErrorMessage()
    {
        // Arrange
        User user1 = new User("user1", "password1");
        users.Add(user1);

        // Act
        string errorMessage = Register("user1", "password2");

        // Assert
        Assert.AreEqual("Username sudah digunakan.", errorMessage);
        Assert.AreEqual(1, users.Count);
    }

    [Test]
    public void Register_WhenUsernameDoesNotExist_ShouldAddUserToList()
    {
        // Act
        string errorMessage = Register("user2", "password2");

        // Assert
        Assert.IsNull(errorMessage);
        Assert.AreEqual(1, users.Count);
        Assert.AreEqual("user2", users[0].Username);
        Assert.AreEqual("password2", users[0].Password);
    }

    private string Register(string username, string password)
    {
        if (users.Exists(user => user.Username == username))
        {
            return "Username sudah digunakan.";
        }

        User newUser = new User(username, password);
        users.Add(newUser);

        return null;
    }
}

