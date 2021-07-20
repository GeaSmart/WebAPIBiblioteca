using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIBiblioteca.Entidades;

namespace WebAPIBiblioteca
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Autor> Autor { get; set; } //el nombre de esta propiedad será el que tenga la tabla generada en la BD
    }
}
