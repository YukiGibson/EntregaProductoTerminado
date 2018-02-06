using System;
using System.Collections.Generic;
using EntregaProductoTerminado.Models;
using System.ComponentModel.DataAnnotations;

namespace EntregaProductoTerminado.ViewModels
{
    public class HistorialProductoTerminadoViewModel
    {
        public string historialInput { get; set; }

        [Display(Name = "Fecha Inicio")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime fechaInicio { get; set; }

        [Display(Name = "Fecha Fin")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime fechaFin { get; set; }

        public List<OrdenDeProduccion> OPHistorial { get; set; }

        public OrdenDeProduccion OrdenDeProduccion { get; set; }
    }
}
