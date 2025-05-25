using Microsoft.EntityFrameworkCore;
using Problematica.Components.Data;

namespace Problematica.Repositorio
{
    public class RepositorioPuesto : IRepositorioPuesto
    {
        private readonly CatalogoBDContex _context;

        public RepositorioPuesto(CatalogoBDContex context)
        {
            _context = context;
        }

        public async Task Add(Puesto puesto)
        {
            await _context.Puestos.AddAsync(puesto);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            await _context.Database.ExecuteSqlRawAsync("DELETE FROM Puestos WHERE Id = {0}", id);
        }

        public async Task<Puesto> Get(int id)
        {
            return await _context.Puestos.FindAsync(id) ?? new Puesto(); // o null si prefieres
        }

        public async Task<List<Puesto>> GetAll()
        {
            return await _context.Puestos.ToListAsync();
        }
        public async Task Update(Puesto puesto)
        {
            _context.Entry(puesto).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
