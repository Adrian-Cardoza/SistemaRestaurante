using Microsoft.EntityFrameworkCore;
using SistemaRestaurante.Data;
using SistemaRestaurante.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaRestaurante.Service
{
    public class MesaService
    {
        // listar con filtro dinamico
        public List<Mesa> Listar(string filtro = "")

        {
            using var ctx = new RestauranteContext();
            IQueryable<Mesa> consulta = ctx.Mesas.AsNoTracking();
            if (!string.IsNullOrWhiteSpace(filtro))
            {
                filtro = filtro.Trim();
                // permite que busquemos por numero de mesa o estado de la mesa
                consulta = consulta.Where(m => m.Numero.ToString().Contains(filtro)
                || (m.Estado != null && m.Estado.Contains(filtro)));
            }
            return consulta.OrderBy(m => m.Numero).ToList();
        }

        // read (obtencion por id)
        public Mesa? ObtenerPorId(int Id)
        {
            using var ctx = new RestauranteContext();
            return ctx.Mesas.Find(Id);
        }

        // create
        public void Crear(Mesa mesa)
        {
            using var ctx = new RestauranteContext();
            Validar(ctx, mesa);

            ctx.Mesas.Add(mesa);
            ctx.SaveChanges();
        }

        // update 
        public void Actualizar(Mesa mesa)
        {
            using var ctx = new RestauranteContext();

            Mesa existente = ctx.Mesas.Find(mesa.Id)
                ?? throw new InvalidOperationException($"No se encontró la mesa con Id {mesa.Id}.");
            Validar(ctx, mesa);

            existente.Numero = mesa.Numero;
            existente.Capacidad = mesa.Capacidad;
            existente.Estado = mesa.Estado;

            ctx.SaveChanges();
        }

        // CAMBIAR ESTADO OPERATIVO (Disponible  Ocupada  Reservada)
        public void CambiarEstado(int idMesa, string nuevoEstado)
        {
            using var ctx = new RestauranteContext();

            Mesa mesa = ctx.Mesas.Find(idMesa)
                ?? throw new InvalidOperationException($"No se encontró la mesa con Id {idMesa}.");

            if (string.IsNullOrWhiteSpace(nuevoEstado))
                throw new InvalidOperationException("El nuevo estado no es válido.");

            mesa.Estado = nuevoEstado.Trim();
            ctx.SaveChanges();
        }


        // Reglas de negocio y validaciones 
        private static void Validar(RestauranteContext ctx, Mesa mesa)
        {
            if (mesa.Numero <= 0)
            {
                throw new InvalidOperationException("El número de la mesa debe ser mayor que cero.");
            }

            if (mesa.Capacidad <= 0)
            {
                throw new InvalidOperationException("La capacidad de la mesa debe ser de al menos 1 persona.");
            }

            if (string.IsNullOrWhiteSpace(mesa.Estado))
            {
                throw new InvalidOperationException("El estado de la mesa no puede estar vacío.");
            }

            mesa.Estado = mesa.Estado.Trim();

            // Verificación de duplicado
            bool duplicado = ctx.Mesas.Any(m => m.Numero == mesa.Numero && m.Id != mesa.Id);

            if (duplicado)
            {
                throw new InvalidOperationException($"Ya existe una mesa con el número {mesa.Numero}. No se permiten duplicados.");
            }
        }
    }
}
       
