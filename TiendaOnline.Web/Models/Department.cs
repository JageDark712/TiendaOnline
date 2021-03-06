using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TiendaOnline.Web.Models
{
    public class Department
    {
        public int Id { get; set; }
        [Display(Name = "Departamento")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe contener al menos un caracter")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Name { get; set; }
        public Country Country { get; set; }
        public ICollection<City> Cities { get; set; }
        [Display(Name = "Numero de Ciudades")]
        public int CitiesNumber => Cities == null ? 0 : Cities.Count;
        [NotMapped]
        public int IdCountry { get; set; }
    }
}
