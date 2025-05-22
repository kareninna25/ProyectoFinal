using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Proyecto.Data
{
    public class BDDirectorioDBContext : DbContext
    {
        public BDDirectorioDBContext(
                   DbContextOptions<BDDirectorioDBContext> options
                                    ) : base(options)
        {
        }

        public DbSet<Alumna> Alumnas { get; set; }
        public DbSet<Clase> Clases { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }


    }
}