using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CurrencyExchangeAPI.Controllers.Tests
{
    [TestClass()]
    public class ExchangeRatesControllerTests
    {
        [TestMethod()]
        public void GetTest()
        {
            string from = "USD";
            string to = "EUR";

            var controller = new ExchangeRatesController();
            var result = controller.Get(from, to);
            Assert.AreEqual(0.90, result);
        }
    }
}