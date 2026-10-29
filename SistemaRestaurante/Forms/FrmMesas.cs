using SistemaRestaurante.Data;
using SistemaRestaurante.Models;

namespace SistemaRestaurante.Forms
{
	public partial class FrmMesas : Form
	{
		private bool esSeleccionProgramatica = false;
		private int idMesaSeleccionada = 0;
		private bool estaCargando = true;

		public FrmMesas()
		{
			InitializeComponent();
			this.Load += FrmMesas_Load;
			this.Shown += FrmMesas_Shown;
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

			esSeleccionProgramatica = true;
			dataGridView1.DataSource = query.ToList();

			dataGridView1.ClearSelection();
			dataGridView1.CurrentCell = null;

			esSeleccionProgramatica = false;

			LimpiarCampos();
		}

		private void FrmMesas_Load(object sender, EventArgs e)
		{
			estaCargando = true;
			EstadoMesa.Items.Clear();
			EstadoMesa.Items.Add("Disponible");
			EstadoMesa.Items.Add("Ocupada");
			EstadoMesa.Items.Add("Reservada");

			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView1.RowHeadersVisible = false;

			CargarMesas();
		}

		private void FrmMesas_Shown(object sender, EventArgs e)
		{
			dataGridView1.ClearSelection();
			dataGridView1.CurrentCell = null;
			LimpiarCampos();
			estaCargando = false;
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			CargarMesas(textBox1.Text);
		}

		private void DataGridView1_SelectionChanged(object sender, EventArgs e)
		{
			if (estaCargando || esSeleccionProgramatica || dataGridView1.SelectedRows.Count == 0)
				return;

			if (dataGridView1.CurrentRow?.DataBoundItem is Mesa mesa)
			{
				idMesaSeleccionada = mesa.Id;
				numericUpDown1.Value = mesa.Numero >= numericUpDown1.Minimum && mesa.Numero <= numericUpDown1.Maximum ? mesa.Numero : numericUpDown1.Minimum;
				numericUpDown2.Value = mesa.Capacidad >= numericUpDown2.Minimum && mesa.Capacidad <= numericUpDown2.Maximum ? mesa.Capacidad : numericUpDown2.Minimum;
				EstadoMesa.SelectedItem = mesa.Estado;
			}
		}

		private void GuardarBtn_Click(object sender, EventArgs e)
		{
			int numeroMesa = (int)numericUpDown1.Value;
			int capacidad = (int)numericUpDown2.Value;

			if (numeroMesa <= 0 || capacidad <= 0)
			{
				MessageBox.Show("Por favor, ingresa un número de mesa y una capacidad mayores a 0.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			using var context = new RestauranteContext();

			bool numeroDuplicado = context.Mesas.Any(m => m.Numero == numeroMesa && m.Id != idMesaSeleccionada);

			if (numeroDuplicado)
			{
				MessageBox.Show($"Ya existe otra mesa registrada con el número {numeroMesa}. Por favor, elige un número diferente.", "Número Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			Mesa mesa;
			if (idMesaSeleccionada > 0)
			{
				mesa = context.Mesas.Find(idMesaSeleccionada);
			}
			else
			{
				mesa = new Mesa();
				context.Mesas.Add(mesa);
			}

			mesa.Numero = numeroMesa;
			mesa.Capacidad = capacidad;
			mesa.Estado = EstadoMesa.SelectedItem?.ToString() ?? "Disponible";

			context.SaveChanges();

			MessageBox.Show("Mesa guardada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

			CargarMesas();
		}

		private void CambiarEstadoBtn_Click(object sender, EventArgs e)
		{
			if (idMesaSeleccionada == 0)
			{
				MessageBox.Show("Por favor, selecciona una mesa del listado para cambiar su estado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			using var context = new RestauranteContext();
			var mesa = context.Mesas.Find(idMesaSeleccionada);

			if (mesa != null)
			{
				mesa.Estado = EstadoMesa.SelectedItem?.ToString() ?? "Disponible";
				context.SaveChanges();
				MessageBox.Show("Estado de la mesa actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

			CargarMesas();
		}

		private void LimpiarCamposBtn_Click(object sender, EventArgs e)
		{
			LimpiarCampos();
			dataGridView1.ClearSelection();
			dataGridView1.CurrentCell = null;
		}

		private void LimpiarCampos()
		{
			esSeleccionProgramatica = true;

			idMesaSeleccionada = 0;
			numericUpDown1.Value = 0;
			numericUpDown2.Value = 0;
			EstadoMesa.SelectedItem = "Disponible";

			esSeleccionProgramatica = false;
		}
	}
}