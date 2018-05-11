using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pro_AYD2_1.Account;

namespace Pro_AYD2_1.Tests
{
    [TestClass]
    public class Transaccion
    {
        [TestMethod]
        public void TestTransaccion()
        {
            WebForm2 a = new WebForm2();
            int valor_actual = 0;
            valor_actual = a.cantidad(-1);

            int valor_esperado = 0;

            Assert.AreEqual(valor_esperado, valor_actual);

        }
    }
}
