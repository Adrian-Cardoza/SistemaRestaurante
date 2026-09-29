using SistemaRestaurante.Data;
using SistemaRestaurante.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SistemaRestaurante.Service
{
    public class EmpleadoService
    {
        private readonly RestauranteContext _context;

        public EmpleadoService(RestauranteContext context)
        {
            _context = context;
        }

        public async Task<List<Empleado>> ListarEmpleadosAsync()
        {
            return await _context.Empleados.ToListAsync();
        }

        public async Task<Empleado> ObtenerEmpleadoPorIdAsync(int id)
        {
            return await _context.Empleados.FindAsync(id);
        }

        public async Task CrearEmpleadoAsync(Empleado empleado)
        {
            _context.Empleados.Add(empleado);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> ActualizarEmpleadoAsync(Empleado empleado)
        {
            var existente = await _context.Empleados.FindAsync(empleado.Id);
            if (existente == null) return false;

            existente.Nombre = empleado.Nombre;
            existente.Rol = empleado.Rol;
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> EliminarEmpleadoAsync(int id)
        {
            var empleado = await _context.Empleados.FindAsync(id);
            if (empleado == null) return false;

            _context.Empleados.Remove(empleado);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
