using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingRegistrasi
{
    [TestFixture]
    public class UserTests
    {
        [Test]
        public void Login_ValidUser_ReturnsUserObject()
        {
            // Arrange
            var users = new List<User>()
        {
            new User("user1", "password1"),
            new User("user2", "password2"),
            new User("user3", "password3")
        };

            // Act
            User result = Login(users, "user1", "password1");

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("user1", result.Username);
            Assert.AreEqual("password1", result.Password);
        }

        [Test]
        public void Login_InvalidUser_ReturnsNull()
        {
            // Arrange
            var users = new List<User>()
        {
            new User("user1", "password1"),
            new User("user2", "password2"),
            new User("user3", "password3")
        };

            // Act
            User result = Login(users, "invaliduser", "invalidpassword");

            // Assert
            Assert.IsNull(result);
        }
    }

}
