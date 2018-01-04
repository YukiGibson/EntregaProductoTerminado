namespace EntregaProductoTerminado.DAL
{
    using System.Data.Entity;
    using EntregaProductoTerminado.Models;

    public partial class DiboContext : DbContext
    {
        public DiboContext()
            : base("name=DiboContext")
        {
        }

        public virtual DbSet<OrdenDeProduccion> OrdenDeProduccion { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrdenDeProduccion>()
                    .Property(e => e.NumeroOrdenProduccion)
                    .IsUnicode(false);
        }
    }
}
