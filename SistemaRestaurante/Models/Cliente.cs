using System.ComponentModel.DataAnnotations;

namespace SistemaRestaurante.Models
{
	public class Cliente
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[MaxLength(100)]
		public string Nombre { get; set; }

		[MaxLength(50)]
		public string? DUI { get; set; }


		[MaxLength(100)]
		public string? Correo { get; set; }

		public List<Pedido> Pedidos { get; set; } = new();

	}
}
