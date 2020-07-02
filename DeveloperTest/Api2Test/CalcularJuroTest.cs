using Api2.Core;
using Api2.Interfaces;
using Api2.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Threading.Tasks;

namespace Api2Test
{
    [TestClass]
    public class CalcularJuroTest
    {
        private static CalcularJuro calcularJuro;
        private static Mock<IJurosServices> services;

        [ClassInitialize]
        public static void Setup(TestContext testContext)
        {
            var response = new ResponseJuros()
            {
                Taxa = 0.01m
            };

            services = new Mock<IJurosServices>();
            services.Setup(s => s.GetAsync()).Returns(Task.FromResult(response));
            

            calcularJuro = new CalcularJuro(services.Object);
        }

        [TestMethod]
        public void should_calculate_interest_rate()
        {
            var expected = 105.10m;
            var actual = calcularJuro.JuroPorMesesAsync(100m, 5);

            Assert.AreEqual(expected, actual.Result.ValorFinal);
        }
    }
}
