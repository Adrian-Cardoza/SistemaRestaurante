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
			cmbMesa = new ComboBox();
			lblMesa = new Label();
			lblCliente = new Label();
			lblEstado = new Label();
			cmbCliente = new ComboBox();
			cmbEstado = new ComboBox();
			btnGuardar = new Button();
			btnEditar = new Button();
			btnCancelar = new Button();
			lblFecha = new Label();
			dtpFecha = new DateTimePicker();
			rbComerAqui = new RadioButton();
			rbParaLlevar = new RadioButton();
			dgvDetalles = new DataGridView();
			groupBox1 = new GroupBox();
			label2 = new Label();
			flpProductos = new FlowLayoutPanel();
			groupBox2 = new GroupBox();
			((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
			((System.ComponentModel.ISupportInitialize)dgvDetalles).BeginInit();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			SuspendLayout();
			// 
			// dgvPedidos
			// 
			dgvPedidos.AllowUserToAddRows = false;
			dgvPedidos.AllowUserToDeleteRows = false;
			dgvPedidos.AllowUserToResizeColumns = false;
			dgvPedidos.AllowUserToResizeRows = false;
			dgvPedidos.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			dgvPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvPedidos.BackgroundColor = Color.FromArgb(244, 246, 249);
			dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvPedidos.Location = new Point(4, 20);
			dgvPedidos.Margin = new Padding(1);
			dgvPedidos.Name = "dgvPedidos";
			dgvPedidos.ReadOnly = true;
			dgvPedidos.RowHeadersVisible = false;
			dgvPedidos.RowHeadersWidth = 62;
			dgvPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvPedidos.Size = new Size(555, 184);
			dgvPedidos.TabIndex = 0;
			// 
			// cmbMesa
			// 
			cmbMesa.FormattingEnabled = true;
			cmbMesa.Location = new Point(49, 27);
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
			lblMesa.Location = new Point(11, 30);
			lblMesa.Margin = new Padding(1, 0, 1, 0);
			lblMesa.Name = "lblMesa";
			lblMesa.Size = new Size(36, 15);
			lblMesa.TabIndex = 4;
			lblMesa.Text = "Mesa";
			// 
			// lblCliente
			// 
			lblCliente.AutoSize = true;
			lblCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lblCliente.ForeColor = Color.FromArgb(34, 34, 34);
			lblCliente.Location = new Point(194, 30);
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
			lblEstado.Location = new Point(387, 30);
			lblEstado.Margin = new Padding(1, 0, 1, 0);
			lblEstado.Name = "lblEstado";
			lblEstado.Size = new Size(43, 15);
			lblEstado.TabIndex = 7;
			lblEstado.Text = "Estado";
			// 
			// cmbCliente
			// 
			cmbCliente.FormattingEnabled = true;
			cmbCliente.Location = new Point(242, 27);
			cmbCliente.Margin = new Padding(1);
			cmbCliente.Name = "cmbCliente";
			cmbCliente.Size = new Size(122, 23);
			cmbCliente.TabIndex = 9;
			// 
			// cmbEstado
			// 
			cmbEstado.FormattingEnabled = true;
			cmbEstado.Location = new Point(432, 27);
			cmbEstado.Margin = new Padding(1);
			cmbEstado.Name = "cmbEstado";
			cmbEstado.Size = new Size(127, 23);
			cmbEstado.TabIndex = 10;
			// 
			// btnGuardar
			// 
			btnGuardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnGuardar.BackColor = Color.LightGreen;
			btnGuardar.FlatAppearance.BorderSize = 0;
			btnGuardar.FlatStyle = FlatStyle.Flat;
			btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			btnGuardar.Location = new Point(648, 472);
			btnGuardar.Margin = new Padding(1);
			btnGuardar.Name = "btnGuardar";
			btnGuardar.Size = new Size(97, 45);
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
			btnEditar.Location = new Point(648, 529);
			btnEditar.Margin = new Padding(1);
			btnEditar.Name = "btnEditar";
			btnEditar.Size = new Size(97, 45);
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
			btnCancelar.Location = new Point(648, 586);
			btnCancelar.Margin = new Padding(1);
			btnCancelar.Name = "btnCancelar";
			btnCancelar.Size = new Size(97, 45);
			btnCancelar.TabIndex = 14;
			btnCancelar.Text = "Cancelar";
			btnCancelar.UseVisualStyleBackColor = false;
			// 
			// lblFecha
			// 
			lblFecha.AutoSize = true;
			lblFecha.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lblFecha.ForeColor = Color.FromArgb(34, 34, 34);
			lblFecha.Location = new Point(302, 66);
			lblFecha.Margin = new Padding(1, 0, 1, 0);
			lblFecha.Name = "lblFecha";
			lblFecha.Size = new Size(39, 15);
			lblFecha.TabIndex = 15;
			lblFecha.Text = "Fecha";
			// 
			// dtpFecha
			// 
			dtpFecha.Location = new Point(345, 60);
			dtpFecha.Margin = new Padding(3, 2, 3, 2);
			dtpFecha.Name = "dtpFecha";
			dtpFecha.Size = new Size(214, 23);
			dtpFecha.TabIndex = 16;
			// 
			// rbComerAqui
			// 
			rbComerAqui.AutoSize = true;
			rbComerAqui.Font = new Font("Segoe UI", 9F);
			rbComerAqui.Location = new Point(87, 64);
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
			rbParaLlevar.Font = new Font("Segoe UI", 9F);
			rbParaLlevar.Location = new Point(180, 64);
			rbParaLlevar.Name = "rbParaLlevar";
			rbParaLlevar.Size = new Size(79, 19);
			rbParaLlevar.TabIndex = 20;
			rbParaLlevar.TabStop = true;
			rbParaLlevar.Text = "Para llevar";
			rbParaLlevar.UseVisualStyleBackColor = true;
			rbParaLlevar.CheckedChanged += rbParaLlevar_CheckedChanged;
			// 
			// dgvDetalles
			// 
			dgvDetalles.AllowUserToAddRows = false;
			dgvDetalles.AllowUserToDeleteRows = false;
			dgvDetalles.AllowUserToResizeColumns = false;
			dgvDetalles.AllowUserToResizeRows = false;
			dgvDetalles.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			dgvDetalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvDetalles.BackgroundColor = Color.FromArgb(244, 246, 249);
			dgvDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvDetalles.Location = new Point(581, 12);
			dgvDetalles.Name = "dgvDetalles";
			dgvDetalles.ReadOnly = true;
			dgvDetalles.RowHeadersVisible = false;
			dgvDetalles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvDetalles.Size = new Size(223, 430);
			dgvDetalles.TabIndex = 26;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(lblMesa);
			groupBox1.Controls.Add(cmbMesa);
			groupBox1.Controls.Add(lblCliente);
			groupBox1.Controls.Add(cmbCliente);
			groupBox1.Controls.Add(rbComerAqui);
			groupBox1.Controls.Add(rbParaLlevar);
			groupBox1.Controls.Add(lblFecha);
			groupBox1.Controls.Add(dtpFecha);
			groupBox1.Controls.Add(cmbEstado);
			groupBox1.Controls.Add(lblEstado);
			groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			groupBox1.Location = new Point(10, 12);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(565, 105);
			groupBox1.TabIndex = 27;
			groupBox1.TabStop = false;
			groupBox1.Text = "Nueva Orden";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label2.ForeColor = Color.FromArgb(34, 34, 34);
			label2.Location = new Point(11, 66);
			label2.Margin = new Padding(1, 0, 1, 0);
			label2.Name = "label2";
			label2.Size = new Size(72, 15);
			label2.TabIndex = 28;
			label2.Text = "Tipo Pedido";
			// 
			// flpProductos
			// 
			flpProductos.AutoScroll = true;
			flpProductos.Location = new Point(12, 123);
			flpProductos.Name = "flpProductos";
			flpProductos.Size = new Size(563, 319);
			flpProductos.TabIndex = 28;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(dgvPedidos);
			groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			groupBox2.Location = new Point(12, 448);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(563, 208);
			groupBox2.TabIndex = 29;
			groupBox2.TabStop = false;
			groupBox2.Text = "Historial de Pedidos";
			// 
			// FrmPedidos
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(244, 246, 249);
			ClientSize = new Size(808, 668);
			Controls.Add(groupBox2);
			Controls.Add(flpProductos);
			Controls.Add(groupBox1);
			Controls.Add(dgvDetalles);
			Controls.Add(btnCancelar);
			Controls.Add(btnEditar);
			Controls.Add(btnGuardar);
			Margin = new Padding(1);
			Name = "FrmPedidos";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Pedidos";
			Load += FrmPedidos_Load;
			((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
			((System.ComponentModel.ISupportInitialize)dgvDetalles).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dgvPedidos;
        private ComboBox cmbMesa;
        private Label lblMesa;
        private Label lblCliente;
        private Label lblEstado;
        private ComboBox cmbCliente;
        private ComboBox cmbEstado;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnCancelar;
        private Label lblFecha;
        private DateTimePicker dtpFecha;
		private RadioButton rbComerAqui;
		private RadioButton rbParaLlevar;
		private DataGridView dgvDetalles;
		private GroupBox groupBox1;
		private Label label2;
		private FlowLayoutPanel flpProductos;
		private GroupBox groupBox2;
	}
}