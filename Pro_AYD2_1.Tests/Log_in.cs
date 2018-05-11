using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pro_AYD2_1.Account;

namespace Pro_AYD2_1.Tests
{
    [TestClass]
    public class Log_in
    {
        [TestMethod]
        public void TestLogin()
        {
            Login l = new Login();
            Boolean esperado = l.logg();
            Boolean confirmado = true;
            Assert.AreEqual(esperado, confirmado);
        }
    }
}
