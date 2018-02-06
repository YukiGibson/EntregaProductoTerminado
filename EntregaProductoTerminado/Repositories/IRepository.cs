using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaProductoTerminado.Repositories
{
    interface IRepository<TEntity> where TEntity : class
    {
        TEntity GetByOp(string OP);
        IQueryable<TEntity> GetEntity();
        void Add(TEntity entity);
        void Delete(TEntity entity);

        void Update(TEntity entity);
        void Save();
    }
}
