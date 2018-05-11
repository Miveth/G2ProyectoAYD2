using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pro_AYD2_1.Account;

namespace Pro_AYD2_1.Tests
{
    [TestClass]
    public class Consulta
    {
        [TestMethod]
        public void TestConsulta()
        {

            Consultar c = new Consultar();
            int valor_actual = 0;
            valor_actual = c.vacio("no es una cadena vacia");

            int valor_esperado = 0;

            Assert.AreEqual(valor_esperado, valor_actual);
        }
    }
}
