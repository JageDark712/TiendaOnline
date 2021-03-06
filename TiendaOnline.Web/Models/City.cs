using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TiendaOnline.Web.Models
{
    public class City
    {
        public int Id { get; set; } 
        [Display(Name = "Ciudad")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe contener al menos un caracter")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Name { get; set; }
        public Department Department { get; set; }
        [NotMapped]
        public int IdDepartment { get; set; }
    }
}
