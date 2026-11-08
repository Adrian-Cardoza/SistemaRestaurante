namespace SistemaRestaurante.Forms
{
    partial class FrmProductos
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
            label1 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            txtPrecio = new TextBox();
            label3 = new Label();
            Disponible = new CheckBox();
            btnGuardar = new Button();
            dgvProductos = new DataGridView();
            btnEliminar = new Button();
            groupBox1 = new GroupBox();
            cmbCategoria = new ComboBox();
            btnNuevo = new Button();
            btnEditar = new Button();
            lblDisponible = new Label();
            lblGestionProductos = new Label();
            lblListado = new Label();
            txtBuscarProducto = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(5, 52);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(5, 75);
            txtNombre.Margin = new Padding(2, 3, 2, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(367, 27);
            txtNombre.TabIndex = 1;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(5, 119);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 2;
            label2.Text = "Precio:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(5, 141);
            txtPrecio.Margin = new Padding(2, 3, 2, 3);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(314, 27);
            txtPrecio.TabIndex = 3;
            txtPrecio.TextChanged += txtPrecio_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(410, 52);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 4;
            label3.Text = "Categoria:";
            // 
            // Disponible
            // 
            Disponible.AutoSize = true;
            Disponible.Checked = true;
            Disponible.CheckState = CheckState.Checked;
            Disponible.Location = new Point(410, 144);
            Disponible.Margin = new Padding(2, 3, 2, 3);
            Disponible.Name = "Disponible";
            Disponible.Size = new Size(105, 24);
            Disponible.TabIndex = 6;
            Disponible.Text = "Disponible";
            Disponible.UseVisualStyleBackColor = true;
            Disponible.CheckedChanged += Disponible_CheckedChanged;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnGuardar.BackColor = Color.LimeGreen;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Location = new Point(231, 195);
            btnGuardar.Margin = new Padding(2, 3, 2, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(185, 43);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar Producto";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.AllowUserToResizeColumns = false;
            dgvProductos.AllowUserToResizeRows = false;
            dgvProductos.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.BackgroundColor = Color.FromArgb(244, 246, 249);
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(13, 393);
            dgvProductos.Margin = new Padding(2, 3, 2, 3);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.RowHeadersWidth = 62;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(898, 483);
            dgvProductos.TabIndex = 8;
            dgvProductos.CellClick += dgvProductos_CellContentClick;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEliminar.BackColor = Color.Firebrick;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Location = new Point(707, 195);
            btnEliminar.Margin = new Padding(2, 3, 2, 3);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(184, 43);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(cmbCategoria);
            groupBox1.Controls.Add(btnNuevo);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(lblDisponible);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(txtPrecio);
            groupBox1.Controls.Add(Disponible);
            groupBox1.Controls.Add(label3);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(14, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(896, 255);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nuevo Producto";
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(410, 81);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(304, 28);
            cmbCategoria.TabIndex = 12;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.FromArgb(224, 224, 224);
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Location = new Point(5, 195);
            btnNuevo.Margin = new Padding(2, 3, 2, 3);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(184, 43);
            btnNuevo.TabIndex = 11;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(255, 128, 0);
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Location = new Point(463, 195);
            btnEditar.Margin = new Padding(2, 3, 2, 3);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(185, 43);
            btnEditar.TabIndex = 10;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // lblDisponible
            // 
            lblDisponible.AutoSize = true;
            lblDisponible.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDisponible.Location = new Point(410, 119);
            lblDisponible.Margin = new Padding(2, 0, 2, 0);
            lblDisponible.Name = "lblDisponible";
            lblDisponible.Size = new Size(113, 20);
            lblDisponible.TabIndex = 7;
            lblDisponible.Text = "Disponibilidad:";
            lblDisponible.Click += label4_Click;
            // 
            // lblGestionProductos
            // 
            lblGestionProductos.AutoSize = true;
            lblGestionProductos.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblGestionProductos.Location = new Point(6, 9);
            lblGestionProductos.Margin = new Padding(2, 0, 2, 0);
            lblGestionProductos.Name = "lblGestionProductos";
            lblGestionProductos.Size = new Size(260, 32);
            lblGestionProductos.TabIndex = 11;
            lblGestionProductos.Text = "Gestion de productos";
            // 
            // lblListado
            // 
            lblListado.AutoSize = true;
            lblListado.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblListado.Location = new Point(13, 321);
            lblListado.Margin = new Padding(2, 0, 2, 0);
            lblListado.Name = "lblListado";
            lblListado.Size = new Size(255, 32);
            lblListado.TabIndex = 12;
            lblListado.Text = "Listado de productos";
            // 
            // txtBuscarProducto
            // 
            txtBuscarProducto.Location = new Point(13, 357);
            txtBuscarProducto.Margin = new Padding(2, 3, 2, 3);
            txtBuscarProducto.Name = "txtBuscarProducto";
            txtBuscarProducto.Size = new Size(367, 27);
            txtBuscarProducto.TabIndex = 13;
            txtBuscarProducto.TextChanged += txtBuscarProducto_TextChanged;
            // 
            // FrmProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(923, 891);
            Controls.Add(txtBuscarProducto);
            Controls.Add(lblListado);
            Controls.Add(lblGestionProductos);
            Controls.Add(groupBox1);
            Controls.Add(dgvProductos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2, 3, 2, 3);
            MaximizeBox = false;
            Name = "FrmProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de Productos";
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtPrecio;
        private Label label3;
        private CheckBox Disponible;
        private Button btnGuardar;
        private DataGridView dgvProductos;
        private Button btnEliminar;
        private GroupBox groupBox1;
        private Label lblDisponible;
        private Button btnNuevo;
        private Button btnEditar;
        private Label lblGestionProductos;
        private Label lblListado;
        private TextBox txtBuscarProducto;
        private ComboBox cmbCategoria;
    }
}