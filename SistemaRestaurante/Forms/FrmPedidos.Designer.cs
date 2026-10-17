namespace SistemaRestaurante.Forms
{
    partial class FrmPedidos
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
            dgvPedidos = new DataGridView();
            txtBuscar = new TextBox();
            label1 = new Label();
            cmbMesa = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cmbEmpleado = new ComboBox();
            cmbCliente = new ComboBox();
            cmbEstado = new ComboBox();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnCancelar = new Button();
            lblFecha = new Label();
            dtpFecha = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            SuspendLayout();
            // 
            // dgvPedidos
            // 
            dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidos.Location = new Point(26, 94);
            dgvPedidos.Margin = new Padding(2);
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.RowHeadersVisible = false;
            dgvPedidos.RowHeadersWidth = 62;
            dgvPedidos.Size = new Size(626, 201);
            dgvPedidos.TabIndex = 0;
            dgvPedidos.CellContentClick += dgvPedidos_CellContentClick;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(131, 38);
            txtBuscar.Margin = new Padding(2);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(521, 27);
            txtBuscar.TabIndex = 1;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 41);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 2;
            label1.Text = "Buscar Pedido";
            // 
            // cmbMesa
            // 
            cmbMesa.FormattingEnabled = true;
            cmbMesa.Location = new Point(131, 314);
            cmbMesa.Margin = new Padding(2);
            cmbMesa.Name = "cmbMesa";
            cmbMesa.Size = new Size(146, 28);
            cmbMesa.TabIndex = 3;
            cmbMesa.SelectedIndexChanged += cmbMesa_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 314);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 4;
            label2.Text = "Mesa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 346);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 5;
            label3.Text = "Empleado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 379);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 6;
            label4.Text = "Cliente";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 411);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 7;
            label5.Text = "Estado";
            // 
            // cmbEmpleado
            // 
            cmbEmpleado.FormattingEnabled = true;
            cmbEmpleado.Location = new Point(131, 346);
            cmbEmpleado.Margin = new Padding(2);
            cmbEmpleado.Name = "cmbEmpleado";
            cmbEmpleado.Size = new Size(146, 28);
            cmbEmpleado.TabIndex = 8;
            cmbEmpleado.SelectedIndexChanged += cmbEmpleado_SelectedIndexChanged;
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(131, 379);
            cmbCliente.Margin = new Padding(2);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(146, 28);
            cmbCliente.TabIndex = 9;
            cmbCliente.SelectedIndexChanged += cmbCliente_SelectedIndexChanged;
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(131, 411);
            cmbEstado.Margin = new Padding(2);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(146, 28);
            cmbEstado.TabIndex = 10;
            cmbEstado.SelectedIndexChanged += cmbEstado_SelectedIndexChanged;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.LightGray;
            btnNuevo.Location = new Point(26, 496);
            btnNuevo.Margin = new Padding(2);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(90, 27);
            btnNuevo.TabIndex = 11;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.SpringGreen;
            btnGuardar.Location = new Point(141, 496);
            btnGuardar.Margin = new Padding(2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(90, 27);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.AliceBlue;
            btnEditar.Location = new Point(266, 496);
            btnEditar.Margin = new Padding(2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(90, 27);
            btnEditar.TabIndex = 13;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Firebrick;
            btnCancelar.Location = new Point(386, 496);
            btnCancelar.Margin = new Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 27);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(26, 449);
            lblFecha.Margin = new Padding(2, 0, 2, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(47, 20);
            lblFecha.TabIndex = 15;
            lblFecha.Text = "Fecha";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(131, 449);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(291, 27);
            dtpFecha.TabIndex = 16;
            // 
            // FrmPedidos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(679, 533);
            Controls.Add(dtpFecha);
            Controls.Add(lblFecha);
            Controls.Add(btnCancelar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(cmbEstado);
            Controls.Add(cmbCliente);
            Controls.Add(cmbEmpleado);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbMesa);
            Controls.Add(label1);
            Controls.Add(txtBuscar);
            Controls.Add(dgvPedidos);
            Margin = new Padding(2);
            Name = "FrmPedidos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPedidos";
            Load += FrmPedidos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPedidos;
        private TextBox txtBuscar;
        private Label label1;
        private ComboBox cmbMesa;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cmbEmpleado;
        private ComboBox cmbCliente;
        private ComboBox cmbEstado;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnCancelar;
        private Label lblFecha;
        private DateTimePicker dtpFecha;
    }
}