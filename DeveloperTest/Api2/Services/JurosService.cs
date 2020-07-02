using Api2.Interfaces;
using Api2.Model;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Api2.Services
{
    public class JurosService : IJurosServices
    {
        public HttpClient _client { get; }
        private readonly ILogger<JurosService> _logger;
        private readonly JurosServiceConfig _jurosConfig;

        public JurosService(ILogger<JurosService> logger, IOptions<JurosServiceConfig> options)
        {
            _logger = logger;
            _jurosConfig = options.Value;

            _client = new HttpClient();
        }

        public async Task<ResponseJuros> GetAsync()
        {
            try
            {
                _logger.LogInformation("Get Juros: ", _jurosConfig.BaseUrl);
                _logger.LogInformation("Get url complementar: ", _jurosConfig.ComplementaryUrl);

                _client.BaseAddress = new Uri(_jurosConfig.BaseUrl);
                var response = await _client.GetAsync(_jurosConfig.ComplementaryUrl);

                response.EnsureSuccessStatusCode();
                var jurosJson = await response.Content.ReadAsStringAsync();
                _logger.LogInformation("Juros recuperados na chamada da API: {juros}", jurosJson);

                var juros = JsonConvert.DeserializeObject<ResponseJuros>(jurosJson);

                return juros;
            }
            catch (Exception e)
            {
                throw new Exception(String.Format("Erro ao chamar api: {0}", e.Message), e.InnerException);
            }

        }
    }
}
