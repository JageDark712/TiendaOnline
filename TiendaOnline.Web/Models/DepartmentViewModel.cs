using System.ComponentModel.DataAnnotations;

namespace TiendaOnline.Web.Models
{
    public class DepartmentViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Departamento")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe contener al menos un caracter")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Name { get; set; }
        public int IdCountry { get; set; }
    }
}
