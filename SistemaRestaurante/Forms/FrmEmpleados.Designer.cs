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
            lblId.Size = new Size(100, 23);
            lblId.TabIndex = 11;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(43, 105);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblPuesto
            // 
            lblPuesto.AutoSize = true;
            lblPuesto.Location = new Point(43, 157);
            lblPuesto.Name = "lblPuesto";
            lblPuesto.Size = new Size(53, 20);
            lblPuesto.TabIndex = 2;
            lblPuesto.Text = "Puesto";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(71, 57);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(50, 27);
            txtId.TabIndex = 3;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(109, 101);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(215, 27);
            txtNombre.TabIndex = 4;
            // 
            // txtPuesto
            // 
            txtPuesto.Location = new Point(109, 153);
            txtPuesto.Margin = new Padding(3, 4, 3, 4);
            txtPuesto.Name = "txtPuesto";
            txtPuesto.Size = new Size(215, 27);
            txtPuesto.TabIndex = 5;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.ForestGreen;
            btnCrear.ForeColor = SystemColors.ButtonHighlight;
            btnCrear.Location = new Point(43, 216);
            btnCrear.Margin = new Padding(3, 4, 3, 4);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(113, 55);
            btnCrear.TabIndex = 6;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.DarkOrange;
            btnActualizar.ForeColor = SystemColors.ButtonHighlight;
            btnActualizar.Location = new Point(175, 216);
            btnActualizar.Margin = new Padding(3, 4, 3, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(119, 55);
            btnActualizar.TabIndex = 7;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Firebrick;
            btnEliminar.ForeColor = SystemColors.ButtonHighlight;
            btnEliminar.Location = new Point(321, 216);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(119, 55);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnListar
            // 
            btnListar.BackColor = SystemColors.Highlight;
            btnListar.ForeColor = SystemColors.ButtonHighlight;
            btnListar.Location = new Point(467, 216);
            btnListar.Margin = new Padding(3, 4, 3, 4);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(119, 55);
            btnListar.TabIndex = 9;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = false;
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Location = new Point(43, 303);
            dgvEmpleados.Margin = new Padding(3, 4, 3, 4);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.RowHeadersWidth = 51;
            dgvEmpleados.Size = new Size(543, 281);
            dgvEmpleados.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 60);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 12;
            label1.Text = "Id";
            // 
            // FrmEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 600);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmEmpleados";
            Text = "FrmEmpleados";
            Load += FrmEmpleados_Load;
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