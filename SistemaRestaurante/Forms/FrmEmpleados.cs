using SistemaRestaurante.Models;
using SistemaRestaurante.Service;

namespace SistemaRestaurante.Forms
{
	public partial class FrmEmpleados : Form
	{
		private readonly EmpleadoService _empleadoService;

		public FrmEmpleados()
		{
			InitializeComponent();
			_empleadoService = new EmpleadoService();
		}

		private async void FrmEmpleados_Load(object sender, EventArgs e)
		{
			await RefrescarLista();
			LimpiarCampos();
		}

		private async void btnCrear_Click(object sender, EventArgs e)
		{
			// Validar que los campos obligatorios no estén vacíos
			if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
				string.IsNullOrWhiteSpace(txtPuesto.Text) ||
				string.IsNullOrWhiteSpace(txtUsuario.Text) ||
				string.IsNullOrWhiteSpace(txtContraseña.Text))
			{
				MessageBox.Show("Debe completar todos los campos (Nombre, Puesto, Usuario y Contraseña).", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			var nuevo = new Empleado
			{
				Nombre = txtNombre.Text.Trim(),
				Rol = txtPuesto.Text.Trim(),
				Usuario = txtUsuario.Text.Trim(),
				Contraseña = txtContraseña.Text.Trim() // Asegúrate de que el campo en tu entidad se llame así
			};

			await _empleadoService.CrearEmpleadoAsync(nuevo);
			MessageBox.Show("Empleado creado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

			await RefrescarLista();
			LimpiarCampos();
		}

		private async void btnActualizar_Click(object sender, EventArgs e)
		{
			if (dgvEmpleados.CurrentRow != null)
			{
				if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
					string.IsNullOrWhiteSpace(txtPuesto.Text) ||
					string.IsNullOrWhiteSpace(txtUsuario.Text) ||
					string.IsNullOrWhiteSpace(txtContraseña.Text))
				{
					MessageBox.Show("Debe completar todos los campos antes de actualizar.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				int id = Convert.ToInt32(dgvEmpleados.CurrentRow.Cells["Id"].Value);

				var empleado = await _empleadoService.ObtenerEmpleadoPorIdAsync(id);
				if (empleado != null)
				{
					empleado.Nombre = txtNombre.Text.Trim();
					empleado.Rol = txtPuesto.Text.Trim();
					empleado.Usuario = txtUsuario.Text.Trim();
					empleado.Contraseña = txtContraseña.Text.Trim();

					await _empleadoService.ActualizarEmpleadoAsync(empleado);
					MessageBox.Show("Empleado actualizado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
					await RefrescarLista();
					LimpiarCampos();
				}
				else
				{
					MessageBox.Show("Empleado no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("Seleccione un empleado en la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void LimpiarCampos()
		{
			txtId.Clear();
			txtNombre.Clear();
			txtPuesto.Clear();
			txtUsuario.Clear();
			txtContraseña.Clear();
		}

		private void dgvEmpleados_SelectionChanged(object sender, EventArgs e)
		{
			if (dgvEmpleados.CurrentRow != null)
			{
				txtId.Text = dgvEmpleados.CurrentRow.Cells["Id"].Value?.ToString() ?? "";
				txtNombre.Text = dgvEmpleados.CurrentRow.Cells["Nombre"].Value?.ToString() ?? "";
				txtPuesto.Text = dgvEmpleados.CurrentRow.Cells["Rol"].Value?.ToString() ?? "";
				txtUsuario.Text = dgvEmpleados.CurrentRow.Cells["Usuario"].Value?.ToString() ?? "";
				txtContraseña.Text = dgvEmpleados.CurrentRow.Cells["Contraseña"].Value?.ToString() ?? "";
			}
		}

		private async void btnEliminar_Click(object sender, EventArgs e)
		{
			if (dgvEmpleados.CurrentRow != null)
			{
				var confirm = MessageBox.Show("¿Está seguro de eliminar este empleado?",
											   "Confirmar eliminación",
											   MessageBoxButtons.YesNo,
											   MessageBoxIcon.Warning);

				if (confirm == DialogResult.No) return;

				int id = Convert.ToInt32(dgvEmpleados.CurrentRow.Cells["Id"].Value);

				bool eliminado = await _empleadoService.EliminarEmpleadoAsync(id);
				MessageBox.Show(eliminado ? "Empleado eliminado" : "Empleado no encontrado");

				await RefrescarLista();
				LimpiarCampos();
			}
			else
			{
				MessageBox.Show("Seleccione un empleado en la lista.");
			}
		}

		private async Task RefrescarLista()
		{
			var empleados = await _empleadoService.ListarEmpleadosAsync();
			dgvEmpleados.DataSource = empleados;

			dgvEmpleados.ClearSelection();
			LimpiarCampos();
		}

		private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				txtId.Text = dgvEmpleados.Rows[e.RowIndex].Cells["Id"].Value?.ToString() ?? "";
				txtNombre.Text = dgvEmpleados.Rows[e.RowIndex].Cells["Nombre"].Value?.ToString() ?? "";
				txtPuesto.Text = dgvEmpleados.Rows[e.RowIndex].Cells["Rol"].Value?.ToString() ?? "";
				txtUsuario.Text = dgvEmpleados.Rows[e.RowIndex].Cells["Usuario"].Value?.ToString() ?? "";
				txtContraseña.Text = dgvEmpleados.Rows[e.RowIndex].Cells["Contraseña"]?.ToString() ?? "";
			}
		}

		private void FrmEmpleados_MouseClick(object sender, MouseEventArgs e)
		{
			var hit = dgvEmpleados.HitTest(e.X, e.Y);

			if (hit.Type == DataGridViewHitTestType.None)
			{
				LimpiarCampos();
			}
		}

		private void btnListar_Click(object sender, EventArgs e)
		{
			RefrescarLista();
		}
	}
}
