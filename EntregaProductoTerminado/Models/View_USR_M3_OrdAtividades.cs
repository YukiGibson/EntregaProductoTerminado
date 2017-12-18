namespace EntregaProductoTerminado.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_USR_M3_OrdAtividades
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(32)]
        public string NumOrdem { get; set; }

        [StringLength(200)]
        public string NomeCliente { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idAtiv { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(200)]
        public string Idprocesso { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(200)]
        public string obs { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(200)]
        public string Titulo { get; set; }

        public double? QtdPlanejada { get; set; }

        [Key]
        [Column(Order = 5)]
        public double QtdProduzida { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int QtdRepeticoes { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int QtdEntradas { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GrupoAtivOP { get; set; }

        [Key]
        [Column(Order = 9)]
        public double ProducaoHora { get; set; }

        [StringLength(50)]
        public string CodAtiv { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PerdaFixa { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PerdaPorEntrada { get; set; }

        [StringLength(50)]
        public string CodRecurso { get; set; }

        public double? FatorPeso { get; set; }

        public double? FatorComprimento { get; set; }

        public double? FatorUnidade { get; set; }
    }
}
