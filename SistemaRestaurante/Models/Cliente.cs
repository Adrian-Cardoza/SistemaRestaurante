using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SistemaRestaurante.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; }

        [Required]
        public int DUI { get; set; }

        
        [MaxLength(100)]
        public string? Correo { get; set; }

        public List<Pedido> Pedidos { get; set; } = new();

    }
}
