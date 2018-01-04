using System;
using System.Linq;
using EntregaProductoTerminado.Models;
using EntregaProductoTerminado.DAL;
using System.Data.SqlClient;

namespace EntregaProductoTerminado.Repositories
{
    public class MetricsRepository : IRepository<OrdenDeProduccion>, IDisposable
    {
        private MetricsContext _metricsContext;

        public MetricsRepository()
        {
            _metricsContext = new MetricsContext();
        }

        public IQueryable<OrdenDeProduccion> GetEntity()
        {
            throw new NotImplementedException();
        }

        public void Add(OrdenDeProduccion entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(OrdenDeProduccion entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Obtiene una OP por propiedad de OP
        /// </summary>
        /// <param name="OP">Numero de la orden de produccion</param>
        /// <returns></returns>
        public OrdenDeProduccion GetByOp(string OP)
        {
            DiboRepository dibo = new DiboRepository();
            if (_metricsContext.A_Vista_OConversion_Reserva.Where(p => p.NumOrdem
            .Equals(OP.Trim())).Any())
            {
                SqlParameter OrdenDeProduccion = new SqlParameter("@OrdenDeProduccion",
                    OP.Trim());
                OrdenDeProduccion produccion = _metricsContext.Database.SqlQuery<OrdenDeProduccion>
               ("PTSearchByOP @OrdenDeProduccion", OrdenDeProduccion).FirstOrDefault();

                var diboQuery = dibo.GetDibo.OrdenDeProduccion.Where(p => p.NumeroOrdenProduccion.ToString()
                .Equals(OP)).GroupBy(o => new
                {
                    o.NumeroOrdenProduccion
                }).Select(i => new {
                    Bultos = i.Sum(g => g.Bultos),
                    TotalCalculado = i.Sum(g => g.TotalCalculado),
                    Excedente = i.Sum(g => g.Excedente),
                    Fraccion = i.Sum(g => g.Fraccion)
                    }).SingleOrDefault();

                if (diboQuery != null)
                {
                    produccion.Bultos = diboQuery.Bultos;
                    produccion.Fraccion = diboQuery.Fraccion;
                    produccion.TotalCalculado = diboQuery.TotalCalculado;
                    produccion.Excedente = diboQuery.Excedente;
                }
                dibo.Dispose();
                return produccion;
            }
            dibo.Dispose();
            return null;
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(OrdenDeProduccion entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _metricsContext.Dispose();
        }
    }
}