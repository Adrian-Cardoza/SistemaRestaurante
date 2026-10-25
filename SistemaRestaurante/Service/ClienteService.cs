using Microsoft.EntityFrameworkCore;
using SistemaRestaurante.Data;
using SistemaRestaurante.Models;

namespace SistemaRestaurante.Service
{
    public class ClienteService
    {
        public async Task<List<Cliente>> ListarClientesAsync()
        {
            using var ctx = new RestauranteContext();
            {
                return await ctx.Clientes
                    .Include(c => c.Pedidos)
                    .ToListAsync();
            }
        }

        public async Task CrearClienteAsync(Cliente cliente)
        {
            using var ctx = new RestauranteContext();
            {
                ctx.Clientes.Add(cliente);
                await ctx.SaveChangesAsync();
            }
        }

        public async Task<Cliente?> ObtenerClientePorIdAsync(int id)
        {
            using var ctx = new RestauranteContext();
            {
                return await ctx.Clientes
                    .Include(c => c.Pedidos)
                    .FirstOrDefaultAsync(c => c.Id == id);
            }
        }

        public async Task ActualizarClienteAsync(Cliente cliente)
        {
            using var ctx = new RestauranteContext();
            {
                ctx.Clientes.Update(cliente);
                await ctx.SaveChangesAsync();
            }
        }

        public async Task<bool> EliminarClienteAsync(int id)
        {
            using var ctx = new RestauranteContext();
            {
                var cliente = await ctx.Clientes.FindAsync(id);
                if (cliente == null) return false;

                ctx.Clientes.Remove(cliente);
                await ctx.SaveChangesAsync();
                return true;
            }
        }
    }
}
