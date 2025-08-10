using System;

namespace TuProyecto.Models
{
    public class ProductoMascota
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; } // Ej: Alimento, Juguete, Higiene
        public decimal Precio { get; set; }
        public int Stock { get; set; }
    }
}
