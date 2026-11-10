
using Microsoft.EntityFrameworkCore;
using SistemaRestaurante.Data;
using SistemaRestaurante.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaRestaurante.Service
{
    public class ReporteService
    {
        // ==========================================
        // 1. OBTENER PEDIDOS SEGÚN LOS FILTROS
        // ==========================================

        public List<ReportePedidoDto> ObtenerReporte(
            DateTime desde,
            DateTime hasta,
            string tipoPedido = "Todos",
            string estado = "Todos")
        {
            // Validar el rango de fechas
            if (desde.Date > hasta.Date)
            {
                throw new ArgumentException(
                    "La fecha inicial no puede ser mayor que la fecha final.");
            }

            // Validar el tipo de pedido
            if (!string.Equals(tipoPedido, "Todos",
                StringComparison.OrdinalIgnoreCase) &&
                !string.Equals(tipoPedido, "En mesa",
                StringComparison.OrdinalIgnoreCase) &&
                !string.Equals(tipoPedido, "Para llevar",
                StringComparison.OrdinalIgnoreCase))
            {
                throw new ArgumentException(
                    "El tipo de pedido seleccionado no es válido.");
            }

            // Validar el estado
            string[] estadosPermitidos =
            {
                "Todos",
                "Pendiente",
                "Facturado",
                "Cancelado"
            };

            if (!estadosPermitidos.Any(e =>
                string.Equals(e, estado?.Trim(),
                    StringComparison.OrdinalIgnoreCase)))
            {
                throw new ArgumentException(
                    "El estado seleccionado no es válido.");
            }

            // Preparar el rango de fechas
            DateTime inicio = desde.Date;
            DateTime fin = hasta.Date.AddDays(1);

            using var ctx = new RestauranteContext();

            // Consultar pedidos y cargar sus relaciones
            var consulta = ctx.Pedidos
                .AsNoTracking()
                .Include(p => p.Cliente)
                .Include(p => p.Empleado)
                .Include(p => p.Mesa)
                .Include(p => p.DetallesPedidos)
                .Include(p => p.Factura)
                .Where(p =>
                    p.Fecha >= inicio &&
                    p.Fecha < fin);

            // ==========================================
            // 2. FILTRAR POR TIPO DE PEDIDO
            // ==========================================

            if (string.Equals(tipoPedido, "En mesa",
                StringComparison.OrdinalIgnoreCase))
            {
                consulta = consulta.Where(p => p.IdMesa.HasValue);
            }
            else if (string.Equals(tipoPedido, "Para llevar",
                StringComparison.OrdinalIgnoreCase))
            {
                consulta = consulta.Where(p => !p.IdMesa.HasValue);
            }

            // ==========================================
            // 3. FILTRAR POR ESTADO
            // ==========================================

            if (!string.Equals(estado, "Todos",
                StringComparison.OrdinalIgnoreCase))
            {
                string estadoFiltro = estado.Trim();

                consulta = consulta.Where(p =>
                    p.Estado == estadoFiltro);
            }

            // ==========================================
            // 4. OBTENER RESULTADOS
            // ==========================================

            var pedidos = consulta
                .OrderByDescending(p => p.Fecha)
                .ToList();

            // ==========================================
            // 5. CONVERTIR LOS PEDIDOS A DTO
            // ==========================================

            List<ReportePedidoDto> resultado = pedidos
                .Select(p =>
                {
                    // Obtener el total de la factura si existe.
                    // Si todavía no está facturado, calcular
                    // el importe usando los detalles del pedido.
                    decimal total = p.Factura != null
                        ? p.Factura.Total
                        : p.DetallesPedidos.Sum(d =>
                            d.Cantidad * d.PrecioUnitario);

                    return new ReportePedidoDto
                    {
                        IdPedido = p.Id,

                        Fecha = p.Fecha,

                        Cliente = p.Cliente?.Nombre
                            ?? "Cliente general",

                        Empleado = p.Empleado?.Nombre
                            ?? "No asignado",

                        TipoPedido = p.IdMesa.HasValue
                            ? "En mesa"
                            : "Para llevar",

                        Estado = p.Estado,

                        CantidadProductos =
                            p.DetallesPedidos.Sum(d => d.Cantidad),

                        Total = total,

                        IdFactura = p.Factura?.Id
                    };
                })
                .ToList();

            return resultado;
        }
    }
}
