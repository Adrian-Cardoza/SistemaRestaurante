using Microsoft.EntityFrameworkCore;
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
			dgvPedidos.CellClick += dgvPedidos_CellClick;
		}

		private void RefrescarListaPedidos(string filtro = "")
		{
			using (var ctx = new RestauranteContext())
			{
				var query = ctx.Pedidos.AsQueryable();

				if (!string.IsNullOrWhiteSpace(filtro))
				{
					query = query.Where(p => p.Cliente.Nombre.Contains(filtro) || p.Estado.Contains(filtro));
				}

				var pedidos = query
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
				if (dgvPedidos.Columns["DetalleProductos"] != null) dgvPedidos.Columns["DetalleProductos"].FillWeight = 150;
			}
		}

		private void dgvPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && dgvPedidos.CurrentRow != null)
			{
				try
				{
					int idPedido = Convert.ToInt32(dgvPedidos.CurrentRow.Cells["Id"].Value);

					using (var ctx = new RestauranteContext())
					{
						// Incluimos los detalles y el producto asociado
						var pedidoDb = ctx.Pedidos
							.Include(p => p.DetallesPedidos)
							.ThenInclude(d => d.Productos)
							.FirstOrDefault(p => p.Id == idPedido);

						if (pedidoDb != null)
						{
							// 1. Cargar datos generales
							cmbCliente.SelectedValue = pedidoDb.IdCliente;
							cmbEstado.SelectedItem = pedidoDb.Estado;
							dtpFecha.Value = pedidoDb.Fecha;

							if (pedidoDb.IdMesa.HasValue)
							{
								rbComerAqui.Checked = true;
								cmbMesa.SelectedValue = pedidoDb.IdMesa.Value;
							}
							else
							{
								rbParaLlevar.Checked = true;
							}

							// 2. Cargar los productos del pedido seleccionado en el carrito/grid de detalles
							_listaDetalles.Clear();
							foreach (var detalle in pedidoDb.DetallesPedidos)
							{
								_listaDetalles.Add(new DetallePedidoItem
								{
									IdProducto = detalle.IdProducto,
									Nombre = detalle.Productos?.Nombre ?? "Producto",
									PrecioUnitario = detalle.PrecioUnitario,
									Cantidad = detalle.Cantidad
								});
							}
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Error al cargar el pedido seleccionado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
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

				// Validar que se haya escrito un nombre de cliente
				string nombreCliente = cmbCliente.Text.Trim();
				if (string.IsNullOrWhiteSpace(nombreCliente))
				{
					MessageBox.Show("Debe ingresar o seleccionar un Cliente.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				if (_listaDetalles.Count == 0)
				{
					MessageBox.Show("Debe agregar al menos un producto al carrito.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				int clienteId;

				using (var ctx = new RestauranteContext())
				{
					// 1. Buscar si el cliente ya existe por su nombre (ignorando mayúsculas/minúsculas)
					var clienteExistente = ctx.Clientes
						.FirstOrDefault(c => c.Nombre.ToLower() == nombreCliente.ToLower());

					if (clienteExistente != null)
					{
						// Si ya existe, usamos su ID
						clienteId = clienteExistente.Id;
					}
					else
					{
						// Si NO existe, lo creamos automáticamente solo con el nombre
						var nuevoCliente = new Cliente
						{
							Nombre = nombreCliente,
							DUI = null,
							Correo = null
						};

						ctx.Clientes.Add(nuevoCliente);
						ctx.SaveChanges();

						clienteId = nuevoCliente.Id;
					}

					// 2. Creamos el pedido usando el ID del cliente (existente o recién creado)
					var pedido = new Pedido
					{
						IdMesa = rbComerAqui.Checked ? Convert.ToInt32(cmbMesa.SelectedValue) : (int?)null,
						IdCliente = clienteId,
						IdEmpleado = SesionActual.IdEmpleadoLogueado,
						Estado = cmbEstado.Text.Trim(),
						Fecha = dtpFecha.Value,
						DetallesPedidos = _listaDetalles.Select(d => new DetallePedido
						{
							IdProducto = d.IdProducto,
							Cantidad = d.Cantidad,
							PrecioUnitario = d.PrecioUnitario
						}).ToList()
					};

					_pedidoService.CrearPedido(pedido);
				}

				MessageBox.Show("Pedido y cliente procesados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

				RefrescarListaPedidos();
				CargarClientes();
				LimpiarFormulario();
			}
			catch (Exception ex)
			{
				string mensajeDetallado = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
				MessageBox.Show($"Error al guardar: {mensajeDetallado}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
				if (_listaDetalles.Count == 0)
				{
					MessageBox.Show("El pedido debe contener al menos un producto.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				int id = Convert.ToInt32(dgvPedidos.CurrentRow.Cells["Id"].Value);

				var pedido = new Pedido
				{
					Id = id,
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

				_pedidoService.ActualizarPedido(pedido);
				MessageBox.Show("Pedido actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

				RefrescarListaPedidos();
				LimpiarFormulario();
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

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			//LimpiarFormulario();
			//dgvPedidos.ClearSelection();
			//MessageBox.Show("Acción cancelada. Formulario limpiado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

			if (dgvPedidos.CurrentRow == null)
			{
				MessageBox.Show("Seleccione un pedido del historial para cancelar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			var confirm = MessageBox.Show("¿Está seguro de cancelar este pedido?",
										   "Confirmar cancelación",
										   MessageBoxButtons.YesNo,
										   MessageBoxIcon.Question);

			if (confirm == DialogResult.No) return;

			try
			{
				int idPedido = Convert.ToInt32(dgvPedidos.CurrentRow.Cells["Id"].Value);

				using (var ctx = new RestauranteContext())
				{
					var pedido = ctx.Pedidos.Find(idPedido);
					if (pedido != null)
					{
						if (pedido.Estado == "Facturado")
						{
							MessageBox.Show("No se puede cancelar un pedido que ya ha sido facturado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							return;
						}

						pedido.Estado = "Cancelado";
						ctx.SaveChanges();

						MessageBox.Show("El pedido ha sido cancelado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

						RefrescarListaPedidos();
						LimpiarFormulario();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error al cancelar el pedido: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
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
