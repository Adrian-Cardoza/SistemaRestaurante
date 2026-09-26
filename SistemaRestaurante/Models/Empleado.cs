using System.ComponentModel.DataAnnotations;

namespace SistemaRestaurante.Models
{
	public class Empleado
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[MaxLength(100)]

		public string Nombre { get; set; }

		[Required]
		[MaxLength(50)]
		public string Rol { get; set; }

		public List<Pedido> Pedidos { get; set; } = new();
	}
}
