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
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 6);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(111, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(383, 31);
            txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 49);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 2;
            label2.Text = "Precio:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(111, 44);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(170, 31);
            txtPrecio.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 92);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 4;
            label3.Text = "Categoria:";
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(111, 92);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(170, 31);
            txtCategoria.TabIndex = 5;
            // 
            // Disponible
            // 
            Disponible.AutoSize = true;
            Disponible.Checked = true;
            Disponible.CheckState = CheckState.Checked;
            Disponible.Location = new Point(12, 152);
            Disponible.Name = "Disponible";
            Disponible.Size = new Size(123, 29);
            Disponible.TabIndex = 6;
            Disponible.Text = "Disponible";
            Disponible.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.LimeGreen;
            btnGuardar.Location = new Point(6, 413);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(231, 34);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar Producto";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(8, 188);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 62;
            dgvProductos.Size = new Size(782, 220);
            dgvProductos.TabIndex = 8;
            dgvProductos.CellContentClick += dgvProductos_CellContentClick;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Firebrick;
            btnEliminar.Location = new Point(676, 413);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 34);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FormProductos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminar);
            Controls.Add(dgvProductos);
            Controls.Add(btnGuardar);
            Controls.Add(Disponible);
            Controls.Add(txtCategoria);
            Controls.Add(label3);
            Controls.Add(txtPrecio);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "FormProductos";
            Text = "FormProductos";
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
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
    }
}