using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SistemaRestaurante.Models
{
    public class Facturas
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int IdPedido { get; set; }

        [Required]
        public DateTime FechaEmision { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Subtotal { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal? Descuento { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Total { get; set; }

        [Required]
        [MaxLength(20)]
        public string MetodoPago { get; set; }

        public Pedidos Pedidos { get; set; }
    }
}
