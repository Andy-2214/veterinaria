using System.ComponentModel.DataAnnotations;

namespace Veterinaria.Models
{
    public class Mascota
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nombre de la mascota")]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Animal")]
        public string Animal { get; set; } = string.Empty;

        [Required]
        [Range(0, 50, ErrorMessage = "La edad debe estar entre 0 y 50 años")]
        public int Edad { get; set; }

        [Required]
        [Display(Name = "Sexo")]
        public string Sexo { get; set; } = string.Empty;
    }
}
