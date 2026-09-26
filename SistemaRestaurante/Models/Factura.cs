using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaRestaurante.Models
{
	public class Factura
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

		public Pedido? Pedidos { get; set; }
		public Producto? Productos { get; set; }
	}
}
