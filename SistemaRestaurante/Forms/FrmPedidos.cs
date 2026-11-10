
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
        private int? _idPedidoEnEdicion = null;

        public FrmPedidos()
        {
            InitializeComponent();

            _pedidoService = new PedidoService();
            _listaDetalles = new BindingList<DetallePedidoItem>();

            this.Load += FrmPedidos_Load;

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
            RefrescarListaPedidos();
            LimpiarFormulario();
        }

        // ==========================================
        // ACTUALIZAR HISTORIAL DE PEDIDOS
        // ==========================================

        private void RefrescarListaPedidos(string filtro = "")
        {
            using (var ctx = new RestauranteContext())
            {
                var query = ctx.Pedidos.AsQueryable();

                if (!string.IsNullOrWhiteSpace(filtro))
                {
                    query = query.Where(p =>
                        p.Cliente.Nombre.Contains(filtro) ||
                        p.Estado.Contains(filtro));
                }

                // Mostrar todos los pedidos, sin limitar a cinco
                var pedidos = query
                    .OrderByDescending(p => p.Fecha)
                    .Select(p => new
                    {
                        Id = p.Id,
                        Mesa = p.Mesa != null
                            ? p.Mesa.Numero.ToString()
                            : "Llevar",

                        Empleado = p.Empleado.Nombre,
                        Cliente = p.Cliente.Nombre,

                        DetalleProductos = string.Join(", ",
                            p.DetallesPedidos.Select(d =>
                                $"{d.Cantidad}x {d.Productos.Nombre}")),

                        Estado = p.Estado,
                        Fecha = p.Fecha
                    })
                    .ToList();

                dgvPedidos.DataSource = pedidos;

                dgvPedidos.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                if (dgvPedidos.Columns["Id"] != null)
                    dgvPedidos.Columns["Id"].FillWeight = 40;

                if (dgvPedidos.Columns["Mesa"] != null)
                    dgvPedidos.Columns["Mesa"].FillWeight = 50;

                if (dgvPedidos.Columns["DetalleProductos"] != null)
                    dgvPedidos.Columns["DetalleProductos"].FillWeight = 150;
            }
        }

        // ==========================================
        // SELECCIONAR PEDIDO DEL HISTORIAL
        // ==========================================

        private void dgvPedidos_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvPedidos.CurrentRow != null)
            {
                try
                {
                    int idPedido = Convert.ToInt32(
                        dgvPedidos.CurrentRow.Cells["Id"].Value);

                    _idPedidoEnEdicion = idPedido;

                    using (var ctx = new RestauranteContext())
                    {
                        var pedidoDb = ctx.Pedidos
                            .Include(p => p.DetallesPedidos)
                            .ThenInclude(d => d.Productos)
                            .FirstOrDefault(p => p.Id == idPedido);

                        if (pedidoDb != null)
                        {
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
                    MessageBox.Show(
                        $"Error al cargar el pedido seleccionado: {ex.Message}",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        // ==========================================
        // CARGAR CATÁLOGO DE PRODUCTOS
        // ==========================================

        private void CargarCatalogoProductos()
        {
            flpProductos.Controls.Clear();
            flpProductos.AutoScroll = true;

            using var ctx = new RestauranteContext();

            var productos = ctx.Productos.ToList();

            foreach (var prod in productos)
            {
                Panel card = new Panel
                {
                    Width = 140,
                    Height = 170,
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = prod.Disponible
                        ? Color.White
                        : Color.FromArgb(240, 240, 240),
                    Margin = new Padding(8)
                };

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

                Label lblPrecio = new Label
                {
                    Text = $"${prod.Precio:F2}",
                    ForeColor = prod.Disponible
                        ? Color.ForestGreen
                        : Color.Gray,
                    Font = new Font("Segoe UI", 9, FontStyle.Bold),
                    Location = new Point(8, 50)
                };

                card.Controls.Add(lblPrecio);

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
                        var itemExistente = _listaDetalles.FirstOrDefault(
                            d => d.IdProducto == prod.ID);

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
                        var itemExistente = _listaDetalles.FirstOrDefault(
                            d => d.IdProducto == prod.ID);

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

        // ==========================================
        // ACTUALIZAR CANTIDADES
        // ==========================================

        private void ActualizarCantidadUI(
            int idProducto,
            Label lblCantidad)
        {
            var item = _listaDetalles.FirstOrDefault(
                d => d.IdProducto == idProducto);

            lblCantidad.Text = item != null
                ? item.Cantidad.ToString()
                : "0";

            dgvDetalles.Refresh();
        }

        // ==========================================
        // GUARDAR PEDIDO
        // ==========================================

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (_idPedidoEnEdicion != null)
            {
                MessageBox.Show(
                    "Estás en modo de edición. Usa el botón 'Editar' para guardar los cambios o limpia el formulario para crear un pedido nuevo.",
                    "Estás en edición",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                if (rbComerAqui.Checked && cmbMesa.SelectedIndex < 0)
                {
                    MessageBox.Show(
                        "Debe seleccionar una Mesa para pedidos de tipo 'Comer aquí'.",
                        "Atención",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                int idMesaSeleccionada = 0;

                if (rbComerAqui.Checked)
                {
                    if (cmbMesa.SelectedValue == null)
                    {
                        MessageBox.Show(
                            "Debe seleccionar una mesa.",
                            "Atención",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        return;
                    }

                    idMesaSeleccionada = Convert.ToInt32(cmbMesa.SelectedValue);

                    using (var ctxCheck = new RestauranteContext())
                    {
                        var mesaActual = ctxCheck.Mesas.Find(idMesaSeleccionada);

                        if (mesaActual != null && mesaActual.Estado == "Ocupada")
                        {
                            MessageBox.Show(
                                $"La mesa #{mesaActual.Numero} ya se encuentra Ocupada. Seleccione otra mesa disponible.",
                                "Mesa no disponible",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                            return;
                        }
                    }
                }

                string nombreCliente = cmbCliente.Text.Trim();

                if (string.IsNullOrWhiteSpace(nombreCliente))
                {
                    MessageBox.Show(
                        "Debe ingresar o seleccionar un Cliente.",
                        "Atención",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (_listaDetalles.Count == 0)
                {
                    MessageBox.Show(
                        "Debe agregar al menos un producto al carrito.",
                        "Atención",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                int clienteId;

                using (var ctx = new RestauranteContext())
                {
                    var clienteExistente = ctx.Clientes
                        .FirstOrDefault(c =>
                            c.Nombre.ToLower() == nombreCliente.ToLower());

                    if (clienteExistente != null)
                    {
                        clienteId = clienteExistente.Id;
                    }
                    else
                    {
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

                    // Crear pedido
                    var pedido = new Pedido
                    {
                        IdMesa = rbComerAqui.Checked
                            ? idMesaSeleccionada
                            : (int?)null,

                        IdCliente = clienteId,
                        IdEmpleado = SesionActual.IdEmpleadoLogueado,
                        Estado = cmbEstado.Text.Trim(),
                        Fecha = dtpFecha.Value,

                        DetallesPedidos = _listaDetalles.Select(d =>
                            new DetallePedido
                            {
                                IdProducto = d.IdProducto,
                                Cantidad = d.Cantidad,
                                PrecioUnitario = d.PrecioUnitario
                            }).ToList()
                    };

                    _pedidoService.CrearPedido(pedido);

                    // Actualizar estado de mesa
                    if (rbComerAqui.Checked)
                    {
                        var mesaDb = ctx.Mesas.Find(idMesaSeleccionada);

                        if (mesaDb != null)
                        {
                            if (pedido.Estado == "Facturado" ||
                                pedido.Estado == "Cancelado")
                            {
                                mesaDb.Estado = "Disponible";
                            }
                            else
                            {
                                mesaDb.Estado = "Ocupada";
                            }

                            ctx.SaveChanges();
                        }
                    }
                }

                MessageBox.Show(
                    "Pedido registrado y mesa marcada como ocupada correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                RefrescarListaPedidos();
                CargarClientes();
                CargarMesas();
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                string mensajeDetallado = ex.InnerException != null
                    ? ex.InnerException.Message
                    : ex.Message;

                MessageBox.Show(
                    $"Error al guardar: {mensajeDetallado}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // EDITAR PEDIDO
        // ==========================================

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (_idPedidoEnEdicion == null)
            {
                MessageBox.Show(
                    "Seleccione un pedido del historial para editar.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                if (_listaDetalles.Count == 0)
                {
                    MessageBox.Show(
                        "El pedido debe contener al menos un producto.",
                        "Atención",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                string nuevoEstado = cmbEstado.Text.Trim();

                int? nuevaMesaId = rbComerAqui.Checked
                    ? Convert.ToInt32(cmbMesa.SelectedValue)
                    : (int?)null;

                using (var ctx = new RestauranteContext())
                {
                    // Buscar pedido original
                    var pedidoDb = ctx.Pedidos
                        .Include(p => p.DetallesPedidos)
                        .FirstOrDefault(
                            p => p.Id == _idPedidoEnEdicion.Value);

                    if (pedidoDb != null)
                    {
                        int? mesaAnteriorId = pedidoDb.IdMesa;

                        // Actualizar información
                        pedidoDb.IdMesa = nuevaMesaId;
                        pedidoDb.IdCliente = Convert.ToInt32(cmbCliente.SelectedValue);
                        pedidoDb.IdEmpleado = SesionActual.IdEmpleadoLogueado;
                        pedidoDb.Estado = nuevoEstado;
                        pedidoDb.Fecha = dtpFecha.Value;

                        // Actualizar detalles
                        ctx.DetallesPedidos.RemoveRange(
                            pedidoDb.DetallesPedidos);

                        foreach (var detalle in _listaDetalles)
                        {
                            pedidoDb.DetallesPedidos.Add(new DetallePedido
                            {
                                IdPedido = pedidoDb.Id,
                                IdProducto = detalle.IdProducto,
                                Cantidad = detalle.Cantidad,
                                PrecioUnitario = detalle.PrecioUnitario
                            });
                        }

                        // Gestionar mesa anterior
                        if (mesaAnteriorId.HasValue)
                        {
                            if (mesaAnteriorId != nuevaMesaId ||
                                nuevoEstado == "Facturado" ||
                                nuevoEstado == "Cancelado")
                            {
                                var mesaAntigua = ctx.Mesas.Find(
                                    mesaAnteriorId.Value);

                                if (mesaAntigua != null)
                                {
                                    mesaAntigua.Estado = "Disponible";
                                }
                            }
                        }

                        // Gestionar nueva mesa
                        if (nuevaMesaId.HasValue &&
                            nuevoEstado != "Facturado" &&
                            nuevoEstado != "Cancelado")
                        {
                            var mesaNueva = ctx.Mesas.Find(
                                nuevaMesaId.Value);

                            if (mesaNueva != null)
                            {
                                mesaNueva.Estado = "Ocupada";
                            }
                        }

                        ctx.SaveChanges();
                    }
                }

                MessageBox.Show(
                    "Pedido actualizado y estados de mesa sincronizados correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                RefrescarListaPedidos();
                CargarMesas();
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error al actualizar: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // CARGAR MESAS
        // ==========================================

        private void CargarMesas()
        {
            using var ctx = new RestauranteContext();

            cmbMesa.DataSource = ctx.Mesas
                .Select(m => new { m.Id, m.Numero })
                .ToList();

            cmbMesa.DisplayMember = "Numero";
            cmbMesa.ValueMember = "Id";
            cmbMesa.SelectedIndex = -1;
        }

        // ==========================================
        // CARGAR CLIENTES
        // ==========================================

        private void CargarClientes()
        {
            using var ctx = new RestauranteContext();

            cmbCliente.DataSource = ctx.Clientes
                .Select(c => new { c.Id, c.Nombre })
                .ToList();

            cmbCliente.DisplayMember = "Nombre";
            cmbCliente.ValueMember = "Id";
            cmbCliente.SelectedIndex = -1;
        }

        // ==========================================
        // CARGAR ESTADOS
        // ==========================================

        private void CargarEstados()
        {
            cmbEstado.DataSource = new List<string>
            {
                "Pendiente",
                "Facturado",
                "Cancelado"
            };

            cmbEstado.SelectedItem = "Pendiente";
        }

        // ==========================================
        // CONFIGURAR GRID DEL CARRITO
        // ==========================================

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
                DefaultCellStyle =
                {
                    Format = "C2",
                    FormatProvider =
                        System.Globalization.CultureInfo.GetCultureInfo("es-SV")
                }
            });

            dgvDetalles.DataSource = _listaDetalles;
        }

        // ==========================================
        // CONFIGURAR HISTORIAL DE PEDIDOS
        // ==========================================

        private void ConfigurarGridHistorialPedidos()
        {
            using (var ctx = new RestauranteContext())
            {
                // Mostrar todos los pedidos, sin Take(5)
                var pedidos = ctx.Pedidos
                    .OrderByDescending(p => p.Fecha)
                    .Select(p => new
                    {
                        Id = p.Id,

                        Mesa = p.Mesa != null
                            ? p.Mesa.Numero.ToString()
                            : "Llevar",

                        Empleado = p.Empleado.Nombre,
                        Cliente = p.Cliente.Nombre,

                        DetalleProductos = string.Join(", ",
                            p.DetallesPedidos.Select(d =>
                                $"{d.Cantidad}x {d.Productos.Nombre}")),

                        Estado = p.Estado,
                        Fecha = p.Fecha
                    })
                    .ToList();

                dgvPedidos.DataSource = pedidos;

                dgvPedidos.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                if (dgvPedidos.Columns["Id"] != null)
                    dgvPedidos.Columns["Id"].FillWeight = 40;

                if (dgvPedidos.Columns["Mesa"] != null)
                    dgvPedidos.Columns["Mesa"].FillWeight = 50;

                if (dgvPedidos.Columns["DetalleProductos"] != null)
                    dgvPedidos.Columns["DetalleProductos"].FillWeight = 150;
            }
        }

        // ==========================================
        // TIPO DE PEDIDO: COMER AQUÍ
        // ==========================================

        private void rbComerAqui_CheckedChanged(object sender, EventArgs e)
        {
            cmbMesa.Visible = rbComerAqui.Checked;
        }

        // ==========================================
        // TIPO DE PEDIDO: PARA LLEVAR
        // ==========================================

        private void rbParaLlevar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbParaLlevar.Checked)
            {
                cmbMesa.Visible = false;
                cmbMesa.SelectedIndex = -1;
            }
        }

        // ==========================================
        // LIMPIAR FORMULARIO
        // ==========================================

        private void LimpiarFormulario()
        {
            _idPedidoEnEdicion = null;

            cmbMesa.SelectedIndex = -1;
            cmbCliente.SelectedIndex = -1;
            cmbEstado.SelectedItem = "Pendiente";

            _listaDetalles.Clear();

            dgvPedidos.ClearSelection();

            CargarCatalogoProductos();
        }

        // ==========================================
        // CANCELAR
        // ==========================================

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();

            MessageBox.Show(
                "Acción cancelada. Formulario limpiado.",
                "Información",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // ==========================================
        // GENERAR FACTURA
        // ==========================================

        private void btnGenerarFactura_Click(object sender, EventArgs e)
        {
            // Comprobar pedido seleccionado
            if (dgvPedidos.CurrentRow == null)
            {
                MessageBox.Show(
                    "Seleccione un pedido del historial para generar su factura.",
                    "RestoSys",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                // Obtener ID del pedido
                int idPedido = Convert.ToInt32(
                    dgvPedidos.CurrentRow.Cells["Id"].Value);

                // Obtener estado del pedido
                string estado = Convert.ToString(
                    dgvPedidos.CurrentRow.Cells["Estado"].Value) ?? "";

                // Impedir facturar pedidos cancelados
                if (string.Equals(
                    estado,
                    "Cancelado",
                    StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show(
                        "No se puede generar una factura para un pedido cancelado.",
                        "RestoSys",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // Abrir formulario de facturación
                using (FrmFactura formulario = new FrmFactura(idPedido))
                {
                    formulario.ShowDialog(this);
                }

                // Actualizar historial
                RefrescarListaPedidos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"No se pudo abrir la facturación:\n{ex.Message}",
                    "RestoSys",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }

    // ==========================================
    // MODELO AUXILIAR DEL CARRITO
    // ==========================================

    public class DetallePedidoItem
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public decimal PrecioUnitario { get; set; }
        public int Cantidad { get; set; }
    }
}
