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
			lblId = new Label();
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
			((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
			SuspendLayout();
			// 
			// lblId
			// 
			lblId.Location = new Point(0, 0);
			lblId.Name = "lblId";
			lblId.Size = new Size(88, 17);
			lblId.TabIndex = 11;
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
			lblPuesto.Location = new Point(38, 115);
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
			txtId.Size = new Size(28, 23);
			txtId.TabIndex = 3;
			txtId.TextChanged += txtId_TextChanged;
			// 
			// txtNombre
			// 
			txtNombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			txtNombre.Location = new Point(95, 76);
			txtNombre.Name = "txtNombre";
			txtNombre.Size = new Size(134, 23);
			txtNombre.TabIndex = 4;
			// 
			// txtPuesto
			// 
			txtPuesto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			txtPuesto.Location = new Point(95, 109);
			txtPuesto.Name = "txtPuesto";
			txtPuesto.Size = new Size(134, 23);
			txtPuesto.TabIndex = 5;
			// 
			// btnCrear
			// 
			btnCrear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnCrear.BackColor = Color.ForestGreen;
			btnCrear.FlatAppearance.BorderSize = 0;
			btnCrear.FlatStyle = FlatStyle.Flat;
			btnCrear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			btnCrear.ForeColor = Color.FromArgb(34, 34, 34);
			btnCrear.Location = new Point(38, 158);
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
			btnActualizar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnActualizar.BackColor = Color.DarkOrange;
			btnActualizar.FlatAppearance.BorderSize = 0;
			btnActualizar.FlatStyle = FlatStyle.Flat;
			btnActualizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			btnActualizar.ForeColor = Color.FromArgb(34, 34, 34);
			btnActualizar.Location = new Point(112, 158);
			btnActualizar.Margin = new Padding(1, 2, 1, 2);
			btnActualizar.Name = "btnActualizar";
			btnActualizar.Size = new Size(77, 23);
			btnActualizar.TabIndex = 7;
			btnActualizar.Text = "Actualizar";
			btnActualizar.UseVisualStyleBackColor = false;
			btnActualizar.Click += btnActualizar_Click;
			// 
			// btnEliminar
			// 
			btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnEliminar.BackColor = Color.Firebrick;
			btnEliminar.FlatAppearance.BorderSize = 0;
			btnEliminar.FlatStyle = FlatStyle.Flat;
			btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			btnEliminar.ForeColor = Color.FromArgb(34, 34, 34);
			btnEliminar.Location = new Point(192, 158);
			btnEliminar.Margin = new Padding(1, 2, 1, 2);
			btnEliminar.Name = "btnEliminar";
			btnEliminar.Size = new Size(90, 23);
			btnEliminar.TabIndex = 8;
			btnEliminar.Text = "Eliminar";
			btnEliminar.UseVisualStyleBackColor = false;
			btnEliminar.Click += btnEliminar_Click;
			// 
			// btnListar
			// 
			btnListar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnListar.BackColor = SystemColors.Highlight;
			btnListar.FlatAppearance.BorderSize = 0;
			btnListar.FlatStyle = FlatStyle.Flat;
			btnListar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			btnListar.ForeColor = Color.FromArgb(34, 34, 34);
			btnListar.Location = new Point(286, 158);
			btnListar.Margin = new Padding(1, 2, 1, 2);
			btnListar.Name = "btnListar";
			btnListar.Size = new Size(84, 23);
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
			dgvEmpleados.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvEmpleados.Location = new Point(70, 197);
			dgvEmpleados.Margin = new Padding(1, 2, 1, 2);
			dgvEmpleados.MultiSelect = false;
			dgvEmpleados.Name = "dgvEmpleados";
			dgvEmpleados.ReadOnly = true;
			dgvEmpleados.RowHeadersVisible = false;
			dgvEmpleados.RowHeadersWidth = 51;
			dgvEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvEmpleados.Size = new Size(277, 169);
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
			// FrmEmpleados
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(244, 246, 249);
			ClientSize = new Size(440, 375);
			Controls.Add(label1);
			Controls.Add(dgvEmpleados);
			Controls.Add(btnListar);
			Controls.Add(btnEliminar);
			Controls.Add(btnActualizar);
			Controls.Add(btnCrear);
			Controls.Add(txtPuesto);
			Controls.Add(txtNombre);
			Controls.Add(txtId);
			Controls.Add(lblPuesto);
			Controls.Add(lblNombre);
			Controls.Add(lblId);
			Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			Name = "FrmEmpleados";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Registro de Empleados";
			Load += FrmEmpleados_Load;
			MouseClick += FrmEmpleados_MouseClick;
			((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}





		#endregion

		private Label lblId;
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
    }
}