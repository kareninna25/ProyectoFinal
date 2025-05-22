using System.ComponentModel.DataAnnotations;

namespace Proyecto.Data
{
    public class Alumna
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El número de cuenta es obligatorio.")]
        [RegularExpression(@"^\d{4}$", ErrorMessage = "El número de cuenta debe contener exactamente 4 dígitos.")]
        public int? Num_Cuenta { get; set; }

        [Required(ErrorMessage = "El Nombre es obligatorio.")]
        [StringLength(100, ErrorMessage = "El Nombre no puede tener más de 100 caracteres.")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "La fecha de nacimiento es obligatoria.")]
        [DataType(DataType.Date, ErrorMessage = "Debes ingresar una fecha válida.")]
        public DateTime? Fecha_Nacimiento { get; set; }

        [Required(ErrorMessage = "El campo Teléfono es obligatorio.")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "El número de teléfono debe contener exactamente 10 dígitos.")]
        public string? Contacto_Padres { get; set; }
    }
}