using almoxarifado3.NovaPasta1;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace almoxarifado3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly List<NovaPasta.Categoria> _categoria;

        public CategoriaController()
        {
            _categoria = new List<NovaPasta.Categoria>()
            {
                new NovaPasta.Categoria()
                {
                    Codigo = 1,
                    Descricao = "Bebidas"
                },
                new NovaPasta.Categoria()
                {
                    Codigo = 2,
                    Descricao = "Alimentos"
                }    
            }; 
        }

        [HttpGet("/Lista")]
        public IActionResult listaCategorias() 
        {
            return Ok(_categoria);
        }

        [HttpPost("/categoria")]
        public IActionResult listaCategorias(CategoriaDTO categoria)
        {
            return Ok(_categoria.Where(x=>x.Codigo==categoria.Codigo));
        }
    }
}
