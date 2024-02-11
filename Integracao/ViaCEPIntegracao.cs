using CEPvia.Integração.Response;
using CEPvia.Integracao;


namespace CEPvia.Integracao

{
    public class ViaCEPIntegracao : IViaCEPIntegracao
    {
        private readonly IViaCEPIntegracaoRefit _viaCEPIntegracaoRefit;

        public ViaCEPIntegracao(IViaCEPIntegracaoRefit viaCEPIntegracaoRefit)
        {
            _viaCEPIntegracaoRefit = viaCEPIntegracaoRefit;
        }

        public async Task<ViaCEPResponse> ObterDadosViaCep(string cep)
        {
            var responsedata = await _viaCEPIntegracaoRefit.ObterDadosViaCep(cep);
            
            if(responsedata != null && responsedata.IsSuccessStatusCode)
            {
                return responsedata.Content;
            }
            return null;
        }
    }
}
