using CEPvia.Integração.Response;

namespace CEPvia.Integração.Response;

public interface IViaCEPIntegracao
{
    Task<ViaCEPResponse> ObterDadosViaCep(string cep);
}
