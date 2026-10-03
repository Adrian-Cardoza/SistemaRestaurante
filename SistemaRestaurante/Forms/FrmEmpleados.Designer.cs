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
            lblNombre.Location = new Point(54, 131);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(78, 25);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblPuesto
            // 
            lblPuesto.AutoSize = true;
            lblPuesto.Location = new Point(54, 196);
            lblPuesto.Margin = new Padding(4, 0, 4, 0);
            lblPuesto.Name = "lblPuesto";
            lblPuesto.Size = new Size(66, 25);
            lblPuesto.TabIndex = 2;
            lblPuesto.Text = "Puesto";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(133, 72);
            txtId.Margin = new Padding(4, 5, 4, 5);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(62, 31);
            txtId.TabIndex = 3;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(136, 126);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(268, 31);
            txtNombre.TabIndex = 4;
            // 
            // txtPuesto
            // 
            txtPuesto.Location = new Point(136, 191);
            txtPuesto.Margin = new Padding(4, 5, 4, 5);
            txtPuesto.Name = "txtPuesto";
            txtPuesto.Size = new Size(268, 31);
            txtPuesto.TabIndex = 5;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.Lime;
            btnCrear.ForeColor = SystemColors.ActiveCaptionText;
            btnCrear.Location = new Point(54, 270);
            btnCrear.Margin = new Padding(4, 5, 4, 5);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(141, 69);
            btnCrear.TabIndex = 6;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.Silver;
            btnActualizar.ForeColor = SystemColors.ActiveCaptionText;
            btnActualizar.Location = new Point(219, 270);
            btnActualizar.Margin = new Padding(4, 5, 4, 5);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(149, 69);
            btnActualizar.TabIndex = 7;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Firebrick;
            btnEliminar.ForeColor = SystemColors.ActiveCaptionText;
            btnEliminar.Location = new Point(401, 270);
            btnEliminar.Margin = new Padding(4, 5, 4, 5);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(149, 69);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnListar
            // 
            btnListar.BackColor = Color.Azure;
            btnListar.ForeColor = SystemColors.ActiveCaptionText;
            btnListar.Location = new Point(584, 270);
            btnListar.Margin = new Padding(4, 5, 4, 5);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(149, 69);
            btnListar.TabIndex = 9;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = false;
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Location = new Point(54, 379);
            dgvEmpleados.Margin = new Padding(4, 5, 4, 5);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.RowHeadersWidth = 51;
            dgvEmpleados.Size = new Size(679, 351);
            dgvEmpleados.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 75);
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
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(792, 750);
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