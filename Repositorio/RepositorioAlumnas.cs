using Proyecto.Data;
using Microsoft.EntityFrameworkCore;

namespace Proyecto.Repositorio
{
    public class RepositorioAlumnas : IRepositorioAlumnas
    {
        private readonly BDDirectorioDBContext _context;
        public RepositorioAlumnas(BDDirectorioDBContext context)
        {
            _context = context;
        }
        public async Task<List<Alumna>> GetAll()
        {
            return await _context.Alumnas.ToListAsync();
        }
        public async Task<Alumna> Get(int id)
        {
            return await _context.Alumnas.FindAsync(id);
        }
        public async Task Add(Alumna alumna)
        {
            _context.Alumnas.Add(alumna);
            await _context.SaveChangesAsync();
        }
        public async Task Update(Alumna alumna)
        {
            _context.Alumnas.Update(alumna);
            await _context.SaveChangesAsync();
        }
        public async Task Delete(int id)
        {
            var alumna = await Get(id);
            _context.Alumnas.Remove(alumna);
            await _context.SaveChangesAsync();
        }
    }
}