using Microsoft.EntityFrameworkCore;
using SistemaRestaurante.Config;
using SistemaRestaurante.Models;

namespace SistemaRestaurante.Data
{
	public class RestauranteContext : DbContext
	{
        public RestauranteContext() { }

        public RestauranteContext(DbContextOptions<RestauranteContext> options)
            : base(options) { }


        public DbSet<Empleado> Empleados { get; set; }
		public DbSet<Cliente> Clientes { get; set; }
		public DbSet<Mesa> Mesas { get; set; }
		public DbSet<Pedido> Pedidos { get; set; }
		public DbSet<Factura> Facturas { get; set; }
		public DbSet<Producto> Productos { get; set; }
		public DbSet<DetallePedido> DetallesPedidos { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder options)
		{
            if (!options.IsConfigured)
            {
                options.UseSqlServer(ConfiguracionApp.ObtenerCadenaConexion());
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			// Relación Mesas (1) -> Pedidos (N)
			modelBuilder.Entity<Pedido>()
				.HasOne(p => p.Mesa)
				.WithMany(m => m.Pedidos)
				.HasForeignKey(p => p.IdMesa)
				.OnDelete(DeleteBehavior.Restrict);

			// Relación Empleados (1) -> Pedidos (N)
			modelBuilder.Entity<Pedido>()
				.HasOne(p => p.Empleado)
				.WithMany(e => e.Pedidos)
				.HasForeignKey(p => p.IdEmpleado)
				.OnDelete(DeleteBehavior.Restrict);

			// Relación Clientes (1) -> Pedidos (N)
			modelBuilder.Entity<Pedido>()
				.HasOne(p => p.Cliente)
				.WithMany(c => c.Pedidos)
				.HasForeignKey(p => p.IdCliente)
				.OnDelete(DeleteBehavior.Restrict);

			// Relación Pedidos (1) -> Facturas (1)
			modelBuilder.Entity<Factura>()
				.HasOne(f => f.Pedidos)
				.WithOne()
				.HasForeignKey<Factura>(f => f.IdPedido)
				.OnDelete(DeleteBehavior.Restrict);

			// Relación Pedidos (1) -> DetallesPedidos (N)
			modelBuilder.Entity<DetallePedido>()
				.HasOne(dp => dp.Pedidos)
				.WithMany(p => p.DetallesPedidos)
				.HasForeignKey(dp => dp.IdPedido)
				.OnDelete(DeleteBehavior.Restrict);

			// Relación Productos (1) -> DetallesPedidos (N)
			modelBuilder.Entity<DetallePedido>()
				.HasOne(dp => dp.Productos)
				.WithMany(pr => pr.DetallesPedidos)
				.HasForeignKey(dp => dp.IdProducto)
				.OnDelete(DeleteBehavior.Restrict);
		}
	}
}
