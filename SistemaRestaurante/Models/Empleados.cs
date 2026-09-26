namespace SistemaRestaurante.Models
{
	public class Empleados
	{
		public int Id { get; set; }
		public string Nombre { get; set; }
		public string Rol { get; set; }

		public List<Pedidos> Pedidos { get; set; } = new();
	}
}
