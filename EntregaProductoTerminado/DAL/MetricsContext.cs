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
        }
    }
}
