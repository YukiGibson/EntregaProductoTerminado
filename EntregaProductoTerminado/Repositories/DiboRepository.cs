using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EntregaProductoTerminado.DAL;
using EntregaProductoTerminado.Models;
using EntregaProductoTerminado.ViewModels;

namespace EntregaProductoTerminado.Repositories
{
    public class DiboRepository : IRepository<OrdenDeProduccion>, IDisposable
    {
        private DiboContext _diboContext;

        public DiboRepository()
        {
            this._diboContext = new DiboContext();
        }

        public DiboContext GetDibo { get { return _diboContext; } }

        public List<OrdenDeProduccion> OrdenList(HistorialProductoTerminadoViewModel historial)
        {
            List<OrdenDeProduccion> ordersByOP = new List<OrdenDeProduccion>();
            ordersByOP = _diboContext.OrdenDeProduccion.Where(o => o.FechaIngreso >= historial.fechaInicio &&
            o.FechaIngreso <= historial.fechaFin).ToList();
            if (!String.IsNullOrEmpty(historial.historialInput))
            {
                ordersByOP = ordersByOP.Where(p =>
                p.NumeroOrdenProduccion.ToLower().Contains(historial.historialInput.ToLower()) ||
                p.Cliente.ToLower().Contains(historial.historialInput.ToLower())).ToList();
            }
            return ordersByOP;
        }

        public List<OrdenDeProduccion> Consult(string OP)
        {
            var ordersByOP = _diboContext.OrdenDeProduccion.Where(p =>
            p.NumeroOrdenProduccion.Equals(OP) ||
            p.Cliente.Equals(OP)).ToList();
            return ordersByOP;
        }

        public IQueryable<OrdenDeProduccion> GetEntity()
        {
            return _diboContext.OrdenDeProduccion;
        }
        //Create
        public void Add(OrdenDeProduccion entity)
        {
            _diboContext.OrdenDeProduccion.Add(entity);
        }
        //Delete
        public void Delete(OrdenDeProduccion entity)
        {
            _diboContext.OrdenDeProduccion.Remove(entity);
        }
        //Read
        public OrdenDeProduccion GetByOp(string OP)
        {
            OrdenDeProduccion getOrden = _diboContext.OrdenDeProduccion.
                Where(p => p.NumeroOrdenProduccion == OP).FirstOrDefault();
            return getOrden;
        }
        public bool Exists(string OP)
        {
            return _diboContext.OrdenDeProduccion.Any(p => p.NumeroOrdenProduccion == OP);
        }

        /// <summary>
        ///Ingresa una nueva linea de bultos tomando en cuenta la cantidad anterior
        ///en conjunto con el excedente.
        /// </summary>
        /// <param name="entity"></param>
        public void Update(OrdenDeProduccion entity)
        {
            int? sumaDeIngresos = (_diboContext.OrdenDeProduccion
                .Where(o => o.NumeroOrdenProduccion == entity.NumeroOrdenProduccion)
                .Sum(o => o.TotalCalculado) + entity.TotalCalculado);

            int? sumaExcedentes = _diboContext.OrdenDeProduccion.Where(o => o.NumeroOrdenProduccion
            == entity.NumeroOrdenProduccion).Sum(o => o.Excedente);

            entity.Entregas = (byte)(_diboContext.OrdenDeProduccion.Where(o => o.NumeroOrdenProduccion 
            == entity.NumeroOrdenProduccion).Select(p => p.Entregas).Max() + 1);

            if (sumaDeIngresos > entity.MaximoAceptadoPorCliente)
            {
                entity.Excedente = (sumaDeIngresos - entity.MaximoAceptadoPorCliente) - 
                    (sumaExcedentes ?? 0 );
                // If there is a necessity to send an e-mail por excedente, then use it here
            }
            Add(entity);
        }
        public void Save()
        {
            _diboContext.SaveChanges();
        }

        public void Dispose()
        {
            ((IDisposable)_diboContext).Dispose();
        }
    }
}