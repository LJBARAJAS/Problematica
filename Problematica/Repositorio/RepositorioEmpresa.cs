using Microsoft.EntityFrameworkCore;
using Problematica.Components.Data;

namespace Problematica.Repositorio
{
    public class RepositorioEmpresa : IRepositorioEmpresa
    {
        private readonly CatalogoBDContex _context;

        public RepositorioEmpresa(CatalogoBDContex context)
        {
            _context = context;
        }

        public async Task Add(Empresa empresa)
        {
            await _context.Empresas.AddAsync(empresa);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            await _context.Database.ExecuteSqlRawAsync("DELETE FROM Empresas WHERE Id = {0}", id);
        }

        public async Task<Empresa> Get(int id)
        {
            return await _context.Empresas.FindAsync(id) ?? new Empresa(); // o null si prefieres
        }

        public async Task<List<Empresa>> GetAll()
        {
            return await _context.Empresas.ToListAsync();
        }
        public async Task Update(Empresa empresa)
        {
            _context.Entry(empresa).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}

