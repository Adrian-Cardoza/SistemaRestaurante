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
            _empleadoService = new EmpleadoService(new RestauranteContext());
        }

        private async void FrmEmpleados_Load(object sender, EventArgs e)
        {
            await RefrescarLista();
            
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
                int id = Convert.ToInt32(dgvEmpleados.CurrentRow.Cells["Id"].Value);

                var empleado = await _empleadoService.ObtenerEmpleadoPorIdAsync(id);
                if (empleado != null)
                {
                    empleado.Nombre = txtNombre.Text;
                    empleado.Rol = txtPuesto.Text;

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
            if (dgvEmpleados.CurrentRow is DataGridViewRow row)
            {
                txtId.Text = row.Cells["Id"].Value?.ToString() ?? string.Empty;
                txtNombre.Text = row.Cells["Nombre"].Value?.ToString() ?? string.Empty;
                txtPuesto.Text = row.Cells["Rol"].Value?.ToString() ?? string.Empty;
            }
        }



        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.CurrentRow != null)
            {
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


        private async void btnListar_Click(object sender, EventArgs e)
        {
            await RefrescarLista();
        }

        private async Task RefrescarLista()
        {
            var empleados = await _empleadoService.ListarEmpleadosAsync();
            dgvEmpleados.DataSource = empleados;
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
