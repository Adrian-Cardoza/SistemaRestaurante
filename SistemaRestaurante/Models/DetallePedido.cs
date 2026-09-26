using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaRestaurante.Models
{
	public class DetallePedido
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

		public Pedido? Pedidos { get; set; }
		public Producto? Productos { get; set; }
	}
}
