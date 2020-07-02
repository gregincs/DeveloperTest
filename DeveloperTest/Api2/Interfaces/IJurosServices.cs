using Api2.Model;
using System.Threading.Tasks;

namespace Api2.Interfaces
{
    public interface IJurosServices
    {
        Task<ResponseJuros> GetAsync();
    }
}
