using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        private readonly ApplicationDbContext context;

        public AutoresController(ApplicationDbContext context)
        {
            this.context = context;
        }

        

        [HttpGet]
        public async Task<ActionResult<List<Autor>>> Get()
        {            
            return await context.Autor.ToListAsync();            
        }

        [HttpPost]
        public async Task<ActionResult> Post(Autor autor)
        {
            context.Add(autor);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut("{id:int}")]//especificamos un parámetro de ruta
        public async Task<ActionResult> Put(Autor autor, int id)
        {
            if (autor.Id != id)
                return BadRequest("El id del autor no coincide con el id de la URL");

            var existe = await context.Autor.AnyAsync(x => x.Id == id);
            if (!existe)
                return NotFound();

            context.Update(autor);            
            await context.SaveChangesAsync();
            return Ok();            
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var existe = await context.Autor.AnyAsync(x => x.Id == id);
            if (!existe)
                return NotFound();

            context.Remove(new Autor() { Id = id });
            await context.SaveChangesAsync();

            return Ok();
        }


    }
}
