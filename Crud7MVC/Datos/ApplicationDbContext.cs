using Crud7MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace Crud7MVC.Datos
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}

        //Agregar los modelos aquí
        public DbSet<Contacto> Contactos { get; set; }

    }
}
