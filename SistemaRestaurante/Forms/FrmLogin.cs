using SistemaRestaurante.Data;
using SistemaRestaurante.Service;

namespace SistemaRestaurante.Forms
{
	public partial class FrmLogin : Form
	{
		public FrmLogin()
		{
			InitializeComponent();
		}

		// Este es el botón Aceptar
		private void btnIngresar_Click(object sender, EventArgs e)
		{
			string usuarioIngresado = txtUsuario.Text.Trim();
			string passwordIngresada = txtContraseña.Text.Trim();

			if (string.IsNullOrEmpty(usuarioIngresado) || string.IsNullOrEmpty(passwordIngresada))
			{
				MessageBox.Show("Por favor, ingrese usuario y contraseña.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			using var ctx = new RestauranteContext();

			// Buscamos al empleado en la base de datos por sus credenciales
			var empleadoEncontrado = ctx.Empleados
				.FirstOrDefault(emp => emp.Usuario == usuarioIngresado && emp.Contraseña == passwordIngresada);

			if (empleadoEncontrado != null)
			{
				// Guardamos los datos en la sesión global
				SesionActual.IdEmpleadoLogueado = empleadoEncontrado.Id;
				SesionActual.NombreEmpleado = empleadoEncontrado.Nombre;
				SesionActual.RolEmpleado = empleadoEncontrado.Rol; // Ej: "Mesero" o "Administrador"

				MessageBox.Show($"¡Bienvenido, {empleadoEncontrado.Nombre}!", "Acceso Concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);

				FrmMenuPrincipal menu = new FrmMenuPrincipal();
				menu.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Usuario o contraseña incorrectos.", "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// Este es el botón Cancelar
		private void btnCancelar_Click(object sender, EventArgs e)
		{
			Application.Exit(); // Cierra el sistema si cancelan
		}
	}
}