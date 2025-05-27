using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Proyecto.Data
{
    public class Comentario
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El ID de la alumna es obligatorio.")]
        public int AlumnaId { get; set; } 

        public Alumna? Alumna { get; set; } 

        [Required(ErrorMessage = "La fecha del comentario es obligatoria.")]
        [DataType(DataType.Date)]
        public DateTime Fecha_Comentario { get; set; }

        [Required(ErrorMessage = "El comentario de mejora es obligatorio.")]
        [StringLength(500)]
        public string? Comentario_Mejora { get; set; }

        [Required(ErrorMessage = "El comentario positivo es obligatorio.")]
        [StringLength(500)]
        public string? Comentario_Positivo { get; set; }
    }
}

