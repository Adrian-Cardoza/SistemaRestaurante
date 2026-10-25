using SistemaRestaurante.Data;
using SistemaRestaurante.Models;
using SistemaRestaurante.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace SistemaRestaurante.Forms
{
    public partial class FrmPedidos : Form
    {
        private readonly PedidoService _pedidoService;
        public FrmPedidos()
        {
            InitializeComponent();
            _pedidoService = new PedidoService();
            RefrescarLista();
            CargarEmpleados();
            CargarClientes();
            CargarMesas();
            CargarEstados();
            ConfigurarGrid();
        }

        private void RefrescarLista(string filtro = "")
        {
            dgvPedidos.DataSource = _pedidoService.ListaPedidos(filtro);
        }

        private void FrmPedidos_Load(object? sender, EventArgs e)
        {

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbMesa.SelectedIndex < 0 || cmbEmpleado.SelectedIndex < 0 || cmbCliente.SelectedIndex < 0)
                {
                    MessageBox.Show("Debe seleccionar Mesa, Empleado y Cliente.");
                    return;
                }

                var pedido = new Pedido
                {
                    IdMesa = Convert.ToInt32(cmbMesa.SelectedValue),
                    IdEmpleado = Convert.ToInt32(cmbEmpleado.SelectedValue),
                    IdCliente = Convert.ToInt32(cmbCliente.SelectedValue),
                    Estado = string.IsNullOrWhiteSpace(cmbEstado.Text) ? "Pendiente" : cmbEstado.Text.Trim(),
                    Fecha = dtpFecha.Value
                };

                _pedidoService.CrearPedido(pedido);
                MessageBox.Show("Pedido creado correctamente.");
                RefrescarLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un pedido de la lista.");
                return;
            }

            try
            {
                int id = Convert.ToInt32(dgvPedidos.CurrentRow.Cells["Id"].Value);
                var pedido = new Pedido
                {
                    Id = id,
                    IdMesa = Convert.ToInt32(cmbMesa.SelectedValue),
                    IdEmpleado = Convert.ToInt32(cmbEmpleado.SelectedValue),
                    IdCliente = Convert.ToInt32(cmbCliente.SelectedValue),
                    Estado = cmbEstado.Text.Trim(),
                    Fecha = dtpFecha.Value
                };

                _pedidoService.ActualizarPedido(pedido);
                MessageBox.Show("Pedido actualizado correctamente.");
                RefrescarLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un pedido de la lista.");
                return;
            }

            try
            {
                int id = Convert.ToInt32(dgvPedidos.CurrentRow.Cells["Id"].Value);
                _pedidoService.CancelarPedido(id);
                MessageBox.Show("Pedido cancelado.");
                RefrescarLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            cmbMesa.SelectedIndex = -1;
            cmbEmpleado.SelectedIndex = -1;
            cmbCliente.SelectedIndex = -1;
            cmbEstado.SelectedIndex = -1;
            dtpFecha.Value = DateTime.Now;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            RefrescarLista(txtBuscar.Text.Trim());
        }

        private void dgvPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbMesa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void CargarMesas()
        {
            using var ctx = new RestauranteContext();
            var mesas = ctx.Mesas
                .Select(m => new { m.Id, m.Numero })
                .ToList();

            cmbMesa.DataSource = mesas;
            cmbMesa.DisplayMember = "Numero";
            cmbMesa.ValueMember = "Id";
            cmbMesa.SelectedIndex = -1;
        }

        private void CargarEmpleados()
        {
            using var ctx = new RestauranteContext();
            var empleados = ctx.Empleados
                .Select(e => new { e.Id, Nombre = e.Nombre})
                .ToList();

            cmbEmpleado.DataSource = empleados;
            cmbEmpleado.DisplayMember = "Nombre";
            cmbEmpleado.ValueMember = "Id";
            cmbEmpleado.SelectedIndex = -1;
        }

        private void CargarClientes()
        {
            using var ctx = new RestauranteContext();
            var clientes = ctx.Clientes
                .Select(c => new { c.Id, Nombre = c.Nombre })
                .ToList();

            cmbCliente.DataSource = clientes;
            cmbCliente.DisplayMember = "Nombre";
            cmbCliente.ValueMember = "Id";
            cmbCliente.SelectedIndex = -1;
        }

        private void CargarEstados()
        {
            var estados = new List<string> { "Pendiente", "Facturado", "Cancelado" };
            cmbEstado.DataSource = estados;
            cmbEstado.SelectedIndex = -1;
        }

        private void ConfigurarGrid()
        {
            dgvPedidos.AutoGenerateColumns = false;
            dgvPedidos.Columns.Clear();

            dgvPedidos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "ID",
                Width = 50
            });

            dgvPedidos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Fecha",
                HeaderText = "Fecha",
                Width = 120
            });

            dgvPedidos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Estado",
                HeaderText = "Estado",
                Width = 100
            });

            // Si tu modelo Pedido incluye navegación a Cliente, Mesa, Empleado:
            dgvPedidos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Cliente.Nombre",
                HeaderText = "Cliente",
                Width = 150
            });

            dgvPedidos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Empleado.Nombre",
                HeaderText = "Empleado",
                Width = 150
            });

            dgvPedidos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Mesa.Numero",
                HeaderText = "Mesa",
                Width = 80
            });
        }

    }
}
