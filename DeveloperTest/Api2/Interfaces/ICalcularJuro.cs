using Api2.Model;
using System.Threading.Tasks;

namespace Api2.Core
{
    public interface ICalcularJuro
    {
        Task<ResponseCalculoJuros> JuroPorMesesAsync(decimal Valor, int Meses);
    }
}