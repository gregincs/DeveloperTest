using Api2.Interfaces;
using Api2.Model;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Api2.Core
{
    public class CalcularJuro : ICalcularJuro
    {
        private readonly IJurosServices _jurosServices;

        public CalcularJuro(IJurosServices jurosServices)
        {
            _jurosServices = jurosServices;
        }

        public async Task<ResponseCalculoJuros> JuroPorMesesAsync(decimal Valor, int Meses)
        {
            var juros = await GetJurosAsync();

            var reponseCalculo = new ResponseCalculoJuros()
            {
                ValorFinal = Math.Round(decimal.Multiply(Valor, (decimal)Math.Pow((1 + (double)juros.Taxa), Meses)), 2)
            };

            return reponseCalculo;
        }

        private async Task<ResponseJuros> GetJurosAsync() => await _jurosServices.GetAsync();
    }
}
