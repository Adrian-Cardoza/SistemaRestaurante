using Microsoft.EntityFrameworkCore;
using SistemaRestaurante.Data;

namespace SistemaRestaurante.Forms
{
	public partial class FrmInicio : Form
	{
		private readonly RestauranteContext _context;
		public FrmInicio()
		{
			InitializeComponent();

			// Carga garantizada de datos al instanciar el formulario
			CargarMetricas();
			CargarPedidos();
		}

		private void FrmInicio_Load(object sender, EventArgs e)
		{
			CargarMetricas();
		}

		private void FrmInicio_Load_1(object sender, EventArgs e)
		{
			CargarMetricas();
		}

		public void CargarMetricas()
		{
			string textoMesas = "...";
			string textoPedidos = "...";
			string textoProductos = "...";

			try
			{
				using (var db = new RestauranteContext())
				{
					// 1. Conteo de mesas ocupadas
					int ocupadas = db.Mesas.Count(m => m.Estado != null && m.Estado.ToLower() == "ocupada");
					int totalMesas = db.Mesas.Count();
					if (totalMesas > 0)
					{
						textoMesas = $"{ocupadas} / {totalMesas}";
					}

					// 2. Conteo de pedidos pendientes o activos
					int pedidosActivos = db.Pedidos.Count(p => p.Estado != null && (p.Estado.ToLower() == "pendiente" || p.Estado.ToLower() == "en preparación"));
					textoPedidos = pedidosActivos.ToString();

					// 3. Conteo total de productos en catálogo
					int totalProductos = db.Productos.Count();
					if (totalProductos > 0)
					{
						textoProductos = totalProductos.ToString();
					}
				}
			}
			catch
			{
				// Mantiene los valores de demostración si la base de datos no está accesible aún
			}

			// Asignación segura buscando los controles por nombre directo o respaldos comunes
			AsignarTextoEtiqueta(new string[] { "lblMesasOcupadas", "label2", "lblMesas" }, textoMesas);
			AsignarTextoEtiqueta(new string[] { "lblPedidosActivos", "label3", "lblPedidos" }, textoPedidos);
			AsignarTextoEtiqueta(new string[] { "lblTotalProductos", "label4", "lblProductos" }, textoProductos);
		}

		private void AsignarTextoEtiqueta(string[] posiblesNombres, string valor)
		{
			foreach (string nombre in posiblesNombres)
			{
				Control[] encontrados = this.Controls.Find(nombre, true);
				if (encontrados.Length > 0 && encontrados[0] is Label lbl)
				{
					lbl.Text = valor;
					return;
				}
			}
		}

		// Métodos de respaldo para evitar errores con eventos generados por el Diseñador
		private void panel1_Paint_1(object sender, PaintEventArgs e)
		{
		}

		private void panel3_Paint(object sender, PaintEventArgs e)
		{

		}

		private void CargarPedidos()
		{
			using (var db = new RestauranteContext())
			{
				var pedidos = db.Pedidos
					.Include(p => p.Mesa)
					.Include(p => p.Empleado)
					.Include(p => p.Cliente)
					.OrderByDescending(p => p.Fecha)
					.Take(5)
					.ToList()
					.Select(p => new
					{
						Id = p.Id,

						Mesa = p.Mesa != null
							? p.Mesa.Numero.ToString()
							: "Para llevar",

						Empleado = p.Empleado != null
							? p.Empleado.Nombre
							: "No asignado",

						Cliente = p.Cliente != null
							? p.Cliente.Nombre
							: "Cliente general",

						Fecha = p.Fecha,
						Estado = p.Estado
					})
					.ToList();

				dgvPedidos.AutoGenerateColumns = true;
				dgvPedidos.DataSource = pedidos;
			}
		}
	}
}