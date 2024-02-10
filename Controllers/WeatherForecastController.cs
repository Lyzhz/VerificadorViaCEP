using CEPvia.Models;
using Info.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Template;
using Microsoft.EntityFrameworkCore;

namespace CEPvia.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        [Route("RetornaEndereco")]
        public ActionResult RetornaEndereco(string CEP)
        {
            if (string.IsNullOrWhiteSpace(CEP) || CEP.Length != 8)
            {
                return BadRequest("CEP Inválido");
            }

            return Ok();
        }
    }
}
