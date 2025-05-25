using System.ComponentModel.DataAnnotations;

namespace Problematica.Components.Data
{
    public class Puesto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100, ErrorMessage = "El nombre no puede exceder los 100 caracteres")]
        public string? NombreDelPuesto { get; set; }
        [Required(ErrorMessage = "El sueldo del puesto es obligatorio")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe ser un número positivo.")]
        public int SueldoBase { get; set; }
        virtual public ICollection<Empleado>? Empleados { get; set; }

    }
}
