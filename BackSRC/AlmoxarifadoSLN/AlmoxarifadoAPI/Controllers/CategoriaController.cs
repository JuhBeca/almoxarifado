using AlmoxarifadoAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlmoxarifadoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly List<Categoria> _categorias;

        public CategoriaController()
        {
            _categorias = new List<Categoria>() {
                new Categoria()
                {
                    Codigo = 1,
                    Descricao = "Alimentos"
                },
                new Categoria()
                {
                    Codigo = 2,
                    Descricao = "Bebidas"
                }
            };
        }


            [HttpGet(Name = "lista")]




            public ActionResult<Categoria> GetCategorias()
            {

                return Ok(_categorias);
            }

            [HttpGet("{id:int}", Name = "Categoria")]
            public ActionResult<Categoria> GetCategorias(int id)
            {

                return Ok(_categorias.Where(l => l.Codigo == id));
            }
        
    }
}
