using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SistemaRestaurante.Models
{
    public class DetallesPedidos
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public int IdPedido { get; set; }

        [Required]
        public int IdProducto { get; set; }

        [Required]
        public int Cantidad { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal PrecioUnitario { get; set; }

        public Pedidos Pedidos { get; set; }
        public Productos Productos { get; set; }
    }
}
