using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class ProgramTest
    {
        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        [TestMethod]
        public void TestRegister()
        {
            List<User> users = new List<User>();

            Program.Register(users, "testuser", "testpass");
            Assert.AreEqual(1, users.Count);

            // Register with same username should fail
            Program.Register(users, "testuser", "testpass");
            Assert.AreEqual(1, users.Count);
        }

        [TestMethod]
        public void TestLogin()
        {
            List<User> users = new List<User>();
            Program.Register(users, "testuser", "testpass");

            // Login with correct credentials should succeed
            User user = Program.Login(users, "testuser", "testpass");
            Assert.IsNotNull(user);

            // Login with incorrect credentials should fail
            user = Program.Login(users, "testuser", "wrongpass");
            Assert.IsNull(user);
        }

        [TestMethod]
        public void TestLogout()
        {
            List<User> users = new List<User>();
            Program.Register(users, "testuser", "testpass");
            User user = Program.Login(users, "testuser", "testpass");

            // Logout should set loggedIn to false and currentUser to null
            Program.Logout(ref user, ref users);
            Assert.IsNull(user);
        }
    }
}
