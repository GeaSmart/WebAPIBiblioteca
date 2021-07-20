using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIBiblioteca.Entidades;

namespace WebAPIBiblioteca.Controllers
{
    [ApiController]
    [Route("api/autores")]
    public class AutoresController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Autor>> Get()
        {
            return new List<Autor>()
            {
                new Autor { Id = 1, Nombre = "Gerson" },
                new Autor { Id = 2, Nombre = "Luis" },
                new Autor { Id = 3, Nombre = "Antonio" }
            };
        }
    }
}
