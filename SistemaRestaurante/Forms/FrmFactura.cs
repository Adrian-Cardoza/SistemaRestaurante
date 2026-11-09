
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using SistemaRestaurante.Dtos;
using SistemaRestaurante.Service;

namespace SistemaRestaurante.Forms
{
    public partial class FrmFactura : Form
    {
        // ==========================================
        // 1. CAMPOS Y SERVICIOS
        // ==========================================

        private readonly int? _idPedido;

        private readonly FacturaService _facturaService = new();

        private readonly PdfFacturaService _pdfFacturaService = new();

        private FacturaDto? _factura;


        // ==========================================
        // 2. CONSTRUCTORES
        // ==========================================

        // Constructor principal
        public FrmFactura()
        {
            InitializeComponent();

            // Conectar eventos
            btnCerrar.Click += btnCerrar_Click;
            btnGenerarPdf.Click += btnGenerarPdf_Click;

            this.Load += FrmFactura_Load;

            nudDescuento.ValueChanged += nudDescuento_ValueChanged;

            // Configuración inicial
            CargarMetodosPago();
            ConfigurarFormulario();
        }

        // Constructor que recibe el ID del pedido
        public FrmFactura(int idPedido) : this()
        {
            if (idPedido <= 0)
            {
                throw new ArgumentException(
                    "El identificador del pedido no es válido.");
            }

            _idPedido = idPedido;

            lblPedidoIdValor.Text = idPedido.ToString();

            lblSubtitulo.Text =
                $"Generación de factura para el pedido N.º {idPedido}";
        }

        // Consultar el ID del pedido
        public int? IdPedido => _idPedido;


        // ==========================================
        // 3. CONFIGURACIÓN INICIAL
        // ==========================================

        private void ConfigurarFormulario()
        {
            lblFechaValor.Text = "Pendiente de cargar";
            lblClienteValor.Text = "Pendiente de cargar";
            lblEmpleadoValor.Text = "Pendiente de cargar";
            lblMesaValor.Text = "Pendiente de cargar";

            lblSubtotalValor.Text = "$0.00";
            lblDescuentoValor.Text = "$0.00";
            lblTotalValor.Text = "$0.00";

            btnGenerarPdf.Enabled = false;

            nudDescuento.Value = 0;
        }

        // Cargar métodos de pago
        private void CargarMetodosPago()
        {
            cmbMetodoPago.Items.Clear();

            cmbMetodoPago.Items.AddRange(new object[]
            {
                "Efectivo",
                "Tarjeta",
                "Transferencia"
            });

            cmbMetodoPago.SelectedIndex = 0;
        }


        // ==========================================
        // 4. CARGAR INFORMACIÓN DEL PEDIDO
        // ==========================================

        private void FrmFactura_Load(object sender, EventArgs e)
        {
            if (!_idPedido.HasValue)
            {
                lblSubtitulo.Text =
                    "Abre este formulario desde un pedido seleccionado.";

                lblPedidoIdValor.Text = "Sin pedido seleccionado";

                return;
            }

            try
            {
                // Consultar pedido mediante FacturaService
                _factura = _facturaService.ObtenerPedidoParaFacturar(
                    _idPedido.Value);

                // Mostrar información en pantalla
                MostrarDatosFactura(_factura);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"No se pudo cargar el pedido:\n{ex.Message}",
                    "RestoSys",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                btnGenerarPdf.Enabled = false;
            }
        }


        // ==========================================
        // 5. MOSTRAR DATOS DE LA FACTURA
        // ==========================================

        private void MostrarDatosFactura(FacturaDto factura)
        {
            // Información general
            lblPedidoIdValor.Text = factura.IdPedido.ToString();

            DateTime fechaMostrar = factura.YaRegistrada
                ? factura.FechaEmision
                : factura.FechaPedido;

            lblFechaValor.Text =
                fechaMostrar.ToString("dd/MM/yyyy HH:mm");

            lblClienteValor.Text = factura.Cliente;
            lblEmpleadoValor.Text = factura.Empleado;
            lblMesaValor.Text = factura.Mesa;

            // Limpiar DataGridView
            dgvDetalles.Rows.Clear();

            // Cargar productos
            foreach (var detalle in factura.Detalles)
            {
                dgvDetalles.Rows.Add(
                    detalle.NombreProducto,
                    detalle.Cantidad,
                    $"${detalle.PrecioUnitario:N2}",
                    $"${detalle.Importe:N2}"
                );
            }

            // Configurar límite del descuento
            nudDescuento.Maximum = Math.Max(
                0m,
                factura.Subtotal);

            nudDescuento.Value = Math.Min(
                factura.Descuento,
                nudDescuento.Maximum);

            // Comprobar si ya existe una factura
            if (factura.YaRegistrada)
            {
                // Recuperar método de pago
                if (!cmbMetodoPago.Items.Contains(factura.MetodoPago))
                {
                    cmbMetodoPago.Items.Add(factura.MetodoPago);
                }

                cmbMetodoPago.SelectedItem = factura.MetodoPago;

                // No permitir modificar una factura registrada
                cmbMetodoPago.Enabled = false;
                nudDescuento.Enabled = false;

                btnGenerarPdf.Text = "Generar PDF nuevamente";
            }
            else
            {
                cmbMetodoPago.Enabled = true;
                nudDescuento.Enabled = true;

                btnGenerarPdf.Text = "Generar factura PDF";
            }

            // Habilitar generación
            btnGenerarPdf.Enabled = true;

            // Actualizar totales
            ActualizarTotales();
        }


        // ==========================================
        // 6. ACTUALIZAR SUBTOTAL, DESCUENTO Y TOTAL
        // ==========================================

        private void nudDescuento_ValueChanged(
            object sender,
            EventArgs e)
        {
            ActualizarTotales();
        }

        private void ActualizarTotales()
        {
            if (_factura == null)
                return;

            decimal descuento = _factura.YaRegistrada
                ? _factura.Descuento
                : nudDescuento.Value;

            decimal total = _factura.Subtotal - descuento;

            lblSubtotalValor.Text =
                $"${_factura.Subtotal:N2}";

            lblDescuentoValor.Text =
                $"${descuento:N2}";

            lblTotalValor.Text =
                $"${total:N2}";
        }


        // ==========================================
        // 7. GENERAR FACTURA PDF
        // ==========================================

        private void btnGenerarPdf_Click(object sender, EventArgs e)
        {
            if (!_idPedido.HasValue || _factura == null)
            {
                MessageBox.Show(
                    "No hay un pedido cargado para facturar.",
                    "RestoSys",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!cmbMetodoPago.Enabled && !_factura.YaRegistrada)
                return;

            if (cmbMetodoPago.SelectedItem == null)
            {
                MessageBox.Show(
                    "Seleccione un método de pago.",
                    "RestoSys",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Seleccionar ubicación del PDF
            using SaveFileDialog dialogo = new SaveFileDialog
            {
                Filter = "Archivo PDF (*.pdf)|*.pdf",
                DefaultExt = "pdf",
                AddExtension = true,

                FileName = _factura.YaRegistrada
                    ? $"{_factura.NumeroFactura}.pdf"
                    : $"Factura_Pedido_{_idPedido.Value}.pdf"
            };

            if (dialogo.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                FacturaDto facturaGenerada;

                // Si ya existe, solamente generar nuevamente el PDF
                if (_factura.YaRegistrada)
                {
                    facturaGenerada =
                        _facturaService.ObtenerFacturaPorPedido(
                            _idPedido.Value);
                }
                else
                {
                    // Registrar la factura por primera vez
                    string metodoPago =
                        cmbMetodoPago.SelectedItem.ToString()!;

                    facturaGenerada = _facturaService.CrearFactura(
                        _idPedido.Value,
                        metodoPago,
                        nudDescuento.Value);
                }

                // Generar PDF
                string ruta = _pdfFacturaService.GenerarPdf(
                    facturaGenerada,
                    dialogo.FileName);

                // Actualizar información en pantalla
                _factura = facturaGenerada;

                MostrarDatosFactura(_factura);

                // Confirmar generación
                MessageBox.Show(
                    $"La factura se generó correctamente.\n\n" +
                    $"Número: {_factura.NumeroFactura}\n" +
                    $"Ubicación: {ruta}",
                    "RestoSys",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Abrir PDF con el visor predeterminado
                Process.Start(new ProcessStartInfo(ruta)
                {
                    UseShellExecute = true
                });
            }
            catch (IOException)
            {
                MessageBox.Show(
                    "No se pudo guardar el PDF. " +
                    "Compruebe que el archivo no esté abierto en otro programa.",
                    "RestoSys",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Ocurrió un error al generar la factura:\n\n{ex.Message}",
                    "RestoSys",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // ==========================================
        // 8. CERRAR FORMULARIO
        // ==========================================

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
