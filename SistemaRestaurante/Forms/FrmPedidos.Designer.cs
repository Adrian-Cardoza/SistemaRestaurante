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
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            SuspendLayout();
            // 
            // dgvPedidos
            // 
            dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidos.Location = new Point(32, 117);
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.RowHeadersWidth = 62;
            dgvPedidos.Size = new Size(782, 251);
            dgvPedidos.TabIndex = 0;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(186, 48);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(521, 31);
            txtBuscar.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 54);
            label1.Name = "label1";
            label1.Size = new Size(123, 25);
            label1.TabIndex = 2;
            label1.Text = "Buscar Pedido";
            // 
            // cmbMesa
            // 
            cmbMesa.FormattingEnabled = true;
            cmbMesa.Location = new Point(164, 393);
            cmbMesa.Name = "cmbMesa";
            cmbMesa.Size = new Size(182, 33);
            cmbMesa.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 393);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 4;
            label2.Text = "Mesa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 432);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 5;
            label3.Text = "Empleado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 474);
            label4.Name = "label4";
            label4.Size = new Size(65, 25);
            label4.TabIndex = 6;
            label4.Text = "Cliente";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 514);
            label5.Name = "label5";
            label5.Size = new Size(66, 25);
            label5.TabIndex = 7;
            label5.Text = "Estado";
            // 
            // cmbEmpleado
            // 
            cmbEmpleado.FormattingEnabled = true;
            cmbEmpleado.Location = new Point(164, 432);
            cmbEmpleado.Name = "cmbEmpleado";
            cmbEmpleado.Size = new Size(182, 33);
            cmbEmpleado.TabIndex = 8;
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(164, 474);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(182, 33);
            cmbCliente.TabIndex = 9;
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(164, 514);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(182, 33);
            cmbEstado.TabIndex = 10;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(32, 620);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(112, 34);
            btnNuevo.TabIndex = 11;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(176, 620);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 34);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(333, 620);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(112, 34);
            btnEditar.TabIndex = 13;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(482, 620);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 34);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(32, 561);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(57, 25);
            lblFecha.TabIndex = 15;
            lblFecha.Text = "Fecha";
            // 
            // FrmPedidos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 666);
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
            Name = "FrmPedidos";
            Text = "FrmPedidos";
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
    }
}