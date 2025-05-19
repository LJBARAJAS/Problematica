using Problematica.Components.Data;

namespace Problematica.Repositorio
{
    public interface IRepositorioEmpleados
    {
        Task<List<Empleado>> GetAll();
        Task<Empleado> Get(int id);
        Task Add(Empleado empleado);
        Task Update(Empleado empleado);
        Task Delete(int id);
    }
}
