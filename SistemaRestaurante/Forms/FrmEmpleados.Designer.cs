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
            lblId.Margin = new Padding(4, 0, 4, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(125, 29);
            lblId.TabIndex = 11;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.ForeColor = Color.FromArgb(34, 34, 34);
            lblNombre.Location = new Point(54, 135);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(78, 25);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblPuesto
            // 
            lblPuesto.AutoSize = true;
            lblPuesto.ForeColor = Color.FromArgb(34, 34, 34);
            lblPuesto.Location = new Point(54, 191);
            lblPuesto.Margin = new Padding(4, 0, 4, 0);
            lblPuesto.Name = "lblPuesto";
            lblPuesto.Size = new Size(66, 25);
            lblPuesto.TabIndex = 2;
            lblPuesto.Text = "Puesto";
            // 
            // txtId
            // 
            txtId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtId.Enabled = false;
            txtId.Location = new Point(136, 72);
            txtId.Margin = new Padding(4, 5, 4, 5);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(38, 31);
            txtId.TabIndex = 3;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNombre.Location = new Point(136, 126);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(189, 31);
            txtNombre.TabIndex = 4;
            // 
            // txtPuesto
            // 
            txtPuesto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPuesto.Location = new Point(136, 182);
            txtPuesto.Margin = new Padding(4, 5, 4, 5);
            txtPuesto.Name = "txtPuesto";
            txtPuesto.Size = new Size(189, 31);
            txtPuesto.TabIndex = 5;
            // 
            // btnCrear
            // 
            btnCrear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCrear.BackColor = Color.ForestGreen;
            btnCrear.FlatAppearance.BorderSize = 0;
            btnCrear.FlatStyle = FlatStyle.Flat;
            btnCrear.ForeColor = Color.FromArgb(34, 34, 34);
            btnCrear.Location = new Point(54, 264);
            btnCrear.Margin = new Padding(2, 4, 2, 4);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(101, 39);
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
            btnActualizar.ForeColor = Color.FromArgb(34, 34, 34);
            btnActualizar.Location = new Point(160, 264);
            btnActualizar.Margin = new Padding(2, 4, 2, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(110, 39);
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
            btnEliminar.ForeColor = Color.FromArgb(34, 34, 34);
            btnEliminar.Location = new Point(275, 264);
            btnEliminar.Margin = new Padding(2, 4, 2, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(128, 39);
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
            btnListar.ForeColor = Color.FromArgb(34, 34, 34);
            btnListar.Location = new Point(408, 264);
            btnListar.Margin = new Padding(2, 4, 2, 4);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(120, 39);
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
            dgvEmpleados.Location = new Point(100, 329);
            dgvEmpleados.Margin = new Padding(2, 4, 2, 4);
            dgvEmpleados.MultiSelect = false;
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.ReadOnly = true;
            dgvEmpleados.RowHeadersVisible = false;
            dgvEmpleados.RowHeadersWidth = 51;
            dgvEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmpleados.Size = new Size(396, 281);
            dgvEmpleados.TabIndex = 10;
            dgvEmpleados.CellContentClick += dgvEmpleados_CellContentClick;
            dgvEmpleados.SelectionChanged += dgvEmpleados_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(34, 34, 34);
            label1.Location = new Point(54, 81);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(28, 25);
            label1.TabIndex = 12;
            label1.Text = "Id";
            // 
            // FrmEmpleados
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(629, 625);
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
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmEmpleados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmEmpleados";
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