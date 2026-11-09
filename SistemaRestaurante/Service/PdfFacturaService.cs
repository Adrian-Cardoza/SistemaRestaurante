using System;
using System.IO;
using SistemaRestaurante.Dtos;
using SistemaRestaurante.Reportes;
using QuestPDF.Fluent;

namespace SistemaRestaurante.Service
{
    public class PdfFacturaService
    {
        // Generar el archivo PDF de una factura
        public string GenerarPdf(
            FacturaDto factura,
            string rutaArchivo)
        {
            // Comprobar que exista una factura
            if (factura == null)
            {
                throw new ArgumentNullException(
                    nameof(factura),
                    "No se ha proporcionado una factura.");
            }

            // Validar la ruta donde se guardará el PDF
            if (string.IsNullOrWhiteSpace(rutaArchivo))
            {
                throw new ArgumentException(
                    "Debe indicar una ubicación para guardar el PDF.");
            }

            // Comprobar que la factura tenga productos
            if (factura.Detalles == null ||
                factura.Detalles.Count == 0)
            {
                throw new InvalidOperationException(
                    "No se puede generar una factura sin productos.");
            }

            // Comprobar que la extensión sea PDF
            if (!string.Equals(
                Path.GetExtension(rutaArchivo),
                ".pdf",
                StringComparison.OrdinalIgnoreCase))
            {
                throw new ArgumentException(
                    "El archivo debe tener formato PDF.");
            }

            // Crear el documento con los datos de la factura
            var documento = new FacturaDocument(factura);

            // Generar y guardar el archivo PDF
            documento.GeneratePdf(rutaArchivo);

            // Devolver la ubicación del archivo generado
            return rutaArchivo;
        }
    }
}
