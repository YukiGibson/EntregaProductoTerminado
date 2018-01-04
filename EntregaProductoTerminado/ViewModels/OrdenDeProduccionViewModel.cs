using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntregaProductoTerminado.Models;

namespace EntregaProductoTerminado.ViewModels
{
    public class OrdenDeProduccionViewModel
    {
        public OrdenDeProduccion ordenDeProduccion { get; set; }

        public string transactionMessage { get; set; }

        public List<OrdenDeProduccion> OPHistorial { get; set; }
    }
}
