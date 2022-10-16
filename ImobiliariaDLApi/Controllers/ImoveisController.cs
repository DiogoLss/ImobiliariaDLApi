using ImobiliariaDLApi.Models;
using ImobiliariaDLApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ImobiliariaDLApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ImoveisController : ControllerBase
    {
        private readonly IImoveisRepository _ouw;
        public ImoveisController(IImoveisRepository ouw)
        {
            _ouw = ouw;
        }

        [HttpGet("teste1")]
        public ActionResult<IEnumerable<Imovel>> GetImoveis()
        {
            var imoveis = _ouw.Get();
            return Ok(imoveis);
        }
    }
}
