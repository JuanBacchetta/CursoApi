using CursoApi.Modelos;
using CursoApi.Modelos.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CursoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VillaController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<VillaDto> GetVillas()
        {
            return new List<VillaDto>
            {
                new VillaDto {Id = 1, Nombre = "Vista a la persona"},
                new VillaDto {Id = 2, Nombre = "Vista a la playa"}
            };
        }
    }
}
