using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EntregaProductoTerminado.Models;
using EntregaProductoTerminado.DAL;

namespace EntregaProductoTerminado.Repositories
{
    public class MetricsRepository : IRepository<View_USR_M3_OrdAtividades>, IDisposable
    {
        private MetricsContext _metricsContext;

        public MetricsRepository()
        {
            _metricsContext = new MetricsContext();
        }

        public IQueryable<View_USR_M3_OrdAtividades> Entity()
        {
            throw new NotImplementedException();
        }

        public void Add(View_USR_M3_OrdAtividades entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(View_USR_M3_OrdAtividades entity)
        {
            throw new NotImplementedException();
        }

        public View_USR_M3_OrdAtividades GetByOp(int? OP)
        {
            string OrdenP = OP.ToString();
            var ordAtividades = _metricsContext.View_USR_M3_OrdAtividades.Where(p => p.NumOrdem.Equals(OrdenP))
                .FirstOrDefault();
            return ordAtividades;
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public string Update(View_USR_M3_OrdAtividades entity, int? OP)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _metricsContext.Dispose();
        }
    }
}