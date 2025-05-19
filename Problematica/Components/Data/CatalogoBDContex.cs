using Microsoft.EntityFrameworkCore;

namespace Problematica.Components.Data
{
    public class CatalogoBDContex : DbContext
    {
        public CatalogoBDContex(DbContextOptions<CatalogoBDContex> options) : base(options)
        {
            
        }
        public DbSet<Empleado> Empleados { get; set; }
    }
}
