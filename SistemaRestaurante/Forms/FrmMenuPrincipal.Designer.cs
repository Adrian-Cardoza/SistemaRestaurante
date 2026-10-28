namespace SistemaRestaurante.Forms
{
    partial class FrmMenuPrincipal
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
			stsEstado = new StatusStrip();
			lblHoraSuperior = new ToolStripStatusLabel();
			pnlMenuLateral = new Panel();
			btnClientes = new Button();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			btnSalir = new Button();
			btnCerrarSesion = new Button();
			btnAyuda = new Button();
			btnInformacio = new Button();
			btnConfiguracion = new Button();
			btnReportes = new Button();
			btnInventario = new Button();
			btnMesas = new Button();
			btnVentas = new Button();
			btnInicio = new Button();
			pnlContenedor = new Panel();
			panel1 = new Panel();
			IblHora = new Label();
			IblTituloPestaña = new Label();
			btnCerrarHijo = new Button();
			timerHora = new System.Windows.Forms.Timer(components);
			stsEstado.SuspendLayout();
			pnlMenuLateral.SuspendLayout();
			pnlContenedor.SuspendLayout();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// stsEstado
			// 
			stsEstado.ImageScalingSize = new Size(24, 24);
			stsEstado.Items.AddRange(new ToolStripItem[] { lblHoraSuperior });
			stsEstado.Location = new Point(0, 707);
			stsEstado.Name = "stsEstado";
			stsEstado.Padding = new Padding(1, 0, 10, 0);
			stsEstado.Size = new Size(1008, 22);
			stsEstado.TabIndex = 2;
			stsEstado.Text = "statusStrip1";
			// 
			// lblHoraSuperior
			// 
			lblHoraSuperior.ImageAlign = ContentAlignment.MiddleRight;
			lblHoraSuperior.Name = "lblHoraSuperior";
			lblHoraSuperior.Size = new Size(38, 17);
			lblHoraSuperior.Text = "Fecha";
			lblHoraSuperior.TextAlign = ContentAlignment.MiddleRight;
			// 
			// pnlMenuLateral
			// 
			pnlMenuLateral.BackColor = Color.FromArgb(11, 59, 96);
			pnlMenuLateral.Controls.Add(btnClientes);
			pnlMenuLateral.Controls.Add(label3);
			pnlMenuLateral.Controls.Add(label2);
			pnlMenuLateral.Controls.Add(label1);
			pnlMenuLateral.Controls.Add(btnSalir);
			pnlMenuLateral.Controls.Add(btnCerrarSesion);
			pnlMenuLateral.Controls.Add(btnAyuda);
			pnlMenuLateral.Controls.Add(btnInformacio);
			pnlMenuLateral.Controls.Add(btnConfiguracion);
			pnlMenuLateral.Controls.Add(btnReportes);
			pnlMenuLateral.Controls.Add(btnInventario);
			pnlMenuLateral.Controls.Add(btnMesas);
			pnlMenuLateral.Controls.Add(btnVentas);
			pnlMenuLateral.Controls.Add(btnInicio);
			pnlMenuLateral.Cursor = Cursors.Hand;
			pnlMenuLateral.Dock = DockStyle.Left;
			pnlMenuLateral.Location = new Point(0, 0);
			pnlMenuLateral.Margin = new Padding(2);
			pnlMenuLateral.Name = "pnlMenuLateral";
			pnlMenuLateral.Size = new Size(184, 707);
			pnlMenuLateral.TabIndex = 3;
			// 
			// btnClientes
			// 
			btnClientes.Cursor = Cursors.Hand;
			btnClientes.FlatAppearance.BorderSize = 0;
			btnClientes.FlatStyle = FlatStyle.Flat;
			btnClientes.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
			btnClientes.ForeColor = Color.White;
			btnClientes.Image = (Image)resources.GetObject("btnClientes.Image");
			btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
			btnClientes.Location = new Point(0, 297);
			btnClientes.Margin = new Padding(2);
			btnClientes.Name = "btnClientes";
			btnClientes.Size = new Size(184, 36);
			btnClientes.TabIndex = 14;
			btnClientes.Text = "Clientes";
			btnClientes.TextAlign = ContentAlignment.MiddleLeft;
			btnClientes.TextImageRelation = TextImageRelation.ImageBeforeText;
			btnClientes.UseVisualStyleBackColor = true;
			btnClientes.Click += btnClientes_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.BackColor = Color.Transparent;
			label3.ForeColor = Color.White;
			label3.Location = new Point(24, 52);
			label3.Name = "label3";
			label3.Size = new Size(134, 15);
			label3.TabIndex = 13;
			label3.Text = "Sistema de Restaurantes";
			label3.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.Transparent;
			label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
			label2.ForeColor = Color.MediumSeaGreen;
			label2.Location = new Point(100, 15);
			label2.Name = "label2";
			label2.Size = new Size(58, 37);
			label2.TabIndex = 12;
			label2.Text = "Sys";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
			label1.ForeColor = Color.White;
			label1.Location = new Point(22, 15);
			label1.Name = "label1";
			label1.Size = new Size(89, 37);
			label1.TabIndex = 11;
			label1.Text = "Resto";
			// 
			// btnSalir
			// 
			btnSalir.Dock = DockStyle.Bottom;
			btnSalir.FlatAppearance.BorderSize = 0;
			btnSalir.FlatStyle = FlatStyle.Flat;
			btnSalir.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
			btnSalir.ForeColor = SystemColors.ButtonFace;
			btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
			btnSalir.ImageAlign = ContentAlignment.MiddleLeft;
			btnSalir.Location = new Point(0, 641);
			btnSalir.Margin = new Padding(2);
			btnSalir.Name = "btnSalir";
			btnSalir.Size = new Size(184, 33);
			btnSalir.TabIndex = 10;
			btnSalir.Text = "Salir";
			btnSalir.TextAlign = ContentAlignment.MiddleLeft;
			btnSalir.TextImageRelation = TextImageRelation.ImageBeforeText;
			btnSalir.UseVisualStyleBackColor = true;
			btnSalir.Click += btnSalir_Click_1;
			// 
			// btnCerrarSesion
			// 
			btnCerrarSesion.Dock = DockStyle.Bottom;
			btnCerrarSesion.FlatAppearance.BorderSize = 0;
			btnCerrarSesion.FlatStyle = FlatStyle.Flat;
			btnCerrarSesion.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
			btnCerrarSesion.ForeColor = SystemColors.ButtonFace;
			btnCerrarSesion.Image = (Image)resources.GetObject("btnCerrarSesion.Image");
			btnCerrarSesion.ImageAlign = ContentAlignment.MiddleLeft;
			btnCerrarSesion.Location = new Point(0, 674);
			btnCerrarSesion.Margin = new Padding(2);
			btnCerrarSesion.Name = "btnCerrarSesion";
			btnCerrarSesion.Size = new Size(184, 33);
			btnCerrarSesion.TabIndex = 9;
			btnCerrarSesion.Text = "Cerrar Sesion";
			btnCerrarSesion.TextAlign = ContentAlignment.MiddleLeft;
			btnCerrarSesion.TextImageRelation = TextImageRelation.ImageBeforeText;
			btnCerrarSesion.UseVisualStyleBackColor = true;
			btnCerrarSesion.Click += btnCerrarSesion_Click;
			// 
			// btnAyuda
			// 
			btnAyuda.Cursor = Cursors.Hand;
			btnAyuda.FlatAppearance.BorderSize = 0;
			btnAyuda.FlatStyle = FlatStyle.Flat;
			btnAyuda.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
			btnAyuda.ForeColor = SystemColors.ButtonFace;
			btnAyuda.Image = (Image)resources.GetObject("btnAyuda.Image");
			btnAyuda.ImageAlign = ContentAlignment.MiddleLeft;
			btnAyuda.Location = new Point(0, 421);
			btnAyuda.Margin = new Padding(2);
			btnAyuda.Name = "btnAyuda";
			btnAyuda.Size = new Size(184, 38);
			btnAyuda.TabIndex = 8;
			btnAyuda.Text = "Ayuda";
			btnAyuda.TextAlign = ContentAlignment.MiddleLeft;
			btnAyuda.TextImageRelation = TextImageRelation.ImageBeforeText;
			btnAyuda.UseVisualStyleBackColor = true;
			btnAyuda.Click += btnAyuda_Click;
			// 
			// btnInformacio
			// 
			btnInformacio.Cursor = Cursors.Hand;
			btnInformacio.FlatAppearance.BorderSize = 0;
			btnInformacio.FlatStyle = FlatStyle.Flat;
			btnInformacio.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
			btnInformacio.ForeColor = SystemColors.ButtonFace;
			btnInformacio.Image = (Image)resources.GetObject("btnInformacio.Image");
			btnInformacio.ImageAlign = ContentAlignment.MiddleLeft;
			btnInformacio.Location = new Point(0, 377);
			btnInformacio.Margin = new Padding(2);
			btnInformacio.Name = "btnInformacio";
			btnInformacio.Size = new Size(184, 40);
			btnInformacio.TabIndex = 7;
			btnInformacio.Text = "Informacion";
			btnInformacio.TextAlign = ContentAlignment.MiddleLeft;
			btnInformacio.TextImageRelation = TextImageRelation.ImageBeforeText;
			btnInformacio.UseVisualStyleBackColor = true;
			btnInformacio.Click += btnInformacion_Click;
			// 
			// btnConfiguracion
			// 
			btnConfiguracion.Cursor = Cursors.Hand;
			btnConfiguracion.FlatAppearance.BorderSize = 0;
			btnConfiguracion.FlatStyle = FlatStyle.Flat;
			btnConfiguracion.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
			btnConfiguracion.ForeColor = SystemColors.ButtonFace;
			btnConfiguracion.Image = (Image)resources.GetObject("btnConfiguracion.Image");
			btnConfiguracion.ImageAlign = ContentAlignment.MiddleLeft;
			btnConfiguracion.Location = new Point(0, 337);
			btnConfiguracion.Margin = new Padding(2);
			btnConfiguracion.Name = "btnConfiguracion";
			btnConfiguracion.Size = new Size(184, 36);
			btnConfiguracion.TabIndex = 6;
			btnConfiguracion.Text = "Empleados";
			btnConfiguracion.TextAlign = ContentAlignment.MiddleLeft;
			btnConfiguracion.TextImageRelation = TextImageRelation.ImageBeforeText;
			btnConfiguracion.UseVisualStyleBackColor = true;
			btnConfiguracion.Click += btnConfiguracion_Click;
			// 
			// btnReportes
			// 
			btnReportes.Cursor = Cursors.Hand;
			btnReportes.FlatAppearance.BorderSize = 0;
			btnReportes.FlatStyle = FlatStyle.Flat;
			btnReportes.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
			btnReportes.ForeColor = SystemColors.ButtonFace;
			btnReportes.Image = (Image)resources.GetObject("btnReportes.Image");
			btnReportes.ImageAlign = ContentAlignment.MiddleLeft;
			btnReportes.Location = new Point(0, 257);
			btnReportes.Margin = new Padding(2);
			btnReportes.Name = "btnReportes";
			btnReportes.Size = new Size(184, 36);
			btnReportes.TabIndex = 5;
			btnReportes.Text = "Reportes";
			btnReportes.TextAlign = ContentAlignment.MiddleLeft;
			btnReportes.TextImageRelation = TextImageRelation.ImageBeforeText;
			btnReportes.UseVisualStyleBackColor = true;
			btnReportes.Click += btnReportes_Click;
			// 
			// btnInventario
			// 
			btnInventario.Cursor = Cursors.Hand;
			btnInventario.FlatAppearance.BorderSize = 0;
			btnInventario.FlatStyle = FlatStyle.Flat;
			btnInventario.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
			btnInventario.ForeColor = SystemColors.ButtonFace;
			btnInventario.Image = (Image)resources.GetObject("btnInventario.Image");
			btnInventario.ImageAlign = ContentAlignment.MiddleLeft;
			btnInventario.Location = new Point(0, 217);
			btnInventario.Margin = new Padding(2);
			btnInventario.Name = "btnInventario";
			btnInventario.Size = new Size(184, 36);
			btnInventario.TabIndex = 4;
			btnInventario.Text = "Menú";
			btnInventario.TextAlign = ContentAlignment.MiddleLeft;
			btnInventario.TextImageRelation = TextImageRelation.ImageBeforeText;
			btnInventario.UseVisualStyleBackColor = true;
			btnInventario.Click += btnInventario_Click;
			// 
			// btnMesas
			// 
			btnMesas.Cursor = Cursors.Hand;
			btnMesas.FlatAppearance.BorderSize = 0;
			btnMesas.FlatStyle = FlatStyle.Flat;
			btnMesas.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
			btnMesas.ForeColor = SystemColors.ButtonFace;
			btnMesas.Image = (Image)resources.GetObject("btnMesas.Image");
			btnMesas.ImageAlign = ContentAlignment.MiddleLeft;
			btnMesas.Location = new Point(0, 173);
			btnMesas.Margin = new Padding(2);
			btnMesas.Name = "btnMesas";
			btnMesas.Size = new Size(184, 40);
			btnMesas.TabIndex = 3;
			btnMesas.Text = "Mesas";
			btnMesas.TextAlign = ContentAlignment.MiddleLeft;
			btnMesas.TextImageRelation = TextImageRelation.ImageBeforeText;
			btnMesas.UseVisualStyleBackColor = true;
			btnMesas.Click += btnMesas_Click;
			// 
			// btnVentas
			// 
			btnVentas.Cursor = Cursors.Hand;
			btnVentas.FlatAppearance.BorderSize = 0;
			btnVentas.FlatStyle = FlatStyle.Flat;
			btnVentas.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
			btnVentas.ForeColor = SystemColors.ButtonFace;
			btnVentas.Image = (Image)resources.GetObject("btnVentas.Image");
			btnVentas.ImageAlign = ContentAlignment.MiddleLeft;
			btnVentas.Location = new Point(0, 129);
			btnVentas.Margin = new Padding(2);
			btnVentas.Name = "btnVentas";
			btnVentas.Size = new Size(184, 40);
			btnVentas.TabIndex = 2;
			btnVentas.Text = "Pedidos";
			btnVentas.TextAlign = ContentAlignment.MiddleLeft;
			btnVentas.TextImageRelation = TextImageRelation.ImageBeforeText;
			btnVentas.UseVisualStyleBackColor = true;
			btnVentas.Click += btnVentas_Click;
			// 
			// btnInicio
			// 
			btnInicio.Cursor = Cursors.Hand;
			btnInicio.FlatAppearance.BorderSize = 0;
			btnInicio.FlatStyle = FlatStyle.Flat;
			btnInicio.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
			btnInicio.ForeColor = SystemColors.ButtonFace;
			btnInicio.Image = (Image)resources.GetObject("btnInicio.Image");
			btnInicio.ImageAlign = ContentAlignment.MiddleLeft;
			btnInicio.Location = new Point(0, 85);
			btnInicio.Margin = new Padding(2);
			btnInicio.Name = "btnInicio";
			btnInicio.Size = new Size(184, 40);
			btnInicio.TabIndex = 1;
			btnInicio.Text = "Inicio";
			btnInicio.TextAlign = ContentAlignment.MiddleLeft;
			btnInicio.TextImageRelation = TextImageRelation.ImageBeforeText;
			btnInicio.UseVisualStyleBackColor = true;
			btnInicio.Click += btnInicio_Click_1;
			// 
			// pnlContenedor
			// 
			pnlContenedor.Controls.Add(panel1);
			pnlContenedor.Dock = DockStyle.Fill;
			pnlContenedor.Location = new Point(184, 0);
			pnlContenedor.Margin = new Padding(2);
			pnlContenedor.Name = "pnlContenedor";
			pnlContenedor.Size = new Size(824, 707);
			pnlContenedor.TabIndex = 4;
			pnlContenedor.Paint += pnlContenedor_Paint;
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(248, 249, 250);
			panel1.Controls.Add(IblHora);
			panel1.Controls.Add(IblTituloPestaña);
			panel1.Controls.Add(btnCerrarHijo);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Margin = new Padding(2);
			panel1.Name = "panel1";
			panel1.Size = new Size(824, 35);
			panel1.TabIndex = 0;
			// 
			// IblHora
			// 
			IblHora.AutoSize = true;
			IblHora.Dock = DockStyle.Right;
			IblHora.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
			IblHora.ForeColor = Color.FromArgb(85, 85, 85);
			IblHora.Location = new Point(767, 0);
			IblHora.Margin = new Padding(2, 0, 2, 0);
			IblHora.Name = "IblHora";
			IblHora.Size = new Size(0, 19);
			IblHora.TabIndex = 1;
			IblHora.TextAlign = ContentAlignment.MiddleRight;
			// 
			// IblTituloPestaña
			// 
			IblTituloPestaña.AutoSize = true;
			IblTituloPestaña.Dock = DockStyle.Fill;
			IblTituloPestaña.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			IblTituloPestaña.ForeColor = Color.FromArgb(11, 59, 96);
			IblTituloPestaña.Location = new Point(0, 0);
			IblTituloPestaña.Margin = new Padding(2, 0, 2, 0);
			IblTituloPestaña.Name = "IblTituloPestaña";
			IblTituloPestaña.Padding = new Padding(0, 0, 0, 9);
			IblTituloPestaña.Size = new Size(123, 30);
			IblTituloPestaña.TabIndex = 0;
			IblTituloPestaña.Text = "Panel de Inicio";
			IblTituloPestaña.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// btnCerrarHijo
			// 
			btnCerrarHijo.BackColor = Color.FromArgb(217, 83, 79);
			btnCerrarHijo.Dock = DockStyle.Right;
			btnCerrarHijo.FlatAppearance.BorderSize = 0;
			btnCerrarHijo.FlatStyle = FlatStyle.Flat;
			btnCerrarHijo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
			btnCerrarHijo.ForeColor = SystemColors.ButtonFace;
			btnCerrarHijo.Location = new Point(767, 0);
			btnCerrarHijo.Margin = new Padding(2);
			btnCerrarHijo.Name = "btnCerrarHijo";
			btnCerrarHijo.Size = new Size(57, 35);
			btnCerrarHijo.TabIndex = 2;
			btnCerrarHijo.Text = "X";
			btnCerrarHijo.UseVisualStyleBackColor = false;
			btnCerrarHijo.Click += btnCerrarHijo_Click;
			// 
			// timerHora
			// 
			timerHora.Enabled = true;
			// 
			// FrmMenuPrincipal
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.Silver;
			ClientSize = new Size(1008, 729);
			Controls.Add(pnlContenedor);
			Controls.Add(pnlMenuLateral);
			Controls.Add(stsEstado);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Margin = new Padding(2);
			MaximizeBox = false;
			Name = "FrmMenuPrincipal";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Sistema de Restaurante";
			Load += FrmMenuPrincipal_Load;
			stsEstado.ResumeLayout(false);
			stsEstado.PerformLayout();
			pnlMenuLateral.ResumeLayout(false);
			pnlMenuLateral.PerformLayout();
			pnlContenedor.ResumeLayout(false);
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private StatusStrip stsEstado;
        private Panel pnlMenuLateral;
        private Panel pnlContenedor;
        private Button btnInicio;
        private Button btnAyuda;
        private Button btnInformacio;
        private Button btnConfiguracion;
        private Button btnReportes;
        private Button btnInventario;
        private Button btnMesas;
        private Button btnVentas;
        private Button btnCerrarSesion;
        private Panel panel1;
        private Label IblTituloPestaña;
        private Button btnSalir;
        private Button btnCerrarHijo;
        private Label IblHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerHora;
        private System.Windows.Forms.Timer timer2;
		private ToolStripStatusLabel lblHoraSuperior;
		private Label label1;
		private Label label2;
		private Label label3;
		private Button btnClientes;
	}
}