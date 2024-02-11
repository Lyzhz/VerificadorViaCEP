using Refit;
using CEPvia.Integração.Response;

namespace CEPvia.Integracao
{
    public interface IViaCEPIntegracaoRefit
    {
        [Get("/ws/{cep}/json")]
        Task<ApiResponse<ViaCEPResponse>> ObterDadosViaCep(string cep);
    }
}