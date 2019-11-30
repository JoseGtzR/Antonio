using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccountNS;

namespace TestUnitario
{
    [TestClass]
    public class BankAccountTest
    {
        [TestMethod]
        public void Debit1()
        {
            double resta = 11.99;
            double resta1 = 0.77;
            double esperado = 11.22;
            BankAccount RestaTotal = new BankAccount("Jose G", resta);

            RestaTotal.Debit(resta1);

            double ahora = RestaTotal.Balance;
            Assert.AreEqual(esperado, RestaTotal);
        }


        [TestMethod]
        public void Credit1()
        {
            double suma = 11;
            double suma1 = 0.77;
            double esperado = 11.77;
            BankAccount SumaTotal = new BankAccount("Jose G", suma);

            SumaTotal.Debit(suma1);

            double ahora = SumaTotal.Balance;
            Assert.AreEqual(esperado, SumaTotal);

        }
    }
}
