using Microsoft.EntityFrameworkCore;

namespace Problematica.Components.Data
{
    public class CatalogoBDContex : DbContext
    {
        public CatalogoBDContex(DbContextOptions<CatalogoBDContex> options) : base(options)
        {
            
        }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Puesto> Puestos { get; set; }
    }
}
