using SistemaRestaurante.Data;
using SistemaRestaurante.Models;
using SistemaRestaurante.Service;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtPuesto.Text))
            {
                MessageBox.Show("Debe ingresar un nombre y un puesto antes de crear el empleado.");
                return; // salir sin crear
            }

            var nuevo = new Empleado
            {
                Nombre = txtNombre.Text.Trim(),
                Rol = txtPuesto.Text.Trim()
            };

            await _empleadoService.CrearEmpleadoAsync(nuevo);
            MessageBox.Show("Empleado creado correctamente");

            await RefrescarLista();
            LimpiarCampos();
        }


        private async void btnActualizar_Click(object sender, EventArgs e)

        {
            if (dgvEmpleados.CurrentRow != null)
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtPuesto.Text))
                {
                    MessageBox.Show("Debe ingresar un nombre y un puesto antes de actualizar.");
                    return;
                }

                int id = Convert.ToInt32(dgvEmpleados.CurrentRow.Cells["Id"].Value);

                var empleado = await _empleadoService.ObtenerEmpleadoPorIdAsync(id);
                if (empleado != null)
                {
                    empleado.Nombre = txtNombre.Text.Trim();
                    empleado.Rol = txtPuesto.Text.Trim();

                    await _empleadoService.ActualizarEmpleadoAsync(empleado);
                    MessageBox.Show("Empleado actualizado");
                    await RefrescarLista();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Empleado no encontrado");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un empleado en la lista.");
            }
        }
        private void LimpiarCampos()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtPuesto.Clear();
        }

        private void dgvEmpleados_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEmpleados.CurrentRow != null)
            {
                txtId.Text = dgvEmpleados.CurrentRow.Cells["Id"].Value.ToString();
                txtNombre.Text = dgvEmpleados.CurrentRow.Cells["Nombre"].Value.ToString();
                txtPuesto.Text = dgvEmpleados.CurrentRow.Cells["Rol"].Value.ToString();
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

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtId.Text = dgvEmpleados.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                txtNombre.Text = dgvEmpleados.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                txtPuesto.Text = dgvEmpleados.Rows[e.RowIndex].Cells["Rol"].Value.ToString();
            }
        }

        private void FrmEmpleados_MouseClick(object sender, MouseEventArgs e)
        {
            var hit = dgvEmpleados.HitTest(e.X, e.Y);

            // Si el clic no fue sobre una celda válida
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
