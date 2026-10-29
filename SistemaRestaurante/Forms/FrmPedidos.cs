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
		private BindingList<DetallePedidoItem> _listaDetalles;

		public FrmPedidos()
		{
			InitializeComponent();
			_pedidoService = new PedidoService();
			_listaDetalles = new BindingList<DetallePedidoItem>();

			this.Load += FrmPedidos_Load;

			RefrescarListaPedidos();
			CargarClientes();
			CargarMesas();
			CargarEstados();
			ConfigurarGridHistorialPedidos();
			ConfigurarGridCarrito();

			CargarCatalogoProductos();
		}

		private void FrmPedidos_Load(object? sender, EventArgs e)
		{
			rbComerAqui.Checked = true;
			dtpFecha.Value = DateTime.Now;
		}

		private void RefrescarListaPedidos(string filtro = "")
		{
			dgvPedidos.DataSource = _pedidoService.ListaPedidos(filtro);
		}

		private void CargarCatalogoProductos()
		{
			flpProductos.Controls.Clear();
			flpProductos.AutoScroll = true;

			using var ctx = new RestauranteContext();
			var productos = ctx.Productos.ToList();

			foreach (var prod in productos)
			{
				// 1. Panel contenedor de la tarjeta
				Panel card = new Panel
				{
					Width = 140,
					Height = 170,
					BorderStyle = BorderStyle.FixedSingle,
					BackColor = prod.Disponible ? Color.White : Color.FromArgb(240, 240, 240),
					Margin = new Padding(8)
				};

				// 2. Nombre del producto
				Label lblNombre = new Label
				{
					Text = prod.Nombre,
					Font = new Font("Segoe UI", 9, FontStyle.Bold),
					ForeColor = prod.Disponible ? Color.Black : Color.Gray,
					Width = 124,
					Height = 35,
					Location = new Point(8, 10)
				};
				card.Controls.Add(lblNombre);

				// 3. Precio del producto
				Label lblPrecio = new Label
				{
					Text = $"${prod.Precio:F2}",
					ForeColor = prod.Disponible ? Color.ForestGreen : Color.Gray,
					Font = new Font("Segoe UI", 9, FontStyle.Bold),
					Location = new Point(8, 50)
				};
				card.Controls.Add(lblPrecio);

				// 4. Etiqueta de cantidad seleccionada
				Label lblCantidad = new Label
				{
					Text = prod.Disponible ? "0" : "N/D",
					TextAlign = ContentAlignment.MiddleCenter,
					ForeColor = prod.Disponible ? Color.Black : Color.Gray,
					Font = new Font("Segoe UI", 9, FontStyle.Bold),
					Width = 30,
					Height = 22,
					Location = new Point(55, 95)
				};
				card.Controls.Add(lblCantidad);

				// 5. Botón Menos (-)
				Button btnMenos = new Button
				{
					Text = "-",
					Width = 35,
					Height = 25,
					Location = new Point(15, 94),
					Enabled = prod.Disponible,
					UseVisualStyleBackColor = true
				};
				card.Controls.Add(btnMenos);

				// 6. Botón Más (+)
				Button btnMas = new Button
				{
					Text = "+",
					Width = 35,
					Height = 25,
					Location = new Point(90, 94),
					Enabled = prod.Disponible,
					UseVisualStyleBackColor = true
				};
				card.Controls.Add(btnMas);

				if (prod.Disponible)
				{
					btnMas.Click += (s, e) =>
					{
						var itemExistente = _listaDetalles.FirstOrDefault(d => d.IdProducto == prod.ID);
						if (itemExistente != null)
						{
							itemExistente.Cantidad++;
						}
						else
						{
							_listaDetalles.Add(new DetallePedidoItem
							{
								IdProducto = prod.ID,
								Nombre = prod.Nombre,
								PrecioUnitario = prod.Precio,
								Cantidad = 1
							});
						}
						ActualizarCantidadUI(prod.ID, lblCantidad);
					};

					btnMenos.Click += (s, e) =>
					{
						var itemExistente = _listaDetalles.FirstOrDefault(d => d.IdProducto == prod.ID);
						if (itemExistente != null)
						{
							itemExistente.Cantidad--;
							if (itemExistente.Cantidad <= 0)
							{
								_listaDetalles.Remove(itemExistente);
							}
							ActualizarCantidadUI(prod.ID, lblCantidad);
						}
					};
				}
				flpProductos.Controls.Add(card);
			}
		}

		private void ActualizarCantidadUI(int idProducto, Label lblCantidad)
		{
			var item = _listaDetalles.FirstOrDefault(d => d.IdProducto == idProducto);
			lblCantidad.Text = item != null ? item.Cantidad.ToString() : "0";
			dgvDetalles.Refresh();
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			try
			{
				if (rbComerAqui.Checked && cmbMesa.SelectedIndex < 0)
				{
					MessageBox.Show("Debe seleccionar una Mesa para pedidos de tipo 'Comer aquí'.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				if (cmbCliente.SelectedIndex < 0)
				{
					MessageBox.Show("Debe seleccionar un Cliente.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				if (_listaDetalles.Count == 0)
				{
					MessageBox.Show("Debe agregar al menos un producto al carrito.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				var pedido = new Pedido
				{
					IdMesa = rbComerAqui.Checked ? Convert.ToInt32(cmbMesa.SelectedValue) : (int?)null,
					IdCliente = Convert.ToInt32(cmbCliente.SelectedValue),

					IdEmpleado = SesionActual.IdEmpleadoLogueado,

					Estado = cmbEstado.Text.Trim(),
					Fecha = dtpFecha.Value,
					DetallesPedidos = _listaDetalles.Select(d => new DetallePedido
					{
						IdProducto = d.IdProducto,
						Cantidad = d.Cantidad
					}).ToList()
				};

				_pedidoService.CrearPedido(pedido);
				MessageBox.Show("Pedido creado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

				RefrescarListaPedidos();
				LimpiarFormulario();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error al guardar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnEditar_Click(object sender, EventArgs e)
		{
			if (dgvPedidos.CurrentRow == null)
			{
				MessageBox.Show("Seleccione un pedido del historial para editar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			try
			{
				int id = Convert.ToInt32(dgvPedidos.CurrentRow.Cells["Id"].Value);
				var pedido = new Pedido
				{
					Id = id,
					IdMesa = rbComerAqui.Checked ? Convert.ToInt32(cmbMesa.SelectedValue) : (int?)null,
					IdCliente = Convert.ToInt32(cmbCliente.SelectedValue),
					Estado = cmbEstado.Text.Trim(),
					Fecha = dtpFecha.Value
				};

				_pedidoService.ActualizarPedido(pedido);
				MessageBox.Show("Pedido actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
				RefrescarListaPedidos();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error al actualizar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void CargarMesas()
		{
			using var ctx = new RestauranteContext();
			cmbMesa.DataSource = ctx.Mesas.Select(m => new { m.Id, m.Numero }).ToList();
			cmbMesa.DisplayMember = "Numero";
			cmbMesa.ValueMember = "Id";
			cmbMesa.SelectedIndex = -1;
		}

		private void CargarClientes()
		{
			using var ctx = new RestauranteContext();
			cmbCliente.DataSource = ctx.Clientes.Select(c => new { c.Id, c.Nombre }).ToList();
			cmbCliente.DisplayMember = "Nombre";
			cmbCliente.ValueMember = "Id";
			cmbCliente.SelectedIndex = -1;
		}

		private void CargarEstados()
		{
			cmbEstado.DataSource = new List<string> { "Pendiente", "Facturado", "Cancelado" };
			cmbEstado.SelectedItem = "Pendiente";
		}

		private void ConfigurarGridCarrito()
		{
			dgvDetalles.AutoGenerateColumns = false;
			dgvDetalles.Columns.Clear();

			dgvDetalles.Columns.Add(new DataGridViewTextBoxColumn
			{
				DataPropertyName = "Nombre",
				HeaderText = "Producto",
				Width = 130
			});

			dgvDetalles.Columns.Add(new DataGridViewTextBoxColumn
			{
				DataPropertyName = "Cantidad",
				HeaderText = "Cant.",
				Width = 55
			});

			dgvDetalles.Columns.Add(new DataGridViewTextBoxColumn
			{
				DataPropertyName = "PrecioUnitario",
				HeaderText = "P. Unit",
				Width = 65,
				DefaultCellStyle = { Format = "C2" }
			});

			dgvDetalles.DataSource = _listaDetalles;
		}

		private void ConfigurarGridHistorialPedidos()
		{
			using (var ctx = new RestauranteContext())
			{
				var pedidos = ctx.Pedidos
					.OrderByDescending(p => p.Fecha)
					.Take(5)
					.Select(p => new
					{
						Id = p.Id,
						Mesa = p.Mesa != null ? p.Mesa.Numero.ToString() : "Llevar",
						Empleado = p.Empleado.Nombre,
						Cliente = p.Cliente.Nombre,
						DetalleProductos = string.Join(", ", p.DetallesPedidos.Select(d => $"{d.Cantidad}x {d.Productos.Nombre}")),
						Estado = p.Estado,
						Fecha = p.Fecha
					})
					.ToList();

				dgvPedidos.DataSource = pedidos;
				dgvPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

				if (dgvPedidos.Columns["Id"] != null) dgvPedidos.Columns["Id"].FillWeight = 40;
				if (dgvPedidos.Columns["Mesa"] != null) dgvPedidos.Columns["Mesa"].FillWeight = 50;
				if (dgvPedidos.Columns["DetalleProductos"] != null) dgvPedidos.Columns["DetalleProductos"].FillWeight = 150; // Damos más espacio para los productos
			}
		}

		private void rbComerAqui_CheckedChanged(object sender, EventArgs e)
		{
			cmbMesa.Visible = rbComerAqui.Checked;
		}

		private void rbParaLlevar_CheckedChanged(object sender, EventArgs e)
		{
			if (rbParaLlevar.Checked)
			{
				cmbMesa.Visible = false;
				cmbMesa.SelectedIndex = -1;
			}
		}

		private void LimpiarFormulario()
		{
			cmbMesa.SelectedIndex = -1;
			cmbCliente.SelectedIndex = -1;
			cmbEstado.SelectedItem = "Pendiente";
			_listaDetalles.Clear();
			CargarCatalogoProductos();
		}
	}

	public class DetallePedidoItem
	{
		public int IdProducto { get; set; }
		public string Nombre { get; set; }
		public decimal PrecioUnitario { get; set; }
		public int Cantidad { get; set; }
	}
}
