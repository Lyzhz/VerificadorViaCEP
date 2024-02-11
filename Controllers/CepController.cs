using CEPvia.Integração.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.ConstrainedExecution;
using CEPvia.Models;
using Info.Data;
using Microsoft.AspNetCore.Routing.Template;
using Microsoft.EntityFrameworkCore;

namespace CEPvia.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
        public class CepControler : ControllerBase
        {
            private readonly IViaCEPIntegracao _viaCEPIntegracao;

            public CepControler(IViaCEPIntegracao viaCEPIntegracao)
            {
                _viaCEPIntegracao = viaCEPIntegracao;
            }

            [HttpGet("{cep}")]
            public async Task<ActionResult<ViaCEPResponse>> ListarDadosEndereco(string cep)
            {
                var ViaCEPResponse = await _viaCEPIntegracao.ObterDadosViaCep(cep);

                if (string.IsNullOrWhiteSpace(cep) || cep.Length != 8)
                {
                    return BadRequest("CEP Inválido");
                }
                return Ok(ViaCEPResponse);
            }
        }
    }