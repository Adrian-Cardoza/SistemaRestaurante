using System.Globalization;

namespace SistemaRestaurante.Forms
{
	public partial class FrmMenuPrincipal : Form
	{
		private Form formularioActivo = null;
		private System.Windows.Forms.Timer reloj = null;

		public FrmMenuPrincipal()
		{
			InitializeComponent();
		}

		private void FrmMenuPrincipal_Load(object sender, EventArgs e)
		{
			// 1. Mostrar pantalla de inicio por defecto
			MostrarInicio();

			// 2. Iniciar el reloj de la barra superior
			var region = new CultureInfo("es-SV");
			lblHoraSuperior.Text = DateTime.Now.ToString("dddd, " +
				"dd 'de' MMMM 'de' yyyy", region);
		}

		private void ActualizarTituloPestaña(string titulo)
		{
			Control[] controles = this.Controls.Find("IblTituloPestaña", true);
			if (controles.Length > 0 && controles[0] is Label lbl)
			{
				lbl.Text = titulo;
			}
		}

		private void EstablecerBotonCerrar(bool visible)
		{
			Control[] controles = this.Controls.Find("btnCerrarHijo", true);
			if (controles.Length > 0 && controles[0] is Button btn)
			{
				btn.Visible = visible;
				btn.BringToFront(); // Garantiza que no quede tapado
			}
		}

		private void AbrirFormularioHijo(Form formularioHijo, string titulo)
		{
			if (formularioActivo != null)
			{
				formularioActivo.Close();
			}

			formularioActivo = formularioHijo;

			// 1. Configuraciones básicas sin el Dock todavía
			formularioHijo.TopLevel = false;
			formularioHijo.FormBorderStyle = FormBorderStyle.None;

			// Buscamos el panel contenedor de forma segura
			Panel contenedor = null;
			Control[] paneles = this.Controls.Find("pnlContenedor", true);
			if (paneles.Length > 0 && paneles[0] is Panel pnl)
			{
				contenedor = pnl;
			}

			if (contenedor != null)
			{
				// Evitamos parpadeos visuales durante la carga
				contenedor.SuspendLayout();

				// 2. PRIMERO agregamos el formulario al contenedor
				contenedor.Controls.Add(formularioHijo);
				contenedor.Tag = formularioHijo;

				// 3. DESPUÉS aplicamos el Dock = Fill para que tome exactamente el tamaño del panel
				formularioHijo.Dock = DockStyle.Fill;

				formularioHijo.BringToFront();
				formularioHijo.Show();

				contenedor.ResumeLayout();
			}

			ActualizarTituloPestaña(titulo);
			EstablecerBotonCerrar(true);
		}

		private void MostrarInicio()
		{
			AbrirFormularioHijo(new FrmInicio(), "Panel de Inicio - Dashboard");
			EstablecerBotonCerrar(false); // En inicio no se muestra la X
		}

		// --- Evento Click de la X roja superior ---
		private void btnCerrarHijo_Click(object sender, EventArgs e)
		{
			if (formularioActivo != null)
			{
				formularioActivo.Close();
				formularioActivo = null;
			}
			MostrarInicio();
		}

		// --- Botones del menú lateral ---

		private void btnVentas_Click(object sender, EventArgs e)
		{
			AbrirFormularioHijo(new FrmPedidos(), "Módulo de Ventas y Pedidos");
		}

		private void btnMesas_Click(object sender, EventArgs e)
		{
			AbrirFormularioHijo(new FrmMesas(), "Gestión y Estado de Mesas");
		}

		private void btnInventario_Click(object sender, EventArgs e)
		{
			AbrirFormularioHijo(new FrmProductos(), "Inventario de Platillos y Productos");
		}

		private void btnReportes_Click(object sender, EventArgs e)
		{
			MessageBox.Show("El módulo de reportes y estadísticas está en desarrollo.", "Reportes", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void btnConfiguracion_Click(object sender, EventArgs e)
		{
			AbrirFormularioHijo(new FrmEmpleados(), "Configuración de Personal y Usuarios");
		}

		private void btnInformacion_Click(object sender, EventArgs e)
		{
			string mensaje =
				"=========================================\n" +
				"    RESTOSYS - SISTEMA DE RESTAURANTE\n" +
				"=========================================\n\n" +
				"Versión: 1.0 (Build 2026)\n" +
				"Asignatura: Programación II\n" +
				"Año Académico: 2026\n\n" +
				"--- EQUIPO DE DESARROLLO ---\n" +
				"• José Ángel Gutiérrez Cortez\n" +
				"• Elvis Reinaldo Calles Hernández\n" +
				"• Dennis Alirio López Rivera\n" +
				"• Jason Alexander Rivas Oliva\n" +
				"• Óscar Jonathan Vásquez Rivera\n" +
				"• Kenia Lisbeth Hernández Oliva\n" +
				"• Adrián Alexander Cardoza Martínez\n\n" +
				"-----------------------------------------\n" +
				"Todos los derechos reservados © 2026.";

			MessageBox.Show(mensaje, "Acerca de RestoSys", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void btnAyuda_Click(object sender, EventArgs e)
		{
			MessageBox.Show(
				"Guía Rápida:\n\n" +
				"1. Inicio: Panel de control y métricas del restaurante.\n" +
				"2. Ventas: Toma órdenes y asigna pedidos.\n" +
				"3. Mesas: Control de ocupación.\n" +
				"4. Inventario: Catálogo de productos y precios.\n" +
				"5. Configuración: Gestión de empleados.\n\n" +
				"Use la '✕' en la esquina superior derecha para cerrar la ventana activa.",
				"Centro de Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Question);
		}

		private void btnCerrarSesion_Click(object sender, EventArgs e)
		{
			DialogResult respuesta = MessageBox.Show(
				"¿Desea cerrar la sesión actual?",
				"Cerrar Sesión",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question
			);

			if (respuesta == DialogResult.Yes)
			{
				if (reloj != null) reloj.Stop();
				this.Hide();
				FrmLogin login = new FrmLogin();
				login.ShowDialog();
				this.Close();
			}
		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			DialogResult respuesta = MessageBox.Show(
				"¿Está seguro de que desea salir del sistema por completo?",
				"Salir del Sistema",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Warning
			);

			if (respuesta == DialogResult.Yes)
			{
				if (reloj != null) reloj.Stop();
				Application.Exit();
			}
		}

		private void pnlContenedor_Paint(object sender, PaintEventArgs e) { }

		private void btnSalir_Click_1(object sender, EventArgs e)
		{
			DialogResult respuesta = MessageBox.Show(
				"¿Está seguro de que desea salir del sistema por completo?",
				"Salir del Sistema",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question
			);

			if (respuesta == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

		private void btnClientes_Click(object sender, EventArgs e)
		{
			AbrirFormularioHijo(new FrmClientes(), "Gestión de Clientes");
		}

		private void btnInicio_Click_1(object sender, EventArgs e)
		{
			MostrarInicio();
		}
	}
}