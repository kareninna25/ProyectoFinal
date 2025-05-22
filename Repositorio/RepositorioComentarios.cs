using Proyecto.Data;
using Microsoft.EntityFrameworkCore;

namespace Proyecto.Repositorio
{
    public class RepositorioComentarios : IRepositorioComentarios
    {
        private readonly BDDirectorioDBContext _context;

        public RepositorioComentarios(BDDirectorioDBContext context)
        {
            _context = context;
        }

        public async Task<List<Comentario>> GetAll()
        {
            return await _context.Comentarios.Include(c => c.Alumna).ToListAsync();
        }

        public async Task<Comentario> Get(int id)
        {
            return await _context.Comentarios.Include(c => c.Alumna).FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task Add(Comentario comentario)
        {
            _context.Comentarios.Add(comentario);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Comentario comentario)
        {
            _context.Comentarios.Update(comentario);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var comentario = await Get(id);
            if (comentario != null)
            {
                _context.Comentarios.Remove(comentario);
                await _context.SaveChangesAsync();
            }
        }
    }
}
