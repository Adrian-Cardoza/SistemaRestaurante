namespace SistemaRestaurante.Forms
{
    partial class FormProductos
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
            txtCategoria = new TextBox();
            Disponible = new CheckBox();
            btnGuardar = new Button();
            dgvProductos = new DataGridView();
            btnEliminar = new Button();
            groupBox1 = new GroupBox();
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
            label1.Location = new Point(5, 52);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(5, 74);
            txtNombre.Margin = new Padding(2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(367, 27);
            txtNombre.TabIndex = 1;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 119);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 2;
            label2.Text = "Precio:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(5, 141);
            txtPrecio.Margin = new Padding(2);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(314, 27);
            txtPrecio.TabIndex = 3;
            txtPrecio.TextChanged += txtPrecio_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(410, 52);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 4;
            label3.Text = "Categoria:";
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(410, 74);
            txtCategoria.Margin = new Padding(2);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(454, 27);
            txtCategoria.TabIndex = 5;
            txtCategoria.TextChanged += txtCategoria_TextChanged;
            // 
            // Disponible
            // 
            Disponible.AutoSize = true;
            Disponible.Checked = true;
            Disponible.CheckState = CheckState.Checked;
            Disponible.Location = new Point(410, 144);
            Disponible.Margin = new Padding(2);
            Disponible.Name = "Disponible";
            Disponible.Size = new Size(103, 24);
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
            btnGuardar.Location = new Point(231, 194);
            btnGuardar.Margin = new Padding(2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(185, 42);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar Producto";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(6, 417);
            dgvProductos.Margin = new Padding(2);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 62;
            dgvProductos.Size = new Size(864, 135);
            dgvProductos.TabIndex = 8;
            dgvProductos.CellClick += dgvProductos_CellContentClick;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEliminar.BackColor = Color.Firebrick;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Location = new Point(680, 194);
            btnEliminar.Margin = new Padding(2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(184, 42);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // groupBox1
            // 
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
            groupBox1.Controls.Add(txtCategoria);
            groupBox1.Controls.Add(label3);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(6, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(869, 255);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.FromArgb(224, 224, 224);
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Location = new Point(5, 194);
            btnNuevo.Margin = new Padding(2);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(184, 42);
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
            btnEditar.Location = new Point(463, 194);
            btnEditar.Margin = new Padding(2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(185, 42);
            btnEditar.TabIndex = 10;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // lblDisponible
            // 
            lblDisponible.AutoSize = true;
            lblDisponible.Location = new Point(410, 119);
            lblDisponible.Margin = new Padding(2, 0, 2, 0);
            lblDisponible.Name = "lblDisponible";
            lblDisponible.Size = new Size(110, 20);
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
            lblListado.Location = new Point(6, 331);
            lblListado.Margin = new Padding(2, 0, 2, 0);
            lblListado.Name = "lblListado";
            lblListado.Size = new Size(255, 32);
            lblListado.TabIndex = 12;
            lblListado.Text = "Listado de productos";
            // 
            // txtBuscarProducto
            // 
            txtBuscarProducto.Location = new Point(6, 375);
            txtBuscarProducto.Margin = new Padding(2);
            txtBuscarProducto.Name = "txtBuscarProducto";
            txtBuscarProducto.Size = new Size(367, 27);
            txtBuscarProducto.TabIndex = 13;
            txtBuscarProducto.TextChanged += txtBuscarProducto_TextChanged;
            // 
            // FormProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(882, 573);
            Controls.Add(txtBuscarProducto);
            Controls.Add(lblListado);
            Controls.Add(lblGestionProductos);
            Controls.Add(groupBox1);
            Controls.Add(dgvProductos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "FormProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormProductos";
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
        private TextBox txtCategoria;
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
    }
}