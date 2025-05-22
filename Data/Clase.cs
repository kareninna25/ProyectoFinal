using System.ComponentModel.DataAnnotations;

namespace Proyecto.Data
{
    public class Clase
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre de la clase es obligatorio.")]
        [StringLength(100, ErrorMessage = "El nombre no puede tener más de 100 caracteres.")]
        public string? Nombre_Clase { get; set; }

        [Required(ErrorMessage = "El día de la semana es obligatorio.")]
        [RegularExpression(@"^(Lunes|Martes|Miércoles|Jueves|Viernes|Sábado|Domingo)$",
             ErrorMessage = "El día de la semana debe ser válido (Lunes a Domingo).")]
        public string? Dia_Semana { get; set; }

        [Required(ErrorMessage = "El horario es obligatorio.")]
        [RegularExpression(@"^\d{2}:\d{2}\s*-\s*\d{2}:\d{2}$",
                   ErrorMessage = "El horario debe estar en formato HH:MM - HH:MM.")]
        public string? Horario { get; set; }

        [Required(ErrorMessage = "La alumna es obligatoria.")]
        public int? Num_Cuenta { get; set; }
    }
}
