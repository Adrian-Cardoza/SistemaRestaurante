using SistemaRestaurante.Data;
using SistemaRestaurante.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SistemaRestaurante.Service
{
    public class EmpleadoService
    {
        public async Task<List<Empleado>> ListarEmpleadosAsync()
        {
            using (var context = new RestauranteContext())
            {
                return await context.Empleados.ToListAsync();
            }
        }

        public async Task CrearEmpleadoAsync(Empleado empleado)
        {
            using (var context = new RestauranteContext())
            {
                context.Empleados.Add(empleado);
                await context.SaveChangesAsync();
            }
        }

        public async Task<Empleado> ObtenerEmpleadoPorIdAsync(int id)
        {
            using (var context = new RestauranteContext())
            {
                return await context.Empleados.FindAsync(id);
            }
        }

        public async Task ActualizarEmpleadoAsync(Empleado empleado)
        {
            using (var context = new RestauranteContext())
            {
                context.Empleados.Update(empleado);
                await context.SaveChangesAsync();
            }
        }

        public async Task<bool> EliminarEmpleadoAsync(int id)
        {
            using (var context = new RestauranteContext())
            {
                var empleado = await context.Empleados.FindAsync(id);
                if (empleado == null) return false;

                context.Empleados.Remove(empleado);
                await context.SaveChangesAsync();
                return true;
            }
        }
    }
}
