using Api1.Model;
using DeveloperTest.Controllers;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Api1Test
{
    [TestClass]
    public class TaxaJurosControllerTest
    {
        private static TaxaJurosController controller;
        
        [ClassInitialize]
        public static void Setup(TestContext testContext)
        {
            var logger = Mock.Of<ILogger<TaxaJurosController>>();

            controller = new TaxaJurosController(logger);
        }

        [TestMethod]
        public void should_return_interest_rate()
        {
            var expected = new ResponseJuros() 
            {
                Taxa = 0.01m
            };

            var actual = controller.Get().Value;

            Assert.AreEqual(expected.Taxa, actual.Taxa);
        }
    }
}
