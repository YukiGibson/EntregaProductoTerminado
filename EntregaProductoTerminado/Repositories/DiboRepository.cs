using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EntregaProductoTerminado.Models;
using EntregaProductoTerminado.DAL;

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

        public IQueryable<OrdenDeProduccion> Entity()
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
        public OrdenDeProduccion GetByOp(int? OP)
        {
            var test = _diboContext.OrdenDeProduccion.Where(p => p.NumeroOrdenProduccion == OP).FirstOrDefault();
            return test;
        }
        public bool Exists(int OP)
        {

            return _diboContext.OrdenDeProduccion.Any(p => p.NumeroOrdenProduccion == OP);
        }
        public string Update(OrdenDeProduccion entity, int? OP)
        {
            var lineToUpdate = _diboContext.OrdenDeProduccion.Where(o => o.NumeroOrdenProduccion == OP).FirstOrDefault();
            int? sumResult = lineToUpdate.TotalCalculado + entity.TotalCalculado;
            lineToUpdate.Bultos += entity.Bultos;
            lineToUpdate.UnidadesPorBulto = entity.UnidadesPorBulto;
            lineToUpdate.Fraccion += entity.Fraccion;
            if (sumResult > lineToUpdate.TotalEnSistema)
            {
                lineToUpdate.Excedente = sumResult - (int?)lineToUpdate.TotalEnSistema;
                // If there is a necessity to send an e-mail por excedente, then use it here
            }
            else
            {
                lineToUpdate.Excedente = 0;
            }
            lineToUpdate.TotalCalculado += (entity.TotalCalculado - lineToUpdate.Excedente);
            return "Los valores han sido actualizados en el sistema de forma correcta, ha sido enviado un correo a los encargados" +
                " de producto terminado";
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