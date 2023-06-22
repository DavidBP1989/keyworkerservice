using KeyWorkerService.Domain.Models.LocalContext;
using Microsoft.EntityFrameworkCore;

namespace KeyWorkerService.Infrastructure.DataContext.Local;

public partial class DefaultContext : DbContext
{
    public DefaultContext() { }

    public DefaultContext(DbContextOptions<DefaultContext> options) : base(options) { }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.LastName).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
