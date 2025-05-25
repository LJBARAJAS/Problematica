using Problematica.Components.Data;

namespace Problematica.Repositorio
{
    public interface IRepositorioEmpresa
    {
        Task<List<Empresa>> GetAll();
        Task<Empresa> Get(int id);
        Task Add(Empresa empresa);
        Task Update(Empresa empresa);
        Task Delete(int id);
    }
}