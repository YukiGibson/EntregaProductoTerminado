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
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "OP")]
        public int NumeroOrdenProduccion { get; set; }

        [Required]
        [StringLength(50)]
        public string Cliente { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "Orden de Compra")]
        public string OrdenDeCompra { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "Código Interno")]
        public string CodProductoInterno { get; set; }

        [Required(ErrorMessage ="El campo bultos no puede ser vacio")]
        [Range(0, 200000, ErrorMessage = "El rango de los bultos debe ser entre 0 y 200000")]
        [RegularExpression(@"([0-9])\d*", ErrorMessage = "El valor en bultos no es numérico")]
        public int? Bultos { get; set; }

        [Required(ErrorMessage = "El campo unidades por bulto no puede ser vacio")]
        [Range(0, 200000, ErrorMessage = "El rango debe ser entre 0 y 200000")]
        [RegularExpression(@"([0-9])\d*", ErrorMessage = "El valor en unidades por bulto no es numérico")]
        public int? UnidadesPorBulto { get; set; }

        [RegularExpression(@"([0-9])\d*", ErrorMessage = "El valor de fracción no es numérico")]
        [Display(Name = "Fracción")]
        public int? Fraccion { get; set; }

        [Display(Name = "Total Calculado")]
        public int? TotalCalculado { get; set; }

        [Display(Name = "Total en Sistema")]
        public double? TotalEnSistema { get; set; }

        [Display(Name = "Porcentaje de Tolerancia")]
        public short? PorcentajeTolerancia { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? FechaIngreso { get; set; }

        public int? Excedente { get; set; }

        [Display(Name = "Máximo Aceptado")]
        public double? MaximoAceptadoPorCliente { get; set; }
    }
}
