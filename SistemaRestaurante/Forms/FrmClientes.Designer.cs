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
            lblNombre.ForeColor = Color.FromArgb(34, 34, 34);
            lblNombre.Location = new Point(41, 43);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(82, 25);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNombre.Location = new Point(136, 38);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(294, 31);
            txtNombre.TabIndex = 1;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // lblDui
            // 
            lblDui.AutoSize = true;
            lblDui.ForeColor = Color.FromArgb(34, 34, 34);
            lblDui.Location = new Point(41, 97);
            lblDui.Margin = new Padding(4, 0, 4, 0);
            lblDui.Name = "lblDui";
            lblDui.Size = new Size(46, 25);
            lblDui.TabIndex = 2;
            lblDui.Text = "DUI:";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.ForeColor = Color.FromArgb(34, 34, 34);
            lblCorreo.Location = new Point(41, 152);
            lblCorreo.Margin = new Padding(4, 0, 4, 0);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(70, 25);
            lblCorreo.TabIndex = 3;
            lblCorreo.Text = "Correo:";
            // 
            // txtDui
            // 
            txtDui.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDui.Location = new Point(136, 92);
            txtDui.Margin = new Padding(4, 5, 4, 5);
            txtDui.Name = "txtDui";
            txtDui.Size = new Size(294, 31);
            txtDui.TabIndex = 4;
            txtDui.TextChanged += txtDui_TextChanged;
            // 
            // txtCorreo
            // 
            txtCorreo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCorreo.Location = new Point(136, 147);
            txtCorreo.Margin = new Padding(4, 5, 4, 5);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(294, 31);
            txtCorreo.TabIndex = 5;
            txtCorreo.TextChanged += txtCorreo_TextChanged;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.AllowUserToResizeColumns = false;
            dgvClientes.AllowUserToResizeRows = false;
            dgvClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(41, 227);
            dgvClientes.Margin = new Padding(4, 5, 4, 5);
            dgvClientes.MultiSelect = false;
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.RowHeadersWidth = 62;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(593, 290);
            dgvClientes.TabIndex = 6;
            dgvClientes.CellContentClick += dgvClientes_CellContentClick;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAgregar.BackColor = Color.MediumSeaGreen;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.ForeColor = Color.FromArgb(34, 34, 34);
            btnAgregar.Location = new Point(64, 538);
            btnAgregar.Margin = new Padding(4, 5, 4, 5);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(153, 57);
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
            btnEliminar.ForeColor = Color.FromArgb(34, 34, 34);
            btnEliminar.Location = new Point(464, 538);
            btnEliminar.Margin = new Padding(4, 5, 4, 5);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(153, 57);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(679, 615);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvClientes);
            Controls.Add(txtCorreo);
            Controls.Add(txtDui);
            Controls.Add(lblCorreo);
            Controls.Add(lblDui);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Margin = new Padding(4, 5, 4, 5);
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