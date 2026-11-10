using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaRestaurante.Dtos
{
    public class ReportePedidoDto
    {
        // Identificación del pedido
        public int IdPedido { get; set; }

        // Información general
        public DateTime Fecha { get; set; }

        public string Cliente { get; set; } = string.Empty;

        public string Empleado { get; set; } = string.Empty;

        // Tipo de pedido: En mesa o Para llevar
        public string TipoPedido { get; set; } = string.Empty;

        // Estado: Pendiente, Facturado o Cancelado
        public string Estado { get; set; } = string.Empty;

        // Cantidad total de unidades solicitadas
        public int CantidadProductos { get; set; }

        // Total del pedido
        public decimal Total { get; set; }

        // Identificación de la factura, si existe
        public int? IdFactura { get; set; }

        // Número de factura generado automáticamente
        public string NumeroFactura =>
            IdFactura.HasValue
                ? $"FAC-{IdFactura.Value:D6}"
                : "Sin factura";

    }
}
