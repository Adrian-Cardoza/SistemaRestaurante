namespace SistemaRestaurante.Forms
{
    partial class FrmEmpleados
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
			lblPuesto = new Label();
			txtId = new TextBox();
			txtNombre = new TextBox();
			txtPuesto = new TextBox();
			btnCrear = new Button();
			btnActualizar = new Button();
			btnEliminar = new Button();
			btnListar = new Button();
			dgvEmpleados = new DataGridView();
			label1 = new Label();
			groupBox1 = new GroupBox();
			txtUsuario = new TextBox();
			lblContraseña = new Label();
			lblUsuario = new Label();
			txtContraseña = new TextBox();
			((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// lblNombre
			// 
			lblNombre.AutoSize = true;
			lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lblNombre.ForeColor = Color.FromArgb(34, 34, 34);
			lblNombre.Location = new Point(38, 81);
			lblNombre.Name = "lblNombre";
			lblNombre.Size = new Size(53, 15);
			lblNombre.TabIndex = 1;
			lblNombre.Text = "Nombre";
			// 
			// lblPuesto
			// 
			lblPuesto.AutoSize = true;
			lblPuesto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lblPuesto.ForeColor = Color.FromArgb(34, 34, 34);
			lblPuesto.Location = new Point(202, 69);
			lblPuesto.Name = "lblPuesto";
			lblPuesto.Size = new Size(45, 15);
			lblPuesto.TabIndex = 2;
			lblPuesto.Text = "Puesto";
			// 
			// txtId
			// 
			txtId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			txtId.Enabled = false;
			txtId.Location = new Point(95, 43);
			txtId.Name = "txtId";
			txtId.ReadOnly = true;
			txtId.Size = new Size(396, 23);
			txtId.TabIndex = 3;
			// 
			// txtNombre
			// 
			txtNombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			txtNombre.Location = new Point(95, 76);
			txtNombre.Name = "txtNombre";
			txtNombre.Size = new Size(97, 23);
			txtNombre.TabIndex = 4;
			// 
			// txtPuesto
			// 
			txtPuesto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			txtPuesto.Location = new Point(253, 66);
			txtPuesto.Name = "txtPuesto";
			txtPuesto.Size = new Size(97, 23);
			txtPuesto.TabIndex = 5;
			// 
			// btnCrear
			// 
			btnCrear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnCrear.BackColor = Color.ForestGreen;
			btnCrear.FlatAppearance.BorderSize = 0;
			btnCrear.FlatStyle = FlatStyle.Flat;
			btnCrear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			btnCrear.ForeColor = Color.FromArgb(34, 34, 34);
			btnCrear.Location = new Point(661, 30);
			btnCrear.Margin = new Padding(1, 2, 1, 2);
			btnCrear.Name = "btnCrear";
			btnCrear.Size = new Size(71, 23);
			btnCrear.TabIndex = 6;
			btnCrear.Text = "Crear";
			btnCrear.UseVisualStyleBackColor = false;
			btnCrear.Click += btnCrear_Click;
			// 
			// btnActualizar
			// 
			btnActualizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnActualizar.BackColor = Color.DarkOrange;
			btnActualizar.FlatAppearance.BorderSize = 0;
			btnActualizar.FlatStyle = FlatStyle.Flat;
			btnActualizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			btnActualizar.ForeColor = Color.FromArgb(34, 34, 34);
			btnActualizar.Location = new Point(661, 57);
			btnActualizar.Margin = new Padding(1, 2, 1, 2);
			btnActualizar.Name = "btnActualizar";
			btnActualizar.Size = new Size(71, 23);
			btnActualizar.TabIndex = 7;
			btnActualizar.Text = "Actualizar";
			btnActualizar.UseVisualStyleBackColor = false;
			btnActualizar.Click += btnActualizar_Click;
			// 
			// btnEliminar
			// 
			btnEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnEliminar.BackColor = Color.Firebrick;
			btnEliminar.FlatAppearance.BorderSize = 0;
			btnEliminar.FlatStyle = FlatStyle.Flat;
			btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			btnEliminar.ForeColor = Color.FromArgb(34, 34, 34);
			btnEliminar.Location = new Point(661, 84);
			btnEliminar.Margin = new Padding(1, 2, 1, 2);
			btnEliminar.Name = "btnEliminar";
			btnEliminar.Size = new Size(71, 23);
			btnEliminar.TabIndex = 8;
			btnEliminar.Text = "Eliminar";
			btnEliminar.UseVisualStyleBackColor = false;
			btnEliminar.Click += btnEliminar_Click;
			// 
			// btnListar
			// 
			btnListar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnListar.BackColor = SystemColors.Highlight;
			btnListar.FlatAppearance.BorderSize = 0;
			btnListar.FlatStyle = FlatStyle.Flat;
			btnListar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			btnListar.ForeColor = Color.FromArgb(34, 34, 34);
			btnListar.Location = new Point(661, 111);
			btnListar.Margin = new Padding(1, 2, 1, 2);
			btnListar.Name = "btnListar";
			btnListar.Size = new Size(71, 23);
			btnListar.TabIndex = 9;
			btnListar.Text = "Listar";
			btnListar.UseVisualStyleBackColor = false;
			btnListar.Click += btnListar_Click;
			// 
			// dgvEmpleados
			// 
			dgvEmpleados.AllowUserToAddRows = false;
			dgvEmpleados.AllowUserToDeleteRows = false;
			dgvEmpleados.AllowUserToResizeColumns = false;
			dgvEmpleados.AllowUserToResizeRows = false;
			dgvEmpleados.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvEmpleados.BackgroundColor = Color.FromArgb(244, 246, 249);
			dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvEmpleados.Location = new Point(12, 172);
			dgvEmpleados.Margin = new Padding(1, 2, 1, 2);
			dgvEmpleados.MultiSelect = false;
			dgvEmpleados.Name = "dgvEmpleados";
			dgvEmpleados.ReadOnly = true;
			dgvEmpleados.RowHeadersVisible = false;
			dgvEmpleados.RowHeadersWidth = 51;
			dgvEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvEmpleados.Size = new Size(786, 485);
			dgvEmpleados.TabIndex = 10;
			dgvEmpleados.CellContentClick += dgvEmpleados_CellContentClick;
			dgvEmpleados.SelectionChanged += dgvEmpleados_SelectionChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label1.ForeColor = Color.FromArgb(34, 34, 34);
			label1.Location = new Point(38, 49);
			label1.Name = "label1";
			label1.Size = new Size(18, 15);
			label1.TabIndex = 12;
			label1.Text = "Id";
			// 
			// groupBox1
			// 
			groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			groupBox1.Controls.Add(txtUsuario);
			groupBox1.Controls.Add(txtPuesto);
			groupBox1.Controls.Add(lblContraseña);
			groupBox1.Controls.Add(lblPuesto);
			groupBox1.Controls.Add(lblUsuario);
			groupBox1.Controls.Add(txtContraseña);
			groupBox1.Controls.Add(btnCrear);
			groupBox1.Controls.Add(btnActualizar);
			groupBox1.Controls.Add(btnListar);
			groupBox1.Controls.Add(btnEliminar);
			groupBox1.Location = new Point(12, 12);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(784, 155);
			groupBox1.TabIndex = 13;
			groupBox1.TabStop = false;
			groupBox1.Text = "Nuevo Empleado";
			// 
			// txtUsuario
			// 
			txtUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			txtUsuario.Location = new Point(81, 109);
			txtUsuario.Name = "txtUsuario";
			txtUsuario.Size = new Size(97, 23);
			txtUsuario.TabIndex = 16;
			// 
			// lblContraseña
			// 
			lblContraseña.AutoSize = true;
			lblContraseña.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lblContraseña.ForeColor = Color.FromArgb(34, 34, 34);
			lblContraseña.Location = new Point(200, 112);
			lblContraseña.Name = "lblContraseña";
			lblContraseña.Size = new Size(69, 15);
			lblContraseña.TabIndex = 15;
			lblContraseña.Text = "Contraseña";
			// 
			// lblUsuario
			// 
			lblUsuario.AutoSize = true;
			lblUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lblUsuario.ForeColor = Color.FromArgb(34, 34, 34);
			lblUsuario.Location = new Point(26, 112);
			lblUsuario.Name = "lblUsuario";
			lblUsuario.Size = new Size(49, 15);
			lblUsuario.TabIndex = 14;
			lblUsuario.Text = "Usuario";
			// 
			// txtContraseña
			// 
			txtContraseña.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			txtContraseña.Location = new Point(275, 109);
			txtContraseña.Name = "txtContraseña";
			txtContraseña.Size = new Size(97, 23);
			txtContraseña.TabIndex = 17;
			// 
			// FrmEmpleados
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(244, 246, 249);
			ClientSize = new Size(808, 668);
			Controls.Add(txtNombre);
			Controls.Add(lblNombre);
			Controls.Add(label1);
			Controls.Add(dgvEmpleados);
			Controls.Add(txtId);
			Controls.Add(groupBox1);
			Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			Name = "FrmEmpleados";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Registro de Empleados";
			Load += FrmEmpleados_Load;
			MouseClick += FrmEmpleados_MouseClick;
			((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Label lblNombre;
        private Label lblPuesto;
        private TextBox txtId;
        private TextBox txtNombre;
        private TextBox txtPuesto;
        private Button btnCrear;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnListar;
        private DataGridView dgvEmpleados;
        private Label label1;
		private GroupBox groupBox1;
		private TextBox txtUsuario;
		private Label lblContraseña;
		private Label lblUsuario;
		private TextBox txtContraseña;
	}
}