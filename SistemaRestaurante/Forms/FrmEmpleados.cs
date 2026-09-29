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
            var nuevo = new Empleado
            {
                Nombre = txtNombre.Text,
                Rol = txtPuesto.Text
            };

            await _empleadoService.CrearEmpleadoAsync(nuevo);
            MessageBox.Show("Empleado creado correctamente");
            await RefrescarLista();
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtId.Text, out int id))
            {
                var empleado = await _empleadoService.ObtenerEmpleadoPorIdAsync(id);
                if (empleado != null)
                {
                    empleado.Nombre = txtNombre.Text;
                    empleado.Rol = txtPuesto.Text;
                    await _empleadoService.ActualizarEmpleadoAsync(empleado);
                    MessageBox.Show("Empleado actualizado");
                    await RefrescarLista();
                }
                else
                {
                    MessageBox.Show("Empleado no encontrado");
                }
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtId.Text, out int id))
            {
                bool eliminado = await _empleadoService.EliminarEmpleadoAsync(id);
                MessageBox.Show(eliminado ? "Empleado eliminado" : "Empleado no encontrado");
                await RefrescarLista();
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
