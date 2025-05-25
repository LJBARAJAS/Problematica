using Microsoft.EntityFrameworkCore;
using Problematica.Components.Data;

namespace Problematica.Repositorio
{
    public class RepositorioEmpleados : IRepositorioEmpleados
    {
        private readonly CatalogoBDContex _context;

        public RepositorioEmpleados(CatalogoBDContex context)
        {
            _context = context;
        }

        public async Task Add(Empleado empleado)
        {
            await _context.Empleados.AddAsync(empleado);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            await _context.Database.ExecuteSqlRawAsync("DELETE FROM Empleados WHERE Id = {0}", id);
        }

        public async Task<Empleado> Get(int id)
        {
            return await _context.Empleados.FindAsync(id) ?? new Empleado();
        }

        public async Task<List<Empleado>> GetAll()
        {
            return await _context.Empleados.ToListAsync();
        }
        public async Task<List<Empresa>> GetEmpresas()
        {
            return await _context.Empresas.ToListAsync();
        }
        public async Task<List<Puesto>> GetPuestos()
        {
            return await _context.Puestos.ToListAsync();
        }

        public async Task Update(Empleado empleado)
        {
            _context.Entry(empleado).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }


    }
}
