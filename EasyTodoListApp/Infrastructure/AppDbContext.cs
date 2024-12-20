
using EasyTodoListApp.Todos.Common;
using Microsoft.EntityFrameworkCore;

namespace EasyTodoListApp.Infrastructure;

public class AppDbContext : DbContext
{
    public AppDbContext() { }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    
    public DbSet<Todo> Todos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        optionsBuilder.UseSqlite("Data Source=easytodolist.dat");

    protected override void OnModelCreating(ModelBuilder modelBuilder) =>
        modelBuilder.Entity<Todo>(entity =>
        {
            entity.ToTable("Todo");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false);
        });
}
