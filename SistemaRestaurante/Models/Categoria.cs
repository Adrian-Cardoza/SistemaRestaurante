using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SistemaRestaurante.Models
{
    public class Categoria
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }

        public List<Producto> Productos { get; set; } = new();
    }
}