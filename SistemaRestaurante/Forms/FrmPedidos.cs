using SistemaRestaurante.Data;
using SistemaRestaurante.Models;
using SistemaRestaurante.Service;
using System.ComponentModel;
using System.Data;


namespace SistemaRestaurante.Forms
{
	public partial class FrmPedidos : Form
	{
		private readonly PedidoService _pedidoService;
		// Lista temporal para almacenar los productos agregados al pedido actual antes de guardarlo
		private BindingList<DetallePedidoItem> _listaDetalles;

		public FrmPedidos()
		{
			InitializeComponent();
			_pedidoService = new PedidoService();
			_listaDetalles = new BindingList<DetallePedidoItem>();

			RefrescarLista();
			CargarEmpleados();
			CargarClientes();
			CargarMesas();
			CargarProductos();
			CargarEstados();
			ConfigurarGridPedidos();
			ConfigurarGridDetalles();
		}

		private void FrmPedidos_Load(object? sender, EventArgs e)
		{
			rbComerAqui.Checked = true; // Por defecto inicia en Comer aquí
		}

		private void RefrescarLista(string filtro = "")
		{
			dgvPedidos.DataSource = _pedidoService.ListaPedidos(filtro);
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			try
			{
				// Validaciones básicas
				if (cmbEmpleado.SelectedIndex < 0 || cmbCliente.SelectedIndex < 0)
				{
					MessageBox.Show("Debe seleccionar Empleado y Cliente.");
					return;
				}

				// Si es "Comer aquí", la mesa es obligatoria
				if (rbComerAqui.Checked && cmbMesa.SelectedIndex < 0)
				{
					MessageBox.Show("Debe seleccionar una Mesa para pedidos de tipo 'Comer aquí'.");
					return;
				}

				if (_listaDetalles.Count == 0)
				{
					MessageBox.Show("Debe agregar al menos un producto al pedido.");
					return;
				}

				// Crear el objeto Pedido
				var pedido = new Pedido
				{
					IdMesa = rbComerAqui.Checked ? Convert.ToInt32(cmbMesa.SelectedValue) : (int?)null,
					IdEmpleado = Convert.ToInt32(cmbEmpleado.SelectedValue),
					IdCliente = Convert.ToInt32(cmbCliente.SelectedValue),
					Estado = string.IsNullOrWhiteSpace(cmbEstado.Text) ? "Pendiente" : cmbEstado.Text.Trim(),
					Fecha = dtpFecha.Value,
					// Mapear los detalles del pedido
					DetallesPedidos = _listaDetalles.Select(d => new DetallePedido
					{
						IdProducto = d.IdProducto,
						Cantidad = d.Cantidad
					}).ToList()
				};

				_pedidoService.CrearPedido(pedido);
				MessageBox.Show("Pedido creado correctamente.");
				RefrescarLista();
				LimpiarFormulario();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message}");
			}
		}

		private void btnEditar_Click(object sender, EventArgs e)
		{
			if (dgvPedidos.CurrentRow == null)
			{
				MessageBox.Show("Seleccione un pedido de la lista.");
				return;
			}

			try
			{
				int id = Convert.ToInt32(dgvPedidos.CurrentRow.Cells["Id"].Value);
				var pedido = new Pedido
				{
					Id = id,
					IdMesa = rbComerAqui.Checked ? Convert.ToInt32(cmbMesa.SelectedValue) : (int?)null,
					IdEmpleado = Convert.ToInt32(cmbEmpleado.SelectedValue),
					IdCliente = Convert.ToInt32(cmbCliente.SelectedValue),
					Estado = cmbEstado.Text.Trim(),
					Fecha = dtpFecha.Value
				};

				_pedidoService.ActualizarPedido(pedido);
				MessageBox.Show("Pedido actualizado correctamente.");
				RefrescarLista();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message}");
			}
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			if (dgvPedidos.CurrentRow == null)
			{
				MessageBox.Show("Seleccione un pedido de la lista.");
				return;
			}

			try
			{
				int id = Convert.ToInt32(dgvPedidos.CurrentRow.Cells["Id"].Value);
				_pedidoService.CancelarPedido(id);
				MessageBox.Show("Pedido cancelado.");
				RefrescarLista();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message}");
			}
		}

		// Método para agregar producto a la lista temporal del pedido actual
		private void btnAgregarProducto_Click(object sender, EventArgs e)
		{
			if (cmbProducto.SelectedIndex < 0)
			{
				MessageBox.Show("Seleccione un producto.");
				return;
			}

			int idProducto = Convert.ToInt32(cmbProducto.SelectedValue);
			string nombreProducto = cmbProducto.Text;

			// Si 'Cant.' es un ComboBox o TextBox, aseguramos leer el valor numérico
			if (!int.TryParse(nudCantidad.Value.ToString(), out int cantidad) || cantidad <= 0)
			{
				MessageBox.Show("Ingrese una cantidad válida.");
				return;
			}

			// Agregar a la lista temporal
			_listaDetalles.Add(new DetallePedidoItem
			{
				IdProducto = idProducto,
				Nombre = nombreProducto,
				Cantidad = cantidad
			});

			cmbProducto.SelectedIndex = -1;
			nudCantidad.Value = 0;
		}

		private void txtBuscar_TextChanged(object sender, EventArgs e)
		{
			RefrescarLista(txtBuscar.Text.Trim());
		}

		#region Métodos de Carga de Comboboxes
		private void CargarMesas()
		{
			using var ctx = new RestauranteContext();
			cmbMesa.DataSource = ctx.Mesas.Select(m => new { m.Id, m.Numero }).ToList();
			cmbMesa.DisplayMember = "Numero";
			cmbMesa.ValueMember = "Id";
			cmbMesa.SelectedIndex = -1;
		}

		private void CargarEmpleados()
		{
			using var ctx = new RestauranteContext();
			cmbEmpleado.DataSource = ctx.Empleados.Select(e => new { e.Id, e.Nombre }).ToList();
			cmbEmpleado.DisplayMember = "Nombre";
			cmbEmpleado.ValueMember = "Id";
			cmbEmpleado.SelectedIndex = -1;
		}

		private void CargarClientes()
		{
			using var ctx = new RestauranteContext();
			cmbCliente.DataSource = ctx.Clientes.Select(c => new { c.Id, c.Nombre }).ToList();
			cmbCliente.DisplayMember = "Nombre";
			cmbCliente.ValueMember = "Id";
			cmbCliente.SelectedIndex = -1;
		}

		private void CargarProductos()
		{
			using var ctx = new RestauranteContext();
			cmbProducto.DataSource = ctx.Productos.Select(p => new { p.ID, p.Nombre }).ToList();
			cmbProducto.DisplayMember = "Nombre";
			cmbProducto.ValueMember = "ID";
			cmbProducto.SelectedIndex = -1;
		}

		private void CargarEstados()
		{
			cmbEstado.DataSource = new List<string> { "Pendiente", "Facturado", "Cancelado" };
			cmbEstado.SelectedIndex = -1;
		}
		#endregion

		#region Configuración de Grids
		private void ConfigurarGridPedidos()
		{
			dgvPedidos.AutoGenerateColumns = false;
			dgvPedidos.Columns.Clear();

			dgvPedidos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "ID", Width = 50 });
			dgvPedidos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Fecha", HeaderText = "Fecha", Width = 120 });
			dgvPedidos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Estado", HeaderText = "Estado", Width = 100 });
			dgvPedidos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Cliente.Nombre", HeaderText = "Cliente", Width = 150 });
			dgvPedidos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Empleado.Nombre", HeaderText = "Empleado", Width = 150 });
			dgvPedidos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Mesa.Numero", HeaderText = "Mesa", Width = 80 });
		}

		private void ConfigurarGridDetalles()
		{
			dgvDetalles.AutoGenerateColumns = false;
			dgvDetalles.Columns.Clear();

			// Columna para el nombre del producto
			dgvDetalles.Columns.Add(new DataGridViewTextBoxColumn
			{
				DataPropertyName = "Nombre",
				HeaderText = "Producto",
				Width = 200
			});

			// Columna para la cantidad
			dgvDetalles.Columns.Add(new DataGridViewTextBoxColumn
			{
				DataPropertyName = "Cantidad",
				HeaderText = "Cantidad",
				Width = 80
			});

			// Enlazamos la lista temporal al DataGridView
			dgvDetalles.DataSource = _listaDetalles;
		}
		#endregion

		private void rbComerAqui_CheckedChanged(object sender, EventArgs e)
		{
			if (rbComerAqui.Checked)
			{
				lblMesa.Visible = true;
				cmbMesa.Visible = true;
			}
		}

		private void rbParaLlevar_CheckedChanged(object sender, EventArgs e)
		{
			if (rbParaLlevar.Checked)
			{
				lblMesa.Visible = false;
				cmbMesa.Visible = false;
				cmbMesa.SelectedIndex = -1; // Limpiar selección de mesa
			}
		}

		private void LimpiarFormulario()
		{
			cmbMesa.SelectedIndex = -1;
			cmbEmpleado.SelectedIndex = -1;
			cmbCliente.SelectedIndex = -1;
			cmbEstado.SelectedIndex = -1;
			_listaDetalles.Clear();
		}
	}

	public class DetallePedidoItem
	{
		public int IdProducto { get; set; }
		public string Nombre { get; set; }
		public int Cantidad { get; set; }
	}
}
