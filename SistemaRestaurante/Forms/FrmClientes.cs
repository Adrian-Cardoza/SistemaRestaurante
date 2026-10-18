using SistemaRestaurante.Models;
using SistemaRestaurante.Service;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaRestaurante.Forms
{
    public partial class FrmClientes : Form
    {
        private readonly ClienteService _clienteService = new ClienteService();

        public FrmClientes()
        {
            InitializeComponent();
        }

        private async void FrmClientes_Load(object sender, EventArgs e)
        {
            await CargarClientesAsync();
        }

        private async Task CargarClientesAsync()
        {
            var clientes = await _clienteService.ListarClientesAsync();
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = clientes;
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtDui.Text))
            {
                MessageBox.Show("Nombre y DUI son obligatorios.");
                return;
            }

            var cliente = new Cliente
            {
                Nombre = txtNombre.Text,
                DUI = int.Parse(txtDui.Text),
                Correo = txtCorreo.Text
            };

            await _clienteService.CrearClienteAsync(cliente);
            await CargarClientesAsync();
            LimpiarCampos();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un cliente para eliminar.");
                return;
            }

            var cliente = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
            var eliminado = await _clienteService.EliminarClienteAsync(cliente.Id);

            if (eliminado)
                MessageBox.Show("Cliente eliminado correctamente.");
            else
                MessageBox.Show("No se pudo eliminar el cliente.");

            await CargarClientesAsync();
        }

        private async void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClientes.CurrentRow != null)
            {
                var cliente = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
                txtNombre.Text = cliente.Nombre;
                txtDui.Text = cliente.DUI.ToString();
                txtCorreo.Text = cliente.Correo;
            }
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un cliente para actualizar.");
                return;
            }

            var cliente = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
            cliente.Nombre = txtNombre.Text;
            cliente.DUI = int.Parse(txtDui.Text);
            cliente.Correo = txtCorreo.Text;

            await _clienteService.ActualizarClienteAsync(cliente);
            MessageBox.Show("Cliente actualizado correctamente.");
            await CargarClientesAsync();
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtDui.Clear();
            txtCorreo.Clear();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e) { }
        private void txtDui_TextChanged(object sender, EventArgs e) { }
        private void txtCorreo_TextChanged(object sender, EventArgs e) { }
    }
}

