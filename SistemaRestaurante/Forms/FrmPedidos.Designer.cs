namespace SistemaRestaurante.Forms
{
    partial class FrmPedidos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			dgvPedidos = new DataGridView();
			txtBuscar = new TextBox();
			label1 = new Label();
			cmbMesa = new ComboBox();
			lblMesa = new Label();
			lblEmpleado = new Label();
			lblCliente = new Label();
			lblEstado = new Label();
			cmbEmpleado = new ComboBox();
			cmbCliente = new ComboBox();
			cmbEstado = new ComboBox();
			btnGuardar = new Button();
			btnEditar = new Button();
			btnCancelar = new Button();
			lblFecha = new Label();
			dtpFecha = new DateTimePicker();
			rbComerAqui = new RadioButton();
			rbParaLlevar = new RadioButton();
			lblProducto = new Label();
			cmbProducto = new ComboBox();
			lblCantidad = new Label();
			nudCantidad = new NumericUpDown();
			btnAgregar = new Button();
			dgvDetalles = new DataGridView();
			((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
			((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
			((System.ComponentModel.ISupportInitialize)dgvDetalles).BeginInit();
			SuspendLayout();
			// 
			// dgvPedidos
			// 
			dgvPedidos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvPedidos.Location = new Point(260, 218);
			dgvPedidos.Margin = new Padding(1);
			dgvPedidos.Name = "dgvPedidos";
			dgvPedidos.RowHeadersVisible = false;
			dgvPedidos.RowHeadersWidth = 62;
			dgvPedidos.Size = new Size(357, 212);
			dgvPedidos.TabIndex = 0;
			// 
			// txtBuscar
			// 
			txtBuscar.Location = new Point(94, 6);
			txtBuscar.Margin = new Padding(1);
			txtBuscar.Name = "txtBuscar";
			txtBuscar.Size = new Size(525, 23);
			txtBuscar.TabIndex = 1;
			txtBuscar.TextChanged += txtBuscar_TextChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(10, 9);
			label1.Margin = new Padding(1, 0, 1, 0);
			label1.Name = "label1";
			label1.Size = new Size(82, 15);
			label1.TabIndex = 2;
			label1.Text = "Buscar Pedido";
			// 
			// cmbMesa
			// 
			cmbMesa.FormattingEnabled = true;
			cmbMesa.Location = new Point(51, 77);
			cmbMesa.Margin = new Padding(1);
			cmbMesa.Name = "cmbMesa";
			cmbMesa.Size = new Size(129, 23);
			cmbMesa.TabIndex = 3;
			// 
			// lblMesa
			// 
			lblMesa.AutoSize = true;
			lblMesa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lblMesa.ForeColor = Color.FromArgb(34, 34, 34);
			lblMesa.Location = new Point(13, 80);
			lblMesa.Margin = new Padding(1, 0, 1, 0);
			lblMesa.Name = "lblMesa";
			lblMesa.Size = new Size(36, 15);
			lblMesa.TabIndex = 4;
			lblMesa.Text = "Mesa";
			// 
			// lblEmpleado
			// 
			lblEmpleado.AutoSize = true;
			lblEmpleado.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lblEmpleado.ForeColor = Color.FromArgb(34, 34, 34);
			lblEmpleado.Location = new Point(191, 80);
			lblEmpleado.Margin = new Padding(1, 0, 1, 0);
			lblEmpleado.Name = "lblEmpleado";
			lblEmpleado.Size = new Size(61, 15);
			lblEmpleado.TabIndex = 5;
			lblEmpleado.Text = "Empleado";
			// 
			// lblCliente
			// 
			lblCliente.AutoSize = true;
			lblCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lblCliente.ForeColor = Color.FromArgb(34, 34, 34);
			lblCliente.Location = new Point(399, 80);
			lblCliente.Margin = new Padding(1, 0, 1, 0);
			lblCliente.Name = "lblCliente";
			lblCliente.Size = new Size(46, 15);
			lblCliente.TabIndex = 6;
			lblCliente.Text = "Cliente";
			// 
			// lblEstado
			// 
			lblEstado.AutoSize = true;
			lblEstado.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lblEstado.ForeColor = Color.FromArgb(34, 34, 34);
			lblEstado.Location = new Point(323, 127);
			lblEstado.Margin = new Padding(1, 0, 1, 0);
			lblEstado.Name = "lblEstado";
			lblEstado.Size = new Size(43, 15);
			lblEstado.TabIndex = 7;
			lblEstado.Text = "Estado";
			// 
			// cmbEmpleado
			// 
			cmbEmpleado.FormattingEnabled = true;
			cmbEmpleado.Location = new Point(254, 77);
			cmbEmpleado.Margin = new Padding(1);
			cmbEmpleado.Name = "cmbEmpleado";
			cmbEmpleado.Size = new Size(129, 23);
			cmbEmpleado.TabIndex = 8;
			// 
			// cmbCliente
			// 
			cmbCliente.FormattingEnabled = true;
			cmbCliente.Location = new Point(447, 77);
			cmbCliente.Margin = new Padding(1);
			cmbCliente.Name = "cmbCliente";
			cmbCliente.Size = new Size(172, 23);
			cmbCliente.TabIndex = 9;
			// 
			// cmbEstado
			// 
			cmbEstado.FormattingEnabled = true;
			cmbEstado.Location = new Point(368, 124);
			cmbEstado.Margin = new Padding(1);
			cmbEstado.Name = "cmbEstado";
			cmbEstado.Size = new Size(129, 23);
			cmbEstado.TabIndex = 10;
			// 
			// btnGuardar
			// 
			btnGuardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnGuardar.BackColor = Color.LightGreen;
			btnGuardar.FlatAppearance.BorderSize = 0;
			btnGuardar.FlatStyle = FlatStyle.Flat;
			btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			btnGuardar.Location = new Point(196, 463);
			btnGuardar.Margin = new Padding(1);
			btnGuardar.Name = "btnGuardar";
			btnGuardar.Size = new Size(78, 20);
			btnGuardar.TabIndex = 12;
			btnGuardar.Text = "Guardar";
			btnGuardar.UseVisualStyleBackColor = false;
			btnGuardar.Click += btnGuardar_Click;
			// 
			// btnEditar
			// 
			btnEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnEditar.BackColor = Color.Khaki;
			btnEditar.FlatAppearance.BorderSize = 0;
			btnEditar.FlatStyle = FlatStyle.Flat;
			btnEditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			btnEditar.Location = new Point(297, 463);
			btnEditar.Margin = new Padding(1);
			btnEditar.Name = "btnEditar";
			btnEditar.Size = new Size(78, 20);
			btnEditar.TabIndex = 13;
			btnEditar.Text = "Editar";
			btnEditar.UseVisualStyleBackColor = false;
			btnEditar.Click += btnEditar_Click;
			// 
			// btnCancelar
			// 
			btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnCancelar.BackColor = Color.IndianRed;
			btnCancelar.FlatAppearance.BorderSize = 0;
			btnCancelar.FlatStyle = FlatStyle.Flat;
			btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			btnCancelar.Location = new Point(399, 463);
			btnCancelar.Margin = new Padding(1);
			btnCancelar.Name = "btnCancelar";
			btnCancelar.Size = new Size(78, 20);
			btnCancelar.TabIndex = 14;
			btnCancelar.Text = "Cancelar";
			btnCancelar.UseVisualStyleBackColor = false;
			btnCancelar.Click += btnCancelar_Click;
			// 
			// lblFecha
			// 
			lblFecha.AutoSize = true;
			lblFecha.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lblFecha.ForeColor = Color.FromArgb(34, 34, 34);
			lblFecha.Location = new Point(10, 127);
			lblFecha.Margin = new Padding(1, 0, 1, 0);
			lblFecha.Name = "lblFecha";
			lblFecha.Size = new Size(39, 15);
			lblFecha.TabIndex = 15;
			lblFecha.Text = "Fecha";
			// 
			// dtpFecha
			// 
			dtpFecha.Location = new Point(53, 124);
			dtpFecha.Margin = new Padding(3, 2, 3, 2);
			dtpFecha.Name = "dtpFecha";
			dtpFecha.Size = new Size(255, 23);
			dtpFecha.TabIndex = 16;
			// 
			// rbComerAqui
			// 
			rbComerAqui.AutoSize = true;
			rbComerAqui.Location = new Point(180, 43);
			rbComerAqui.Name = "rbComerAqui";
			rbComerAqui.Size = new Size(87, 19);
			rbComerAqui.TabIndex = 19;
			rbComerAqui.TabStop = true;
			rbComerAqui.Text = "Comer aquí";
			rbComerAqui.UseVisualStyleBackColor = true;
			rbComerAqui.CheckedChanged += rbComerAqui_CheckedChanged;
			// 
			// rbParaLlevar
			// 
			rbParaLlevar.AutoSize = true;
			rbParaLlevar.Location = new Point(304, 43);
			rbParaLlevar.Name = "rbParaLlevar";
			rbParaLlevar.Size = new Size(79, 19);
			rbParaLlevar.TabIndex = 20;
			rbParaLlevar.TabStop = true;
			rbParaLlevar.Text = "Para llevar";
			rbParaLlevar.UseVisualStyleBackColor = true;
			rbParaLlevar.CheckedChanged += rbParaLlevar_CheckedChanged;
			// 
			// lblProducto
			// 
			lblProducto.AutoSize = true;
			lblProducto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lblProducto.ForeColor = Color.FromArgb(34, 34, 34);
			lblProducto.Location = new Point(34, 177);
			lblProducto.Margin = new Padding(1, 0, 1, 0);
			lblProducto.Name = "lblProducto";
			lblProducto.Size = new Size(58, 15);
			lblProducto.TabIndex = 21;
			lblProducto.Text = "Producto";
			// 
			// cmbProducto
			// 
			cmbProducto.FormattingEnabled = true;
			cmbProducto.Location = new Point(94, 174);
			cmbProducto.Margin = new Padding(1);
			cmbProducto.Name = "cmbProducto";
			cmbProducto.Size = new Size(129, 23);
			cmbProducto.TabIndex = 22;
			// 
			// lblCantidad
			// 
			lblCantidad.AutoSize = true;
			lblCantidad.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lblCantidad.ForeColor = Color.FromArgb(34, 34, 34);
			lblCantidad.Location = new Point(260, 177);
			lblCantidad.Margin = new Padding(1, 0, 1, 0);
			lblCantidad.Name = "lblCantidad";
			lblCantidad.Size = new Size(35, 15);
			lblCantidad.TabIndex = 23;
			lblCantidad.Text = "Cant.";
			// 
			// nudCantidad
			// 
			nudCantidad.Location = new Point(299, 174);
			nudCantidad.Name = "nudCantidad";
			nudCantidad.Size = new Size(120, 23);
			nudCantidad.TabIndex = 24;
			// 
			// btnAgregar
			// 
			btnAgregar.BackColor = Color.LightBlue;
			btnAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnAgregar.Location = new Point(447, 174);
			btnAgregar.Name = "btnAgregar";
			btnAgregar.Size = new Size(30, 23);
			btnAgregar.TabIndex = 25;
			btnAgregar.Text = "+";
			btnAgregar.UseVisualStyleBackColor = false;
			btnAgregar.Click += btnAgregarProducto_Click;
			// 
			// dgvDetalles
			// 
			dgvDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvDetalles.Location = new Point(10, 218);
			dgvDetalles.Name = "dgvDetalles";
			dgvDetalles.Size = new Size(240, 212);
			dgvDetalles.TabIndex = 26;
			// 
			// FrmPedidos
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(244, 246, 249);
			ClientSize = new Size(627, 519);
			Controls.Add(dgvDetalles);
			Controls.Add(btnAgregar);
			Controls.Add(nudCantidad);
			Controls.Add(lblCantidad);
			Controls.Add(cmbProducto);
			Controls.Add(lblProducto);
			Controls.Add(rbParaLlevar);
			Controls.Add(rbComerAqui);
			Controls.Add(dtpFecha);
			Controls.Add(lblFecha);
			Controls.Add(btnCancelar);
			Controls.Add(btnEditar);
			Controls.Add(btnGuardar);
			Controls.Add(cmbEstado);
			Controls.Add(cmbCliente);
			Controls.Add(cmbEmpleado);
			Controls.Add(lblEstado);
			Controls.Add(lblCliente);
			Controls.Add(lblEmpleado);
			Controls.Add(lblMesa);
			Controls.Add(cmbMesa);
			Controls.Add(label1);
			Controls.Add(txtBuscar);
			Controls.Add(dgvPedidos);
			Margin = new Padding(1);
			Name = "FrmPedidos";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Pedidos";
			Load += FrmPedidos_Load;
			((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
			((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
			((System.ComponentModel.ISupportInitialize)dgvDetalles).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dgvPedidos;
        private TextBox txtBuscar;
        private Label label1;
        private ComboBox cmbMesa;
        private Label lblMesa;
        private Label lblEmpleado;
        private Label lblCliente;
        private Label lblEstado;
        private ComboBox cmbEmpleado;
        private ComboBox cmbCliente;
        private ComboBox cmbEstado;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnCancelar;
        private Label lblFecha;
        private DateTimePicker dtpFecha;
		private RadioButton rbComerAqui;
		private RadioButton rbParaLlevar;
		private Label lblProducto;
		private ComboBox cmbProducto;
		private Label lblCantidad;
		private NumericUpDown nudCantidad;
		private Button btnAgregar;
		private DataGridView dgvDetalles;
	}
}