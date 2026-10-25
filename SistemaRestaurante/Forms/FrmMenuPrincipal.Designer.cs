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
            statusStrip1 = new StatusStrip();
            pnlMenuLateral = new Panel();
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
            RestorSys = new PictureBox();
            pnlContenedor = new Panel();
            panel1 = new Panel();
            lblHoraSuperior = new Label();
            IblHora = new Label();
            IblTituloPestaña = new Label();
            btnCerrarHijo = new Button();
            timerHora = new System.Windows.Forms.Timer(components);
            pnlMenuLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RestorSys).BeginInit();
            pnlContenedor.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Location = new Point(0, 622);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1178, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // pnlMenuLateral
            // 
            pnlMenuLateral.BackColor = Color.FromArgb(11, 59, 96);
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
            pnlMenuLateral.Controls.Add(RestorSys);
            pnlMenuLateral.Dock = DockStyle.Left;
            pnlMenuLateral.Location = new Point(0, 0);
            pnlMenuLateral.Name = "pnlMenuLateral";
            pnlMenuLateral.Size = new Size(300, 622);
            pnlMenuLateral.TabIndex = 3;
            // 
            // btnSalir
            // 
            btnSalir.Dock = DockStyle.Bottom;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.ForeColor = SystemColors.ButtonFace;
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalir.Location = new Point(0, 544);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(300, 34);
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
            btnCerrarSesion.ForeColor = SystemColors.ButtonFace;
            btnCerrarSesion.Image = (Image)resources.GetObject("btnCerrarSesion.Image");
            btnCerrarSesion.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.Location = new Point(0, 578);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(300, 44);
            btnCerrarSesion.TabIndex = 9;
            btnCerrarSesion.Text = "Cerrar Sesion";
            btnCerrarSesion.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnAyuda
            // 
            btnAyuda.Dock = DockStyle.Top;
            btnAyuda.FlatAppearance.BorderSize = 0;
            btnAyuda.FlatStyle = FlatStyle.Flat;
            btnAyuda.ForeColor = SystemColors.ButtonFace;
            btnAyuda.Image = (Image)resources.GetObject("btnAyuda.Image");
            btnAyuda.ImageAlign = ContentAlignment.MiddleLeft;
            btnAyuda.Location = new Point(0, 313);
            btnAyuda.Name = "btnAyuda";
            btnAyuda.Size = new Size(300, 34);
            btnAyuda.TabIndex = 8;
            btnAyuda.Text = "Ayuda";
            btnAyuda.TextAlign = ContentAlignment.MiddleLeft;
            btnAyuda.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAyuda.UseVisualStyleBackColor = true;
            btnAyuda.Click += btnAyuda_Click;
            // 
            // btnInformacio
            // 
            btnInformacio.Dock = DockStyle.Top;
            btnInformacio.FlatAppearance.BorderSize = 0;
            btnInformacio.FlatStyle = FlatStyle.Flat;
            btnInformacio.ForeColor = SystemColors.ButtonFace;
            btnInformacio.Image = (Image)resources.GetObject("btnInformacio.Image");
            btnInformacio.ImageAlign = ContentAlignment.MiddleLeft;
            btnInformacio.Location = new Point(0, 279);
            btnInformacio.Name = "btnInformacio";
            btnInformacio.Size = new Size(300, 34);
            btnInformacio.TabIndex = 7;
            btnInformacio.Text = "Informacion";
            btnInformacio.TextAlign = ContentAlignment.MiddleLeft;
            btnInformacio.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInformacio.UseVisualStyleBackColor = true;
            btnInformacio.Click += btnInformacion_Click;
            // 
            // btnConfiguracion
            // 
            btnConfiguracion.Dock = DockStyle.Top;
            btnConfiguracion.FlatAppearance.BorderSize = 0;
            btnConfiguracion.FlatStyle = FlatStyle.Flat;
            btnConfiguracion.ForeColor = SystemColors.ButtonFace;
            btnConfiguracion.Image = (Image)resources.GetObject("btnConfiguracion.Image");
            btnConfiguracion.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfiguracion.Location = new Point(0, 245);
            btnConfiguracion.Name = "btnConfiguracion";
            btnConfiguracion.Size = new Size(300, 34);
            btnConfiguracion.TabIndex = 6;
            btnConfiguracion.Text = "Configuracion";
            btnConfiguracion.TextAlign = ContentAlignment.MiddleLeft;
            btnConfiguracion.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConfiguracion.UseVisualStyleBackColor = true;
            btnConfiguracion.Click += btnConfiguracion_Click;
            // 
            // btnReportes
            // 
            btnReportes.Dock = DockStyle.Top;
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.ForeColor = SystemColors.ButtonFace;
            btnReportes.Image = (Image)resources.GetObject("btnReportes.Image");
            btnReportes.ImageAlign = ContentAlignment.MiddleLeft;
            btnReportes.Location = new Point(0, 211);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(300, 34);
            btnReportes.TabIndex = 5;
            btnReportes.Text = "Reportes";
            btnReportes.TextAlign = ContentAlignment.MiddleLeft;
            btnReportes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnInventario
            // 
            btnInventario.Dock = DockStyle.Top;
            btnInventario.FlatAppearance.BorderSize = 0;
            btnInventario.FlatStyle = FlatStyle.Flat;
            btnInventario.ForeColor = SystemColors.ButtonFace;
            btnInventario.Image = (Image)resources.GetObject("btnInventario.Image");
            btnInventario.ImageAlign = ContentAlignment.MiddleLeft;
            btnInventario.Location = new Point(0, 177);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(300, 34);
            btnInventario.TabIndex = 4;
            btnInventario.Text = "Inventario";
            btnInventario.TextAlign = ContentAlignment.MiddleLeft;
            btnInventario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInventario.UseVisualStyleBackColor = true;
            btnInventario.Click += btnInventario_Click;
            // 
            // btnMesas
            // 
            btnMesas.Dock = DockStyle.Top;
            btnMesas.FlatAppearance.BorderSize = 0;
            btnMesas.FlatStyle = FlatStyle.Flat;
            btnMesas.ForeColor = SystemColors.ButtonFace;
            btnMesas.Image = (Image)resources.GetObject("btnMesas.Image");
            btnMesas.ImageAlign = ContentAlignment.MiddleLeft;
            btnMesas.Location = new Point(0, 143);
            btnMesas.Name = "btnMesas";
            btnMesas.Size = new Size(300, 34);
            btnMesas.TabIndex = 3;
            btnMesas.Text = "Mesas";
            btnMesas.TextAlign = ContentAlignment.MiddleLeft;
            btnMesas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMesas.UseVisualStyleBackColor = true;
            btnMesas.Click += btnMesas_Click;
            // 
            // btnVentas
            // 
            btnVentas.Dock = DockStyle.Top;
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.ForeColor = SystemColors.ButtonFace;
            btnVentas.Image = (Image)resources.GetObject("btnVentas.Image");
            btnVentas.ImageAlign = ContentAlignment.MiddleLeft;
            btnVentas.Location = new Point(0, 109);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(300, 34);
            btnVentas.TabIndex = 2;
            btnVentas.Text = "Ventas";
            btnVentas.TextAlign = ContentAlignment.MiddleLeft;
            btnVentas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnInicio
            // 
            btnInicio.Dock = DockStyle.Top;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.ForeColor = SystemColors.ButtonFace;
            btnInicio.Image = (Image)resources.GetObject("btnInicio.Image");
            btnInicio.ImageAlign = ContentAlignment.MiddleLeft;
            btnInicio.Location = new Point(0, 75);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(300, 34);
            btnInicio.TabIndex = 1;
            btnInicio.Text = "Inicio";
            btnInicio.TextAlign = ContentAlignment.MiddleLeft;
            btnInicio.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInicio.UseVisualStyleBackColor = true;
            // 
            // RestorSys
            // 
            RestorSys.Dock = DockStyle.Top;
            RestorSys.Location = new Point(0, 0);
            RestorSys.Name = "RestorSys";
            RestorSys.Size = new Size(300, 75);
            RestorSys.TabIndex = 0;
            RestorSys.TabStop = false;
            // 
            // pnlContenedor
            // 
            pnlContenedor.Controls.Add(panel1);
            pnlContenedor.Dock = DockStyle.Fill;
            pnlContenedor.Location = new Point(300, 0);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(878, 622);
            pnlContenedor.TabIndex = 4;
            pnlContenedor.Paint += pnlContenedor_Paint;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(248, 249, 250);
            panel1.Controls.Add(lblHoraSuperior);
            panel1.Controls.Add(IblHora);
            panel1.Controls.Add(IblTituloPestaña);
            panel1.Controls.Add(btnCerrarHijo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(878, 59);
            panel1.TabIndex = 0;
            // 
            // lblHoraSuperior
            // 
            lblHoraSuperior.AutoSize = true;
            lblHoraSuperior.Dock = DockStyle.Right;
            lblHoraSuperior.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHoraSuperior.ForeColor = Color.FromArgb(51, 51, 51);
            lblHoraSuperior.Location = new Point(732, 0);
            lblHoraSuperior.Name = "lblHoraSuperior";
            lblHoraSuperior.Size = new Size(65, 25);
            lblHoraSuperior.TabIndex = 3;
            lblHoraSuperior.Text = "label1";
            // 
            // IblHora
            // 
            IblHora.AutoSize = true;
            IblHora.Dock = DockStyle.Right;
            IblHora.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IblHora.ForeColor = Color.FromArgb(85, 85, 85);
            IblHora.Location = new Point(797, 0);
            IblHora.Name = "IblHora";
            IblHora.Size = new Size(0, 28);
            IblHora.TabIndex = 1;
            IblHora.TextAlign = ContentAlignment.MiddleRight;
            // 
            // IblTituloPestaña
            // 
            IblTituloPestaña.AutoSize = true;
            IblTituloPestaña.Dock = DockStyle.Left;
            IblTituloPestaña.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IblTituloPestaña.ForeColor = Color.FromArgb(11, 59, 96);
            IblTituloPestaña.Location = new Point(0, 0);
            IblTituloPestaña.Name = "IblTituloPestaña";
            IblTituloPestaña.Padding = new Padding(0, 0, 0, 15);
            IblTituloPestaña.Size = new Size(182, 47);
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
            btnCerrarHijo.Font = new Font("Expo M", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnCerrarHijo.ForeColor = SystemColors.ButtonFace;
            btnCerrarHijo.Location = new Point(797, 0);
            btnCerrarHijo.Name = "btnCerrarHijo";
            btnCerrarHijo.Size = new Size(81, 59);
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
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1178, 644);
            Controls.Add(pnlContenedor);
            Controls.Add(pnlMenuLateral);
            Controls.Add(statusStrip1);
            Name = "FrmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Restaurante";
            WindowState = FormWindowState.Maximized;
            Load += FrmMenuPrincipal_Load;
            pnlMenuLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)RestorSys).EndInit();
            pnlContenedor.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private StatusStrip statusStrip1;
        private Panel pnlMenuLateral;
        private PictureBox RestorSys;
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
        private Label lblHoraSuperior;
    }
}