using System;
using System.Collections.Generic;
using System.Text;


namespace SistemaRestaurante.Dtos
    {
        public class FacturaDto
        {
            // Información general
            public int IdFactura { get; set; }
            public int IdPedido { get; set; }

            public DateTime FechaEmision { get; set; }
            public DateTime FechaPedido { get; set; }

            // Número de factura
            public string NumeroFactura =>
                IdFactura > 0
                    ? $"FAC-{IdFactura:D6}"
                    : "PENDIENTE";

            // Información del cliente
            public string Cliente { get; set; } = string.Empty;

            // Información del empleado y mesa
            public string Empleado { get; set; } = string.Empty;
            public string Mesa { get; set; } = string.Empty;

            // Información del pago
            public string MetodoPago { get; set; } = string.Empty;

            // Totales
            public decimal Subtotal { get; set; }
            public decimal Descuento { get; set; }
            public decimal Total { get; set; }

            // Estado de la factura
            public bool YaRegistrada { get; set; }

            // Productos de la factura
            public List<DetalleFacturaDto> Detalles { get; set; }
                = new List<DetalleFacturaDto>();
        }
    }
