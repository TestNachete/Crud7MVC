using System.ComponentModel.DataAnnotations;

namespace Crud7MVC.Models
{
    public class Contacto
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El Nombre es obligatorio")] 
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El Telefono es obligatorio")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "El Móvil es obligatorio")]
        public string Movil { get; set; }
        [Required(ErrorMessage = "El Email es obligatorio")]
        public string Email { get; set; }

        public DateTime FechaCreacion { get; set; }

    }
}
