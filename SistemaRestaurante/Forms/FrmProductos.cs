using System;
using System.Globalization;
using System.Windows.Forms;
using SistemaRestaurante.Models;
using SistemaRestaurante.Services;
using SistemaRestaurante.Data;
using System.Linq;
namespace SistemaRestaurante.Forms
{
    public partial class FrmProductos : Form
    {
        private ProductoService _service;
        private int _productoIdSeleccionado = 0;

        public FrmProductos()
        {
            InitializeComponent();
            _service = new ProductoService(new RestauranteContext());
            CargarTabla();
        }

        private void CargarTabla()
        {
            if (_service == null)
                return;

            // Obtener todos los productos
            var productos = _service.ObtenerTodos().ToList();

            // Obtener el texto del buscador
            string busqueda = txtBuscarProducto.Text.Trim();

            // Filtrar por nombre o categoría
            if (!string.IsNullOrWhiteSpace(busqueda))
            {
                productos = productos.Where(p =>
                    (p.Nombre ?? "").Contains(
                        busqueda,
                        StringComparison.OrdinalIgnoreCase) ||

                    (p.Categoria ?? "").Contains(
                        busqueda,
                        StringComparison.OrdinalIgnoreCase)
                ).ToList();
            }

            // Actualizar la tabla
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = productos;

            // Formato del precio en dólares
            if (dgvProductos.Columns["Precio"] != null)
            {
                dgvProductos.Columns["Precio"]
                    .DefaultCellStyle.Format = "$#,##0.00";
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (_productoIdSeleccionado != 0)
            {
                MessageBox.Show(
                    "Tiene un producto seleccionado. Use Editar para actualizarlo o Nuevo para registrar otro.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

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
            if (e.RowIndex < 0)
                return;

            DataGridViewRow fila = dgvProductos.Rows[e.RowIndex];

            _productoIdSeleccionado =
                Convert.ToInt32(fila.Cells["ID"].Value);

            txtNombre.Text =
                Convert.ToString(fila.Cells["Nombre"].Value) ?? "";

            txtPrecio.Text =
                Convert.ToDecimal(fila.Cells["Precio"].Value)
                .ToString("0.00", CultureInfo.InvariantCulture);

            txtCategoria.Text =
                Convert.ToString(fila.Cells["Categoria"].Value) ?? "";

            Disponible.Checked =
                Convert.ToBoolean(fila.Cells["Disponible"].Value);
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Verificar que exista un producto seleccionado
                if (_productoIdSeleccionado == 0)
                {
                    MessageBox.Show(
                        "Seleccione un producto de la tabla para editar.",
                        "Atención",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                // 2. Validar campos vacíos
                if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtPrecio.Text) ||
                    string.IsNullOrWhiteSpace(txtCategoria.Text))
                {
                    MessageBox.Show(
                        "Por favor llene todos los campos obligatorios.",
                        "Atención",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                string nombre = txtNombre.Text.Trim();
                string categoria = txtCategoria.Text.Trim();

                // 3. Validar nombre
                foreach (char c in nombre)
                {
                    if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                    {
                        MessageBox.Show(
                            "El nombre solo debe contener letras y espacios.",
                            "Nombre inválido",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        txtNombre.Focus();
                        return;
                    }
                }

                // 4. Validar categoría
                foreach (char c in categoria)
                {
                    if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                    {
                        MessageBox.Show(
                            "La categoría solo debe contener letras y espacios.",
                            "Categoría inválida",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        txtCategoria.Focus();
                        return;
                    }
                }

                // 5. Validar precio
                string textoPrecio = txtPrecio.Text.Trim().Replace(',', '.');

                if (!decimal.TryParse(
                        textoPrecio,
                        NumberStyles.Any,
                        CultureInfo.InvariantCulture,
                        out decimal precio) || precio <= 0)
                {
                    MessageBox.Show(
                        "El precio debe ser un número válido mayor a 0.",
                        "Precio inválido",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    txtPrecio.Focus();
                    return;
                }

                // 6. Actualizar el producto seleccionado
                bool actualizado = _service.Actualizar(
                    _productoIdSeleccionado,
                    nombre,
                    precio,
                    categoria,
                    Disponible.Checked
                );

                if (!actualizado)
                {
                    MessageBox.Show(
                        "El producto seleccionado ya no existe.",
                        "Atención",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                // 7. Confirmación
                MessageBox.Show(
                    "Producto actualizado correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // 8. Actualizar tabla
                CargarTabla();

                // 9. Limpiar los campos
                txtNombre.Clear();
                txtPrecio.Clear();
                txtCategoria.Clear();

                Disponible.Checked = true;
                _productoIdSeleccionado = 0;

                dgvProductos.ClearSelection();
                txtNombre.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al actualizar el producto: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtPrecio.Clear();
            txtCategoria.Clear();

            Disponible.Checked = true;

            dgvProductos.ClearSelection();

            _productoIdSeleccionado = 0;

            txtNombre.Focus();
        }

        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void Disponible_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}