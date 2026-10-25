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
            using var ctx = new RestauranteContext();
            {
                return await ctx.Empleados.ToListAsync();
            }
        }

        public async Task CrearEmpleadoAsync(Empleado empleado)
        {
            using var ctx = new RestauranteContext();
            {
                ctx.Empleados.Add(empleado);
                await ctx.SaveChangesAsync();
            }
        }

        public async Task<Empleado> ObtenerEmpleadoPorIdAsync(int id)
        {
            using var ctx = new RestauranteContext();
            {
                return await ctx.Empleados.FindAsync(id);
            }
        }

        public async Task ActualizarEmpleadoAsync(Empleado empleado)
        {
            using var ctx = new RestauranteContext();
            {
                ctx.Empleados.Update(empleado);
                await ctx.SaveChangesAsync();
            }
        }

        public async Task<bool> EliminarEmpleadoAsync(int id)
        {
            using var ctx = new RestauranteContext();
            {
                var empleado = await ctx.Empleados.FindAsync(id);
                if (empleado == null) return false;

                ctx.Empleados.Remove(empleado);
                await ctx.SaveChangesAsync();
                return true;
            }
        }
    }
}
