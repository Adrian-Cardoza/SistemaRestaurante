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
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.ForeColor = Color.Black;
            lblNombre.Location = new Point(29, 26);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(95, 23);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(207, 23);
            txtNombre.TabIndex = 1;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // lblDui
            // 
            lblDui.AutoSize = true;
            lblDui.ForeColor = Color.Black;
            lblDui.Location = new Point(29, 58);
            lblDui.Name = "lblDui";
            lblDui.Size = new Size(29, 15);
            lblDui.TabIndex = 2;
            lblDui.Text = "DUI:";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.ForeColor = Color.Black;
            lblCorreo.Location = new Point(29, 91);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(46, 15);
            lblCorreo.TabIndex = 3;
            lblCorreo.Text = "Correo:";
            // 
            // txtDui
            // 
            txtDui.Location = new Point(95, 55);
            txtDui.Name = "txtDui";
            txtDui.Size = new Size(207, 23);
            txtDui.TabIndex = 4;
            txtDui.TextChanged += txtDui_TextChanged;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(95, 88);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(207, 23);
            txtCorreo.TabIndex = 5;
            txtCorreo.TextChanged += txtCorreo_TextChanged;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.AllowUserToResizeColumns = false;
            dgvClientes.AllowUserToResizeRows = false;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(29, 136);
            dgvClientes.MultiSelect = false;
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(415, 174);
            dgvClientes.TabIndex = 6;
            dgvClientes.CellContentClick += dgvClientes_CellContentClick;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.MediumSeaGreen;
            btnAgregar.Location = new Point(45, 323);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(107, 34);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Crimson;
            btnEliminar.Location = new Point(325, 323);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(107, 34);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(475, 369);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvClientes);
            Controls.Add(txtCorreo);
            Controls.Add(txtDui);
            Controls.Add(lblCorreo);
            Controls.Add(lblDui);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Name = "FrmClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmClientes";
            Load += FrmClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}