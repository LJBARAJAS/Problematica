using System.ComponentModel.DataAnnotations;

namespace Problematica.Components.Data
{
    public class Empresa
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100, ErrorMessage = "El nombre no puede exceder los 100 caracteres")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "El numero de sucursal es obligatorio")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe ser un número positivo.")]
        public int NumDeSucursal { get; set; }
        virtual public ICollection<Empleado>? Empleados { get; set; }
    }
}
