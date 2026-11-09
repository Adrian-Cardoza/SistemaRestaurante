using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaRestaurante.Dtos
{
    public class DetalleFacturaDto
    {
        public int IdProducto { get; set; }

        public string NombreProducto { get; set; }
            = string.Empty;

        public int Cantidad { get; set; }

        public decimal PrecioUnitario { get; set; }

        // Importe = Cantidad × Precio unitario
        public decimal Importe =>
            Cantidad * PrecioUnitario;
    }
}
