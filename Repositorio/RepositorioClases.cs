using Proyecto.Data;
using Microsoft.EntityFrameworkCore;

namespace Proyecto.Repositorio
{
    public class RepositorioClases : IRepositorioClases
    {
        private readonly BDDirectorioDBContext _context;

        public RepositorioClases(BDDirectorioDBContext context)
        {
            _context = context;
        }

        public async Task<List<Clase>> GetAll()
        {
            return await _context.Clases.AsNoTracking().ToListAsync();
        }

        public async Task<Clase> Get(int id)
        {
            return await _context.Clases.FindAsync(id);
        }

        public async Task Add(Clase clase)
        {
            _context.Clases.Add(clase);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Clase clase)
        {
            _context.Clases.Update(clase);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var clase = await Get(id);
            if (clase != null)
            {
                _context.Clases.Remove(clase);
                await _context.SaveChangesAsync();
            }
        }
    }
}
