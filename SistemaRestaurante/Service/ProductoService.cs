using System.Collections.Generic;
using System.Linq;
using SistemaRestaurante.Data;
using SistemaRestaurante.Models;

namespace SistemaRestaurante.Services
{
    public class ProductoService
    {
        private readonly RestauranteContext _context;

        public ProductoService(RestauranteContext context)
        {
            _context = context;
        }

        // Método de Consulta (Listar todos los productos)
        public List<Producto> ObtenerTodos()
        {
            return _context.Productos.ToList();
        }

        // Método de Registro (Guardar producto)
        public void Registrar(Producto producto)
        {
            _context.Productos.Add(producto);
            _context.SaveChanges();
        }

        // Método para eliminar un producto por su ID
        public void Eliminar(int id)
        {
            var producto = _context.Productos.Find(id);
            if (producto != null)
            {
                _context.Productos.Remove(producto);
                _context.SaveChanges(); // Guarda la eliminación en la base de datos
            }
        }
    }
}