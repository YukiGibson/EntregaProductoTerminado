using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaProductoTerminado.Repositories
{
    interface IRepository<TEntity> where TEntity : class
    {
        TEntity GetByOp(int? OP);
        IQueryable<TEntity> Entity();
        void Add(TEntity entity);
        void Delete(TEntity entity);

        string Update(TEntity entity, int? OP);
        void Save();
    }
}
