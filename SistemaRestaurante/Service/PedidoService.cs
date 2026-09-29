using Microsoft.EntityFrameworkCore;
using SistemaRestaurante.Data;
using SistemaRestaurante.Models;

namespace SistemaRestaurante.Service
{
	public class PedidoService
	{
		//Traer los pedidos de la base de datos
		public List<Pedido> ListaPedidos(string filtro = "")
		{
			using var ctx = new RestauranteContext();
			IQueryable<Pedido> consulta = ctx.Pedidos
				.Include(p => p.DetallesPedidos)
				.AsNoTracking();

			if (!string.IsNullOrWhiteSpace(filtro))
			{
				consulta = consulta.Where(p => p.Estado.ToLower().Contains(filtro.Trim().ToLower()));
			}
			return consulta.OrderByDescending(p => p.Fecha).ToList();
		}

		//Read
		public Pedido? ObtenerPedido(int id)
		{
			using var ctx = new RestauranteContext();
			return ctx.Pedidos
				.Include(p => p.DetallesPedidos)
				.ThenInclude(dp => dp.Productos)
				.FirstOrDefault(p => p.Id == id);
		}

		//Create
		public void CrearPedido(Pedido pedido)
		{
			using var ctx = new RestauranteContext();

			if (pedido.Fecha == default)
				pedido.Fecha = DateTime.Now;
			if (string.IsNullOrWhiteSpace(pedido.Estado))
				pedido.Estado = "Pendiente";

			Validar(ctx, pedido);
			ctx.Pedidos.Add(pedido);
			ctx.SaveChanges();
		}

		//Update
		public void ActualizarPedido(Pedido pedido)
		{
			using var ctx = new RestauranteContext();
			Pedido existente = ctx.Pedidos.Find(pedido.Id) ?? throw new InvalidOperationException("Pedido no encontrado");
			if (existente.Estado == "Facturado" || existente.Estado == "Cancelado")
			{
				throw new InvalidOperationException($"No se puede modificar un pedido en estado '{existente.Estado}'.");
			}

			Validar(ctx, pedido);
			existente.IdMesa = pedido.IdMesa;
			existente.IdEmpleado = pedido.IdEmpleado;
			existente.IdCliente = pedido.IdCliente;
			existente.Estado = pedido.Estado;
			ctx.SaveChanges();
		}

		//Estado
		public void CancelarPedido(int id)
		{
			using var ctx = new RestauranteContext();
			Pedido existente = ctx.Pedidos.Find(id)
				?? throw new InvalidOperationException("El pedido no fue encontrado.");

			if (existente.Estado == "Facturado")
			{
				throw new InvalidOperationException("No se puede cancelar un pedido que ya ha sido facturado.");
			}

			existente.Estado = "Cancelado";
			ctx.SaveChanges();
		}

		//Validar
		private void Validar(RestauranteContext ctx, Pedido pedido)
		{
			if (pedido.IdMesa <= 0)
				throw new ArgumentException("Debe seleccionar una mesa válida.");

			if (pedido.IdEmpleado <= 0)
				throw new ArgumentException("Debe asignar un empleado al pedido.");

			if (pedido.IdCliente <= 0)
				throw new ArgumentException("Debe asignar un cliente al pedido.");
		}
	}
}
