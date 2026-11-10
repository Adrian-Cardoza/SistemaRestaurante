
namespace SistemaRestaurante.Forms
{
    partial class FrmReportes
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            tlpPrincipal = new TableLayoutPanel();

            pnlEncabezado = new Panel();
            lblTitulo = new Label();
            lblSubtitulo = new Label();

            pnlFiltros = new Panel();

            lblDesde = new Label();
            dtpDesde = new DateTimePicker();

            lblHasta = new Label();
            dtpHasta = new DateTimePicker();

            lblTipoPedido = new Label();
            cmbTipoPedido = new ComboBox();

            lblEstado = new Label();
            cmbEstado = new ComboBox();

            btnBuscar = new Button();
            btnExportar = new Button();

            dgvReporte = new DataGridView();

            // Solamente siete columnas
            colIdPedido = new DataGridViewTextBoxColumn();
            colFecha = new DataGridViewTextBoxColumn();
            colCliente = new DataGridViewTextBoxColumn();
            colEmpleado = new DataGridViewTextBoxColumn();
            colTipoPedido = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            colFactura = new DataGridViewTextBoxColumn();

            pnlResumen = new Panel();
            lblResumen = new Label();

            tlpPrincipal.SuspendLayout();
            pnlEncabezado.SuspendLayout();
            pnlFiltros.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)dgvReporte).BeginInit();

            pnlResumen.SuspendLayout();
            SuspendLayout();

            // ==========================================
            // TABLA PRINCIPAL
            // ==========================================

            tlpPrincipal.ColumnCount = 1;
            tlpPrincipal.RowCount = 4;

            tlpPrincipal.ColumnStyles.Clear();

            tlpPrincipal.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 100F));

            tlpPrincipal.RowStyles.Clear();

            tlpPrincipal.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 85F));

            tlpPrincipal.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 125F));

            tlpPrincipal.RowStyles.Add(
                new RowStyle(SizeType.Percent, 100F));

            tlpPrincipal.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 50F));

            tlpPrincipal.Controls.Add(pnlEncabezado, 0, 0);
            tlpPrincipal.Controls.Add(pnlFiltros, 0, 1);
            tlpPrincipal.Controls.Add(dgvReporte, 0, 2);
            tlpPrincipal.Controls.Add(pnlResumen, 0, 3);

            tlpPrincipal.Dock = DockStyle.Fill;
            tlpPrincipal.Margin = new Padding(0);
            tlpPrincipal.Name = "tlpPrincipal";
            tlpPrincipal.Padding = new Padding(0);

            // ==========================================
            // ENCABEZADO
            // ==========================================

            pnlEncabezado.BackColor =
                Color.FromArgb(27, 58, 92);

            pnlEncabezado.Controls.Add(lblTitulo);
            pnlEncabezado.Controls.Add(lblSubtitulo);

            pnlEncabezado.Dock = DockStyle.Fill;
            pnlEncabezado.Margin = new Padding(0);
            pnlEncabezado.Name = "pnlEncabezado";

            // Título

            lblTitulo.AutoSize = true;

            lblTitulo.Font = new Font(
                "Segoe UI", 20F, FontStyle.Bold);

            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(22, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Text = "REPORTES";

            // Subtítulo

            lblSubtitulo.AutoSize = true;

            lblSubtitulo.Font = new Font(
                "Segoe UI", 9F);

            lblSubtitulo.ForeColor = Color.WhiteSmoke;
            lblSubtitulo.Location = new Point(26, 53);
            lblSubtitulo.Name = "lblSubtitulo";

            lblSubtitulo.Text =
                "RestoSys | Consulta y exportación de información";

            // ==========================================
            // PANEL DE FILTROS
            // ==========================================

            pnlFiltros.BackColor = Color.White;
            pnlFiltros.Dock = DockStyle.Fill;
            pnlFiltros.Margin = new Padding(0);
            pnlFiltros.Name = "pnlFiltros";
            pnlFiltros.Padding = new Padding(10);

            // Fecha desde

            lblDesde.AutoSize = true;

            lblDesde.Font = new Font(
                "Segoe UI", 9F, FontStyle.Bold);

            lblDesde.Location = new Point(15, 10);
            lblDesde.Name = "lblDesde";
            lblDesde.Text = "Fecha desde:";

            dtpDesde.Font = new Font("Segoe UI", 9F);
            dtpDesde.Format = DateTimePickerFormat.Short;
            dtpDesde.Location = new Point(15, 35);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(135, 23);

            // Fecha hasta

            lblHasta.AutoSize = true;

            lblHasta.Font = new Font(
                "Segoe UI", 9F, FontStyle.Bold);

            lblHasta.Location = new Point(165, 10);
            lblHasta.Name = "lblHasta";
            lblHasta.Text = "Fecha hasta:";

            dtpHasta.Font = new Font("Segoe UI", 9F);
            dtpHasta.Format = DateTimePickerFormat.Short;
            dtpHasta.Location = new Point(165, 35);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(135, 23);

            // Tipo de pedido

            lblTipoPedido.AutoSize = true;

            lblTipoPedido.Font = new Font(
                "Segoe UI", 9F, FontStyle.Bold);

            lblTipoPedido.Location = new Point(315, 10);
            lblTipoPedido.Name = "lblTipoPedido";
            lblTipoPedido.Text = "Tipo de pedido:";

            cmbTipoPedido.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cmbTipoPedido.Font = new Font("Segoe UI", 9F);
            cmbTipoPedido.Location = new Point(315, 35);
            cmbTipoPedido.Name = "cmbTipoPedido";
            cmbTipoPedido.Size = new Size(140, 23);

            // Estado

            lblEstado.AutoSize = true;

            lblEstado.Font = new Font(
                "Segoe UI", 9F, FontStyle.Bold);

            lblEstado.Location = new Point(470, 10);
            lblEstado.Name = "lblEstado";
            lblEstado.Text = "Estado:";

            cmbEstado.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cmbEstado.Font = new Font("Segoe UI", 9F);
            cmbEstado.Location = new Point(470, 35);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(140, 23);

            // ==========================================
            // BOTÓN BUSCAR
            // ==========================================

            btnBuscar.BackColor =
                Color.FromArgb(27, 58, 92);

            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;

            btnBuscar.Font = new Font(
                "Segoe UI", 9F, FontStyle.Bold);

            btnBuscar.ForeColor = Color.White;

            // Posición original
            btnBuscar.Location = new Point(679, 13);

            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(105, 35);
            btnBuscar.Text = "Buscar";

            btnBuscar.UseVisualStyleBackColor = false;

            // ==========================================
            // BOTÓN EXPORTAR PDF
            // ==========================================

            btnExportar.BackColor =
                Color.FromArgb(40, 125, 80);

            btnExportar.Enabled = false;
            btnExportar.FlatAppearance.BorderSize = 0;
            btnExportar.FlatStyle = FlatStyle.Flat;

            btnExportar.Font = new Font(
                "Segoe UI", 9F, FontStyle.Bold);

            btnExportar.ForeColor = Color.White;

            // Posición original
            btnExportar.Location = new Point(679, 66);

            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(105, 35);
            btnExportar.Text = "Exportar PDF";

            btnExportar.UseVisualStyleBackColor = false;

            pnlFiltros.Controls.AddRange(new Control[]
            {
                lblDesde,
                dtpDesde,
                lblHasta,
                dtpHasta,
                lblTipoPedido,
                cmbTipoPedido,
                lblEstado,
                cmbEstado,
                btnBuscar,
                btnExportar
            });

            // ==========================================
            // DATA GRID VIEW
            // ==========================================

            dgvReporte.AllowUserToAddRows = false;
            dgvReporte.AllowUserToDeleteRows = false;

            dgvReporte.AllowUserToResizeColumns = false;
            dgvReporte.AllowUserToResizeRows = false;

            dgvReporte.AutoGenerateColumns = false;

            dgvReporte.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvReporte.BackgroundColor = Color.White;
            dgvReporte.BorderStyle = BorderStyle.None;

            dgvReporte.ColumnHeadersHeight = 40;

            dgvReporte.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            dgvReporte.EnableHeadersVisualStyles = false;

            dgvReporte.ReadOnly = true;
            dgvReporte.RowHeadersVisible = false;
            dgvReporte.MultiSelect = false;

            dgvReporte.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvReporte.ScrollBars = ScrollBars.Both;
            dgvReporte.Dock = DockStyle.Fill;

            dgvReporte.Margin = new Padding(3);
            dgvReporte.Name = "dgvReporte";
            dgvReporte.RowTemplate.Height = 32;

            // Estilo del encabezado

            dgvReporte.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(27, 58, 92);

            dgvReporte.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvReporte.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);

            dgvReporte.ColumnHeadersDefaultCellStyle.WrapMode =
                DataGridViewTriState.True;

            // Estilo de las filas

            dgvReporte.DefaultCellStyle.Font =
                new Font("Segoe UI", 9F);

            dgvReporte.DefaultCellStyle.BackColor =
                Color.White;

            dgvReporte.DefaultCellStyle.ForeColor =
                Color.Black;

            dgvReporte.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(210, 225, 240);

            dgvReporte.DefaultCellStyle.SelectionForeColor =
                Color.Black;

            dgvReporte.DefaultCellStyle.WrapMode =
                DataGridViewTriState.False;

            dgvReporte.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(238, 245, 252);

            // ==========================================
            // COLUMNA: PEDIDO
            // ==========================================

            colIdPedido.Name = "colIdPedido";
            colIdPedido.DataPropertyName = "IdPedido";
            colIdPedido.HeaderText = "Pedido";
            colIdPedido.ReadOnly = true;
            colIdPedido.MinimumWidth = 45;
            colIdPedido.FillWeight = 55;

            // ==========================================
            // COLUMNA: FECHA
            // ==========================================

            colFecha.Name = "colFecha";
            colFecha.DataPropertyName = "Fecha";
            colFecha.HeaderText = "Fecha";
            colFecha.ReadOnly = true;
            colFecha.MinimumWidth = 75;
            colFecha.FillWeight = 90;

            colFecha.DefaultCellStyle.Format = "dd/MM/yy HH:mm";

            // ==========================================
            // COLUMNA: CLIENTE
            // ==========================================

            colCliente.Name = "colCliente";
            colCliente.DataPropertyName = "Cliente";
            colCliente.HeaderText = "Cliente";
            colCliente.ReadOnly = true;
            colCliente.MinimumWidth = 70;
            colCliente.FillWeight = 90;

            // ==========================================
            // COLUMNA: EMPLEADO
            // ==========================================

            colEmpleado.Name = "colEmpleado";
            colEmpleado.DataPropertyName = "Empleado";
            colEmpleado.HeaderText = "Empleado";
            colEmpleado.ReadOnly = true;
            colEmpleado.MinimumWidth = 70;
            colEmpleado.FillWeight = 85;

            // ==========================================
            // COLUMNA: TIPO
            // ==========================================

            colTipoPedido.Name = "colTipoPedido";
            colTipoPedido.DataPropertyName = "TipoPedido";
            colTipoPedido.HeaderText = "Tipo";
            colTipoPedido.ReadOnly = true;
            colTipoPedido.MinimumWidth = 55;
            colTipoPedido.FillWeight = 65;

            // ==========================================
            // COLUMNA: ESTADO
            // ==========================================

            colEstado.Name = "colEstado";
            colEstado.DataPropertyName = "Estado";
            colEstado.HeaderText = "Estado";
            colEstado.ReadOnly = true;
            colEstado.MinimumWidth = 60;
            colEstado.FillWeight = 75;

            // ==========================================
            // COLUMNA: FACTURA
            // ==========================================

            colFactura.Name = "colFactura";
            colFactura.DataPropertyName = "NumeroFactura";
            colFactura.HeaderText = "Factura";
            colFactura.ReadOnly = true;
            colFactura.MinimumWidth = 70;
            colFactura.FillWeight = 90;

            // Agregar únicamente las siete columnas

            dgvReporte.Columns.AddRange(new DataGridViewColumn[]
            {
                colIdPedido,
                colFecha,
                colCliente,
                colEmpleado,
                colTipoPedido,
                colEstado,
                colFactura
            });

            // ==========================================
            // PANEL DE RESUMEN
            // ==========================================

            pnlResumen.BackColor =
                Color.FromArgb(235, 240, 246);

            pnlResumen.Controls.Add(lblResumen);

            pnlResumen.Dock = DockStyle.Fill;
            pnlResumen.Margin = new Padding(0);
            pnlResumen.Name = "pnlResumen";
            pnlResumen.Padding = new Padding(12);

            lblResumen.Dock = DockStyle.Fill;

            lblResumen.Font = new Font(
                "Segoe UI", 9F, FontStyle.Bold);

            lblResumen.ForeColor =
                Color.FromArgb(27, 58, 92);

            lblResumen.Name = "lblResumen";

            lblResumen.Text =
                "Selecciona los filtros y presiona Buscar.";

            lblResumen.TextAlign =
                ContentAlignment.MiddleLeft;

            // ==========================================
            // FORMULARIO PRINCIPAL
            // ==========================================

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;

            BackColor = Color.FromArgb(244, 246, 249);

            // Dimensiones interiores
            ClientSize = new Size(986, 668);

            Controls.Add(tlpPrincipal);

            Font = new Font("Segoe UI", 9F);

            MinimumSize = new Size(900, 580);

            Name = "FrmReportes";

            StartPosition = FormStartPosition.CenterScreen;

            Text = "RestoSys - Reportes";

            // Finalizar diseño

            tlpPrincipal.ResumeLayout(false);

            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();

            pnlFiltros.ResumeLayout(false);
            pnlFiltros.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)dgvReporte).EndInit();

            pnlResumen.ResumeLayout(false);

            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpPrincipal;

        private Panel pnlEncabezado;
        private Label lblTitulo;
        private Label lblSubtitulo;

        private Panel pnlFiltros;

        private Label lblDesde;
        private DateTimePicker dtpDesde;

        private Label lblHasta;
        private DateTimePicker dtpHasta;

        private Label lblTipoPedido;
        private ComboBox cmbTipoPedido;

        private Label lblEstado;
        private ComboBox cmbEstado;

        private Button btnBuscar;
        private Button btnExportar;

        private DataGridView dgvReporte;

        private DataGridViewTextBoxColumn colIdPedido;
        private DataGridViewTextBoxColumn colFecha;
        private DataGridViewTextBoxColumn colCliente;
        private DataGridViewTextBoxColumn colEmpleado;
        private DataGridViewTextBoxColumn colTipoPedido;
        private DataGridViewTextBoxColumn colEstado;
        private DataGridViewTextBoxColumn colFactura;

        private Panel pnlResumen;
        private Label lblResumen;
    }
}
