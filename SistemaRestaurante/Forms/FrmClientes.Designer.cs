namespace SistemaRestaurante.Forms
{
    partial class FrmClientes
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
			lblNombre = new Label();
			txtNombre = new TextBox();
			lblDui = new Label();
			lblCorreo = new Label();
			txtDui = new TextBox();
			txtCorreo = new TextBox();
			dgvClientes = new DataGridView();
			btnAgregar = new Button();
			btnEliminar = new Button();
			groupBox1 = new GroupBox();
			((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// lblNombre
			// 
			lblNombre.AutoSize = true;
			lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lblNombre.ForeColor = Color.FromArgb(34, 34, 34);
			lblNombre.Location = new Point(25, 37);
			lblNombre.Name = "lblNombre";
			lblNombre.Size = new Size(56, 15);
			lblNombre.TabIndex = 0;
			lblNombre.Text = "Nombre:";
			// 
			// txtNombre
			// 
			txtNombre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			txtNombre.Location = new Point(91, 34);
			txtNombre.Name = "txtNombre";
			txtNombre.Size = new Size(540, 23);
			txtNombre.TabIndex = 1;
			txtNombre.TextChanged += txtNombre_TextChanged;
			// 
			// lblDui
			// 
			lblDui.AutoSize = true;
			lblDui.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lblDui.ForeColor = Color.FromArgb(34, 34, 34);
			lblDui.Location = new Point(25, 69);
			lblDui.Name = "lblDui";
			lblDui.Size = new Size(32, 15);
			lblDui.TabIndex = 2;
			lblDui.Text = "DUI:";
			// 
			// lblCorreo
			// 
			lblCorreo.AutoSize = true;
			lblCorreo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lblCorreo.ForeColor = Color.FromArgb(34, 34, 34);
			lblCorreo.Location = new Point(25, 102);
			lblCorreo.Name = "lblCorreo";
			lblCorreo.Size = new Size(48, 15);
			lblCorreo.TabIndex = 3;
			lblCorreo.Text = "Correo:";
			// 
			// txtDui
			// 
			txtDui.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			txtDui.Location = new Point(91, 66);
			txtDui.Name = "txtDui";
			txtDui.Size = new Size(540, 23);
			txtDui.TabIndex = 4;
			txtDui.TextChanged += txtDui_TextChanged;
			// 
			// txtCorreo
			// 
			txtCorreo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			txtCorreo.Location = new Point(91, 99);
			txtCorreo.Name = "txtCorreo";
			txtCorreo.Size = new Size(540, 23);
			txtCorreo.TabIndex = 5;
			txtCorreo.TextChanged += txtCorreo_TextChanged;
			// 
			// dgvClientes
			// 
			dgvClientes.AllowUserToAddRows = false;
			dgvClientes.AllowUserToDeleteRows = false;
			dgvClientes.AllowUserToResizeColumns = false;
			dgvClientes.AllowUserToResizeRows = false;
			dgvClientes.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvClientes.BackgroundColor = Color.FromArgb(244, 246, 249);
			dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvClientes.Location = new Point(12, 169);
			dgvClientes.MultiSelect = false;
			dgvClientes.Name = "dgvClientes";
			dgvClientes.ReadOnly = true;
			dgvClientes.RowHeadersVisible = false;
			dgvClientes.RowHeadersWidth = 62;
			dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvClientes.Size = new Size(784, 487);
			dgvClientes.TabIndex = 6;
			dgvClientes.CellContentClick += dgvClientes_CellContentClick;
			// 
			// btnAgregar
			// 
			btnAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			btnAgregar.BackColor = Color.MediumSeaGreen;
			btnAgregar.FlatAppearance.BorderSize = 0;
			btnAgregar.FlatStyle = FlatStyle.Flat;
			btnAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			btnAgregar.ForeColor = Color.FromArgb(34, 34, 34);
			btnAgregar.Location = new Point(660, 34);
			btnAgregar.Name = "btnAgregar";
			btnAgregar.Size = new Size(107, 34);
			btnAgregar.TabIndex = 7;
			btnAgregar.Text = "Agregar";
			btnAgregar.UseVisualStyleBackColor = false;
			btnAgregar.Click += btnAgregar_Click;
			// 
			// btnEliminar
			// 
			btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnEliminar.BackColor = Color.Crimson;
			btnEliminar.FlatAppearance.BorderSize = 0;
			btnEliminar.FlatStyle = FlatStyle.Flat;
			btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			btnEliminar.ForeColor = Color.FromArgb(34, 34, 34);
			btnEliminar.Location = new Point(660, 88);
			btnEliminar.Name = "btnEliminar";
			btnEliminar.Size = new Size(107, 34);
			btnEliminar.TabIndex = 8;
			btnEliminar.Text = "Eliminar";
			btnEliminar.UseVisualStyleBackColor = false;
			btnEliminar.Click += btnEliminar_Click;
			// 
			// groupBox1
			// 
			groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			groupBox1.Controls.Add(btnEliminar);
			groupBox1.Controls.Add(lblNombre);
			groupBox1.Controls.Add(btnAgregar);
			groupBox1.Controls.Add(txtNombre);
			groupBox1.Controls.Add(lblDui);
			groupBox1.Controls.Add(txtCorreo);
			groupBox1.Controls.Add(lblCorreo);
			groupBox1.Controls.Add(txtDui);
			groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			groupBox1.Location = new Point(12, 12);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(784, 151);
			groupBox1.TabIndex = 9;
			groupBox1.TabStop = false;
			groupBox1.Text = "Nuevo Cliente";
			// 
			// FrmClientes
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(244, 246, 249);
			ClientSize = new Size(808, 668);
			Controls.Add(dgvClientes);
			Controls.Add(groupBox1);
			Name = "FrmClientes";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Registro de Clientes";
			Load += FrmClientes_Load;
			((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Label lblNombre;
        private TextBox txtNombre;
        private Label lblDui;
        private Label lblCorreo;
        private TextBox txtDui;
        private TextBox txtCorreo;
        private DataGridView dgvClientes;
        private Button btnAgregar;
        private Button btnEliminar;
		private GroupBox groupBox1;
	}
}