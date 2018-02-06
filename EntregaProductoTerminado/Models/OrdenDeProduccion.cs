namespace EntregaProductoTerminado.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrdenDeProduccion")]
    public partial class OrdenDeProduccion
    {
        public int ID { get; set; }

        public byte Entregas { get; set; }

        [StringLength(13)]
        [Display(Name = "OP")]
        public string NumeroOrdenProduccion { get; set; }

        [Required]
        [StringLength(50)]
        public string Cliente { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "Orden de Compra")]
        public string OrdenDeCompra { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "Codigo Interno")]
        public string CodProductoInterno { get; set; }

        [Required(ErrorMessage = "El campo bultos no puede ser vacio")]
        [Range(0, 200000, ErrorMessage = "El rango de los bultos debe ser entre 0 y 200000")]
        [RegularExpression(@"([0-9])\d*", ErrorMessage = "El valor en bultos no es num�rico")]
        public int? Bultos { get; set; }

        [Required(ErrorMessage = "El campo unidades por bulto no puede ser vacio")]
        [Range(0, 200000, ErrorMessage = "El rango debe ser entre 0 y 200000")]
        [RegularExpression(@"([0-9])\d*", ErrorMessage = "El valor en unidades por bulto no es num�rico")]
        [Display(Name = "Unidades por Bulto")]
        public int? UnidadesPorBulto { get; set; }

        [RegularExpression(@"([0-9])\d*", ErrorMessage = "El valor de fracci�n no es num�rico")]
        [Display(Name = "Fracci�n")]
        public int? Fraccion { get; set; }

        [Display(Name = "Total Calculado")]
        public int? TotalCalculado { get; set; }

        [Display(Name = "Total en Sistema")]
        public int? TotalEnSistema { get; set; }

        [Display(Name = "Porcentaje de Tolerancia")]
        public short? PorcentajeTolerancia { get; set; }

        [Display(Name = "Fecha Ingreso")]
        [Column(TypeName = "datetime2")]
        public DateTime? FechaIngreso { get; set; }

        public int? Excedente { get; set; }

        [Display(Name = "M�ximo Aceptado")]
        public int? MaximoAceptadoPorCliente { get; set; }
    }
}
