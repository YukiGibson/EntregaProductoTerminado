namespace EntregaProductoTerminado.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OINV")]
    public partial class OINV
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DocEntry { get; set; }

        public int DocNum { get; set; }

        [StringLength(1)]
        public string DocType { get; set; }

        [StringLength(1)]
        public string CANCELED { get; set; }

        [StringLength(1)]
        public string Handwrtten { get; set; }

        [StringLength(1)]
        public string Printed { get; set; }

        [StringLength(1)]
        public string DocStatus { get; set; }

        [StringLength(1)]
        public string InvntSttus { get; set; }

        [StringLength(1)]
        public string Transfered { get; set; }

        [StringLength(20)]
        public string ObjType { get; set; }

        public DateTime? DocDate { get; set; }

        public DateTime? DocDueDate { get; set; }

        [StringLength(15)]
        public string CardCode { get; set; }

        [StringLength(100)]
        public string CardName { get; set; }

        [StringLength(254)]
        public string Address { get; set; }

        [StringLength(100)]
        public string NumAtCard { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? VatPercent { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? VatSum { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? VatSumFC { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DiscPrcnt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DiscSum { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DiscSumFC { get; set; }

        [StringLength(3)]
        public string DocCur { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DocRate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DocTotal { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DocTotalFC { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PaidToDate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PaidFC { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? GrosProfit { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? GrosProfFC { get; set; }

        [StringLength(11)]
        public string Ref1 { get; set; }

        [StringLength(11)]
        public string Ref2 { get; set; }

        [StringLength(254)]
        public string Comments { get; set; }

        [StringLength(50)]
        public string JrnlMemo { get; set; }

        public int? TransId { get; set; }

        public int? ReceiptNum { get; set; }

        public short? GroupNum { get; set; }

        public short? DocTime { get; set; }

        public short? SlpCode { get; set; }

        public short? TrnspCode { get; set; }

        [StringLength(1)]
        public string PartSupply { get; set; }

        [StringLength(1)]
        public string Confirmed { get; set; }

        public short? GrossBase { get; set; }

        public int? ImportEnt { get; set; }

        [StringLength(1)]
        public string CreateTran { get; set; }

        [StringLength(1)]
        public string SummryType { get; set; }

        [StringLength(1)]
        public string UpdInvnt { get; set; }

        [StringLength(1)]
        public string UpdCardBal { get; set; }

        public short Instance { get; set; }

        public int? Flags { get; set; }

        [StringLength(1)]
        public string InvntDirec { get; set; }

        public int? CntctCode { get; set; }

        [StringLength(1)]
        public string ShowSCN { get; set; }

        [StringLength(15)]
        public string FatherCard { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SysRate { get; set; }

        [StringLength(1)]
        public string CurSource { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? VatSumSy { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DiscSumSy { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DocTotalSy { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PaidSys { get; set; }

        [StringLength(1)]
        public string FatherType { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? GrosProfSy { get; set; }

        public DateTime? UpdateDate { get; set; }

        [StringLength(1)]
        public string IsICT { get; set; }

        public DateTime? CreateDate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Volume { get; set; }

        public short? VolUnit { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Weight { get; set; }

        public short? WeightUnit { get; set; }

        public short? Series { get; set; }

        public DateTime? TaxDate { get; set; }

        [StringLength(8)]
        public string Filler { get; set; }

        [StringLength(1)]
        public string DataSource { get; set; }

        [StringLength(16)]
        public string StampNum { get; set; }

        [StringLength(1)]
        public string isCrin { get; set; }

        public int? FinncPriod { get; set; }

        public short? UserSign { get; set; }

        [StringLength(1)]
        public string selfInv { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? VatPaid { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? VatPaidFC { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? VatPaidSys { get; set; }

        public short? UserSign2 { get; set; }

        [StringLength(1)]
        public string WddStatus { get; set; }

        public int? draftKey { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TotalExpns { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TotalExpFC { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TotalExpSC { get; set; }

        public int? DunnLevel { get; set; }

        [StringLength(254)]
        public string Address2 { get; set; }

        public short? LogInstanc { get; set; }

        [StringLength(1)]
        public string Exported { get; set; }

        public int? StationID { get; set; }

        [StringLength(2)]
        public string Indicator { get; set; }

        [StringLength(1)]
        public string NetProc { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? AqcsTax { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? AqcsTaxFC { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? AqcsTaxSC { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CashDiscPr { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CashDiscnt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CashDiscFC { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CashDiscSC { get; set; }

        [StringLength(50)]
        public string ShipToCode { get; set; }

        [StringLength(32)]
        public string LicTradNum { get; set; }

        [StringLength(27)]
        public string PaymentRef { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? WTSum { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? WTSumFC { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? WTSumSC { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? RoundDif { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? RoundDifFC { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? RoundDifSy { get; set; }

        [StringLength(1)]
        public string CheckDigit { get; set; }

        public int? Form1099 { get; set; }

        [StringLength(20)]
        public string Box1099 { get; set; }

        [StringLength(1)]
        public string submitted { get; set; }

        [StringLength(1)]
        public string PoPrss { get; set; }

        [StringLength(1)]
        public string Rounding { get; set; }

        [StringLength(1)]
        public string RevisionPo { get; set; }

        public short Segment { get; set; }

        public DateTime? ReqDate { get; set; }

        public DateTime? CancelDate { get; set; }

        [StringLength(1)]
        public string PickStatus { get; set; }

        [StringLength(1)]
        public string Pick { get; set; }

        [StringLength(1)]
        public string BlockDunn { get; set; }

        [StringLength(15)]
        public string PeyMethod { get; set; }

        [StringLength(1)]
        public string PayBlock { get; set; }

        public int? PayBlckRef { get; set; }

        [StringLength(1)]
        public string MaxDscn { get; set; }

        [StringLength(1)]
        public string Reserve { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Max1099 { get; set; }

        [StringLength(15)]
        public string CntrlBnk { get; set; }

        [StringLength(254)]
        public string PickRmrk { get; set; }

        [StringLength(53)]
        public string ISRCodLine { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ExpAppl { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ExpApplFC { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ExpApplSC { get; set; }

        [StringLength(20)]
        public string Project { get; set; }

        [StringLength(1)]
        public string DeferrTax { get; set; }

        [StringLength(20)]
        public string LetterNum { get; set; }

        public DateTime? FromDate { get; set; }

        public DateTime? ToDate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? WTApplied { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? WTAppliedF { get; set; }

        [StringLength(1)]
        public string BoeReserev { get; set; }

        [StringLength(32)]
        public string AgentCode { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? WTAppliedS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? EquVatSum { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? EquVatSumF { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? EquVatSumS { get; set; }

        public short? Installmnt { get; set; }

        [StringLength(1)]
        public string VATFirst { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? NnSbAmnt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? NnSbAmntSC { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? NbSbAmntFC { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ExepAmnt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ExepAmntSC { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ExepAmntFC { get; set; }

        public DateTime? VatDate { get; set; }

        [StringLength(25)]
        public string CorrExt { get; set; }

        public int? CorrInv { get; set; }

        public int? NCorrInv { get; set; }

        [StringLength(1)]
        public string CEECFlag { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BaseAmnt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BaseAmntSC { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BaseAmntFC { get; set; }

        [StringLength(15)]
        public string CtlAccount { get; set; }

        public int? BPLId { get; set; }

        [StringLength(20)]
        public string BPLName { get; set; }

        [StringLength(12)]
        public string VATRegNum { get; set; }

        [StringLength(10)]
        public string TxInvRptNo { get; set; }

        public DateTime? TxInvRptDt { get; set; }

        [Column(TypeName = "ntext")]
        public string KVVATCode { get; set; }

        [StringLength(100)]
        public string WTDetails { get; set; }

        public int? SumAbsId { get; set; }

        public DateTime? SumRptDate { get; set; }

        [Required]
        [StringLength(10)]
        public string PIndicator { get; set; }

        [StringLength(20)]
        public string ManualNum { get; set; }

        [StringLength(1)]
        public string UseShpdGd { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BaseVtAt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BaseVtAtSC { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BaseVtAtFC { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? NnSbVAt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? NnSbVAtSC { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? NbSbVAtFC { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ExptVAt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ExptVAtSC { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ExptVAtFC { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? LYPmtAt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? LYPmtAtSC { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? LYPmtAtFC { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ExpAnSum { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ExpAnSys { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ExpAnFrgn { get; set; }

        [Required]
        [StringLength(2)]
        public string DocSubType { get; set; }

        [StringLength(1)]
        public string DpmStatus { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DpmAmnt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DpmAmntSC { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DpmAmntFC { get; set; }

        [StringLength(1)]
        public string DpmDrawn { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DpmPrcnt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PaidSum { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PaidSumFc { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PaidSumSc { get; set; }

        [StringLength(2)]
        public string FolioPref { get; set; }

        public int? FolioNum { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DpmAppl { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DpmApplFc { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DpmApplSc { get; set; }

        public int? LPgFolioN { get; set; }

        [Column(TypeName = "ntext")]
        public string Header { get; set; }

        [Column(TypeName = "ntext")]
        public string Footer { get; set; }

        [StringLength(1)]
        public string Posted { get; set; }

        public int? OwnerCode { get; set; }

        [StringLength(15)]
        public string BPChCode { get; set; }

        public int? BPChCntc { get; set; }

        [StringLength(50)]
        public string PayToCode { get; set; }

        [StringLength(1)]
        public string IsPaytoBnk { get; set; }

        [StringLength(3)]
        public string BnkCntry { get; set; }

        [StringLength(30)]
        public string BankCode { get; set; }

        [StringLength(50)]
        public string BnkAccount { get; set; }

        [StringLength(50)]
        public string BnkBranch { get; set; }

        [StringLength(1)]
        public string isIns { get; set; }

        [StringLength(30)]
        public string TrackNo { get; set; }

        [StringLength(11)]
        public string VersionNum { get; set; }

        public int? LangCode { get; set; }

        [StringLength(1)]
        public string BPNameOW { get; set; }

        [StringLength(1)]
        public string BillToOW { get; set; }

        [StringLength(1)]
        public string ShipToOW { get; set; }

        [StringLength(1)]
        public string RetInvoice { get; set; }

        public DateTime? ClsDate { get; set; }

        public int? MInvNum { get; set; }

        public DateTime? MInvDate { get; set; }

        public short? SeqCode { get; set; }

        public int? Serial { get; set; }

        [StringLength(3)]
        public string SeriesStr { get; set; }

        [StringLength(3)]
        public string SubStr { get; set; }

        [StringLength(6)]
        public string Model { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TaxOnExp { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TaxOnExpFc { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TaxOnExpSc { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TaxOnExAp { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TaxOnExApF { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TaxOnExApS { get; set; }

        [StringLength(1)]
        public string LastPmnTyp { get; set; }

        public int? LndCstNum { get; set; }

        [StringLength(1)]
        public string UseCorrVat { get; set; }

        [StringLength(1)]
        public string BlkCredMmo { get; set; }

        [StringLength(1)]
        public string OpenForLaC { get; set; }

        [StringLength(1)]
        public string Excised { get; set; }

        public DateTime? ExcRefDate { get; set; }

        [StringLength(8)]
        public string ExcRmvTime { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SrvGpPrcnt { get; set; }

        public int? DepositNum { get; set; }

        [StringLength(31)]
        public string CertNum { get; set; }

        [StringLength(1)]
        public string DutyStatus { get; set; }

        [StringLength(1)]
        public string AutoCrtFlw { get; set; }

        public DateTime? FlwRefDate { get; set; }

        [StringLength(100)]
        public string FlwRefNum { get; set; }

        public int? VatJENum { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DpmVat { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DpmVatFc { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DpmVatSc { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DpmAppVat { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DpmAppVatF { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DpmAppVatS { get; set; }

        [StringLength(1)]
        public string InsurOp347 { get; set; }

        [StringLength(1)]
        public string IgnRelDoc { get; set; }

        [StringLength(50)]
        public string BuildDesc { get; set; }

        [StringLength(1)]
        public string ResidenNum { get; set; }

        public int? Checker { get; set; }

        public int? Payee { get; set; }

        public int? CopyNumber { get; set; }

        [StringLength(1)]
        public string NTSApprov { get; set; }

        public short? NTSWebSite { get; set; }

        [StringLength(50)]
        public string NTSeTaxNo { get; set; }

        [StringLength(50)]
        public string NTSApprNo { get; set; }

        [StringLength(1)]
        public string PayDuMonth { get; set; }

        public short? ExtraMonth { get; set; }

        public short? ExtraDays { get; set; }

        public short? CdcOffset { get; set; }

        [Column(TypeName = "ntext")]
        public string SignMsg { get; set; }

        [Column(TypeName = "ntext")]
        public string SignDigest { get; set; }

        [StringLength(50)]
        public string CertifNum { get; set; }

        public int? KeyVersion { get; set; }

        [StringLength(1)]
        public string EDocGenTyp { get; set; }

        public short? ESeries { get; set; }

        [StringLength(50)]
        public string EDocNum { get; set; }

        public int? EDocExpFrm { get; set; }

        [StringLength(1)]
        public string SSIExmpt { get; set; }

        public short? PQTGrpSer { get; set; }

        public int? PQTGrpNum { get; set; }

        [StringLength(1)]
        public string PQTGrpHW { get; set; }

        [StringLength(1)]
        public string ReopOriDoc { get; set; }

        [StringLength(1)]
        public string ReopManCls { get; set; }

        [StringLength(1)]
        public string DocManClsd { get; set; }

        [StringLength(1)]
        public string EDocStatus { get; set; }

        [Column(TypeName = "ntext")]
        public string EDocCntnt { get; set; }

        [StringLength(1)]
        public string OnlineQuo { get; set; }

        [StringLength(1)]
        public string EDocProces { get; set; }

        [StringLength(50)]
        public string EDocErrCod { get; set; }

        [Column(TypeName = "ntext")]
        public string EDocErrMsg { get; set; }

        public int? CUP { get; set; }

        public int? CIG { get; set; }

        [Column(TypeName = "ntext")]
        public string Attachment { get; set; }

        [StringLength(20)]
        public string POSEqNum { get; set; }

        [StringLength(20)]
        public string POSManufSN { get; set; }

        public int? POSCashN { get; set; }

        [StringLength(1)]
        public string EDocCancel { get; set; }

        [StringLength(1)]
        public string DpmAsDscnt { get; set; }

        [StringLength(1)]
        public string EDocTest { get; set; }

        [StringLength(10)]
        public string EDocPrefix { get; set; }

        public int? AtcEntry { get; set; }

        [Required]
        public string U_TipoAjuste { get; set; }

        public string U_Operacion { get; set; }

        public DateTime? U_FFormalizacion { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? U_PrincDolares { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? U_PrinColones { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? U_TICorriente { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? U_TIPasivaMoratoria { get; set; }

        public int? U_PlazoMeses { get; set; }

        public string U_PlanInversion { get; set; }

        public string U_Garantia { get; set; }

        public DateTime? U_FechaVencimiento { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? U_SAPrincipalCOL { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? U_SAPrincipalDOL { get; set; }

        public string U_TipoPedido { get; set; }

        public string U_Tolerancia { get; set; }

        public string U_Exento { get; set; }

        public string U_Sincronizado { get; set; }

        public string U_CotizacionMatrix { get; set; }

        public string U_CodMProcedencia { get; set; }

        public DateTime? U_FechaEntregaFinal { get; set; }

        public DateTime? U_FechaReserva { get; set; }

        public DateTime? U_FechaCompra { get; set; }
    }
}
