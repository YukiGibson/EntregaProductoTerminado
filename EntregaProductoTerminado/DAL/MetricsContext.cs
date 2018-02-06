namespace EntregaProductoTerminado.DAL
{
    using System.Data.Entity;
    using EntregaProductoTerminado.Models;

    public partial class MetricsContext : DbContext
    {
        public MetricsContext()
            : base("name=MetricsContext")
        {
        }

        public virtual DbSet<View_USR_M3_OrdAtividades> View_USR_M3_OrdAtividades { get; set; }

        public virtual DbSet<A_Vista_OConversion_Reserva> A_Vista_OConversion_Reserva { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<View_USR_M3_OrdAtividades>()
                .Property(e => e.NumOrdem)
                .IsUnicode(false);

            modelBuilder.Entity<View_USR_M3_OrdAtividades>()
                .Property(e => e.NomeCliente)
                .IsUnicode(false);

            modelBuilder.Entity<View_USR_M3_OrdAtividades>()
                .Property(e => e.Idprocesso)
                .IsUnicode(false);

            modelBuilder.Entity<View_USR_M3_OrdAtividades>()
                .Property(e => e.obs)
                .IsUnicode(false);

            modelBuilder.Entity<View_USR_M3_OrdAtividades>()
                .Property(e => e.Titulo)
                .IsUnicode(false);

            modelBuilder.Entity<View_USR_M3_OrdAtividades>()
                .Property(e => e.CodAtiv)
                .IsUnicode(false);

            modelBuilder.Entity<View_USR_M3_OrdAtividades>()
                .Property(e => e.CodRecurso)
                .IsUnicode(false);
            modelBuilder.Entity<A_Vista_OConversion_Reserva>()
                .Property(e => e.Presupuesto)
                .IsUnicode(false);

            modelBuilder.Entity<A_Vista_OConversion_Reserva>()
                .Property(e => e.Titulo)
                .IsUnicode(false);

            modelBuilder.Entity<A_Vista_OConversion_Reserva>()
                .Property(e => e.Cliente)
                .IsUnicode(false);

            modelBuilder.Entity<A_Vista_OConversion_Reserva>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<A_Vista_OConversion_Reserva>()
                .Property(e => e.Material)
                .IsUnicode(false);

            modelBuilder.Entity<A_Vista_OConversion_Reserva>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<A_Vista_OConversion_Reserva>()
                .Property(e => e.ComplementoDesc)
                .IsUnicode(false);

            modelBuilder.Entity<A_Vista_OConversion_Reserva>()
                .Property(e => e.UM)
                .IsUnicode(false);

            modelBuilder.Entity<A_Vista_OConversion_Reserva>()
                .Property(e => e.Valor)
                .HasPrecision(20, 5);

            modelBuilder.Entity<A_Vista_OConversion_Reserva>()
                .Property(e => e.Suministrado)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<A_Vista_OConversion_Reserva>()
                .Property(e => e.Lote)
                .IsUnicode(false);

            modelBuilder.Entity<A_Vista_OConversion_Reserva>()
                .Property(e => e.IDProcessoOrigem)
                .IsUnicode(false);

            modelBuilder.Entity<A_Vista_OConversion_Reserva>()
                .Property(e => e.NumOrdem)
                .IsUnicode(false);

            modelBuilder.Entity<A_Vista_OConversion_Reserva>()
                .Property(e => e.Apelido)
                .IsUnicode(false);

            modelBuilder.Entity<A_Vista_OConversion_Reserva>()
                .Property(e => e.Recurso)
                .IsUnicode(false);

            modelBuilder.Entity<A_Vista_OConversion_Reserva>()
                .Property(e => e.CodEstructura)
                .IsUnicode(false);
        }
    }
}
