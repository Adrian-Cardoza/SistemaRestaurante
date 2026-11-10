using System;
using System.Collections.Generic;
using System.Text;
using SistemaRestaurante.Dtos;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace SistemaRestaurante.Reportes
{
    public class FacturaDocument : IDocument
    {
        // Información de la factura
        private readonly FacturaDto _factura;

        // Constructor
        public FacturaDocument(FacturaDto factura)
        {
            _factura = factura
                ?? throw new ArgumentNullException(nameof(factura));
        }

        // Metadatos del documento
        public DocumentMetadata GetMetadata()
        {
            return DocumentMetadata.Default;
        }

        // Estructura principal del PDF
        public void Compose(IDocumentContainer container)
        {
            container.Page(page =>
            {
                // Configuración de página
                page.Size(PageSizes.Letter);
                page.Margin(30);

                page.DefaultTextStyle(x =>
                    x.FontSize(10).FontFamily("Lato"));

                // Encabezado
                page.Header().Element(ComponerEncabezado);

                // Contenido
                page.Content().Element(ComponerContenido);

                // Pie de página
                page.Footer().Element(ComponerPie);
            });
        }

        // ==========================================
        // 1. ENCABEZADO DE LA FACTURA
        // ==========================================
        private void ComponerEncabezado(IContainer container)
        {
            container.Column(col =>
            {
                col.Item().Row(row =>
                {
                    // Información del restaurante
                    row.RelativeItem().Column(c =>
                    {
                        c.Item()
                            .Text("RESTOSYS")
                            .FontSize(22)
                            .Bold()
                            .FontColor("#1B3A5C");

                        c.Item()
                            .Text("Sistema de Gestión de Restaurante")
                            .FontSize(10);

                        c.Item()
                            .Text("COMPROBANTE DE CONSUMO")
                            .FontSize(9)
                            .SemiBold();
                    });

                    // Información de la factura
                    row.ConstantItem(180)
                        .AlignRight()
                        .Column(c =>
                        {
                            c.Item()
                                .AlignRight()
                                .Text("FACTURA")
                                .FontSize(18)
                                .Bold()
                                .FontColor("#1B3A5C");

                            c.Item()
                                .AlignRight()
                                .Text(_factura.NumeroFactura)
                                .Bold();

                            c.Item()
                                .AlignRight()
                                .Text($"Fecha: {_factura.FechaEmision:dd/MM/yyyy}");

                            c.Item()
                                .AlignRight()
                                .Text($"Pedido: {_factura.IdPedido}");
                        });
                });

                // Línea divisoria
                col.Item()
                    .PaddingTop(10)
                    .LineHorizontal(1.5f)
                    .LineColor("#2E6DA4");
            });
        }

        // ==========================================
        // 2. CONTENIDO DE LA FACTURA
        // ==========================================
        private void ComponerContenido(IContainer container)
        {
            container.PaddingVertical(15).Column(col =>
            {
                // Información del cliente
                col.Item()
                    .Text("DATOS DEL CLIENTE")
                    .FontSize(12)
                    .Bold()
                    .FontColor("#1B3A5C");

                col.Item().PaddingTop(8).Row(row =>
                {
                    row.RelativeItem().Column(c =>
                    {
                        c.Item().Text($"Cliente: {_factura.Cliente}");
                    });

                    row.RelativeItem().Column(c =>
                    {
                        c.Item().Text($"Empleado: {_factura.Empleado}");
                        c.Item().Text($"Mesa: {_factura.Mesa}");
                        c.Item().Text($"Método de pago: {_factura.MetodoPago}");
                    });
                });

                // Detalle de productos
                col.Item()
                    .PaddingTop(20)
                    .Text("DETALLE DE PRODUCTOS")
                    .FontSize(12)
                    .Bold()
                    .FontColor("#1B3A5C");

                // Tabla de productos
                col.Item().PaddingTop(8).Table(table =>
                {
                    // Definición de columnas
                    table.ColumnsDefinition(columns =>
                    {
                        columns.RelativeColumn(4);     // Producto
                        columns.RelativeColumn(1);     // Cantidad
                        columns.RelativeColumn(1.5f);  // Precio
                        columns.RelativeColumn(1.5f);  // Importe
                    });

                    // Encabezados
                    table.Header(header =>
                    {
                        header.Cell()
                            .Element(CeldaTitulo)
                            .Text("Producto");

                        header.Cell()
                            .Element(CeldaTitulo)
                            .AlignRight()
                            .Text("Cant.");

                        header.Cell()
                            .Element(CeldaTitulo)
                            .AlignRight()
                            .Text("Precio");

                        header.Cell()
                            .Element(CeldaTitulo)
                            .AlignRight()
                            .Text("Importe");
                    });

                    // Productos de la factura
                    if (_factura.Detalles != null)
                    {
                        for (int i = 0; i < _factura.Detalles.Count; i++)
                        {
                            var detalle = _factura.Detalles[i];

                            string fondo = i % 2 == 0
                                ? "#FFFFFF"
                                : "#EEF5FC";

                            IContainer Celda() =>
                                table.Cell().Element(c =>
                                    CeldaDato(c, fondo));

                            Celda().Text(detalle.NombreProducto);

                            Celda()
                                .AlignRight()
                                .Text(detalle.Cantidad.ToString());

                            Celda()
                                .AlignRight()
                                .Text($"${detalle.PrecioUnitario:N2}");

                            Celda()
                                .AlignRight()
                                .Text($"${detalle.Importe:N2}");
                        }
                    }
                });

                // Resumen de la factura
                col.Item()
                    .PaddingTop(15)
                    .AlignRight()
                    .Column(resumen =>
                    {
                        resumen.Item()
                            .Text($"Subtotal: ${_factura.Subtotal:N2}")
                            .AlignRight();

                        resumen.Item()
                            .Text($"Descuento: ${_factura.Descuento:N2}")
                            .AlignRight();

                        resumen.Item()
                            .PaddingTop(5)
                            .Text($"TOTAL: ${_factura.Total:N2}")
                            .FontSize(16)
                            .Bold()
                            .FontColor("#1B3A5C")
                            .AlignRight();
                    });

                // Mensaje final
                col.Item()
                    .PaddingTop(30)
                    .AlignCenter()
                    .Text("¡Gracias por su preferencia!")
                    .FontSize(12)
                    .Bold()
                    .FontColor("#2E6DA4");
            });
        }

        // ==========================================
        // 3. ESTILO DE LOS ENCABEZADOS DE TABLA
        // ==========================================
        private static IContainer CeldaTitulo(IContainer container)
        {
            return container
                .Background("#1B3A5C")
                .Padding(6)
                .DefaultTextStyle(x => x
                    .FontColor("#FFFFFF")
                    .Bold());
        }

        // ==========================================
        // 4. ESTILO DE LAS CELDAS DE INFORMACIÓN
        // ==========================================
        private static IContainer CeldaDato(
            IContainer container,
            string fondo)
        {
            return container
                .Background(fondo)
                .BorderBottom(0.5f)
                .BorderColor("#D0D0D0")
                .Padding(6);
        }

        // ==========================================
        // 5. PIE DE PÁGINA
        // ==========================================
        private void ComponerPie(IContainer container)
        {
            container.Column(col =>
            {
                col.Item()
                    .LineHorizontal(0.5f)
                    .LineColor("#2E6DA4");

                col.Item()
                    .PaddingTop(5)
                    .Row(row =>
                    {
                        row.RelativeItem()
                            .DefaultTextStyle(x => x.FontSize(8))
                            .Text("RestoSys | Gracias por visitarnos");

                        row.RelativeItem()
                            .AlignRight()
                            .DefaultTextStyle(x => x.FontSize(8))
                            .Text(text =>
                            {
                                text.Span("Página ");
                                text.CurrentPageNumber();
                                text.Span(" de ");
                                text.TotalPages();
                            });
                    });
            });
        }
    }
}
