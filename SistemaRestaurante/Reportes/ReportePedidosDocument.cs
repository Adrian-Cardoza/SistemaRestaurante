
using System;
using System.Collections.Generic;
using System.Linq;
using SistemaRestaurante.Dtos;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace SistemaRestaurante.Reportes
{
    public class ReportePedidosDocument : IDocument
    {
        // ==========================================
        // 1. INFORMACIÓN DEL REPORTE
        // ==========================================

        private readonly List<ReportePedidoDto> _pedidos;
        private readonly DateTime _desde;
        private readonly DateTime _hasta;
        private readonly string _tipoPedido;
        private readonly string _estado;
        private readonly string _usuario;

        // Constructor
        public ReportePedidosDocument(
            List<ReportePedidoDto> pedidos,
            DateTime desde,
            DateTime hasta,
            string tipoPedido,
            string estado,
            string usuario)
        {
            _pedidos = pedidos
                ?? throw new ArgumentNullException(nameof(pedidos));

            _desde = desde;
            _hasta = hasta;
            _tipoPedido = tipoPedido;
            _estado = estado;
            _usuario = string.IsNullOrWhiteSpace(usuario)
                ? "Usuario del sistema"
                : usuario;
        }

        // Metadatos
        public DocumentMetadata GetMetadata()
        {
            return DocumentMetadata.Default;
        }

        // ==========================================
        // 2. ESTRUCTURA PRINCIPAL DEL DOCUMENTO
        // ==========================================

        public void Compose(IDocumentContainer container)
        {
            container.Page(page =>
            {
                // Página horizontal para permitir más columnas
                page.Size(PageSizes.Letter.Landscape());

                page.Margin(30);

                // Utilizamos Lato para evitar errores de fuentes
                page.DefaultTextStyle(x =>
                    x.FontSize(9).FontFamily("Lato"));

                // Encabezado
                page.Header().Element(ComponerEncabezado);

                // Contenido
                page.Content().Element(ComponerContenido);

                // Pie de página
                page.Footer().Element(ComponerPie);
            });
        }

        // ==========================================
        // 3. ENCABEZADO DEL REPORTE
        // ==========================================

        private void ComponerEncabezado(IContainer container)
        {
            container.Column(col =>
            {
                col.Item().Row(row =>
                {
                    // Nombre y título
                    row.RelativeItem().Column(c =>
                    {
                        c.Item()
                            .Text("RESTOSYS")
                            .FontSize(22)
                            .Bold()
                            .FontColor("#1B3A5C");

                        c.Item()
                            .Text("REPORTE GENERAL DE PEDIDOS")
                            .FontSize(12)
                            .SemiBold();

                        c.Item()
                            .Text("Sistema de Gestión de Restaurante")
                            .FontSize(9)
                            .FontColor("#666666");
                    });

                    // Información de generación
                    row.ConstantItem(190)
                        .AlignRight()
                        .Column(c =>
                        {
                            c.Item()
                                .AlignRight()
                                .Text("INFORMACIÓN DEL REPORTE")
                                .Bold()
                                .FontColor("#1B3A5C");

                            c.Item()
                                .AlignRight()
                                .Text($"Generado: {DateTime.Now:dd/MM/yyyy HH:mm}");

                            c.Item()
                                .AlignRight()
                                .Text($"Usuario: {_usuario}");
                        });
                });

                // Parámetros de búsqueda
                col.Item().PaddingTop(12).Row(row =>
                {
                    row.RelativeItem().Text(
                        $"Período: {_desde:dd/MM/yyyy} al {_hasta:dd/MM/yyyy}");

                    row.RelativeItem().Text(
                        $"Tipo de pedido: {_tipoPedido}");

                    row.RelativeItem().Text(
                        $"Estado: {_estado}");
                });

                // Línea divisoria
                col.Item()
                    .PaddingTop(8)
                    .LineHorizontal(1.5f)
                    .LineColor("#2E6DA4");
            });
        }

        // ==========================================
        // 4. CONTENIDO DEL REPORTE
        // ==========================================

        private void ComponerContenido(IContainer container)
        {
            container.PaddingVertical(12).Column(col =>
            {
                col.Item()
                    .Text("DETALLE DE PEDIDOS")
                    .FontSize(12)
                    .Bold()
                    .FontColor("#1B3A5C");

                if (_pedidos.Count == 0)
                {
                    col.Item()
                        .PaddingTop(20)
                        .Background("#EEF5FC")
                        .Padding(15)
                        .AlignCenter()
                        .Text("No se encontraron pedidos con los filtros seleccionados.")
                        .FontSize(11)
                        .FontColor("#666666");
                }
                else
                {
                    // Tabla de resultados
                    col.Item().PaddingTop(10).Table(table =>
                    {
                        // Definir columnas
                        table.ColumnsDefinition(columns =>
                        {
                            columns.ConstantColumn(48);    // Pedido
                            columns.ConstantColumn(85);    // Fecha
                            columns.RelativeColumn(2);     // Cliente
                            columns.RelativeColumn(1.6f);  // Empleado
                            columns.ConstantColumn(75);    // Tipo
                            columns.ConstantColumn(75);    // Estado
                            columns.ConstantColumn(55);    // Unidades
                            columns.ConstantColumn(85);    // Factura
                            columns.ConstantColumn(75);    // Total
                        });

                        // Encabezados de la tabla
                        table.Header(header =>
                        {
                            header.Cell().Element(CeldaTitulo).Text("N.º");
                            header.Cell().Element(CeldaTitulo).Text("Fecha");
                            header.Cell().Element(CeldaTitulo).Text("Cliente");
                            header.Cell().Element(CeldaTitulo).Text("Empleado");
                            header.Cell().Element(CeldaTitulo).Text("Tipo");
                            header.Cell().Element(CeldaTitulo).Text("Estado");
                            header.Cell().Element(CeldaTitulo)
                                .AlignRight().Text("Unid.");
                            header.Cell().Element(CeldaTitulo).Text("Factura");
                            header.Cell().Element(CeldaTitulo)
                                .AlignRight().Text("Total");
                        });

                        // Filas de resultados
                        for (int i = 0; i < _pedidos.Count; i++)
                        {
                            var pedido = _pedidos[i];

                            string fondo = i % 2 == 0
                                ? "#FFFFFF"
                                : "#EEF5FC";

                            IContainer Celda() =>
                                table.Cell().Element(c =>
                                    CeldaDato(c, fondo));

                            Celda().Text(pedido.IdPedido.ToString());

                            Celda().Text(
                                pedido.Fecha.ToString("dd/MM/yyyy"));

                            Celda().Text(pedido.Cliente);

                            Celda().Text(pedido.Empleado);

                            Celda().Text(pedido.TipoPedido);

                            Celda().Text(pedido.Estado);

                            Celda().AlignRight()
                                .Text(pedido.CantidadProductos.ToString());

                            Celda().Text(pedido.NumeroFactura);

                            Celda().AlignRight()
                                .Text($"${pedido.Total:N2}");
                        }
                    });

                    // ==========================================
                    // 5. RESUMEN DEL REPORTE
                    // ==========================================

                    int cantidadPedidos = _pedidos.Count;

                    int totalUnidades = _pedidos.Sum(
                        p => p.CantidadProductos);

                    decimal totalGeneral = _pedidos.Sum(
                        p => p.Total);

                    int pedidosFacturados = _pedidos.Count(
                        p => p.IdFactura.HasValue);

                    col.Item()
                        .PaddingTop(15)
                        .BorderTop(1)
                        .BorderColor("#D0D0D0")
                        .PaddingTop(10)
                        .AlignRight()
                        .Column(resumen =>
                        {
                            resumen.Item()
                                .Text($"Pedidos encontrados: {cantidadPedidos}")
                                .AlignRight();

                            resumen.Item()
                                .Text($"Unidades registradas: {totalUnidades}")
                                .AlignRight();

                            resumen.Item()
                                .Text($"Pedidos facturados: {pedidosFacturados}")
                                .AlignRight();

                            resumen.Item()
                                .PaddingTop(5)
                                .Text($"Total de pedidos: ${totalGeneral:N2}")
                                .FontSize(14)
                                .Bold()
                                .FontColor("#1B3A5C")
                                .AlignRight();
                        });
                }
            });
        }

        // ==========================================
        // 6. ESTILO DE ENCABEZADOS DE TABLA
        // ==========================================

        private static IContainer CeldaTitulo(IContainer container)
        {
            return container
                .Background("#1B3A5C")
                .Padding(5)
                .DefaultTextStyle(x =>
                    x.FontColor("#FFFFFF").Bold());
        }

        // ==========================================
        // 7. ESTILO DE CELDAS
        // ==========================================

        private static IContainer CeldaDato(
            IContainer container,
            string fondo)
        {
            return container
                .Background(fondo)
                .BorderBottom(0.5f)
                .BorderColor("#D0D0D0")
                .Padding(5);
        }

        // ==========================================
        // 8. PIE DE PÁGINA
        // ==========================================

        private void ComponerPie(IContainer container)
        {
            container.Column(col =>
            {
                col.Item()
                    .LineHorizontal(0.5f)
                    .LineColor("#2E6DA4");

                col.Item().PaddingTop(5).Row(row =>
                {
                    row.RelativeItem()
                        .DefaultTextStyle(x => x.FontSize(8))
                        .Text("RestoSys | Reporte de pedidos");

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
