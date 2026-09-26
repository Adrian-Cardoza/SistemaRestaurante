using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SistemaRestaurante.Models
{
    public class Pedidos
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int IdMesa { get; set; }

        [Required]
        public int IdEmpleado { get; set; }

        [Required]
        public int IdCliente { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        [MaxLength(25)]
        public string Estado { get; set; }
        public List<DetallesPedidos> DetallesPedidos { get; set; } = new();
    }
}
