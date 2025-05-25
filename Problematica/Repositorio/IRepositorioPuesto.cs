using Problematica.Components.Data;

namespace Problematica.Repositorio
{
    public interface IRepositorioPuesto
    {
        Task<List<Puesto>> GetAll();
        Task<Puesto> Get(int id);
        Task Add(Puesto puesto);
        Task Update(Puesto puesto);
        Task Delete(int id);
    }
}
