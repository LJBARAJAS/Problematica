
using System.ComponentModel.DataAnnotations;

namespace Problematica.Components.Data
{
    public class Empleado
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100, ErrorMessage = "El nombre no puede exceder los 100 caracteres")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "El numero de empleado es obligatorio")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe ser un número positivo.")]
        public int? NumEmpleado { get; set; }
        [Required(ErrorMessage = "El departamento es obligatoria")]
        public string? Departamento { get; set; }
        public int EmpresaId { get; set; }
        virtual public Empresa? Empresa { get; set; }
        public int PuestoId { get; set; }
        virtual public Puesto? Puesto { get; set; }
    }
}
