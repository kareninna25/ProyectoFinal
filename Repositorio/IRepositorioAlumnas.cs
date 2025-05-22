using Proyecto.Data;

namespace Proyecto.Repositorio
{
    public interface IRepositorioAlumnas
    {
        Task<List<Alumna>> GetAll();
        Task<Alumna> Get(int id);
        Task Add(Alumna alumna);
        Task Update(Alumna alumna);
        Task Delete(int id);
    }
}
