using System.ComponentModel.DataAnnotations;

namespace ElliotDvp_tarea03.Models
{
    public class Mascota
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La especie es obligatoria")]
        public string Especie { get; set; }

        [Required(ErrorMessage = "La edad es obligatoria")]
        public int Edad { get; set; }
    }
}