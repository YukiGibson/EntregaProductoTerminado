using System;
using System.Collections.Generic;
using System.Linq;
using EntregaProductoTerminado.Models;
using EntregaProductoTerminado.DAL;
using EntregaProductoTerminado.ViewModels;
using System.Data.Entity.SqlServer;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;


namespace EntregaProductoTerminado.Repositories
{
    class SapRepository : IRepository<OrdenDeProduccion>, IDisposable
    {
        private DataContext _dataContext;
        public SapRepository()
        {
            this._dataContext = new DataContext();
        }
        public IQueryable<OrdenDeProduccion> Entity()
        {
            return null;
        }
        //Create
        public void Add(OrdenDeProduccion entity)
        {
            //Read-Only, so no adding
            throw new NotImplementedException();
        }
        //Delete
        public void Delete(OrdenDeProduccion entity)
        {
            //Read-Only, so not deleting
            throw new NotImplementedException();
        }
        //Read
        public OrdenDeProduccion GetByOp(int? OP)
        {
            DiboRepository dibo = new DiboRepository();
            var sapQuery = (from INV in _dataContext.INV1.Where(o => o.U_OrdenProd == OP)
                    group new
                    {
                        INV
                    } 
                    by new
                    {
                        INV.U_OrdenProd,
                        INV.BaseAtCard,
                        INV.SWW,
                        INV.GrossBase,
                    } into GroupDibo
                    select new OrdenDeProduccion()
                    {
                        NumeroOrdenProduccion = (int)GroupDibo.Key.U_OrdenProd,
                        Cliente = "",
                        OrdenDeCompra = GroupDibo.Key.BaseAtCard,
                        CodProductoInterno = GroupDibo.Key.SWW,
                        TotalEnSistema = (double)GroupDibo.Sum(p => p.INV.Quantity),
                        PorcentajeTolerancia = GroupDibo.Key.GrossBase,
                        FechaIngreso = SqlFunctions.GetDate(),
                        MaximoAceptadoPorCliente = (double)GroupDibo.Sum(p => p.INV.BaseOpnQty),
                        Bultos = 0,
                        UnidadesPorBulto = 0,
                        Fraccion = 0,
                        TotalCalculado = 0,
                        Excedente = 0
                    }).FirstOrDefault();

            var diboQuery = dibo.GetDibo.OrdenDeProduccion.Where(p => p.NumeroOrdenProduccion == sapQuery.NumeroOrdenProduccion).SingleOrDefault();
            if (diboQuery != null)
            {
                sapQuery.Bultos = diboQuery.Bultos;
                sapQuery.UnidadesPorBulto = diboQuery.UnidadesPorBulto;
                sapQuery.Fraccion = diboQuery.Fraccion;
                sapQuery.TotalCalculado = diboQuery.TotalCalculado;
                sapQuery.Excedente = diboQuery.Excedente;
            }

            dibo.Dispose();
            return sapQuery;
        }
        public string Update(OrdenDeProduccion entity, int? OP)
        {
            throw new NotImplementedException();
        }
        public void Save()
        {
            //Not Used 
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            ((IDisposable)_dataContext).Dispose();
        }
    }
}
