using EntregaProductoTerminado.Models;

namespace EntregaProductoTerminado.DAL
{
    using System.Data.Entity;

    public partial class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataContext")
        {
        }

        public virtual DbSet<INV1> INV1 { get; set; }
        public virtual DbSet<OINV> OINVs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            /*
            modelBuilder.Entity<INV1>()
                .Property(e => e.LineStatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<INV1>()
                .Property(e => e.Quantity)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.OpenQty)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.Price)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.Rate)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.DiscPrcnt)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.LineTotal)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.TotalFrgn)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.OpenSum)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.OpenSumFC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.Commission)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.TreeType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<INV1>()
                .Property(e => e.TaxStatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<INV1>()
                .Property(e => e.GrossBuyPr)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.PriceBefDi)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.OpenCreQty)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.UseBaseUn)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<INV1>()
                .Property(e => e.TotalSumSy)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.OpenSumSys)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.InvntSttus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<INV1>()
                .Property(e => e.VatPrcnt)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.PriceAfVAT)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.Height1)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.Height2)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.Width1)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.Width2)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.Length1)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.length2)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.Volume)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.Weight1)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.Weight2)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.Factor1)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.Factor2)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.Factor3)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.Factor4)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.PackQty)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.UpdInvntry)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<INV1>()
                .Property(e => e.VatSum)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.VatSumFrgn)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.VatSumSy)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.DedVatSum)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.DedVatSumF)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.DedVatSumS)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.IsAqcuistn)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<INV1>()
                .Property(e => e.DistribSum)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.DstrbSumFC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.DstrbSumSC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.GrssProfit)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.GrssProfSC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.GrssProfFC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.INMPrice)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.DropShip)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<INV1>()
                .Property(e => e.TaxType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<INV1>()
                .Property(e => e.BackOrdr)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<INV1>()
                .Property(e => e.PickStatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<INV1>()
                .Property(e => e.PickOty)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.VatAppld)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.VatAppldFC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.VatAppldSC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.BaseQty)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.BaseOpnQty)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.VatDscntPr)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.WtLiable)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<INV1>()
                .Property(e => e.DeferrTax)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<INV1>()
                .Property(e => e.EquVatPer)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.EquVatSum)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.EquVatSumF)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.EquVatSumS)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.LineVat)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.LineVatlF)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.LineVatS)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.NumPerMsr)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.CEECFlag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<INV1>()
                .Property(e => e.ToStock)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.ToDiff)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.ExciseAmt)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.TaxPerUnit)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.TotInclTax)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.StckDstSum)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.ReleasQtty)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.LineType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<INV1>()
                .Property(e => e.TranType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<INV1>()
                .Property(e => e.StockPrice)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.ConsumeFCT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<INV1>()
                .Property(e => e.LstByDsSum)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.StckINMPr)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.LstBINMPr)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.StckDstFc)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.StckDstSc)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.LstByDsFc)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.LstByDsSc)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.StockSum)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.StockSumFc)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.StockSumSc)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.StckSumApp)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.StckAppFc)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.StckAppSc)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.StckAppD)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.StckAppDFC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.StckAppDSC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.BasePrice)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<INV1>()
                .Property(e => e.GTotal)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.GTotalFC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.GTotalSC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.DistribExp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<INV1>()
                .Property(e => e.DescOW)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<INV1>()
                .Property(e => e.DetailsOW)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<INV1>()
                .Property(e => e.VatWoDpm)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.VatWoDpmFc)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.VatWoDpmSc)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.TaxOnly)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<INV1>()
                .Property(e => e.WtCalced)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<INV1>()
                .Property(e => e.QtyToShip)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.DelivrdQty)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.OrderedQty)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.ChgAsmBoMW)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<INV1>()
                .Property(e => e.TaxDistSum)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.TaxDistSFC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.TaxDistSSC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.PostTax)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<INV1>()
                .Property(e => e.Excisable)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<INV1>()
                .Property(e => e.AssblValue)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.LnExcised)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<INV1>()
                .Property(e => e.StockValue)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.GPTtlBasPr)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.NumPerMsr2)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.SpecPrice)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<INV1>()
                .Property(e => e.isSrvCall)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<INV1>()
                .Property(e => e.PQTReqQty)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.PcQuantity)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.LinManClsd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<INV1>()
                .Property(e => e.VatGrpSrc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<INV1>()
                .Property(e => e.CredOrigin)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<INV1>()
                .Property(e => e.U_Margen)
                .HasPrecision(19, 6);

            modelBuilder.Entity<INV1>()
                .Property(e => e.U_Metros)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.DocType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.CANCELED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.Handwrtten)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.Printed)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.DocStatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.InvntSttus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.Transfered)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.VatPercent)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.VatSum)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.VatSumFC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.DiscPrcnt)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.DiscSum)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.DiscSumFC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.DocRate)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.DocTotal)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.DocTotalFC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.PaidToDate)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.PaidFC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.GrosProfit)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.GrosProfFC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.PartSupply)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.Confirmed)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.CreateTran)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.SummryType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.UpdInvnt)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.UpdCardBal)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.InvntDirec)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.ShowSCN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.SysRate)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.CurSource)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.VatSumSy)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.DiscSumSy)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.DocTotalSy)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.PaidSys)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.FatherType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.GrosProfSy)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.IsICT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.Volume)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.Weight)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.DataSource)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.isCrin)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.selfInv)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.VatPaid)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.VatPaidFC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.VatPaidSys)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.WddStatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.TotalExpns)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.TotalExpFC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.TotalExpSC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.Exported)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.NetProc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.AqcsTax)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.AqcsTaxFC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.AqcsTaxSC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.CashDiscPr)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.CashDiscnt)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.CashDiscFC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.CashDiscSC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.WTSum)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.WTSumFC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.WTSumSC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.RoundDif)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.RoundDifFC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.RoundDifSy)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.CheckDigit)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.submitted)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.PoPrss)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.Rounding)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.RevisionPo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.PickStatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.Pick)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.BlockDunn)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.PayBlock)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.MaxDscn)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.Reserve)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.Max1099)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.ExpAppl)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.ExpApplFC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.ExpApplSC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.DeferrTax)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.WTApplied)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.WTAppliedF)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.BoeReserev)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.WTAppliedS)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.EquVatSum)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.EquVatSumF)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.EquVatSumS)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.VATFirst)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.NnSbAmnt)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.NnSbAmntSC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.NbSbAmntFC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.ExepAmnt)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.ExepAmntSC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.ExepAmntFC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.CEECFlag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.BaseAmnt)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.BaseAmntSC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.BaseAmntFC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.UseShpdGd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.BaseVtAt)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.BaseVtAtSC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.BaseVtAtFC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.NnSbVAt)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.NnSbVAtSC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.NbSbVAtFC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.ExptVAt)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.ExptVAtSC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.ExptVAtFC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.LYPmtAt)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.LYPmtAtSC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.LYPmtAtFC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.ExpAnSum)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.ExpAnSys)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.ExpAnFrgn)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.DpmStatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.DpmAmnt)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.DpmAmntSC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.DpmAmntFC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.DpmDrawn)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.DpmPrcnt)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.PaidSum)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.PaidSumFc)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.PaidSumSc)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.DpmAppl)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.DpmApplFc)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.DpmApplSc)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.Posted)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.IsPaytoBnk)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.isIns)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.BPNameOW)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.BillToOW)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.ShipToOW)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.RetInvoice)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.TaxOnExp)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.TaxOnExpFc)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.TaxOnExpSc)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.TaxOnExAp)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.TaxOnExApF)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.TaxOnExApS)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.LastPmnTyp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.UseCorrVat)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.BlkCredMmo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.OpenForLaC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.Excised)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.SrvGpPrcnt)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.DutyStatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.AutoCrtFlw)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.DpmVat)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.DpmVatFc)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.DpmVatSc)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.DpmAppVat)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.DpmAppVatF)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.DpmAppVatS)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.InsurOp347)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.IgnRelDoc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.ResidenNum)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.NTSApprov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.PayDuMonth)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.EDocGenTyp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.SSIExmpt)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.PQTGrpHW)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.ReopOriDoc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.ReopManCls)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.DocManClsd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.EDocStatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.OnlineQuo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.EDocProces)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.EDocCancel)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.DpmAsDscnt)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.EDocTest)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OINV>()
                .Property(e => e.U_PrincDolares)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.U_PrinColones)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.U_TICorriente)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.U_TIPasivaMoratoria)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.U_SAPrincipalCOL)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OINV>()
                .Property(e => e.U_SAPrincipalDOL)
                .HasPrecision(19, 6);
            */
        }
    }
}
