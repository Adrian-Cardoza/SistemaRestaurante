using System;
using System.Linq;
using System.Windows.Forms;
using SistemaRestaurante.Data;
using SistemaRestaurante.Models;

namespace SistemaRestaurante.Forms
{
    public partial class FrmMesas : Form
    {
        public FrmMesas()
        {
            InitializeComponent();
            this.Load += FrmMesas_Load;
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
            GuardarBtn.Click += GuardarBtn_Click;
            CambiarEstadoBtn.Click += CambiarEstadoBtn_Click;
            LimpiarCamposBtn.Click += LimpiarCamposBtn_Click;
        }

        private void CargarMesas(string filtro = "")
        {
            using var context = new RestauranteContext();
            var query = context.Mesas.AsQueryable();

            if (!string.IsNullOrWhiteSpace(filtro) && filtro != "Buscar mesa...")
            {
                query = query.Where(m => m.Numero.ToString().Contains(filtro)
                                       || m.Estado.Contains(filtro));
            }

            dataGridView1.DataSource = query.ToList();
        }

        private void FrmMesas_Load(object sender, EventArgs e)
        {
            CargarMesas();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CargarMesas(textBox1.Text);
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow?.DataBoundItem is Mesa mesa)
            {
                numericUpDown1.Value = mesa.Numero;
                numericUpDown2.Value = mesa.Capacidad;
                EstadoMesa.SelectedItem = mesa.Estado;
            }
        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            using var context = new RestauranteContext();

            Mesa mesa;
            if (dataGridView1.CurrentRow?.DataBoundItem is Mesa seleccionada)
            {
                mesa = context.Mesas.Find(seleccionada.Id);
            }
            else
            {
                mesa = new Mesa();
                context.Mesas.Add(mesa);
            }

            mesa.Numero = (int)numericUpDown1.Value;
            mesa.Capacidad = (int)numericUpDown2.Value;
            mesa.Estado = EstadoMesa.SelectedItem?.ToString() ?? "Libre";

            context.SaveChanges();
            CargarMesas();
            LimpiarCamposBtn_Click(sender, e);
        }

        private void CambiarEstadoBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow?.DataBoundItem is not Mesa seleccionada)
            {
                MessageBox.Show("Selecciona una mesa primero.");
                return;
            }

            using var context = new RestauranteContext();
            var mesa = context.Mesas.Find(seleccionada.Id);
            mesa.Estado = EstadoMesa.SelectedItem?.ToString() ?? mesa.Estado;
            context.SaveChanges();

            CargarMesas();
        }

        private void LimpiarCamposBtn_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            EstadoMesa.SelectedIndex = -1;
            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;
        }
    }
}