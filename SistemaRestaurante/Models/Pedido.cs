using System.ComponentModel.DataAnnotations;

namespace SistemaRestaurante.Models
{
	public class Pedido
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
		public List<DetallePedido> DetallesPedidos { get; set; } = new();

		public Mesa? Mesa { get; set; }
		public Empleado? Empleado { get; set; }
		public Cliente? Cliente { get; set; }
		public Factura? Factura { get; set; }
	}
}
