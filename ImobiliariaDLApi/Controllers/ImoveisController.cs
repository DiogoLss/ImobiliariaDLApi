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
        private readonly IUnitOfWork _ouw;
        public ImoveisController(IUnitOfWork ouw)
        {
            _ouw = ouw;
        }

        [HttpGet("imoveis")]
        public ActionResult<IEnumerable<Imovel>> GetImoveis()
        {
            var imoveis = _ouw.Imoveis.Get();
            return Ok(imoveis);
        }
    }
}
