using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SistemaRestaurante.Models
{
    public class Mesa
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Numero { get; set; }

        [Required]
        public int Capacidad { get; set; }

        [Required]
        [MaxLength(20)]
        public string Estado { get; set; }

        public List<Pedido> Pedidos { get; set; } = new();
    }
}
