
using Microsoft.EntityFrameworkCore;
using SistemaRestaurante.Data;
using SistemaRestaurante.Dtos;
using SistemaRestaurante.Models;
using System;
using System.Linq;

namespace SistemaRestaurante.Service
{
    public class FacturaService
    {
        // ==========================================
        // 1. OBTENER UN PEDIDO PARA FACTURAR
        // ==========================================
        public FacturaDto ObtenerPedidoParaFacturar(int idPedido)
        {
            if (idPedido <= 0)
                throw new ArgumentException(
                    "El pedido no es válido.");

            using var ctx = new RestauranteContext();

            // Buscar pedido y cargar sus relaciones
            var pedido = ctx.Pedidos
                .AsNoTracking()
                .Include(p => p.Cliente)
                .Include(p => p.Empleado)
                .Include(p => p.Mesa)
                .Include(p => p.DetallesPedidos)
                    .ThenInclude(d => d.Productos)
                .FirstOrDefault(p => p.Id == idPedido);

            if (pedido == null)
                throw new InvalidOperationException(
                    "No se encontró el pedido seleccionado.");

            // Buscar factura existente
            var facturaExistente = ctx.Facturas
                .AsNoTracking()
                .FirstOrDefault(f => f.IdPedido == idPedido);

            // Comprobar si está cancelado
            if (facturaExistente == null &&
                string.Equals(
                    pedido.Estado,
                    "Cancelado",
                    StringComparison.OrdinalIgnoreCase))
            {
                throw new InvalidOperationException(
                    "No se puede facturar un pedido cancelado.");
            }

            // Comprobar inconsistencias en el estado
            if (facturaExistente == null &&
                string.Equals(
                    pedido.Estado,
                    "Facturado",
                    StringComparison.OrdinalIgnoreCase))
            {
                throw new InvalidOperationException(
                    "El pedido está marcado como facturado, pero no tiene una factura registrada.");
            }

            // Comprobar que existan productos
            if (pedido.DetallesPedidos.Count == 0)
                throw new InvalidOperationException(
                    "El pedido no contiene productos.");

            // Convertir la información a DTO
            return ConvertirADto(facturaExistente, pedido);
        }

        // ==========================================
        // 2. CREAR Y REGISTRAR UNA FACTURA
        // ==========================================
        public FacturaDto CrearFactura(
            int idPedido,
            string metodoPago,
            decimal descuento = 0m)
        {
            // Validar ID
            if (idPedido <= 0)
                throw new ArgumentException(
                    "El pedido no es válido.");

            // Validar método de pago
            if (string.IsNullOrWhiteSpace(metodoPago))
                throw new ArgumentException(
                    "Debe seleccionar un método de pago.");

            metodoPago = metodoPago.Trim();

            if (metodoPago.Length > 20)
                throw new ArgumentException(
                    "El método de pago es demasiado largo.");

            using var ctx = new RestauranteContext();

            // Recuperar pedido
            var pedido = ctx.Pedidos
                .Include(p => p.Cliente)
                .Include(p => p.Empleado)
                .Include(p => p.Mesa)
                .Include(p => p.DetallesPedidos)
                    .ThenInclude(d => d.Productos)
                .FirstOrDefault(p => p.Id == idPedido);

            if (pedido == null)
                throw new InvalidOperationException(
                    "El pedido no existe.");

            // Comprobar estado del pedido
            if (string.Equals(
                pedido.Estado,
                "Cancelado",
                StringComparison.OrdinalIgnoreCase))
            {
                throw new InvalidOperationException(
                    "No se puede facturar un pedido cancelado.");
            }

            // Comprobar si ya existe una factura
            bool yaFacturado = ctx.Facturas
                .Any(f => f.IdPedido == idPedido);

            if (yaFacturado)
                throw new InvalidOperationException(
                    "Este pedido ya tiene una factura registrada.");

            // Comprobar estado inconsistente
            if (string.Equals(
                pedido.Estado,
                "Facturado",
                StringComparison.OrdinalIgnoreCase))
            {
                throw new InvalidOperationException(
                    "El pedido está marcado como facturado, pero no tiene una factura registrada.");
            }

            // Comprobar productos
            if (pedido.DetallesPedidos.Count == 0)
                throw new InvalidOperationException(
                    "El pedido no contiene productos.");

            // Validar cantidades y precios
            if (pedido.DetallesPedidos.Any(d =>
                d.Cantidad <= 0 || d.PrecioUnitario < 0))
            {
                throw new InvalidOperationException(
                    "Hay cantidades o precios inválidos en el pedido.");
            }

            // Calcular subtotal
            decimal subtotal = pedido.DetallesPedidos.Sum(d =>
                d.Cantidad * d.PrecioUnitario);

            // Validar descuento
            if (descuento < 0 || descuento > subtotal)
                throw new ArgumentException(
                    "El descuento no puede ser negativo ni superar el subtotal.");

            // Calcular total
            decimal total = subtotal - descuento;

            // Crear entidad Factura
            var factura = new Factura
            {
                IdPedido = pedido.Id,
                FechaEmision = DateTime.Now,
                Subtotal = subtotal,
                Descuento = descuento,
                Total = total,
                MetodoPago = metodoPago
            };

            // Agregar factura
            ctx.Facturas.Add(factura);

            // Actualizar estado del pedido
            pedido.Estado = "Facturado";

            // Guardar los cambios
            ctx.SaveChanges();

            // Devolver factura organizada en DTO
            return ConvertirADto(factura, pedido);
        }

        // ==========================================
        // 3. OBTENER UNA FACTURA EXISTENTE
        // ==========================================
        public FacturaDto ObtenerFacturaPorPedido(int idPedido)
        {
            FacturaDto factura =
                ObtenerPedidoParaFacturar(idPedido);

            if (!factura.YaRegistrada)
                throw new InvalidOperationException(
                    "Este pedido todavía no tiene una factura registrada.");

            return factura;
        }

        // ==========================================
        // 4. CONVERTIR ENTIDADES A DTO
        // ==========================================
        private FacturaDto ConvertirADto(
            Factura? factura,
            Pedido pedido)
        {
            // Calcular subtotal si todavía no existe factura
            decimal subtotal = factura?.Subtotal ??
                pedido.DetallesPedidos.Sum(d =>
                    d.Cantidad * d.PrecioUnitario);

            return new FacturaDto
            {
                IdFactura = factura?.Id ?? 0,

                IdPedido = pedido.Id,

                FechaEmision = factura?.FechaEmision
                    ?? DateTime.Now,

                FechaPedido = pedido.Fecha,

                // Cliente
                Cliente = pedido.Cliente?.Nombre
                    ?? "Cliente general",

                // Empleado
                Empleado = pedido.Empleado?.Nombre
                    ?? "No asignado",

                // Mesa
                Mesa = pedido.Mesa != null
                    ? $"Mesa {pedido.Mesa.Numero}"
                    : "Para llevar",

                // Método de pago
                MetodoPago = factura?.MetodoPago
                    ?? string.Empty,

                // Totales
                Subtotal = subtotal,

                Descuento = factura?.Descuento ?? 0m,

                Total = factura?.Total ?? subtotal,

                // Estado de facturación
                YaRegistrada = factura != null,

                // Productos
                Detalles = pedido.DetallesPedidos.Select(d =>
                    new DetalleFacturaDto
                    {
                        IdProducto = d.IdProducto,

                        NombreProducto =
                            d.Productos?.Nombre ?? "Producto",

                        Cantidad = d.Cantidad,

                        PrecioUnitario = d.PrecioUnitario

                    }).ToList()
            };
        }
    }
}
