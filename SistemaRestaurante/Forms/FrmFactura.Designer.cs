
namespace SistemaRestaurante.Forms
{
    partial class FrmFactura
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
            pnlEncabezado = new Panel();
            lblSubtitulo = new Label();
            lblTitulo = new Label();
            grpPedido = new GroupBox();
            lblPedidoId = new Label();
            lblPedidoIdValor = new Label();
            lblFecha = new Label();
            lblFechaValor = new Label();
            lblCliente = new Label();
            lblClienteValor = new Label();
            lblEmpleado = new Label();
            lblEmpleadoValor = new Label();
            lblMesa = new Label();
            lblMesaValor = new Label();
            grpDetalles = new GroupBox();
            dgvDetalles = new DataGridView();
            colProducto = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            colImporte = new DataGridViewTextBoxColumn();
            grpPago = new GroupBox();
            lblMetodoPago = new Label();
            cmbMetodoPago = new ComboBox();
            lblDescuento = new Label();
            nudDescuento = new NumericUpDown();
            lblSubtotalTitulo = new Label();
            lblSubtotalValor = new Label();
            lblDescuentoTitulo = new Label();
            lblDescuentoValor = new Label();
            lblTotalTitulo = new Label();
            lblTotalValor = new Label();
            pnlBotones = new Panel();
            btnGenerarPdf = new Button();
            btnCerrar = new Button();
            pnlEncabezado.SuspendLayout();
            grpPedido.SuspendLayout();
            grpDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).BeginInit();
            grpPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDescuento).BeginInit();
            pnlBotones.SuspendLayout();
            SuspendLayout();
            // 
            // pnlEncabezado
            // 
            pnlEncabezado.BackColor = Color.FromArgb(27, 58, 92);
            pnlEncabezado.Controls.Add(lblSubtitulo);
            pnlEncabezado.Controls.Add(lblTitulo);
            pnlEncabezado.Dock = DockStyle.Top;
            pnlEncabezado.Location = new Point(0, 0);
            pnlEncabezado.Margin = new Padding(3, 4, 3, 4);
            pnlEncabezado.Name = "pnlEncabezado";
            pnlEncabezado.Padding = new Padding(23, 13, 23, 13);
            pnlEncabezado.Size = new Size(1029, 113);
            pnlEncabezado.TabIndex = 3;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 9F);
            lblSubtitulo.ForeColor = Color.FromArgb(220, 230, 240);
            lblSubtitulo.Location = new Point(27, 71);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(275, 20);
            lblSubtitulo.TabIndex = 0;
            lblSubtitulo.Text = "RestoSys | Generación de comprobantes";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(23, 13);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(243, 45);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "FACTURACIÓN";
            // 
            // grpPedido
            // 
            grpPedido.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpPedido.BackColor = Color.White;
            grpPedido.Controls.Add(lblPedidoId);
            grpPedido.Controls.Add(lblPedidoIdValor);
            grpPedido.Controls.Add(lblFecha);
            grpPedido.Controls.Add(lblFechaValor);
            grpPedido.Controls.Add(lblCliente);
            grpPedido.Controls.Add(lblClienteValor);
            grpPedido.Controls.Add(lblEmpleado);
            grpPedido.Controls.Add(lblEmpleadoValor);
            grpPedido.Controls.Add(lblMesa);
            grpPedido.Controls.Add(lblMesaValor);
            grpPedido.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpPedido.ForeColor = Color.FromArgb(27, 58, 92);
            grpPedido.Location = new Point(23, 133);
            grpPedido.Margin = new Padding(3, 4, 3, 4);
            grpPedido.Name = "grpPedido";
            grpPedido.Padding = new Padding(3, 4, 3, 4);
            grpPedido.Size = new Size(983, 193);
            grpPedido.TabIndex = 2;
            grpPedido.TabStop = false;
            grpPedido.Text = "INFORMACIÓN DEL PEDIDO";
            // 
            // lblPedidoId
            // 
            lblPedidoId.AutoSize = true;
            lblPedidoId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPedidoId.ForeColor = Color.FromArgb(50, 50, 50);
            lblPedidoId.Location = new Point(23, 47);
            lblPedidoId.Name = "lblPedidoId";
            lblPedidoId.Size = new Size(144, 20);
            lblPedidoId.TabIndex = 0;
            lblPedidoId.Text = "Número de pedido:";
            // 
            // lblPedidoIdValor
            // 
            lblPedidoIdValor.AutoSize = true;
            lblPedidoIdValor.Font = new Font("Segoe UI", 9F);
            lblPedidoIdValor.ForeColor = Color.Black;
            lblPedidoIdValor.Location = new Point(183, 47);
            lblPedidoIdValor.Name = "lblPedidoIdValor";
            lblPedidoIdValor.Size = new Size(74, 20);
            lblPedidoIdValor.TabIndex = 1;
            lblPedidoIdValor.Text = "Pendiente";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFecha.ForeColor = Color.FromArgb(50, 50, 50);
            lblFecha.Location = new Point(549, 47);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(53, 20);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "Fecha:";
            // 
            // lblFechaValor
            // 
            lblFechaValor.AutoSize = true;
            lblFechaValor.Font = new Font("Segoe UI", 9F);
            lblFechaValor.ForeColor = Color.Black;
            lblFechaValor.Location = new Point(629, 47);
            lblFechaValor.Name = "lblFechaValor";
            lblFechaValor.Size = new Size(74, 20);
            lblFechaValor.TabIndex = 3;
            lblFechaValor.Text = "Pendiente";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCliente.ForeColor = Color.FromArgb(50, 50, 50);
            lblCliente.Location = new Point(23, 100);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(61, 20);
            lblCliente.TabIndex = 4;
            lblCliente.Text = "Cliente:";
            // 
            // lblClienteValor
            // 
            lblClienteValor.AutoSize = true;
            lblClienteValor.Font = new Font("Segoe UI", 9F);
            lblClienteValor.ForeColor = Color.Black;
            lblClienteValor.Location = new Point(183, 100);
            lblClienteValor.Name = "lblClienteValor";
            lblClienteValor.Size = new Size(74, 20);
            lblClienteValor.TabIndex = 5;
            lblClienteValor.Text = "Pendiente";
            // 
            // lblEmpleado
            // 
            lblEmpleado.AutoSize = true;
            lblEmpleado.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEmpleado.ForeColor = Color.FromArgb(50, 50, 50);
            lblEmpleado.Location = new Point(549, 100);
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new Size(82, 20);
            lblEmpleado.TabIndex = 6;
            lblEmpleado.Text = "Empleado:";
            // 
            // lblEmpleadoValor
            // 
            lblEmpleadoValor.AutoSize = true;
            lblEmpleadoValor.Font = new Font("Segoe UI", 9F);
            lblEmpleadoValor.ForeColor = Color.Black;
            lblEmpleadoValor.Location = new Point(629, 100);
            lblEmpleadoValor.Name = "lblEmpleadoValor";
            lblEmpleadoValor.Size = new Size(74, 20);
            lblEmpleadoValor.TabIndex = 7;
            lblEmpleadoValor.Text = "Pendiente";
            // 
            // lblMesa
            // 
            lblMesa.AutoSize = true;
            lblMesa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMesa.ForeColor = Color.FromArgb(50, 50, 50);
            lblMesa.Location = new Point(23, 147);
            lblMesa.Name = "lblMesa";
            lblMesa.Size = new Size(50, 20);
            lblMesa.TabIndex = 8;
            lblMesa.Text = "Mesa:";
            // 
            // lblMesaValor
            // 
            lblMesaValor.AutoSize = true;
            lblMesaValor.Font = new Font("Segoe UI", 9F);
            lblMesaValor.ForeColor = Color.Black;
            lblMesaValor.Location = new Point(183, 147);
            lblMesaValor.Name = "lblMesaValor";
            lblMesaValor.Size = new Size(74, 20);
            lblMesaValor.TabIndex = 9;
            lblMesaValor.Text = "Pendiente";
            // 
            // grpDetalles
            // 
            grpDetalles.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpDetalles.BackColor = Color.White;
            grpDetalles.Controls.Add(dgvDetalles);
            grpDetalles.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpDetalles.ForeColor = Color.FromArgb(27, 58, 92);
            grpDetalles.Location = new Point(23, 340);
            grpDetalles.Margin = new Padding(3, 4, 3, 4);
            grpDetalles.Name = "grpDetalles";
            grpDetalles.Padding = new Padding(3, 4, 3, 4);
            grpDetalles.Size = new Size(983, 293);
            grpDetalles.TabIndex = 1;
            grpDetalles.TabStop = false;
            grpDetalles.Text = "DETALLE DE PRODUCTOS";
            // 
            // dgvDetalles
            // 
            dgvDetalles.AllowUserToAddRows = false;
            dgvDetalles.AllowUserToDeleteRows = false;
            dgvDetalles.AllowUserToResizeRows = false;
            dgvDetalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalles.BackgroundColor = Color.FromArgb(244, 246, 249);
            dgvDetalles.BorderStyle = BorderStyle.None;
            dgvDetalles.ColumnHeadersHeight = 35;
            dgvDetalles.Columns.AddRange(new DataGridViewColumn[] { colProducto, colCantidad, colPrecio, colImporte });
            dgvDetalles.Dock = DockStyle.Fill;
            dgvDetalles.Location = new Point(3, 27);
            dgvDetalles.Margin = new Padding(3, 4, 3, 4);
            dgvDetalles.MultiSelect = false;
            dgvDetalles.Name = "dgvDetalles";
            dgvDetalles.ReadOnly = true;
            dgvDetalles.RowHeadersVisible = false;
            dgvDetalles.RowHeadersWidth = 51;
            dgvDetalles.RowTemplate.Height = 30;
            dgvDetalles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalles.Size = new Size(977, 262);
            dgvDetalles.TabIndex = 0;
            // 
            // colProducto
            // 
            colProducto.FillWeight = 45F;
            colProducto.HeaderText = "Producto";
            colProducto.MinimumWidth = 6;
            colProducto.Name = "colProducto";
            colProducto.ReadOnly = true;
            // 
            // colCantidad
            // 
            colCantidad.FillWeight = 15F;
            colCantidad.HeaderText = "Cantidad";
            colCantidad.MinimumWidth = 6;
            colCantidad.Name = "colCantidad";
            colCantidad.ReadOnly = true;
            // 
            // colPrecio
            // 
            colPrecio.FillWeight = 20F;
            colPrecio.HeaderText = "Precio unitario";
            colPrecio.MinimumWidth = 6;
            colPrecio.Name = "colPrecio";
            colPrecio.ReadOnly = true;
            // 
            // colImporte
            // 
            colImporte.FillWeight = 20F;
            colImporte.HeaderText = "Importe";
            colImporte.MinimumWidth = 6;
            colImporte.Name = "colImporte";
            colImporte.ReadOnly = true;
            // 
            // grpPago
            // 
            grpPago.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpPago.BackColor = Color.White;
            grpPago.Controls.Add(lblMetodoPago);
            grpPago.Controls.Add(cmbMetodoPago);
            grpPago.Controls.Add(lblDescuento);
            grpPago.Controls.Add(nudDescuento);
            grpPago.Controls.Add(lblSubtotalTitulo);
            grpPago.Controls.Add(lblSubtotalValor);
            grpPago.Controls.Add(lblDescuentoTitulo);
            grpPago.Controls.Add(lblDescuentoValor);
            grpPago.Controls.Add(lblTotalTitulo);
            grpPago.Controls.Add(lblTotalValor);
            grpPago.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpPago.ForeColor = Color.FromArgb(27, 58, 92);
            grpPago.Location = new Point(23, 647);
            grpPago.Margin = new Padding(3, 4, 3, 4);
            grpPago.Name = "grpPago";
            grpPago.Padding = new Padding(3, 4, 3, 4);
            grpPago.Size = new Size(983, 193);
            grpPago.TabIndex = 0;
            grpPago.TabStop = false;
            grpPago.Text = "DATOS DE FACTURACIÓN";
            // 
            // lblMetodoPago
            // 
            lblMetodoPago.AutoSize = true;
            lblMetodoPago.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMetodoPago.ForeColor = Color.FromArgb(50, 50, 50);
            lblMetodoPago.Location = new Point(23, 51);
            lblMetodoPago.Name = "lblMetodoPago";
            lblMetodoPago.Size = new Size(128, 20);
            lblMetodoPago.TabIndex = 0;
            lblMetodoPago.Text = "Método de pago:";
            // 
            // cmbMetodoPago
            // 
            cmbMetodoPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMetodoPago.Font = new Font("Segoe UI", 9F);
            cmbMetodoPago.Location = new Point(166, 45);
            cmbMetodoPago.Margin = new Padding(3, 4, 3, 4);
            cmbMetodoPago.Name = "cmbMetodoPago";
            cmbMetodoPago.Size = new Size(217, 28);
            cmbMetodoPago.TabIndex = 1;
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDescuento.ForeColor = Color.FromArgb(50, 50, 50);
            lblDescuento.Location = new Point(23, 109);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(112, 20);
            lblDescuento.TabIndex = 2;
            lblDescuento.Text = "Descuento ($):";
            // 
            // nudDescuento
            // 
            nudDescuento.DecimalPlaces = 2;
            nudDescuento.Font = new Font("Segoe UI", 9F);
            nudDescuento.Increment = new decimal(new int[] { 50, 0, 0, 131072 });
            nudDescuento.Location = new Point(166, 105);
            nudDescuento.Margin = new Padding(3, 4, 3, 4);
            nudDescuento.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudDescuento.Name = "nudDescuento";
            nudDescuento.Size = new Size(217, 27);
            nudDescuento.TabIndex = 3;
            nudDescuento.ThousandsSeparator = true;
            // 
            // lblSubtotalTitulo
            // 
            lblSubtotalTitulo.AutoSize = true;
            lblSubtotalTitulo.Font = new Font("Segoe UI", 9F);
            lblSubtotalTitulo.ForeColor = Color.FromArgb(50, 50, 50);
            lblSubtotalTitulo.Location = new Point(583, 43);
            lblSubtotalTitulo.Name = "lblSubtotalTitulo";
            lblSubtotalTitulo.Size = new Size(68, 20);
            lblSubtotalTitulo.TabIndex = 4;
            lblSubtotalTitulo.Text = "Subtotal:";
            // 
            // lblSubtotalValor
            // 
            lblSubtotalValor.AutoSize = true;
            lblSubtotalValor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSubtotalValor.ForeColor = Color.Black;
            lblSubtotalValor.Location = new Point(789, 43);
            lblSubtotalValor.Name = "lblSubtotalValor";
            lblSubtotalValor.Size = new Size(49, 20);
            lblSubtotalValor.TabIndex = 5;
            lblSubtotalValor.Text = "$0.00";
            // 
            // lblDescuentoTitulo
            // 
            lblDescuentoTitulo.AutoSize = true;
            lblDescuentoTitulo.Font = new Font("Segoe UI", 9F);
            lblDescuentoTitulo.ForeColor = Color.FromArgb(50, 50, 50);
            lblDescuentoTitulo.Location = new Point(583, 83);
            lblDescuentoTitulo.Name = "lblDescuentoTitulo";
            lblDescuentoTitulo.Size = new Size(82, 20);
            lblDescuentoTitulo.TabIndex = 6;
            lblDescuentoTitulo.Text = "Descuento:";
            // 
            // lblDescuentoValor
            // 
            lblDescuentoValor.AutoSize = true;
            lblDescuentoValor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDescuentoValor.ForeColor = Color.Black;
            lblDescuentoValor.Location = new Point(789, 83);
            lblDescuentoValor.Name = "lblDescuentoValor";
            lblDescuentoValor.Size = new Size(49, 20);
            lblDescuentoValor.TabIndex = 7;
            lblDescuentoValor.Text = "$0.00";
            // 
            // lblTotalTitulo
            // 
            lblTotalTitulo.AutoSize = true;
            lblTotalTitulo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTotalTitulo.ForeColor = Color.FromArgb(27, 58, 92);
            lblTotalTitulo.Location = new Point(583, 128);
            lblTotalTitulo.Name = "lblTotalTitulo";
            lblTotalTitulo.Size = new Size(73, 25);
            lblTotalTitulo.TabIndex = 8;
            lblTotalTitulo.Text = "TOTAL:";
            // 
            // lblTotalValor
            // 
            lblTotalValor.AutoSize = true;
            lblTotalValor.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTotalValor.ForeColor = Color.FromArgb(27, 58, 92);
            lblTotalValor.Location = new Point(789, 120);
            lblTotalValor.Name = "lblTotalValor";
            lblTotalValor.Size = new Size(88, 37);
            lblTotalValor.TabIndex = 9;
            lblTotalValor.Text = "$0.00";
            // 
            // pnlBotones
            // 
            pnlBotones.BackColor = Color.FromArgb(244, 246, 249);
            pnlBotones.Controls.Add(btnGenerarPdf);
            pnlBotones.Controls.Add(btnCerrar);
            pnlBotones.Dock = DockStyle.Bottom;
            pnlBotones.Location = new Point(0, 860);
            pnlBotones.Margin = new Padding(3, 4, 3, 4);
            pnlBotones.Name = "pnlBotones";
            pnlBotones.Padding = new Padding(17, 20, 17, 20);
            pnlBotones.Size = new Size(1029, 87);
            pnlBotones.TabIndex = 4;
            // 
            // btnGenerarPdf
            // 
            btnGenerarPdf.BackColor = Color.FromArgb(27, 58, 92);
            btnGenerarPdf.Enabled = false;
            btnGenerarPdf.FlatAppearance.BorderSize = 0;
            btnGenerarPdf.FlatStyle = FlatStyle.Flat;
            btnGenerarPdf.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGenerarPdf.ForeColor = Color.White;
            btnGenerarPdf.Location = new Point(17, 16);
            btnGenerarPdf.Margin = new Padding(3, 4, 3, 4);
            btnGenerarPdf.Name = "btnGenerarPdf";
            btnGenerarPdf.Size = new Size(183, 53);
            btnGenerarPdf.TabIndex = 0;
            btnGenerarPdf.Text = "Generar factura PDF";
            btnGenerarPdf.UseVisualStyleBackColor = false;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(220, 225, 230);
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCerrar.ForeColor = Color.FromArgb(40, 40, 40);
            btnCerrar.Location = new Point(211, 16);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(103, 53);
            btnCerrar.TabIndex = 1;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            // 
            // FrmFactura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(1029, 947);
            Controls.Add(grpPago);
            Controls.Add(grpDetalles);
            Controls.Add(grpPedido);
            Controls.Add(pnlEncabezado);
            Controls.Add(pnlBotones);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(969, 918);
            Name = "FrmFactura";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RestoSys - Facturación";
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            grpPedido.ResumeLayout(false);
            grpPedido.PerformLayout();
            grpDetalles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).EndInit();
            grpPago.ResumeLayout(false);
            grpPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDescuento).EndInit();
            pnlBotones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlEncabezado;
        private Label lblTitulo;
        private Label lblSubtitulo;

        private GroupBox grpPedido;
        private Label lblPedidoId;
        private Label lblPedidoIdValor;
        private Label lblFecha;
        private Label lblFechaValor;
        private Label lblCliente;
        private Label lblClienteValor;
        private Label lblEmpleado;
        private Label lblEmpleadoValor;
        private Label lblMesa;
        private Label lblMesaValor;

        private GroupBox grpDetalles;
        private DataGridView dgvDetalles;
        private DataGridViewTextBoxColumn colProducto;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewTextBoxColumn colPrecio;
        private DataGridViewTextBoxColumn colImporte;

        private GroupBox grpPago;
        private Label lblMetodoPago;
        private ComboBox cmbMetodoPago;
        private Label lblDescuento;
        private NumericUpDown nudDescuento;

        private Label lblSubtotalTitulo;
        private Label lblSubtotalValor;
        private Label lblDescuentoTitulo;
        private Label lblDescuentoValor;
        private Label lblTotalTitulo;
        private Label lblTotalValor;

        private Panel pnlBotones;
        private Button btnGenerarPdf;
        private Button btnCerrar;
    }
}
