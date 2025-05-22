using Proyecto.Data;

namespace Proyecto.Repositorio
{
    public interface IRepositorioComentarios
    {
        Task<List<Comentario>> GetAll();
        Task<Comentario> Get(int id);
        Task Add(Comentario comentario);
        Task Update(Comentario comentario);
        Task Delete(int id);
    }
}

