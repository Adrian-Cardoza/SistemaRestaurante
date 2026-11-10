
using QuestPDF.Fluent;
using SistemaRestaurante.Dtos;
using SistemaRestaurante.Reportes;
using SistemaRestaurante.Service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SistemaRestaurante.Forms
{
    public partial class FrmReportes : Form
    {
        // ==========================================
        // 1. SERVICIOS Y VARIABLES
        // ==========================================

        private readonly ReporteService _reporteService = new();

        private List<ReportePedidoDto> _pedidos = new();

        private DateTime _desdeAplicado;
        private DateTime _hastaAplicado;

        private string _tipoAplicado = "Todos";
        private string _estadoAplicado = "Todos";


        // ==========================================
        // 2. CONSTRUCTOR
        // ==========================================

        public FrmReportes()
        {
            InitializeComponent();

            // ELIMINAR LA COLUMNA TOTAL DEL DATA GRID
            // También funciona si todavía está declarada
            // en FrmReportes.Designer.cs.
            if (dgvReporte.Columns.Contains("colTotal"))
            {
                dgvReporte.Columns.Remove("colTotal");
            }

            // Configurar tabla
            dgvReporte.AutoGenerateColumns = false;

            dgvReporte.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvReporte.RowHeadersVisible = false;

            // Cargar filtros
            CargarFiltros();

            // Conectar eventos
            btnBuscar.Click += btnBuscar_Click;
            btnExportar.Click += btnExportar_Click;
        }


        // ==========================================
        // 3. CARGAR FILTROS
        // ==========================================

        private void CargarFiltros()
        {
            // Primer día del mes hasta la fecha actual
            dtpDesde.Value = new DateTime(
                DateTime.Today.Year,
                DateTime.Today.Month,
                1);

            dtpHasta.Value = DateTime.Today;

            // Tipos de pedido
            cmbTipoPedido.Items.Clear();

            cmbTipoPedido.Items.AddRange(new object[]
            {
                "Todos",
                "En mesa",
                "Para llevar"
            });

            // Estados
            cmbEstado.Items.Clear();

            cmbEstado.Items.AddRange(new object[]
            {
                "Todos",
                "Pendiente",
                "Facturado",
                "Cancelado"
            });

            cmbTipoPedido.SelectedIndex = 0;
            cmbEstado.SelectedIndex = 0;

            btnExportar.Enabled = false;
        }


        // ==========================================
        // 4. BUSCAR PEDIDOS
        // ==========================================

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Validar fechas
            if (dtpDesde.Value.Date > dtpHasta.Value.Date)
            {
                MessageBox.Show(
                    "La fecha inicial no puede ser mayor que la fecha final.",
                    "RestoSys",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                // Obtener filtros seleccionados
                string tipoPedido =
                    cmbTipoPedido.SelectedItem?.ToString() ?? "Todos";

                string estado =
                    cmbEstado.SelectedItem?.ToString() ?? "Todos";

                // Consultar pedidos
                _pedidos = _reporteService.ObtenerReporte(
                    dtpDesde.Value,
                    dtpHasta.Value,
                    tipoPedido,
                    estado);

                // Guardar filtros aplicados
                _desdeAplicado = dtpDesde.Value;
                _hastaAplicado = dtpHasta.Value;

                _tipoAplicado = tipoPedido;
                _estadoAplicado = estado;

                // Actualizar DataGridView
                dgvReporte.DataSource = null;
                dgvReporte.DataSource = _pedidos;

                // Ajustar columnas
                AjustarColumnasReporte();

                // ==========================================
                // CALCULAR RESUMEN
                // ==========================================

                int cantidadPedidos = _pedidos.Count;

                int pedidosFacturados = _pedidos.Count(
                    p => p.IdFactura.HasValue);

                int totalProductos = _pedidos.Sum(
                    p => p.CantidadProductos);

                decimal totalGeneral = _pedidos.Sum(
                    p => p.Total);

                // Verificar resultados
                if (cantidadPedidos == 0)
                {
                    lblResumen.Text =
                        "No se encontraron pedidos con los filtros seleccionados.";

                    btnExportar.Enabled = false;

                    return;
                }

                // Mostrar resumen
                lblResumen.Text =
                    $"Pedidos encontrados: {cantidadPedidos}    |    " +
                    $"Facturados: {pedidosFacturados}    |    " +
                    $"Productos solicitados: {totalProductos}    |    " +
                    $"Total de pedidos: ${totalGeneral:N2}";

                // Habilitar exportación
                btnExportar.Enabled = true;
            }
            catch (Exception ex)
            {
                _pedidos.Clear();

                dgvReporte.DataSource = null;

                btnExportar.Enabled = false;

                lblResumen.Text =
                    "No se pudo realizar la consulta.";

                MessageBox.Show(
                    $"Error al consultar los pedidos:\n\n{ex.Message}",
                    "RestoSys",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // ==========================================
        // 5. AJUSTAR COLUMNAS DEL REPORTE
        // ==========================================

        private void AjustarColumnasReporte()
        {
            dgvReporte.AutoGenerateColumns = false;

            dgvReporte.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvReporte.ScrollBars = ScrollBars.Both;

            dgvReporte.RowHeadersVisible = false;

            // Eliminar Total si todavía existe
            if (dgvReporte.Columns.Contains("colTotal"))
            {
                dgvReporte.Columns.Remove("colTotal");
            }

            // Vinculación de las columnas restantes
            colIdPedido.DataPropertyName =
                nameof(ReportePedidoDto.IdPedido);

            colFecha.DataPropertyName =
                nameof(ReportePedidoDto.Fecha);

            colCliente.DataPropertyName =
                nameof(ReportePedidoDto.Cliente);

            colEmpleado.DataPropertyName =
                nameof(ReportePedidoDto.Empleado);

            colTipoPedido.DataPropertyName =
                nameof(ReportePedidoDto.TipoPedido);

            colEstado.DataPropertyName =
                nameof(ReportePedidoDto.Estado);

            colFactura.DataPropertyName =
                nameof(ReportePedidoDto.NumeroFactura);

            // Encabezados
            colIdPedido.HeaderText = "Pedido";
            colFecha.HeaderText = "Fecha";
            colCliente.HeaderText = "Cliente";
            colEmpleado.HeaderText = "Empleado";
            colTipoPedido.HeaderText = "Tipo";
            colEstado.HeaderText = "Estado";
            colFactura.HeaderText = "Factura";

            // Distribución proporcional
            colIdPedido.FillWeight = 55;
            colFecha.FillWeight = 90;
            colCliente.FillWeight = 90;
            colEmpleado.FillWeight = 85;
            colTipoPedido.FillWeight = 65;
            colEstado.FillWeight = 75;
            colFactura.FillWeight = 90;

            // Anchos mínimos
            colIdPedido.MinimumWidth = 45;
            colFecha.MinimumWidth = 75;
            colCliente.MinimumWidth = 70;
            colEmpleado.MinimumWidth = 70;
            colTipoPedido.MinimumWidth = 55;
            colEstado.MinimumWidth = 60;
            colFactura.MinimumWidth = 70;

            // Formato de fecha
            colFecha.DefaultCellStyle.Format =
                "dd/MM/yy HH:mm";

            // Encabezados
            dgvReporte.ColumnHeadersHeight = 40;

            dgvReporte.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        }


        // ==========================================
        // 6. EXPORTAR REPORTE A PDF
        // ==========================================

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (_pedidos.Count == 0)
            {
                MessageBox.Show(
                    "No hay resultados para exportar.",
                    "RestoSys",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                // Crear carpeta de reportes en Documentos
                string carpetaReportes = Path.Combine(
                    Environment.GetFolderPath(
                        Environment.SpecialFolder.MyDocuments),
                    "RestoSys",
                    "Reportes");

                Directory.CreateDirectory(carpetaReportes);

                // Configurar diálogo para guardar PDF
                using SaveFileDialog dialogo = new SaveFileDialog
                {
                    Filter = "Archivo PDF (*.pdf)|*.pdf",

                    DefaultExt = "pdf",

                    AddExtension = true,

                    InitialDirectory = carpetaReportes,

                    FileName =
                        $"ReportePedidos_{_desdeAplicado:yyyyMMdd}_{_hastaAplicado:yyyyMMdd}.pdf"
                };

                if (dialogo.ShowDialog() != DialogResult.OK)
                    return;

                // Obtener usuario
                string usuario = string.IsNullOrWhiteSpace(
                    SesionActual.NombreEmpleado)
                    ? "Usuario del sistema"
                    : SesionActual.NombreEmpleado;

                // Crear documento PDF
                ReportePedidosDocument documento =
                    new ReportePedidosDocument(
                        _pedidos,
                        _desdeAplicado,
                        _hastaAplicado,
                        _tipoAplicado,
                        _estadoAplicado,
                        usuario);

                // Generar PDF
                documento.GeneratePdf(dialogo.FileName);

                MessageBox.Show(
                    $"El reporte se generó correctamente.\n\n" +
                    $"Pedidos encontrados: {_pedidos.Count}\n" +
                    $"Ubicación: {dialogo.FileName}",
                    "RestoSys",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Abrir PDF
                Process.Start(new ProcessStartInfo(dialogo.FileName)
                {
                    UseShellExecute = true
                });
            }
            catch (IOException)
            {
                MessageBox.Show(
                    "No se pudo guardar el reporte. " +
                    "Comprueba que el archivo no esté abierto en otro programa.",
                    "RestoSys",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error al generar el reporte PDF:\n\n{ex.Message}",
                    "RestoSys",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
