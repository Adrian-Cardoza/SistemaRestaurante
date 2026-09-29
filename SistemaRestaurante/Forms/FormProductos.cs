using System;
using System.Globalization;
using System.Windows.Forms;
using SistemaRestaurante.Models;
using SistemaRestaurante.Services;
using SistemaRestaurante.Data;

namespace SistemaRestaurante.Forms
{
    public partial class FormProductos : Form
    {
        private ProductoService _service;

        public FormProductos()
        {
            InitializeComponent();
            _service = new ProductoService(new RestauranteContext());
            CargarTabla();
        }

        private void CargarTabla()
        {
            if (_service != null)
            {
                dgvProductos.DataSource = null;
                dgvProductos.DataSource = _service.ObtenerTodos();

                // Formato de moneda en dólares ($12.50) para la tabla
                if (dgvProductos.Columns["Precio"] != null)
                {
                    dgvProductos.Columns["Precio"].DefaultCellStyle.Format = "$#,##0.00";
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Validar que no haya campos vacíos
                if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtPrecio.Text) ||
                    string.IsNullOrWhiteSpace(txtCategoria.Text))
                {
                    MessageBox.Show("Por favor llene todos los campos obligatorios.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string nombre = txtNombre.Text.Trim();
                string categoria = txtCategoria.Text.Trim();

                // 2. Validar que el NOMBRE solo contenga letras y espacios
                foreach (char c in nombre)
                {
                    if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                    {
                        MessageBox.Show("El nombre solo debe contener letras (sin números ni símbolos).", "Nombre Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNombre.Focus();
                        return;
                    }
                }

                // 3. Validar que la CATEGORÍA solo contenga letras y espacios
                foreach (char c in categoria)
                {
                    if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                    {
                        MessageBox.Show("La categoría solo debe contener letras (sin números ni símbolos).", "Categoría Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtCategoria.Focus();
                        return;
                    }
                }

                // 4. Validar PRECIO: Reemplaza coma por punto e interpreta decimales correctamente
                string textoPrecio = txtPrecio.Text.Trim().Replace(',', '.');

                if (!decimal.TryParse(textoPrecio, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal precio) || precio <= 0)
                {
                    MessageBox.Show("El precio debe ser un número válido mayor a 0 (ejemplo: 12.50).", "Precio Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPrecio.Focus();
                    return;
                }

                // 5. Crear el objeto con los datos correctos
                var nuevoProducto = new Producto
                {
                    Nombre = nombre,
                    Precio = precio,
                    Categoria = categoria,
                    Disponible = Disponible.Checked
                };

                // 6. Guardar en la base de datos
                if (_service != null)
                {
                    _service.Registrar(nuevoProducto);
                    MessageBox.Show("Producto registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiar controles
                    txtNombre.Clear();
                    txtPrecio.Clear();
                    txtCategoria.Clear();
                    Disponible.Checked = true;
                    CargarTabla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado en el sistema: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                // Obtiene el ID de la fila seleccionada
                int id = Convert.ToInt32(dgvProductos.SelectedRows[0].Cells["ID"].Value);

                var confirmacion = MessageBox.Show("¿Está seguro de eliminar este producto?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    _service.Eliminar(id);
                    MessageBox.Show("Producto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarTabla();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila completa en la tabla para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}